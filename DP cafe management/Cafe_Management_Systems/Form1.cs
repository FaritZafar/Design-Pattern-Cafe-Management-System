using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cafe_Management_Systems
{
    public partial class Form1 : Form
    {

      

        public Form1()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cashname.Text = Environment.GetEnvironmentVariable("username");
          
            lblDate.Text = DateTime.Now.ToLongDateString();
            Timer1.Start();

            FacadeClass fc = new FacadeClass(dataGridView1);

           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
          
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
          
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void lblCharge_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rtfReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            payment payments = new payment();

            payments.SetStrategy(new Cafe_Management_Systems.strategyP.creditcard());
            payments.fee(2.5);
            
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            payment payments = new payment();

            payments.SetStrategy(new Cafe_Management_Systems.strategyP.cash());
            
            
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            AddProduct ad = new AddProduct();
            ad.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Message","error", MessageBoxButtons.YesNoCancel);



            // Exit ex = new Exit();
            //ex.Show();
            this.Hide();
            login obj = new login();
            obj.Show();
            

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            order or = new order();
            or.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void cashname_Click(object sender, EventArgs e)
        {
            string a = "";
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                a = item.Cells[1].Value.ToString();
                //   a=dataGridView1.SelectedRows.
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            StreamReader sr = new StreamReader("product.txt");

            // sr.Close();
            StreamWriter sw = new StreamWriter("product.txt", true);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(a) == true)
                {

                }
                else
                {
                    sw.WriteLine(line);
                }
            }
            sr.Close();
            
        }
    }
    
}
