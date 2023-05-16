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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

     
       }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, x;
            String Mesaj;
            // bool result;
            // result = Double.TryParse("abc", out a);
            if (!Double.TryParse(textBox1.Text, out a) ||
           !Double.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Trebuie introduse valori numerice pentru a sau b! ", "Eroare");
            return;
            };
            if (a != 0)
            {
                x = -b / a;
                Mesaj = Convert.ToString(x);
            }
            else
            {
                if (b == 0) Mesaj = "Ecuatie nedeterminata!";
                else Mesaj = ("Ecuatie imposibila!");
            }
            textBox3.Text = Mesaj;
        }
    }

}
