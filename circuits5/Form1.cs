using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuits5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            double Total;

            Total = res1ser1.Text * res2ser1.Text;
            ser1total.Text = Total.ToString("0");
            // define varibles for calculation 
            
            try
            {
                Total = double.Parse(res1ser1.Text);

            }
           catch
            {
                MessageBox.Show("Error inputting res1ser1 value");
                    
            }
            try
            {
                Total = double.Parse(res2ser1);
            }
            catch
            {
                MessageBox.Show("Error inputting res2ser1 value");
            }
            try
            {
                Total = double.Parse(res3parallel1);
            }
            catch
            {
                MessageBox.Show("Error inputting res3parallel1 value");
            }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
