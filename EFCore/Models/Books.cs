using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Models
{
    public class Books
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Languages { get; set; }
        public int Pages { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
