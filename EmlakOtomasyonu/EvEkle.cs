using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonu
{
    public partial class EvEkle : Form
    {
        ClassLibrary.Class a = new ClassLibrary.Class();
        ArrayList satılıkEv = new ArrayList();
        ArrayList kiralıkEv = new ArrayList();
        DataGridView dwSilinecek = new DataGridView();
        public EvEkle()
        {
            InitializeComponent();
        }

        private void EvEkle_Load(object sender, EventArgs e)
        {
            gbSatilikEv.Show();
            gbKiralıkEv.Hide();
            cbEvTürü.SelectedIndex = 0;
            string iladı = "İl\\";
            DirectoryInfo fileInfo = new DirectoryInfo(iladı);
            foreach (FileInfo item in fileInfo.GetFiles())
            {
                string yazi = Convert.ToString(item);
                yazi = yazi.Substring(0, yazi.Length - 4);
                comboBox_il.Items.Add(yazi);
            }
        }

        private void rbKiralıkEv_CheckedChanged(object sender, EventArgs e)
        {
            gbSatilikEv.Hide();
            gbKiralıkEv.Show();
        }

        private void rbSatilikEv_CheckedChanged(object sender, EventArgs e)
        {
            gbKiralıkEv.Hide();
            gbSatilikEv.Show();
        }

        private void dtpEvYapımTarihi_ValueChanged(object sender, EventArgs e)
        {
            string evYasi = a.yasHesapla(Convert.ToString(dtpEvYapımTarihi.Text));
            int evYasYil = Convert.ToInt32(evYasi) / 365;
            tbEvYasi.Text = evYasYil + " yıllık";
        }

        private void tbKatNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public static int sayac = 000;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
                EviKaydet();
                
                
            
        }
        public void EviKaydet()
        {
            if (tbToplamAlan.Text == "" || tbOdaSayisi.Text == "" || tbKatNumarasi.Text == "" || comboBox_il.SelectedItem == null || comboBox_ilce.SelectedItem == null
                || tbEvYasi.Text == "" || tbEvYasi.Text == "" || (tbKiralıkEvDepozito.Text == "" && tbSatilikEvFiyat.Text == ""))
            {
                MessageBox.Show("Lütfen Boş Alanları Giriniz..");
            }
            else
            {
                Random rnd = new Random();
                if (rbSatilikEv.Checked)
                {
                    ClassLibrary.SatilikEv se = new ClassLibrary.SatilikEv(cbEvTürü.SelectedItem, dtpEvYapımTarihi);
                    string kelime = comboBox_il.SelectedItem.ToString();
                    string üçHarf = kelime.Substring(0, 3);
                    string kelime2 = comboBox_ilce.SelectedItem.ToString();
                    string üçHarf2 = kelime2.Substring(0, 3);
                    sayac = rnd.Next(100, 999);
                    se.EmlakNo = üçHarf + "-" + üçHarf2 + "-S" + sayac;
                    se.EvAlani = Convert.ToInt32(tbToplamAlan.Text);
                    se.OdaSayisi = Convert.ToInt32(tbOdaSayisi.Text);
                    se.KatNumarasi = Convert.ToInt32(tbKatNumarasi.Text);
                    se.İl = comboBox_il.SelectedItem.ToString();
                    se.Semt = comboBox_ilce.Text;
                    se.EvAktifDurum = Convert.ToBoolean(rbAktif.Checked);
                    se.YapimTarihi = Convert.ToString(dtpEvYapımTarihi.Value);
                    se.fiyat = Convert.ToDecimal(tbSatilikEvFiyat.Text);
                    if (!Directory.Exists(@"EvResimleri"))
                    {
                        Directory.CreateDirectory(@"EvResimleri");
                    }
                    Directory.CreateDirectory(@"EvResimleri/" + se.EmlakNo);

                    satılıkEv.Add(se.EvBilgileri());
                    FileStream syaz = new FileStream(@"satilik.txt", FileMode.OpenOrCreate);
                    syaz.Close();
                    StreamWriter swriter = new StreamWriter(@"satilik.txt", true);
                    swriter.WriteLine(satılıkEv[0]);
                    swriter.Close();
                    MessageBox.Show("Başarılı bir şekilde kaydedildi.Ana Forma gönderiliyorsunuz..");
                    AnaMenü aM = new AnaMenü();
                    this.Hide();
                    aM.Show();
                }
                else
                {
                    ClassLibrary.KiralikEv ke = new ClassLibrary.KiralikEv(cbEvTürü.SelectedItem);
                    string kelime = comboBox_il.SelectedItem.ToString();
                    string üçHarf = kelime.Substring(0, 3);
                    string kelime2 = comboBox_ilce.SelectedItem.ToString();
                    string üçHarf2 = kelime2.Substring(0, 3);
                    sayac = rnd.Next(100, 999);
                    ke.EmlakNo = üçHarf + "-" + üçHarf2 + "-K" + sayac;
                    ke.EvAlani = Convert.ToInt32(tbToplamAlan.Text);
                    ke.OdaSayisi = Convert.ToInt32(tbOdaSayisi.Text);
                    ke.KatNumarasi = Convert.ToInt32(tbKatNumarasi.Text);
                    ke.İl = comboBox_il.SelectedItem.ToString();
                    ke.Semt = comboBox_ilce.Text;
                    ke.EvAktifDurum = Convert.ToBoolean(rbAktif.Checked);
                    ke.YapimTarihi = Convert.ToString(dtpEvYapımTarihi.Value);
                    ke.Depozito = (Convert.ToInt32(tbKiralıkEvDepozito.Text));
                    if (!Directory.Exists(@"EvResimleri"))
                    {
                        Directory.CreateDirectory(@"EvResimleri");
                    }
                    Directory.CreateDirectory(@"EvResimleri/" + ke.EmlakNo);
                    ke.FiyatHesapla();
                    kiralıkEv.Add(ke.EvBilgileri());
                    FileStream kyaz = new FileStream(@"kiralik.txt", FileMode.OpenOrCreate);
                    kyaz.Close();
                    StreamWriter kwriter = new StreamWriter(@"kiralik.txt", true);
                    kwriter.WriteLine(kiralıkEv[0]);
                    kwriter.Close();
                    MessageBox.Show("Başarılı bir şekilde kaydedildi.Ana Forma gönderiliyorsunuz..");
                    AnaMenü aM = new AnaMenü();
                    this.Hide();
                    aM.Show();
                }
            }
        }
        private void comboBox_il_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox_ilce.Items.Clear();
            string iladı = "İl\\" + comboBox_il.Text;
            string yazi;
            StreamReader sr = new StreamReader(iladı + ".txt");
            while ((yazi = sr.ReadLine()) != null)
            {
                comboBox_ilce.Items.Add(yazi);
            }
        }
        public void EviGüncelle(DataGridView dw)
        {
            label15.Visible = true;
            btnEvResimleri.Visible = true;
            dwSilinecek = dw;
            label15.Text = Convert.ToString(dw.CurrentRow.Cells[0].FormattedValue);
        //   comboBox_il.ValueMember = Convert.ToString(dw.CurrentRow.Cells[1].FormattedValue);
        //   comboBox_ilce.ValueMember = Convert.ToString(dw.CurrentRow.Cells[2].FormattedValue);
            if (Convert.ToString(dw.CurrentRow.Cells[3].FormattedValue) == "True")
            {
                rbAktif.Checked = true;
            }
            else
            {
                rbPasif.Checked = true;
            }
            tbToplamAlan.Text = Convert.ToString(dw.CurrentRow.Cells[4].FormattedValue);
            tbOdaSayisi.Text = Convert.ToString(dw.CurrentRow.Cells[5].FormattedValue);
            tbKatNumarasi.Text = Convert.ToString(dw.CurrentRow.Cells[6].FormattedValue);
            tbEvYasi.Text = Convert.ToString(dw.CurrentRow.Cells[7].FormattedValue);
            cbEvTürü.ValueMember = Convert.ToString(dw.CurrentRow.Cells[8].FormattedValue);
            btnGüncellemeKaydet.Visible = true;
            btnKaydet.Visible = false;
        }

        public void btnGüncellemeKaydet_Click(object sender, EventArgs e)
        {
            string yazi;
            string i = "";
            
            string alınan = Convert.ToString(dwSilinecek.CurrentRow.Cells[0].FormattedValue);
            dwSilinecek.Rows.RemoveAt(dwSilinecek.SelectedRows[0].Index);
            StreamReader srk = File.OpenText(@"kiralik.txt");
            while ((yazi = srk.ReadLine()) != null)
            {
                if (!yazi.Contains(alınan))  //contains yazinin içinde silinecek veri varsa true döndürür.
                {
                    i += yazi + "\n";
                }
            }
            srk.Close();
            File.WriteAllText(@"kiralik.txt", i);
            string l = "";

            //kiralık için de arıyor.
            StreamReader srs = File.OpenText(@"satilik.txt");
            while ((yazi = srs.ReadLine()) != null)
            {
                if (!yazi.Contains(alınan))  
                {
                    l += yazi + "\n";
                }
            }
            srs.Close();
            File.WriteAllText(@"satilik.txt", l);
            Directory.Delete("EvResimleri\\" + alınan);
            EviKaydet();   
        }
        private void btnEvResimleri_Click(object sender, EventArgs e)
        {
            string path;
            try
            {
                path = Registry.CurrentUser.GetValue("Yolu").ToString();
            }
            catch
            {
                path = @"\";
            }
            DataGridView dw;
            dw = dwSilinecek;
            using (OpenFileDialog Yeni = new OpenFileDialog())
            {
                Yeni.Title = "Resim Seçme Penceresi";
                Yeni.Filter = "Resim DosyaLarı (*.gif;*.jpg;*.jpeg;*.png;*.bmp;) | *.gif;*.jpg;*.jpeg;*.png;*.bmp";
                Yeni.InitialDirectory = path;
                DialogResult Pencere = Yeni.ShowDialog(this);
                if (Pencere == DialogResult.OK)
                {
                    string yoL = null;
                    yoL = Yeni.FileName;
                    int Numara = yoL.LastIndexOf("\\");
                    yoL = yoL.Substring(0, Numara);
                    Registry.CurrentUser.SetValue("Yolu", yoL);

                    string fileName = Path.GetFileName(Yeni.FileName);
                    string ResimAd = Path.GetDirectoryName(Yeni.FileName); 
                    string targetPath = "EvResimleri\\" + dw.CurrentRow.Cells[0].FormattedValue;
                    string sourceFile = System.IO.Path.Combine(ResimAd, fileName);
                    string destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.Directory.CreateDirectory(targetPath);
                    System.IO.File.Copy(sourceFile, destFile, true);

                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenü aM = new AnaMenü();
            aM.Show();
        }
    }
}
