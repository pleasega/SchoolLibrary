using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    class Lending
    {
        private string bookID;
        private DateTime borrowTime;
        private string borrowerID;
        private string borrowerName;
        private bool returned;
        private DateTime returnTime;

        public string BookID { get => bookID; set => bookID = value; }
        public DateTime BorrowTime { get => borrowTime; set => borrowTime = value; }
        public string BorrowerID { get => borrowerID; set => borrowerID = value; }
        public string BorrowerName { get => borrowerName; set => borrowerName = value; }
        public bool Returned { get => returned; set => returned = value; }
        public DateTime ReturnTime { get => returnTime; set => returnTime = value; }
    }
}
