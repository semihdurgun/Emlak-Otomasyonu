using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonu
{
    public partial class Login : Form
    {
        ClassLibrary.Class a = new ClassLibrary.Class();
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            bool isTrue = a.Login(tbKullanıcıAdı.Text , tbSifre.Text);
            if (isTrue)
            {
                MessageBox.Show("Giriş Başarılı");
                this.Close();
                AnaMenü menü = new AnaMenü();
                menü.Show();
            }
            else
            {
                MessageBox.Show("Tekrar Deneyiniz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbSifre.PasswordChar = '*';
            FileStream fs = new FileStream(@"users.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fs.Close();
        }
    }
}
