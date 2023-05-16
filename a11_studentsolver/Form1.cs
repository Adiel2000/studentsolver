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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SOLVER v1.0, 2020\nAutor: Railean Adiel I Mecatronică", "Despre" );

        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult Raspuns;
            Raspuns = MessageBox.Show("Esti sigur?", "Iesire",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button1);
            if (Raspuns == System.Windows.Forms.DialogResult.Yes)
                this.Close();

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 P1 = new Form2();
            P1.ShowDialog();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form3 P2 = new Form3();
            P2.ShowDialog();
        }

        private void ecIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            albToolStripMenuItem.Checked = false;
            galbenToolStripMenuItem.Checked = false;
            verdeToolStripMenuItem.Checked = true;
        }

        private void albToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            albToolStripMenuItem.Checked = true;
            galbenToolStripMenuItem.Checked = false;
            verdeToolStripMenuItem.Checked = false;
        }

        private void galbenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            albToolStripMenuItem.Checked = false;
            galbenToolStripMenuItem.Checked = true;
            verdeToolStripMenuItem.Checked = false;
        }
    }
}
