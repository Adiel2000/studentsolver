using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a11_studentsolver
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           double a, b, c, dt;
            double x1, x2;
            String Mesaj;
            if (!Double.TryParse(textBox1.Text, out a) ||
           !Double.TryParse(textBox2.Text, out b) || 
           !Double.TryParse(textBox3.Text, out c))
            {
                MessageBox.Show("Trebuie introduse valori numerice pentru a sau b! ", "Eroare");
                return;
            };
           
            if (a == 0)
                if (b == 0)
                    if (c == 0) MessageBox.Show("Ec. nedeterminat.");
                    else MessageBox.Show("Ec. imposibila");
                else
                {
                    x1 = -c / b;
                    Mesaj = Convert.ToString(x1); ;
                }
            else
            {
                dt = b * b - 4 * a * c;
                if (dt < 0)
                    MessageBox.Show("Ec. are solutii complxe");
                else
                {
                    if (dt == 0)
                    {
                        x1 = x2 = -b / (2 * a);
                        Mesaj = Convert.ToString(x1);
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(dt)) / (2 * a);
                        Mesaj = Convert.ToString(x1);
                        x2 = (-b - Math.Sqrt(dt)) / (2 * a);
                        Mesaj = Convert.ToString(x2);
                        
                    }
                }
               
              
            }
            textBox4.Text = Mesaj;
            textBox5.Text = Mesaj;
        }
    }
}
