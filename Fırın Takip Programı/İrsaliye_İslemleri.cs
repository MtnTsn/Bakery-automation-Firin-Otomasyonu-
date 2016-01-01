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
    public partial class İrsaliye_İslemleri : Form
    {
        public İrsaliye_İslemleri()
        {
            InitializeComponent();
        }
        string  a;
        private void İrsaliye_İslemleri_Load(object sender, EventArgs e)
        {
            a = DateTime.Now.ToString();
            maskedTextBoxAdv1.Text = a;
            
        }
    }
}
