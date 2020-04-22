using System;
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
    public partial class EvSorgu : Form
    {
        public EvSorgu()
        {
            InitializeComponent();
        }
        private void IlAdresSorgu(string evDurumu, string kiraDurumu)
        {
            string[] satirDizi;
            string rLine;            
            DataTable dt = new DataTable();

            if (kiraDurumu == "kiralik")
            {
                StreamReader reader = File.OpenText(@"kiralik.txt");
                rLine = reader.ReadLine();
                string[] sütunDizi = { "Emlak No","İl", "Semt", "Aktif mi?", "Ev Alanı", "OdaSayisi", "Kat Sayısı", "Bina Yaşı(Gün)", "Ev Türü", "Depozito", "Kira" };
                satirDizi = rLine.Split('|');

                for (int m = 0; m < sütunDizi.Length; m++)
                {
                    dt.Columns.Add(sütunDizi[m]);
                }
                while (rLine != null)
                {
                    rLine = reader.ReadLine();
                    if (rLine != null)
                    {
                        satirDizi = rLine.Split('|');
                    }
                    else
                    {
                        dataGridViewSonuc.DataSource = dt;
                        dataGridViewSonuc.Show();
                        reader.Close();
                        return;
                    }
                    //datatable'ın tüm hücrelerini teker teker dolduruyoruz.
                    if (evDurumu == "aktif")
                    {
                        if (rLine.Contains(comboBox_il.Text) && rLine.Contains("True"))
                        {
                            dt.Rows.Add(satirDizi[0], satirDizi[1], satirDizi[2], satirDizi[3], satirDizi[4], satirDizi[5], satirDizi[6], satirDizi[7], satirDizi[8], satirDizi[9], satirDizi[10]);
                        }
                    }
                    else if (evDurumu == "pasif")
                    {
                        if (rLine.Contains(comboBox_il.Text) && rLine.Contains("False")) 
                        {
                            dt.Rows.Add(satirDizi[0], satirDizi[1], satirDizi[2], satirDizi[3], satirDizi[4], satirDizi[5], satirDizi[6], satirDizi[7], satirDizi[8], satirDizi[9], satirDizi[10]);
                        }
                    }
                    else
                    {
                        if (rLine.Contains(comboBox_il.Text))
                        {
                            dt.Rows.Add(satirDizi[0], satirDizi[1], satirDizi[2], satirDizi[3], satirDizi[4], satirDizi[5], satirDizi[6], satirDizi[7], satirDizi[8], satirDizi[9], satirDizi[10]);
                        }
                    }
                }
                reader.Close();
            }
            if (kiraDurumu == "satilik")
            {
                StreamReader reader = File.OpenText(@"satilik.txt");
                rLine = reader.ReadLine();
                string[] sütunDizi = { "Emlak No","İl", "Semt", "Aktif mi?", "Ev Alanı", "OdaSayisi", "Kat Sayısı", "Bina Yaşı(Gün)", "Ev Türü", "Fiyat" };
                satirDizi = rLine.Split('|');
                for (int m = 0; m < sütunDizi.Length; m++)
                {
                    dt.Columns.Add(sütunDizi[m]);
                }
                while (rLine != null)
                {
                    rLine = reader.ReadLine();
                    if (rLine != null)
                    {
                        satirDizi = rLine.Split('|');
                    }
                    else
                    {
                        dataGridViewSonuc.DataSource = dt;
                        dataGridViewSonuc.Show();
                        reader.Close();
                        return;
                    }
                    //datatable'ın tüm hücrelerini teker teker dolduruyoruz.
                    if (evDurumu == "aktif")
                    {
                        if (rLine.Contains(comboBox_il.Text) && rLine.Contains("True")) 
                        {
                            dt.Rows.Add(satirDizi[0], satirDizi[1], satirDizi[2], satirDizi[3], satirDizi[4], satirDizi[5], satirDizi[6], satirDizi[7], satirDizi[8], satirDizi[9]);
                        }
                    }
                    else if (evDurumu == "pasif")
                    {
                        if (rLine.Contains(comboBox_il.Text) && rLine.Contains("False"))
                        {
                            dt.Rows.Add(satirDizi[0], satirDizi[1], satirDizi[2], satirDizi[3], satirDizi[4], satirDizi[5], satirDizi[6], satirDizi[7], satirDizi[8], satirDizi[9]);
                        }
                    }
                    else
                    {
                        if (rLine.Contains(comboBox_il.Text))
                        {
                            dt.Rows.Add(satirDizi[0], satirDizi[1], satirDizi[2], satirDizi[3], satirDizi[4], satirDizi[5], satirDizi[6], satirDizi[7], satirDizi[8], satirDizi[9]);
                        }
                    }
                }
                reader.Close();
            }
        }
        private void IlIlceAdresSorgu(string evDurumu, string kiraDurumu)
        {
            string[] satirDizi;
            string rLine;
            DataTable dt = new DataTable();
            if (kiraDurumu == "kiralik")
            {
                StreamReader reader = File.OpenText(@"kiralik.txt");
                rLine = reader.ReadLine();
                string[] sütunDizi = { "Emlak No","İl", "Semt", "Aktif mi?", "Ev Alanı", "OdaSayisi", "Kat Sayısı", "Yapım Tarihi", "Ev Türü", "Depozito", "Kira" };
                satirDizi = rLine.Split('|');

                for (int m = 0; m < sütunDizi.Length; m++)
                {
                    dt.Columns.Add(sütunDizi[m]);
                }
                
                while (rLine != null)
                {
                    rLine = reader.ReadLine();
                    if (rLine != null)
                    {
                        satirDizi = rLine.Split('|');
                    }
                    else
                    {
                        dataGridViewSonuc.DataSource = dt;
                        dataGridViewSonuc.Show();
                        reader.Close();
                        return;
                    }
                    //datatable'ın tüm hücrelerini teker teker dolduruyoruz.
                    if (evDurumu == "aktif")
                    {
                        if (rLine.Contains(comboBox_il.Text) && rLine.Contains(comboBox_ilce.Text) && rLine.Contains("True")) //ilk değeri almadıgından dolayı bu kontrolü yaptık.
                        {
                            dt.Rows.Add(satirDizi[0], satirDizi[1], satirDizi[2], satirDizi[3], satirDizi[4], satirDizi[5], satirDizi[6], satirDizi[7], satirDizi[8], satirDizi[9], satirDizi[10]);
                        }
                    }
                    else if (evDurumu == "pasif")
                    {
                        if (rLine.Contains(comboBox_il.Text) && rLine.Contains(comboBox_ilce.Text) && rLine.Contains("False"))
                        {
                            dt.Rows.Add(satirDizi[0], satirDizi[1], satirDizi[2], satirDizi[3], satirDizi[4], satirDizi[5], satirDizi[6], satirDizi[7], satirDizi[8], satirDizi[9], satirDizi[10]);
                        }
                    }
                    else
                    {
                        if (rLine.Contains(comboBox_il.Text) && rLine.Contains(comboBox_ilce.Text))
                        {
                            dt.Rows.Add(satirDizi[0], satirDizi[1], satirDizi[2], satirDizi[3], satirDizi[4], satirDizi[5], satirDizi[6], satirDizi[7], satirDizi[8], satirDizi[9], satirDizi[10]);
                        }
                    }
                }
                reader.Close();
            }
            if (kiraDurumu == "satilik")
            {
                StreamReader reader = File.OpenText(@"satilik.txt");
                rLine = reader.ReadLine();
                string[] sütunDizi = { "Emlak No", "İl","Semt", "Aktif mi?", "Ev Alanı", "OdaSayisi", "Kat Sayısı", "Yapım Tarihi", "Ev Türü", "Fiyat" };
                satirDizi = rLine.Split('|');
                for (int m = 0; m < sütunDizi.Length; m++)
                {
                    dt.Columns.Add(sütunDizi[m]);
                }
                while (rLine != null)
                {
                    rLine = reader.ReadLine();
                    if (rLine != null)
                    {
                        satirDizi = rLine.Split('|');
                    }
                    else
                    {
                        dataGridViewSonuc.DataSource = dt;
                        dataGridViewSonuc.Show();
                        reader.Close();
                        return;
                    }
                    //datatable'ın tüm hücrelerini teker teker dolduruyoruz.
                    if (evDurumu == "aktif")
                    {
                        if (rLine.Contains(comboBox_il.Text) && rLine.Contains(comboBox_ilce.Text) && rLine.Contains("True")) //ilk değeri almadıgından dolayı bu kontrolü yaptık.
                        {
                            dt.Rows.Add(satirDizi[0], satirDizi[1], satirDizi[2], satirDizi[3], satirDizi[4], satirDizi[5], satirDizi[6], satirDizi[7], satirDizi[8], satirDizi[9]);
                        }
                    }
                    else if (evDurumu == "pasif")
                    {
                        if (rLine.Contains(comboBox_il.Text) && rLine.Contains(comboBox_ilce.Text) && rLine.Contains("False"))
                        {
                            dt.Rows.Add(satirDizi[0], satirDizi[1], satirDizi[2], satirDizi[3], satirDizi[4], satirDizi[5], satirDizi[6], satirDizi[7], satirDizi[8], satirDizi[9]);
                        }
                    }
                    else
                    {
                        if (rLine.Contains(comboBox_il.Text) && rLine.Contains(comboBox_ilce.Text))
                        {
                            dt.Rows.Add(satirDizi[0], satirDizi[1], satirDizi[2], satirDizi[3], satirDizi[4], satirDizi[5], satirDizi[6], satirDizi[7], satirDizi[8], satirDizi[9]);
                        }
                    }
                }
                reader.Close();
            }
        }
        public static string evDurumu = "", kiraDurumu = "";

        private void comboBox_il_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox_ilce.Items.Clear();
            string iladı ="İl\\" + comboBox_il.Text;
            string yazi;
            StreamReader sr = new StreamReader(iladı + ".txt");
             while((yazi=sr.ReadLine()) != null)
             {
                comboBox_ilce.Items.Add(yazi);
             }
            sr.Close();
        }

        private void EvSorgu_Load(object sender, EventArgs e)
        {
            string iladı = "İl\\";
            DirectoryInfo fileInfo = new DirectoryInfo(iladı);
            foreach (FileInfo item in fileInfo.GetFiles())
            {
                string yazi = Convert.ToString(item);
                yazi = yazi.Substring(0, yazi.Length - 4);
                comboBox_il.Items.Add(yazi);
            }
        }

        private void btnEvAdresSorgulama_Click(object sender, EventArgs e)
        {
            RadioButtonKontrol();
            
            if (comboBox_il.Text == "" && comboBox_ilce.Text == "")
            {
                MessageBox.Show("Lütfen İL veya İLÇE seçimi yapınız.");

            }
            else if (comboBox_il.Text != "" && comboBox_ilce.Text == "")
            {
                btnEvResimGörüntüle.Visible = true;
                btnGüncelle.Visible = true;
                btnSil.Visible = true;
                IlAdresSorgu(evDurumu, kiraDurumu);

            }
            else if (comboBox_il.Text != "" && comboBox_ilce.Text != "")
            {
                btnEvResimGörüntüle.Visible = true;
                btnGüncelle.Visible = true;
                btnSil.Visible = true;
                IlIlceAdresSorgu(evDurumu, kiraDurumu);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SonucSil();
        }
        public void SonucSil()
        {
            string yazi;
            string i = "";
            if (dataGridViewSonuc.SelectedRows.Count == 1)
            {
                string alınan = Convert.ToString(dataGridViewSonuc.CurrentRow.Cells[0].FormattedValue);
                dataGridViewSonuc.Rows.RemoveAt(dataGridViewSonuc.SelectedRows[0].Index);
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

                //kiralık için de arıyor.
                StreamReader srs = File.OpenText(@"satilik.txt");
                while ((yazi = srs.ReadLine()) != null)
                {
                    if (!yazi.Contains(alınan))  
                    {
                        i += yazi + "\n";
                    }
                }
                srs.Close();
                File.WriteAllText(@"satilik.txt", i);
                Directory.Delete("EvResimleri\\" + alınan);
            }
            else if (dataGridViewSonuc.SelectedRows.Count > 1)
            {
                MessageBox.Show("Lüffen bir değer seçiniz.");
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        public void Guncelle()
        {
            if (dataGridViewSonuc.SelectedRows.Count == 1)
            {
                this.Hide();
                EvEkle EviEkle = new EvEkle();
                EviEkle.EviGüncelle(dataGridViewSonuc);
                EviEkle.Show();
            }
            else if (dataGridViewSonuc.SelectedRows.Count > 1)
            {
                MessageBox.Show("Lüffen bir değer seçiniz.");
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırın sol kutusundan seçim yapınız.");
            }
        }

        private void btnEvResimGörüntüle_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "EvResimleri\\" + Convert.ToString(dataGridViewSonuc.CurrentRow.Cells[0].FormattedValue);
                Process.Start(path);
            }
            catch
            {
                MessageBox.Show("Bu evin resimleri henüz yok.");
            }
        }

        public void RadioButtonKontrol()
        {
            if (rbAktif.Checked == true)
                evDurumu = "aktif";

            if (rbPasif.Checked == true)
                evDurumu = "pasif";
            
            if (rbTümü.Checked == true)
                evDurumu = "tümü";

            if (rbKiralik.Checked == true)
                kiraDurumu = "kiralik";

            if (rbSatilik.Checked == true)
                kiraDurumu = "satilik";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenü aM = new AnaMenü();
            aM.Show();
        }
    }
}
