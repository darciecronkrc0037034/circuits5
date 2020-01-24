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




            // define varibles for calculation 
            double ResistorR1, ResistorR2, Total;

            try
            {
                ResistorR1 = double.Parse(res1ser1.Text);

            }
            catch
            {
                MessageBox.Show("Error inputting res1ser1 value");
                ResistorR1 = 0.0;

            }
            try
            {
                ResistorR2 = double.Parse(res2ser1.Text);
            }
            catch
            {
                MessageBox.Show("Error inputting res2ser1 value");
                ResistorR2 = 0.0;
            }

            //Calculate total resistor value
            Total = ResistorR1 + ResistorR2;

            //Show solution on the sreeen
            label1.Text = Total + " ohms";
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
