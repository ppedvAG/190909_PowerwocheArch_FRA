using System;
using System.Text;

namespace ppedv.MajoDDD.Domain
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
    }
}
