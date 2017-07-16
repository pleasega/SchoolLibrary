using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLibrary
{
    public partial class Action : Form
    {
        DBManager dbManager = new DBManager();

        string actionType;
        ArrayList lendingList = new ArrayList();

        public Action(string actionType, ArrayList lendingListPrev)
        {
            InitializeComponent();

            lendingList = lendingListPrev;
            this.actionType = actionType;

            action_btn.Text = actionType;
            action_label.Text = actionType;
        }

        private void action_btn_Click(object sender, EventArgs e)
        {
            string studentID = studentID_textbox.Text;
            string studentName = studentName_textbox.Text;

            if (studentName.Equals(""))
            {
                MessageBox.Show("Please enter your student name (and ID).", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ArrayList actionUnsuccessfulList = new ArrayList();
            foreach (Lending lending in lendingList)
            {
                lending.BorrowerID = studentID;
                lending.BorrowerName = studentName;

                if (actionType.Equals("Borrow"))
                {
                    int unreturnedQuantity = dbManager.selectUnreturnQuantity(lending.BookID);
                    int totalQuantity = dbManager.selectBook(lending.BookID).Quantity;
                    bool bookAvailable = totalQuantity > unreturnedQuantity;
                    if (bookAvailable == false)
                    {
                        MessageBox.Show("Please return the book ID " + lending.BookID + " before trying to borrow.", "Book Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dbManager.insertLending(lending) == false)
                    {
                        actionUnsuccessfulList.Add(lending.BookID);
                    }
                }
                else if (actionType.Equals("Return")) //check person borrowed
                {
                    string notBorrowedMessage = "The book " + lending.BookID + " has not been borrowed under this student.";

                    bool studentBookUnreturnExist = dbManager.checkStudentBookUnreturnExist(lending);
                    if (studentBookUnreturnExist == false)
                    {
                        MessageBox.Show(notBorrowedMessage, "Book Not Borrowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int booksReturned = dbManager.returnBook(lending);
                    if (booksReturned == 0)
                    {
                        MessageBox.Show(notBorrowedMessage, "Book Not Borrowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }


            // exception errors
            if (actionUnsuccessfulList.Count == 0)
            {
                if (actionType.Equals("Borrow"))
                {
                    MessageBox.Show("Thank you for borrowing from the library, remember to return on time and see you again!", "Success!", MessageBoxButtons.OK);
                }
                else if (actionType.Equals("Return"))
                {
                    MessageBox.Show("Thank you for returning the book(s), see you again!", "Success!", MessageBoxButtons.OK);
                }
            }
            else
            {
                string unsuccessfulBooks = String.Join(",", actionUnsuccessfulList.ToArray());
                if (actionType.Equals("Borrow"))
                {
                    MessageBox.Show("There was an issue with borrowing book(s): " + unsuccessfulBooks + ". Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (actionType.Equals("Return"))
                {
                    MessageBox.Show("There was an issue with returning book(s): " + unsuccessfulBooks + ". Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }

            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scan frmScan = new Scan(actionType);
            frmScan.Show();
        }
    }
}
