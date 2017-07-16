using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    class Book
    {
        private string bookID;
        private string isbn;
        private string title;
        private string author;
        private string remarks;
        private int quantity;

        public string BookID { get => bookID; set => bookID = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
