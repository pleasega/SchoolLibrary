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

        private void continue_btn_Click(object sender, EventArgs e)
        {
            if (book1ID_textbox.Text.Equals(""))
            {
                MessageBox.Show("Please scan a book's barcode.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            ArrayList lendingList = new ArrayList();

            Lending lending1 = new Lending();
            lending1.BookID = book1ID_textbox.Text;
            lendingList.Add(lending1);

            if (!book2ID_textbox.Text.Equals(""))
            {
                Lending lending2 = new Lending();
                lending2.BookID = book2ID_textbox.Text;
                lendingList.Add(lending2);
            }
            if (!book3ID_textbox.Text.Equals(""))
            {
                Lending lending3 = new Lending();
                lending3.BookID = book3ID_textbox.Text;
                lendingList.Add(lending3);
            }
            if (!book4ID_textbox.Text.Equals(""))
            {
                Lending lending4 = new Lending();
                lending4.BookID = book4ID_textbox.Text;
                lendingList.Add(lending4);
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
                this.Hide();
            }

            else if (actionType.Equals("Return")) //return book
            {
                Action frmAction = new Action(actionType, lendingList);
                frmAction.Show();
                this.Hide();
            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
