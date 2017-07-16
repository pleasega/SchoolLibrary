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
    public partial class Scan : Form
    {
        DBManager dbManager = new DBManager();

        string actionType;
        public Scan(string actionType)
        {
            InitializeComponent();

            this.actionType = actionType;

            this.Text = "Scan Barcode [" + actionType + "]"; 
        }

        private bool checkDuplicateBook(List<string> bookIDListForDC)
        {
            if (bookIDListForDC.Distinct().Count() == bookIDListForDC.Count())
            {
                return true;
            }
            return false;
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
           
            ArrayList lendingList = new ArrayList();

            string[] allTextBoxes = { book1ID_textbox.Text, book2ID_textbox.Text, book3ID_textbox.Text, book4ID_textbox.Text };
            // book id list for duplicate checking only
            List<string> bookIDListForDC = new List<string>();

            int emptyTextboxCount = 0;
            foreach(string bookID in allTextBoxes)
            {
                if (!String.IsNullOrEmpty(bookID))
                {
                    Lending lending = new Lending();
                    lending.BookID = bookID.ToUpper();
                    lendingList.Add(lending);
                    bookIDListForDC.Add(bookID.ToUpper());
                }
                else
                {
                    emptyTextboxCount++;
                }
            }

            if (emptyTextboxCount == allTextBoxes.Count())
            {
                MessageBox.Show("Please scan a book's barcode.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkDuplicateBook(bookIDListForDC))
            {
                if (actionType.Equals("Borrow"))
                {
                    MessageBox.Show("You cannot borrow the same book.", "Duplicate Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (actionType.Equals("Return"))
                {
                    MessageBox.Show("You are trying to return many same books.", "Duplicate Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // check if book id is valid
            foreach (Lending lending in lendingList)
            {
                if (dbManager.bookIDExists(lending.BookID) == false)
                {
                    MessageBox.Show("The book ID " + lending.BookID + " does not exist, no such book.", "Invalid Book ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (actionType.Equals("Borrow"))
            {
                foreach (Lending lending in lendingList)
                {
                    int unreturnedQuantity = dbManager.selectUnreturnQuantity(lending.BookID);
                    int totalQuantity = dbManager.selectBook(lending.BookID).Quantity;
                    bool bookAvailable = totalQuantity > unreturnedQuantity;
                    if (bookAvailable == false)
                    {
                        MessageBox.Show("Please return the book ID " + lending.BookID + " before trying to borrow.", "Book Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Action frmAction = new Action(actionType, lendingList);
                frmAction.Show();
                this.Owner = frmAction;
                this.Hide();
            }

            else if (actionType.Equals("Return")) //return book
            {
                Action frmAction = new Action(actionType, lendingList);
                frmAction.Show();
                this.Owner = frmAction;
                this.Hide();
            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            this.Owner = frm1;
            frm1.Show();
        }
    }
}
