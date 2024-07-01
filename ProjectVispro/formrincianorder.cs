using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace ProjectVispro
{
    public partial class formrincianorder : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        private string nilaiDiterima;
        private string hargaDiterima;
        public formrincianorder(string makanan, string hargaDiterima)
        {
            alamat = "server=localhost; database=db; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
            this.nilaiDiterima = makanan;
            this.hargaDiterima = hargaDiterima;
        }

        private void formrincianorder_Load(object sender, EventArgs e)
        {
            LblMakanan.Text = nilaiDiterima;
            LblHarga.Text = hargaDiterima;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nilaiLabel = LblMakanan.Text;
            string nilaiTextBox = LblHarga.Text;
            string nilaiAwal = textBoxNilaiAwal.Text;

            Form formtabel = new formtabel(nilaiLabel, nilaiTextBox, nilaiAwal);
            formtabel.Show();
        }

        private MySqlCommand GetPerintah()
        {
            return perintah;
        }
    }
}
