using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    class DBManager
    {
        string insertBorrowSQL = "INSERT INTO Lendings (Book_ID,Borrow_Time,Borrower_ID,Borrower_Name,Returned,Return_Time) " +
            "VALUES (@bookid, @borrowtime, @borrowerid, @borrowername, FALSE, NULL);";

        string selectBookIDSQL = "SELECT Book_ID FROM Books WHERE Book_ID = @bookid;";
        string selectBookSQL = "SELECT * FROM Books WHERE Book_ID = @bookid;";

        string selectUnreturnedCountSQL = "SELECT Count(*) AS Unreturned FROM Lendings WHERE Book_ID = @bookid AND Returned = FALSE;";

        string selectStudentBookUnreturnedCountSQL = "SELECT * FROM Lendings WHERE Book_ID = @bookid AND Returned = FALSE AND Borrower_Name = @borrowername;";

        string returnBookSQL = "UPDATE Lendings SET Returned = TRUE, Return_Time = @returntime WHERE Book_ID = @bookid AND Borrower_Name = @borrowername AND (@borrowerid IS NULL OR Borrower_ID = @borrowerid);";

        static string accessDBPath = ConfigurationManager.AppSettings["accessDBPath"];
        static string passphrase = ConfigurationManager.AppSettings["passphrase"];
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + accessDBPath + "; Jet OLEDB:Database Password=" + passphrase + "; Persist Security Info=True;");

        private DateTime GetDateWithoutMilliseconds(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
        }

        public bool insertLending(Lending lending)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(insertBorrowSQL, conn);
                cmd.Parameters.AddWithValue("@bookid", lending.BookID);
                cmd.Parameters.AddWithValue("@borrowtime", GetDateWithoutMilliseconds(DateTime.Now));
                cmd.Parameters.AddWithValue("@borrowerid", lending.BorrowerID);
                cmd.Parameters.AddWithValue("@borrowername", lending.BorrowerName);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        public int selectUnreturnQuantity(string bookID)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand(selectUnreturnedCountSQL, conn);
                cmd.Parameters.AddWithValue("@bookid", bookID);
                OleDbDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    return Convert.ToInt32(reader["Unreturned"].ToString());
                }
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }

            return 99;
        }

        public bool bookIDExists(string bookID)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(selectBookIDSQL, conn);
                cmd.Parameters.AddWithValue("@bookid", bookID);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        public Book selectBook(string bookID)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(selectBookSQL, conn);
                cmd.Parameters.AddWithValue("@bookid", bookID);
                OleDbDataReader reader = cmd.ExecuteReader();

                Book book = new Book();
                while (reader.Read())
                {
                    book.BookID = reader["Book_ID"].ToString();
                    book.Isbn = reader["ISBN"].ToString();
                    book.Title = reader["Title"].ToString();
                    book.Author = reader["Author"].ToString();
                    book.Remarks = reader["Remarks"].ToString();
                    book.Quantity = Convert.ToInt32(reader["Quantity"]);
                }
                return book;               
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        public int returnBook(Lending lending)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(returnBookSQL, conn);
                cmd.Parameters.AddWithValue("@returntime", GetDateWithoutMilliseconds(DateTime.Now));
                cmd.Parameters.AddWithValue("@bookid", lending.BookID);
                cmd.Parameters.AddWithValue("@borrowername", lending.BorrowerName);
                cmd.Parameters.AddWithValue("@borrowerid", lending.BorrowerID);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }

            return 0;
        }

        public bool checkStudentBookUnreturnExist(Lending lending)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(selectStudentBookUnreturnedCountSQL, conn);
                cmd.Parameters.AddWithValue("@bookid", lending.BookID);
                cmd.Parameters.AddWithValue("@borrowername", lending.BorrowerName);
                //cmd.Parameters.AddWithValue("@borrowerid", lending.BorrowerID);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows || reader != null)
                {
                    while(reader.Read())
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
    }
}
