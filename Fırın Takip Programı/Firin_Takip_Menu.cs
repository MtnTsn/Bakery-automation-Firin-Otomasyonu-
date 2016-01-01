using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fırın_Takip_Programı
{
    public partial class Firin_Takip_Menu : Form
    {
        public Firin_Takip_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Http://www.facebook.com/ebubekir.bastama.1");
        }
        private void Firin_Takip_Menu_Load(object sender, EventArgs e)
        {
            
        }     
        /// <summary>
        /// Bu bölüm label'lerden oluşmak'da olup işlevi ise sayfaları açtırmaktır.
        /// </summary>
        private void label15_Click_1(object sender, EventArgs e)
        {
            İrsaliye_Listesi iL = new İrsaliye_Listesi();
            iL.Show();
        }
        private void label14_Click_1(object sender, EventArgs e)
        {
Fatura_listesi fl = new Fatura_listesi();
            fl.Show();
        }
        private void label13_Click(object sender, EventArgs e)
        {
Malzeme_Faturalari mz = new Malzeme_Faturalari();
            mz.Show();
        }
        private void label12_Click_1(object sender, EventArgs e)
        {

        }
        private void label11_Click_1(object sender, EventArgs e)
        {
            İRSALİ_LİSTESİ il = new İRSALİ_LİSTESİ();
            il.Show();
        }
        private void label10_Click_1(object sender, EventArgs e)
        {
            İRSALİYE_FATURA_LİSTESİ ifl = new İRSALİYE_FATURA_LİSTESİ();
            ifl.Show();
        }
        private void label6_Click_1(object sender, EventArgs e)
        {
            Urun_Receteleri ur = new Urun_Receteleri();
            ur.ShowDialog();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Tezgah_Satisi ts = new Tezgah_Satisi();
            ts.ShowDialog();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Stok_Kart sk = new Stok_Kart();
            sk.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Araç_Kartlari ak = new Araç_Kartlari();
            ak.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Cari_Kart ck = new Cari_Kart();
            ck.Show();
        }    
        /// <summary>
        /// Bu bölüm label'lerden oluşmak'da olup işlevi ise sayfaları açtırmaktır.
        /// </summary>
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if ("OK" == MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Ebubekir Yazılım", MessageBoxButtons.OKCancel, MessageBoxIcon.Information).ToString())
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            İrsaliye_İslemleri İS = new İrsaliye_İslemleri();
            İS.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Fatura_İslemleri ft = new Fatura_İslemleri();
            ft.ShowDialog();
        }
    }
}
