using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Books> BooksList { get; set; }


    }
}
