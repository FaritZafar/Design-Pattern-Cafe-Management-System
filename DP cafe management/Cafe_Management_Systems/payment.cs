using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Cafe_Management_Systems
{
    public class payment
    {
        private paymentStrategy _payStrategy;

        public void SetStrategy(paymentStrategy payStrategy)
        {
            _payStrategy = payStrategy;
        }

        public void fee(double charges)
        {
           
            MessageBox.Show("you tax charges" + charges+ "%");
        }
    }
}
