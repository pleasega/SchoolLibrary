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

        private bool checkDuplicateBook(List<string> isbnListForDC)
        {
            if (isbnListForDC.Distinct().Count() == isbnListForDC.Count())
            {
                return true;
            }
            return false;
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
           
            ArrayList lendingList = new ArrayList();

            string[] allTextBoxes = { book1ISBN_textbox.Text, book2ISBN_textbox.Text, book3ISBN_textbox.Text, book4ISBN_textbox.Text };
            // book id list for duplicate checking only
            List<string> isbnListForDC = new List<string>();

            int emptyTextboxCount = 0;
            foreach(string ISBN in allTextBoxes)
            {
                if (!String.IsNullOrEmpty(ISBN))
                {
                    Lending lending = new Lending();
                    lending.ISBN = ISBN.ToUpper();
                    lendingList.Add(lending);
                    isbnListForDC.Add(ISBN.ToUpper());
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

            if (!checkDuplicateBook(isbnListForDC))
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
                if (dbManager.isbnExists(lending.ISBN) == false)
                {
                    MessageBox.Show("The book ID " + lending.ISBN + " does not exist, no such book.", "Invalid Book ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (actionType.Equals("Borrow"))
            {
                foreach (Lending lending in lendingList)
                {
                    int unreturnedQuantity = dbManager.selectUnreturnQuantity(lending.ISBN);
                    int totalQuantity = dbManager.selectBook(lending.ISBN).Quantity;
                    bool bookAvailable = totalQuantity > unreturnedQuantity;
                    if (bookAvailable == false)
                    {
                        MessageBox.Show("Please return the book ID " + lending.ISBN + " before trying to borrow.", "Book Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
