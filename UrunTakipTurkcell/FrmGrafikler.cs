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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbUrun;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select Ad,Count(*) from TblKategori inner join TblProducts on TblProducts.Kategori=TblKategori.Id Group By Ad",sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                // GRAFİKTE X Y KORDİNATLARINA NE YAZILACAK
                chart1.Series["Kategoriler"].Points.AddXY(sqlDataReader[0], sqlDataReader[1]);

            }
            sqlConnection.Close();
        }
    }
}
