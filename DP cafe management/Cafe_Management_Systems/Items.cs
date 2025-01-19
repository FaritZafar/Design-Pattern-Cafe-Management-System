using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_Systems
{
    public interface Items
    {
        string ID { get; set; }
        string Name { get; set; }
        int Quantity { get; set; }
        string Type { get; set; }
        int Price { get; set; }
        void Add(BunifuMetroTextbox a, BunifuMetroTextbox b, BunifuMetroTextbox d, BunifuMetroTextbox e);
        
    }
}
