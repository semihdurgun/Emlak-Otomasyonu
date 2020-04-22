using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonu
{
    public partial class AnaMenü : Form
    {
        public AnaMenü()
        {
            InitializeComponent();
        }

        private void btnEvEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvEkle evEkle = new EvEkle();
            evEkle.Show();
        }
        private void btnEvSorgu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvSorgu evSorgu = new EvSorgu();
            evSorgu.Show();
        }
    }
}
