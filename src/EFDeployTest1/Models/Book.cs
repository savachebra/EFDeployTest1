using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFDeployTest1.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string Title{ get; set; }
        public int AuthorId{ get; set; }
        public virtual Author Author { get; set; }
    }
}
