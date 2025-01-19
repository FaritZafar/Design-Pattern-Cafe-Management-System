using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_Systems
{
    public class FacadeClass
    {
        public FacadeClass(DataGridView dataGridView1)
        {
            Drinks a = new Drinks();
            a.show(dataGridView1);
            Snacks s = new Snacks();
            s.show(dataGridView1);
        }
    }
}
