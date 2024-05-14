using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Classes
{
    internal class Client
    {
        private int ID;
        public string Name{ get; set; }
        public string Last_name { get; set; }

        private int Counter_of_money;

        public Client(int ID)
        {
            Counter_of_money = 0;
            this.ID = ID;
        }

        public Client(string name, string Last_name, int ID) : this(ID)
        {
            this.Name = name;
            this.Last_name = Last_name;
        }

    }
}
