using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakipTurkcell
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbUrun;Integrated Security=True");
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void bntGirisYap_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from TblAdmin where Kullanici=@p1 and Sifre=@p2",sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", txbKullaniciAdi.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txbSifre.Text);
            SqlDataReader sqlDataReader =sqlCommand.ExecuteReader();
            // OKUMA İŞLEMİ BAŞARI İLE GERÇEKLEŞİRSE
            if (sqlDataReader.Read())
            {
                FrmYonlendirme frm = new FrmYonlendirme();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA PAROLA HATALI");
            }
            sqlConnection.Close();


        }
    }
}
