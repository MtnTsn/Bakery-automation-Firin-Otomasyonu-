using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fırın_Takip_Programı
{
    public partial class Fatura_İslemleri : Form
    {
        public Fatura_İslemleri()
        {
            InitializeComponent();
        }

        private void btn_yazdır_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Tek_Fatura_Kesimi tfk = new Tek_Fatura_Kesimi();
            tfk.ShowDialog();
        }

    }
}
