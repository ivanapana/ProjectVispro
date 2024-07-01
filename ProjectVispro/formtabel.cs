using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace ProjectVispro
{
    public partial class formtabel : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        private string nilaiDiterima;
        private string hargaDiterima;
        private string nilaiLabel;
        private string nilaiTextBox;
        private string nilaiAwal;
        public formtabel(string nilaiLabel, string nilaiTextBox, string nilaiAwal)
        {
            alamat = "server=localhost; database=db; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
            this.nilaiLabel = nilaiLabel;
            this.nilaiTextBox = nilaiTextBox;
            this.nilaiAwal = nilaiAwal;
        }

        private void BtnRincian_Click(object sender, EventArgs e)
        {
            try
            {


                query = string.Format("insert into `tbl_order` (`id_order`, `namaproduk`, `harga`, `qty`, `jumlahhargaa`) VALUES ('{0}','{1}', '{2}', '{3}', '{4}')", LblIdOrder.Text, LblMakananDiFormTujuan.Text, labelHasil.Text, LblHargaDiFormTujuan.Text, labelTotal.Text);
                //query = string.Format("insert into `tbl_order` (`jumlahhargaa`) VALUES ('{0}')", labelTotal.Text);
                //);//, TxtUsername.Text, TxtPassword.Text, TxtNamaPengguna.Text);

                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();

                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data success");
                    formtabel_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Insert data Error");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Form orderanrincian = new orderanrincian();
            orderanrincian.Show();
        }

        private void formtabel_Load(object sender, EventArgs e)
        {
            LblMakananDiFormTujuan.Text = nilaiLabel;
            LblHargaDiFormTujuan.Text = nilaiTextBox;
            string nilaiTambah = textBoxNilaiTambah.Text;

            // Gabungkan nilaiAwal dengan nilaiTambah
            string hasilGabung = nilaiAwal + nilaiTambah;

            // Tampilkan hasil penggabungan di Label (labelHasil)
            labelHasil.Text = hasilGabung;
            string strJumlah = labelHasil.Text;
            string strHarga = LblHargaDiFormTujuan.Text;

            // Konversi nilai string ke tipe data numerik (misalnya int atau double)
            if (int.TryParse(strJumlah, out int jumlah) && int.TryParse(strHarga, out int harga))
            {
                // Lakukan perkalian
                int total = jumlah * harga;

                // Tampilkan hasil perkalian di labelTotal
                labelTotal.Text = total.ToString();
            }
            else
            {
                // Handle jika nilai tidak valid (opsional)
                labelTotal.Text = "0"; // Atau tampilkan pesan kesalahan
            }
        }
    }
}
