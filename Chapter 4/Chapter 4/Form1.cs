using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTukar_Click(object sender, EventArgs e)
        {
            QRManager.TukarInfo(ref tbNamaPenerima, ref tbNamaPengirim);
            QRManager.TukarInfo(ref tbAlamatAsal, ref tbAlamatTujuan);
            QRManager.TukarInfo(ref tbHpPenerima, ref tbHpPengirim);
        }
    }
}
