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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void formUrun_Load(object sender, EventArgs e)
        {

            LoadProducts();
            sqlConnection.Close();
        }

     

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbUrun;Integrated Security=True");
        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select UrunId,UrunAd,Stok,AlisFiyat,SatisFiyat,Ad,Kategori from TblProducts Inner Join TblKategori On TblProducts.Kategori = TblKategori.Id", sqlConnection);



                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgwProducts.DataSource = dataTable;
                // KULLANICIYA CATEGORY ID BİLGİSİ GÖZÜKMESİN ARKA PLANDA TUTSUN
                dgwProducts.Columns["Kategori"].Visible = false;
                sqlConnection.Close();
                
            }
            catch 
            {

            }
        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // e parametresi o hangi satıda olduğumu kontrol eder
            try
            {
                txbÜrünId.Text = dgwProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbÜrünAdi.Text = dgwProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                nudStok.Value = int.Parse(dgwProducts.Rows[e.RowIndex].Cells[2].Value.ToString());
                txbAlisFiyati.Text = dgwProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                txbSatisFiyati.Text = dgwProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbxKategoriAdi.SelectedValue = dgwProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch 
            {

                
            }
 


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("insert into TblProducts(UrunAd,Stok,AlisFiyat,SatisFiyat,Kategori)  values (@p1,@p2,@p3,@p4,@p5)", sqlConnection);
            sqlCommand3.Parameters.AddWithValue("@p1", txbÜrünAdi.Text);
            sqlCommand3.Parameters.AddWithValue("@p2", nudStok.Value);
            sqlCommand3.Parameters.AddWithValue("@p3", txbAlisFiyati.Text);
            sqlCommand3.Parameters.AddWithValue("@p4", txbSatisFiyati.Text);
            sqlCommand3.Parameters.AddWithValue("@p5", cbxKategoriAdi.SelectedValue);
            sqlCommand3.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Ürünler Eklendi");

        }

        private void nudStok_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete from TblProducts where UrunId=@p1",sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", txbÜrünId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("ÜRÜN SİLİNDİ");

            
        }
        private void LoadProducts()
        {
           
            SqlCommand sqlCommand2 = new SqlCommand("Select * from TblKategori", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            // Ön Planda Gözükecek / Arka Planda Tutulucak Değer
            cbxKategoriAdi.DisplayMember = "Ad";
            cbxKategoriAdi.ValueMember = "Id";
            cbxKategoriAdi.DataSource = dataTable;
            
           
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand5 = new SqlCommand("Update TblProducts set UrunAd=@p1,Stok=@p2,AlisFiyat=@p3,SatisFiyat=@p4,Kategori=@p5 where UrunId=@p6",sqlConnection);
            sqlCommand5.Parameters.AddWithValue("@p1", txbÜrünAdi.Text);
            sqlCommand5.Parameters.AddWithValue("@p2", nudStok.Value);
            sqlCommand5.Parameters.AddWithValue("@p3", decimal.Parse(txbAlisFiyati.Text));
            sqlCommand5.Parameters.AddWithValue("@P4", decimal.Parse(txbSatisFiyati.Text));
            sqlCommand5.Parameters.AddWithValue("@p5", cbxKategoriAdi.SelectedValue);
            sqlCommand5.Parameters.AddWithValue("@p6", txbÜrünId.Text);
            sqlCommand5.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("ÜRÜNLER GÜNCELLENDİ");

            
        }

        private void cbxKategoriAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
