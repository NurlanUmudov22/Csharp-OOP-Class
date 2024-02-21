using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_CLASS
{
    internal class Book
    {

        public string name;
        public string author;




        public Book(string name)
        {
            Console.WriteLine("xaker");
        }

        public Book()
        {
            Console.WriteLine("pb-101");
        }



            public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
    }
}
