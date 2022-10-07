using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakipTurkcell
{
    public partial class FrmYonlendirme : Form
    {
        public FrmYonlendirme()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            FrmUrun frmUrun = new FrmUrun();
            frmUrun.Show();
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            FrmKategori frmKategori= new FrmKategori();
            frmKategori.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Frmİstatisk frmİstatisk = new Frmİstatisk();
            frmİstatisk.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGrafikler = new FrmGrafikler();
            frmGrafikler.Show();
        }

        private void FrmYonlendirme_Load(object sender, EventArgs e)
        {
            
        }
    }
}
