using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayin_Tarlasi
{
    public partial class Form1 : Form
    {
        int rsgl = 0;
        public Form1()
        {
            InitializeComponent();
            Random rasgele = new Random();
            rsgl= rasgele.Next(1, 26);
          //  lblHile.Text = rsgl.ToString();

        }
        void atama()
        {
            
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "10";
            button11.Text = "11";
            button12.Text = "12";
            button13.Text = "13";
            button14.Text = "14";
            button15.Text = "15";
            button16.Text = "16";
            button17.Text = "17";
            button18.Text = "18";
            button19.Text = "19";
            button20.Text = "20";
            button21.Text = "21";
            button22.Text = "22";
            button23.Text = "23";
            button24.Text = "24";
            button25.Text = "25";
         
        }



        private void button1_Click(object sender, EventArgs e)
        {
            atama();
            string a = button1.Text;
            int b = int.Parse(a);
           if (b!=(rsgl))
            {
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
                
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atama();
            string a = button2.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            atama();
            string a = button3.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            atama();
            string a = button4.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button4.BackColor = Color.Green;
            }
            else
            {
                button4.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            atama();
            string a = button5.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button5.BackColor = Color.Green;
            }
            else
            {
                button5.BackColor = Color.Red;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            atama();
            string a = button7.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button7.BackColor = Color.Green;
            }
            else
            {
                button7.BackColor = Color.Red;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            atama();
            string a = button8.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button8.BackColor = Color.Green;
            }
            else
            {
                button8.BackColor = Color.Red;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            atama();
            string a = button9.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button9.BackColor = Color.Green;
            }
            else
            {
                button9.BackColor = Color.Red;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            atama();
            string a = button10.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button10.BackColor = Color.Green;
            }
            else
            {
                button10.BackColor = Color.Red;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            atama();
            string a = button12.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button12.BackColor = Color.Green;
            }
            else
            {
                button12.BackColor = Color.Red;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            atama();
            string a = button13.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button13.BackColor = Color.Green;
            }
            else
            {
                button13.BackColor = Color.Red;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            atama();
            string a = button14.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button14.BackColor = Color.Green;
            }
            else
            {
                button14.BackColor = Color.Red;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            atama();
            string a = button15.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button15.BackColor = Color.Green;
            }
            else
            {
                button15.BackColor = Color.Red;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            atama();
            string a = button17.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button17.BackColor = Color.Green;
            }
            else
            {
                button17.BackColor = Color.Red;
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            atama();
            string a = button18.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button18.BackColor = Color.Green;
            }
            else
            {
                button18.BackColor = Color.Red;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            atama();
            string a = button19.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button19.BackColor = Color.Green;
            }
            else
            {
                button19.BackColor = Color.Red;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            atama();
            string a = button20.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button20.BackColor = Color.Green;
            }
            else
            {
                button20.BackColor = Color.Red;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            atama();
            string a = button22.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button22.BackColor = Color.Green;
            }
            else
            {
                button22.BackColor = Color.Red;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            atama();
            string a = button23.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button23.BackColor = Color.Green;
            }
            else
            {
                button23.BackColor = Color.Red;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            atama();
            string a = button24.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button24.BackColor = Color.Green;
            }
            else
            {
                button24.BackColor = Color.Red;
            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            atama();
            string a = button25.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button25.BackColor = Color.Green;
            }
            else
            {
                button25.BackColor = Color.Red;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            atama();
            string a = button6.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button6.BackColor = Color.Green;
            }
            else
            {
                button6.BackColor = Color.Red;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            atama();
            string a = button11.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button11.BackColor = Color.Green;
            }
            else
            {
                button11.BackColor = Color.Red;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            atama();
            string a = button16.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button16.BackColor = Color.Green;
            }
            else
            {
                button16.BackColor = Color.Red;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            atama();
            string a = button21.Text;
            int b = int.Parse(a);
            if (b != (rsgl))
            {
                button21.BackColor = Color.Green;
            }
            else
            {
                button21.BackColor = Color.Red;
            }
        }
    }
}
