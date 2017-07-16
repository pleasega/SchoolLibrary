using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void borrow_btn_Click(object sender, EventArgs e)
        {
            Scan frmScan = new Scan("Borrow");
            frmScan.Show();
            this.Owner = frmScan;
            this.Hide();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            Scan frmScan = new Scan("Return");
            frmScan.Show();
            this.Owner = frmScan;
            this.Hide();
        }

    }
}
