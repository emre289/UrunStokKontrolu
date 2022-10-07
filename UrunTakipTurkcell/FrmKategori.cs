using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace UrunTakipTurkcell
{
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbUrun;Integrated Security=True");

        private void btnListele_Click(object sender, EventArgs e)
        {
            CategoryLoad();

        }

 

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand(" insert into TblKategori (Ad) values (@p1)", sqlConnection);
            sqlCommand2.Parameters.AddWithValue("@p1", txbKategoriAdi.Text);
            // KODU ÇALIŞTIR
            sqlCommand2.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("KATEGORİ EKLENDİ");
            
            
        }
    

        private void btnSil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("delete from TblKategori where Id=@p1",sqlConnection);
            sqlCommand3.Parameters.AddWithValue("@p1", txbId.Text);
            sqlCommand3.ExecuteNonQuery();
          
            sqlConnection.Close();
            MessageBox.Show("KATEGORİ SİLİNDİ");
            
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand4 = new SqlCommand("Update TblKategori set Ad=@p1 where Id=@p2",sqlConnection);
            sqlCommand4.Parameters.AddWithValue("@p1", txbKategoriAdi.Text);
            sqlCommand4.Parameters.AddWithValue("@p2",txbId.Text);
            sqlCommand4.ExecuteNonQuery();
   
            sqlConnection.Close();
            MessageBox.Show("KATEGORİ GÜNCELLENDİ");

        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand sqlCommand5 = new SqlCommand("Select * from TblKategori where Ad=@p1", sqlConnection);
                sqlCommand5.Parameters.AddWithValue("@p1", txbKategoriAdi.Text);
                sqlCommand5.Parameters.AddWithValue("@p2", txbId.Text);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand5);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgwList.DataSource = dataTable;

            }
            catch
            {

                
            }
           
            


        }

        private void CategoryLoad()
        {
            // KOMUTLARI KULLANABİLMEK İÇİN COMMAND SINIFINDAN NESNE OLUŞTURDUK
            SqlCommand sqlCommand = new SqlCommand("Select * From TblKategori", sqlConnection);

            // ARADAKİ KÖPRÜYÜ OLUŞTURDUK
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            // TABLOYU DOLDURACAĞIMIZ ALAN
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgwList.DataSource = dataTable;
        }

       
    }
}


