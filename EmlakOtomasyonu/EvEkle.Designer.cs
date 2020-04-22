namespace EmlakOtomasyonu
{
    partial class EvEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_ev_adres_bilgileri = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_ilce = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_il = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPasif = new System.Windows.Forms.RadioButton();
            this.rbAktif = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.tbKatNumarasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOdaSayisi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbToplamAlan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEvTürü = new System.Windows.Forms.ComboBox();
            this.textBox_kat_numarasi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbSatilikEv = new System.Windows.Forms.GroupBox();
            this.tbSatilikEvFiyat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbKiralıkEv = new System.Windows.Forms.GroupBox();
            this.tbKiralıkEvDepozito = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbEvDurum = new System.Windows.Forms.GroupBox();
            this.rbKiralıkEv = new System.Windows.Forms.RadioButton();
            this.rbSatilikEv = new System.Windows.Forms.RadioButton();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnEvResimleri = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpEvYapımTarihi = new System.Windows.Forms.DateTimePicker();
            this.tbEvYasi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGüncellemeKaydet = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.groupBox_ev_adres_bilgileri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSatilikEv.SuspendLayout();
            this.gbKiralıkEv.SuspendLayout();
            this.gbEvDurum.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ev_adres_bilgileri
            // 
            this.groupBox_ev_adres_bilgileri.Controls.Add(this.label15);
            this.groupBox_ev_adres_bilgileri.Controls.Add(this.comboBox_ilce);
            this.groupBox_ev_adres_bilgileri.Controls.Add(this.label3);
            this.groupBox_ev_adres_bilgileri.Controls.Add(this.comboBox_il);
            this.groupBox_ev_adres_bilgileri.Controls.Add(this.label1);
            this.groupBox_ev_adres_bilgileri.Location = new System.Drawing.Point(12, 12);
            this.groupBox_ev_adres_bilgileri.Name = "groupBox_ev_adres_bilgileri";
            this.groupBox_ev_adres_bilgileri.Size = new System.Drawing.Size(337, 97);
            this.groupBox_ev_adres_bilgileri.TabIndex = 4;
            this.groupBox_ev_adres_bilgileri.TabStop = false;
            this.groupBox_ev_adres_bilgileri.Text = "Ev Konumu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(244, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "label15";
            this.label15.Visible = false;
            // 
            // comboBox_ilce
            // 
            this.comboBox_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ilce.FormattingEnabled = true;
            this.comboBox_ilce.Location = new System.Drawing.Point(68, 58);
            this.comboBox_ilce.Name = "comboBox_ilce";
            this.comboBox_ilce.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ilce.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "İlçe :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_il
            // 
            this.comboBox_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_il.FormattingEnabled = true;
            this.comboBox_il.Location = new System.Drawing.Point(68, 29);
            this.comboBox_il.Name = "comboBox_il";
            this.comboBox_il.Size = new System.Drawing.Size(121, 21);
            this.comboBox_il.TabIndex = 7;
            this.comboBox_il.SelectedValueChanged += new System.EventHandler(this.comboBox_il_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "İl  :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPasif);
            this.groupBox1.Controls.Add(this.rbAktif);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbKatNumarasi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbOdaSayisi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbToplamAlan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbEvTürü);
            this.groupBox1.Controls.Add(this.textBox_kat_numarasi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 218);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ev Bilgileri";
            // 
            // rbPasif
            // 
            this.rbPasif.AutoSize = true;
            this.rbPasif.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPasif.Location = new System.Drawing.Point(180, 181);
            this.rbPasif.Name = "rbPasif";
            this.rbPasif.Size = new System.Drawing.Size(76, 23);
            this.rbPasif.TabIndex = 20;
            this.rbPasif.TabStop = true;
            this.rbPasif.Text = "Pasif Ev";
            this.rbPasif.UseVisualStyleBackColor = true;
            // 
            // rbAktif
            // 
            this.rbAktif.AutoSize = true;
            this.rbAktif.Checked = true;
            this.rbAktif.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAktif.Location = new System.Drawing.Point(180, 152);
            this.rbAktif.Name = "rbAktif";
            this.rbAktif.Size = new System.Drawing.Size(77, 23);
            this.rbAktif.TabIndex = 19;
            this.rbAktif.TabStop = true;
            this.rbAktif.Text = "Aktif Ev";
            this.rbAktif.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(33, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 52);
            this.label11.TabIndex = 18;
            this.label11.Text = "Ev Durumu :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbKatNumarasi
            // 
            this.tbKatNumarasi.Location = new System.Drawing.Point(180, 126);
            this.tbKatNumarasi.Name = "tbKatNumarasi";
            this.tbKatNumarasi.Size = new System.Drawing.Size(125, 20);
            this.tbKatNumarasi.TabIndex = 16;
            this.tbKatNumarasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKatNumarasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKatNumarasi_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kat Numarası :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOdaSayisi
            // 
            this.tbOdaSayisi.Location = new System.Drawing.Point(180, 95);
            this.tbOdaSayisi.Name = "tbOdaSayisi";
            this.tbOdaSayisi.Size = new System.Drawing.Size(125, 20);
            this.tbOdaSayisi.TabIndex = 8;
            this.tbOdaSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOdaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKatNumarasi_KeyPress);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(21, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 27);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ev Türü :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(17, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ev Oda Sayisi :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbToplamAlan
            // 
            this.tbToplamAlan.Location = new System.Drawing.Point(180, 65);
            this.tbToplamAlan.Name = "tbToplamAlan";
            this.tbToplamAlan.Size = new System.Drawing.Size(125, 20);
            this.tbToplamAlan.TabIndex = 9;
            this.tbToplamAlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbToplamAlan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKatNumarasi_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 27);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ev Toplam Alan (m2):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbEvTürü
            // 
            this.cbEvTürü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvTürü.FormattingEnabled = true;
            this.cbEvTürü.Items.AddRange(new object[] {
            "Bilinmiyor",
            "Daire",
            "Bahçeli            ",
            "Dubleks           ",
            "Müstakil         ",
            "Havuzlu         ",
            "Apart"});
            this.cbEvTürü.Location = new System.Drawing.Point(180, 30);
            this.cbEvTürü.Name = "cbEvTürü";
            this.cbEvTürü.Size = new System.Drawing.Size(125, 21);
            this.cbEvTürü.TabIndex = 15;
            // 
            // textBox_kat_numarasi
            // 
            this.textBox_kat_numarasi.Location = new System.Drawing.Point(-95, 52);
            this.textBox_kat_numarasi.Name = "textBox_kat_numarasi";
            this.textBox_kat_numarasi.Size = new System.Drawing.Size(10, 20);
            this.textBox_kat_numarasi.TabIndex = 10;
            this.textBox_kat_numarasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(-95, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 11);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kat Numarasi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSatilikEv
            // 
            this.gbSatilikEv.Controls.Add(this.tbSatilikEvFiyat);
            this.gbSatilikEv.Controls.Add(this.label14);
            this.gbSatilikEv.Location = new System.Drawing.Point(512, 115);
            this.gbSatilikEv.Name = "gbSatilikEv";
            this.gbSatilikEv.Size = new System.Drawing.Size(198, 87);
            this.gbSatilikEv.TabIndex = 15;
            this.gbSatilikEv.TabStop = false;
            this.gbSatilikEv.Text = "Satilik Ev";
            // 
            // tbSatilikEvFiyat
            // 
            this.tbSatilikEvFiyat.Location = new System.Drawing.Point(74, 40);
            this.tbSatilikEvFiyat.Name = "tbSatilikEvFiyat";
            this.tbSatilikEvFiyat.Size = new System.Drawing.Size(100, 20);
            this.tbSatilikEvFiyat.TabIndex = 0;
            this.tbSatilikEvFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSatilikEvFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKatNumarasi_KeyPress);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(19, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Fiyat";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbKiralıkEv
            // 
            this.gbKiralıkEv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbKiralıkEv.Controls.Add(this.tbKiralıkEvDepozito);
            this.gbKiralıkEv.Controls.Add(this.label13);
            this.gbKiralıkEv.Location = new System.Drawing.Point(518, 113);
            this.gbKiralıkEv.Name = "gbKiralıkEv";
            this.gbKiralıkEv.Size = new System.Drawing.Size(201, 87);
            this.gbKiralıkEv.TabIndex = 8;
            this.gbKiralıkEv.TabStop = false;
            this.gbKiralıkEv.Text = "Kiralik Ev";
            // 
            // tbKiralıkEvDepozito
            // 
            this.tbKiralıkEvDepozito.Location = new System.Drawing.Point(104, 33);
            this.tbKiralıkEvDepozito.Name = "tbKiralıkEvDepozito";
            this.tbKiralıkEvDepozito.Size = new System.Drawing.Size(91, 20);
            this.tbKiralıkEvDepozito.TabIndex = 0;
            this.tbKiralıkEvDepozito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKiralıkEvDepozito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKatNumarasi_KeyPress);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(13, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Depozito";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbEvDurum
            // 
            this.gbEvDurum.Controls.Add(this.rbKiralıkEv);
            this.gbEvDurum.Controls.Add(this.rbSatilikEv);
            this.gbEvDurum.Location = new System.Drawing.Point(365, 115);
            this.gbEvDurum.Name = "gbEvDurum";
            this.gbEvDurum.Size = new System.Drawing.Size(125, 87);
            this.gbEvDurum.TabIndex = 16;
            this.gbEvDurum.TabStop = false;
            this.gbEvDurum.Text = "Ev Durum";
            // 
            // rbKiralıkEv
            // 
            this.rbKiralıkEv.AutoSize = true;
            this.rbKiralıkEv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKiralıkEv.Location = new System.Drawing.Point(18, 51);
            this.rbKiralıkEv.Name = "rbKiralıkEv";
            this.rbKiralıkEv.Size = new System.Drawing.Size(88, 23);
            this.rbKiralıkEv.TabIndex = 5;
            this.rbKiralıkEv.Text = "Kiralik Ev";
            this.rbKiralıkEv.UseVisualStyleBackColor = true;
            this.rbKiralıkEv.CheckedChanged += new System.EventHandler(this.rbKiralıkEv_CheckedChanged);
            // 
            // rbSatilikEv
            // 
            this.rbSatilikEv.AutoSize = true;
            this.rbSatilikEv.Checked = true;
            this.rbSatilikEv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSatilikEv.Location = new System.Drawing.Point(18, 22);
            this.rbSatilikEv.Name = "rbSatilikEv";
            this.rbSatilikEv.Size = new System.Drawing.Size(84, 23);
            this.rbSatilikEv.TabIndex = 5;
            this.rbSatilikEv.TabStop = true;
            this.rbSatilikEv.Text = "Satilik Ev";
            this.rbSatilikEv.UseVisualStyleBackColor = true;
            this.rbSatilikEv.CheckedChanged += new System.EventHandler(this.rbSatilikEv_CheckedChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(575, 236);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(135, 83);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEvResimleri
            // 
            this.btnEvResimleri.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEvResimleri.Location = new System.Drawing.Point(378, 236);
            this.btnEvResimleri.Name = "btnEvResimleri";
            this.btnEvResimleri.Size = new System.Drawing.Size(139, 83);
            this.btnEvResimleri.TabIndex = 18;
            this.btnEvResimleri.Text = "Ev Resmi Yükle";
            this.btnEvResimleri.UseVisualStyleBackColor = true;
            this.btnEvResimleri.Visible = false;
            this.btnEvResimleri.Click += new System.EventHandler(this.btnEvResimleri_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpEvYapımTarihi);
            this.groupBox3.Controls.Add(this.tbEvYasi);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(498, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 87);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ev";
            // 
            // dtpEvYapımTarihi
            // 
            this.dtpEvYapımTarihi.Cursor = System.Windows.Forms.Cursors.No;
            this.dtpEvYapımTarihi.CustomFormat = "dd/mm/yy";
            this.dtpEvYapımTarihi.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpEvYapımTarihi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEvYapımTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEvYapımTarihi.Location = new System.Drawing.Point(124, 22);
            this.dtpEvYapımTarihi.Name = "dtpEvYapımTarihi";
            this.dtpEvYapımTarihi.Size = new System.Drawing.Size(112, 26);
            this.dtpEvYapımTarihi.TabIndex = 2;
            this.dtpEvYapımTarihi.ValueChanged += new System.EventHandler(this.dtpEvYapımTarihi_ValueChanged);
            // 
            // tbEvYasi
            // 
            this.tbEvYasi.Enabled = false;
            this.tbEvYasi.Location = new System.Drawing.Point(124, 56);
            this.tbEvYasi.Name = "tbEvYasi";
            this.tbEvYasi.Size = new System.Drawing.Size(112, 20);
            this.tbEvYasi.TabIndex = 6;
            this.tbEvYasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ev Yaş Bilgisi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ev Yapım Tarihi :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGüncellemeKaydet
            // 
            this.btnGüncellemeKaydet.Location = new System.Drawing.Point(596, 236);
            this.btnGüncellemeKaydet.Name = "btnGüncellemeKaydet";
            this.btnGüncellemeKaydet.Size = new System.Drawing.Size(138, 83);
            this.btnGüncellemeKaydet.TabIndex = 20;
            this.btnGüncellemeKaydet.Text = "Güncellemeyi Kaydet";
            this.btnGüncellemeKaydet.UseVisualStyleBackColor = true;
            this.btnGüncellemeKaydet.Visible = false;
            this.btnGüncellemeKaydet.Click += new System.EventHandler(this.btnGüncellemeKaydet_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Red;
            this.btnGeri.Location = new System.Drawing.Point(753, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 21;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // EvEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 346);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnGüncellemeKaydet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbKiralıkEv);
            this.Controls.Add(this.btnEvResimleri);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gbEvDurum);
            this.Controls.Add(this.gbSatilikEv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_ev_adres_bilgileri);
            this.Name = "EvEkle";
            this.Text = "EvEkle";
            this.Load += new System.EventHandler(this.EvEkle_Load);
            this.groupBox_ev_adres_bilgileri.ResumeLayout(false);
            this.groupBox_ev_adres_bilgileri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSatilikEv.ResumeLayout(false);
            this.gbSatilikEv.PerformLayout();
            this.gbKiralıkEv.ResumeLayout(false);
            this.gbKiralıkEv.PerformLayout();
            this.gbEvDurum.ResumeLayout(false);
            this.gbEvDurum.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ev_adres_bilgileri;
        private System.Windows.Forms.ComboBox comboBox_ilce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_il;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPasif;
        private System.Windows.Forms.RadioButton rbAktif;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbKatNumarasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOdaSayisi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbToplamAlan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEvTürü;
        private System.Windows.Forms.TextBox textBox_kat_numarasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbSatilikEv;
        private System.Windows.Forms.TextBox tbSatilikEvFiyat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbKiralıkEv;
        private System.Windows.Forms.TextBox tbKiralıkEvDepozito;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbEvDurum;
        private System.Windows.Forms.RadioButton rbKiralıkEv;
        private System.Windows.Forms.RadioButton rbSatilikEv;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEvResimleri;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpEvYapımTarihi;
        private System.Windows.Forms.TextBox tbEvYasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnGüncellemeKaydet;
        private System.Windows.Forms.Button btnGeri;
    }
}