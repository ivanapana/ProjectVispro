using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVispro
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Label lbl;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            lbl = label3;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string makanan = "Churos";
            string harga = "20000";
            Form formrincianorder = new formrincianorder(makanan, harga);
            formrincianorder.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            string makanan = "Tori Misu Ramen";
            string harga = "28000";
            Form formrincianorder = new formrincianorder(makanan, harga);
            formrincianorder.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string makanan = "Ayam Woku";
            string harga = "25000";

            Form formrincianorder = new formrincianorder(makanan, harga);
            formrincianorder.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            string makanan = "Cheesy Fries";
            string harga = "20000";
            Form formrincianorder = new formrincianorder(makanan, harga);
            formrincianorder.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string makanan = "Chiken Steak";
            string harga = "30000";
            Form formrincianorder = new formrincianorder(makanan, harga);
            formrincianorder.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            string makanan = "Klabat Spring";
            string harga = "27000";
            Form formrincianorder = new formrincianorder(makanan, harga);
            formrincianorder.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            string makanan = "Klabat Fried Chiken";
            string harga = "33000";
            Form formrincianorder = new formrincianorder(makanan, harga);
            formrincianorder.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            string makanan = "Maklen Spring";
            string harga = "27000";
            Form formrincianorder = new formrincianorder(makanan, harga);
            formrincianorder.Show();
        }
    }
}
