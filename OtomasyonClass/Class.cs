using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class
    {

        public bool Login(string kullanıcıAdı,string sifre)
        {
            string yazi;
            string[] parcalar = { };
            char ayrac = '-';
            bool isTrue = false;
            StreamReader sr = File.OpenText(@"users.txt");
            while( (yazi = sr.ReadLine()) != null)
            {
               parcalar  = yazi.Split(ayrac);
            }
            if (parcalar[0] == kullanıcıAdı && parcalar[1] == sifre)
            {
                isTrue = true;
            }
            sr.Close();
            return isTrue;
        }

        public string yasHesapla(string tarih)
        {
            TimeSpan ts;
            ts = DateTime.Now - Convert.ToDateTime(tarih);
            return ts.Days.ToString();
        }  
    }
    public abstract class Ev
    {
        private int odaSayisi, katNumarasi, evAlani, depozito;
        private Boolean evAktifDurum = false;
        private string semt, emlakNo, il;
        public string yapimTarihi;
        
        public enum EvTur
        {
            Bilinmiyor,
            Daire,
            Bahçeli,
            Dubleks,
            Müstakil,
            Havuzlu,
            Apart
        }
        public int OdaSayisi
        {
            get
            {
                return odaSayisi;
            }
            set
            {
                if (odaSayisi < 0)
                {
                    OdaSayisiLog();
                    odaSayisi = 0;
                }
                else
                {
                    odaSayisi = value;
                    OdaSayisiLog();
                }
            }
        }
        private void OdaSayisiLog()
        {
            if (!Directory.Exists(@"EvLog"))
            {
                Directory.CreateDirectory(@"EvLog");
            }
            FileStream fs = new FileStream(@"Evlog/EvLog.txt", FileMode.OpenOrCreate);
            fs.Close();
            StreamWriter sw = new StreamWriter(@"Evlog/EvLog.txt",true);
            sw.WriteLine("Girilmek İstenen Deger| " + odaSayisi + " |Tarih | " + DateTime.Now);
            sw.Close(); 
        }
        public int KatNumarasi
        {
            get
            {
                return katNumarasi;
            }

            set
            {
                katNumarasi = value;
            }
        }
        public int EvAlani
        {
            get
            {
                return evAlani;
            }

            set
            {
                evAlani = value;
            }
        }

        public string EmlakNo
        {
            get
            {
                return emlakNo;
            }

            set
            {
                emlakNo = value;
            }
        }

        public bool EvAktifDurum
        {
            get
            {
                return evAktifDurum;
            }

            set
            {
                evAktifDurum = value;
            }
        }
        public string İl
        {
            get
            {
                return il;
            }

            set
            {
                il = value;
            }
        }
        public string Semt
        {
            get
            {
                return semt;
            }

            set
            {
                semt = value;
            }
        }
        public int Depozito
        {
            get
            {
                return depozito;
            }

            set
            {
                depozito = value;
            }
        }
        public string YapimTarihi
        {
            get
            {
                return yapimTarihi;
            }
            set
            {
                yapimTarihi = value;
                TimeSpan ts = new TimeSpan();
                ts = DateTime.Now - Convert.ToDateTime(yapimTarihi);
                yapimTarihi = ts.Days.ToString();
            }
        }
        public abstract string EvBilgileri();
    }
    public class KiralikEv : Ev
    {
        public EvTur evtur;
        public decimal kira;

        public KiralikEv(object evtür)
        {
            string b = Convert.ToString(evtür);
            evtur = (EvTur)Enum.Parse(typeof(EvTur), b, true);
        }

        public override string EvBilgileri()
        {
            return String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}", EmlakNo,İl, Semt, EvAktifDurum, EvAlani, OdaSayisi, KatNumarasi, YapimTarihi, evtur, Depozito, kira);
        }                                                                        

        public decimal FiyatHesapla()
        {
            try
            {
                FileStream fs = new FileStream(@"room_cost.txt", FileMode.Append);
                fs.Close();
                StreamReader sr = new StreamReader(@"room_cost.txt");

               
                kira = Convert.ToInt32(Convert.ToInt32(sr.ReadLine()) * OdaSayisi);
                if(kira == 0)
                {
                    kira = OdaSayisi * 200;
                }
             
                sr.Close();
                return kira;
            }
            catch (Exception Excp)
            {
                throw new Exception(Excp.ToString());
            }
        }
    }

    public class SatilikEv : Ev
    {
        public decimal fiyat;
        public EvTur evtur;

        public SatilikEv(object evtür,object yapımtarihi)
        {
            string b = Convert.ToString(evtür);
            evtur = (EvTur)Enum.Parse(typeof(EvTur), b, true);
        }
        
        public override string EvBilgileri()
        {
            return String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}", EmlakNo,İl, Semt, EvAktifDurum, EvAlani, OdaSayisi, KatNumarasi, YapimTarihi, evtur, fiyat);
        }
     
    }
}
