using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryObjectToFiles.Library
{
   internal class Reader
    {
        public int ID{ get; set; }
        public string Username{ get; set; }
        public List<Book> LoanedBooks { get; set; }
    }
}
