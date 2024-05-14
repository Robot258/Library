using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Classes
{
    internal class Book
    {
        public int Number_of_pages { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public string Genre{ get; set; }

        private int ID;

        public Book(int ID)
        {
            this.ID = ID;
        }

        public Book(string name, int price, int ID) : this(ID)
        {
            this.Name = name;
            this.Price = price;
        }

        public Book(string name, int price, string genre, int ID) : this(name, price, ID)
        {
            this.Genre = genre;
        }

    }
}
