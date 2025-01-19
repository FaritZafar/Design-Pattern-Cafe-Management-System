using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_Systems
{
    class ItemFactory
    {
        public Items getInstance(string s)
        {
            if (s == "Drinks")
            {
                return new Drinks();
            }
            else
            {
                return new Snacks();
            }
        }
    }
}
