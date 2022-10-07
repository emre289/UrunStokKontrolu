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
    public partial class Frmİstatisk : Form
    {
        public Frmİstatisk()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbUrun;Integrated Security=True");
        private void İstatisk_Load(object sender, EventArgs e)
        {
            // TOPLAM KATEGORİ SAYISI
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select Count(Ad) from TblKategori",sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lblKategoriSayisi.Text = sqlDataReader[0].ToString();
            }
            sqlConnection.Close();

            // TOPLAM ÜRÜN SAYISI
            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("Select Count(UrunAd) from TblProducts",sqlConnection);
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            while (sqlDataReader2.Read())
            {
                lblÜrünSayisi.Text = sqlDataReader2[0].ToString();
            }
            sqlConnection.Close();

            // PAHALI

            sqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("Select Max(SatisFiyat) from TblProducts", sqlConnection);
            SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();
            while (sqlDataReader3.Read())
            {
                lblPahaliUrun.Text = sqlDataReader3[0].ToString() + "₺";
            }
            sqlConnection.Close();

            // UCUZ
            sqlConnection.Open();
            SqlCommand sqlCommand4 = new SqlCommand("Select Min(SatisFiyat) from TblProducts", sqlConnection);
            SqlDataReader sqlDataReader4 = sqlCommand4.ExecuteReader();
            while (sqlDataReader4.Read())
            {
                lblUcuzUrun.Text = sqlDataReader4[0].ToString() + "₺";
            }
            sqlConnection.Close();

            // STOK SAYISI
            sqlConnection.Open();
            SqlCommand sqlCommand5 = new SqlCommand("Select Sum(Stok) from TblProducts", sqlConnection);
            SqlDataReader sqlDataReader5 = sqlCommand5.ExecuteReader();
            while (sqlDataReader5.Read())
            {
                lblStokSayisi.Text = sqlDataReader5[0].ToString();
            }
            sqlConnection.Close();

            // MALİYET DEĞERİ
            sqlConnection.Open();
            SqlCommand sqlCommand6 = new SqlCommand("Select Sum(AlisFiyat) from TblProducts", sqlConnection);
            SqlDataReader sqlDataReader6 = sqlCommand6.ExecuteReader();
            while (sqlDataReader6.Read())
            {
                lblMaliyetDegeri.Text = sqlDataReader6[0].ToString()+ "₺";
            }
            sqlConnection.Close();

            // SATIŞ DEĞERİ
            sqlConnection.Open();
            SqlCommand sqlCommand7 = new SqlCommand("Select Sum(SatisFiyat) from TblProducts", sqlConnection);
            SqlDataReader sqlDataReader7 = sqlCommand7.ExecuteReader();
            while (sqlDataReader7.Read())
            {
                lblSatisDegeri.Text = sqlDataReader7[0].ToString()+ "₺";
            }
            sqlConnection.Close();

            // TOPLAM CİRO
            sqlConnection.Open();
            SqlCommand sqlCommand8 = new SqlCommand("Select Sum(SatisFiyat)-Sum(AlisFiyat) from TblProducts", sqlConnection);
            SqlDataReader sqlDataReader8 = sqlCommand8.ExecuteReader();
            while (sqlDataReader8.Read())
            {
                lblCiroDegeri.Text = sqlDataReader8[0].ToString() + "₺";
            }
            sqlConnection.Close();


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
