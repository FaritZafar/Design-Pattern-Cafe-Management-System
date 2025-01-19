using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Cafe_Management_Systems.strategyP
{
   public class cash : paymentStrategy
    {
        public cash()
        {
            trasectiontax = 0;
            MessageBox.Show("Your amount has been charged");
        }

       
    }
}
