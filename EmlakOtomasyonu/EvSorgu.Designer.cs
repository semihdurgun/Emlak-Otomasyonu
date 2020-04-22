namespace EmlakOtomasyonu
{
    partial class EvSorgu
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
            this.comboBox_ilce = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_il = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEvAdresSorgulama = new System.Windows.Forms.Button();
            this.groupBox_ev_tercihi = new System.Windows.Forms.GroupBox();
            this.rbKiralik = new System.Windows.Forms.RadioButton();
            this.rbSatilik = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTümü = new System.Windows.Forms.RadioButton();
            this.rbPasif = new System.Windows.Forms.RadioButton();
            this.rbAktif = new System.Windows.Forms.RadioButton();
            this.dataGridViewSonuc = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnEvResimGörüntüle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.groupBox_ev_adres_bilgileri.SuspendLayout();
            this.groupBox_ev_tercihi.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_ev_adres_bilgileri
            // 
            this.groupBox_ev_adres_bilgileri.Controls.Add(this.comboBox_ilce);
            this.groupBox_ev_adres_bilgileri.Controls.Add(this.label3);
            this.groupBox_ev_adres_bilgileri.Controls.Add(this.comboBox_il);
            this.groupBox_ev_adres_bilgileri.Controls.Add(this.label1);
            this.groupBox_ev_adres_bilgileri.Location = new System.Drawing.Point(12, 13);
            this.groupBox_ev_adres_bilgileri.Name = "groupBox_ev_adres_bilgileri";
            this.groupBox_ev_adres_bilgileri.Size = new System.Drawing.Size(235, 94);
            this.groupBox_ev_adres_bilgileri.TabIndex = 5;
            this.groupBox_ev_adres_bilgileri.TabStop = false;
            this.groupBox_ev_adres_bilgileri.Text = "Ev Adres Bilgileri";
            // 
            // comboBox_ilce
            // 
            this.comboBox_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ilce.FormattingEnabled = true;
            this.comboBox_ilce.Location = new System.Drawing.Point(101, 55);
            this.comboBox_ilce.Name = "comboBox_ilce";
            this.comboBox_ilce.Size = new System.Drawing.Size(106, 21);
            this.comboBox_ilce.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "İlçe Seçiniz";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_il
            // 
            this.comboBox_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_il.FormattingEnabled = true;
            this.comboBox_il.Location = new System.Drawing.Point(101, 26);
            this.comboBox_il.Name = "comboBox_il";
            this.comboBox_il.Size = new System.Drawing.Size(106, 21);
            this.comboBox_il.TabIndex = 7;
            this.comboBox_il.SelectedValueChanged += new System.EventHandler(this.comboBox_il_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "İl Seçiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEvAdresSorgulama
            // 
            this.btnEvAdresSorgulama.BackColor = System.Drawing.SystemColors.Info;
            this.btnEvAdresSorgulama.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEvAdresSorgulama.Location = new System.Drawing.Point(475, 14);
            this.btnEvAdresSorgulama.Name = "btnEvAdresSorgulama";
            this.btnEvAdresSorgulama.Size = new System.Drawing.Size(104, 94);
            this.btnEvAdresSorgulama.TabIndex = 5;
            this.btnEvAdresSorgulama.Text = "Ara";
            this.btnEvAdresSorgulama.UseVisualStyleBackColor = false;
            this.btnEvAdresSorgulama.Click += new System.EventHandler(this.btnEvAdresSorgulama_Click);
            // 
            // groupBox_ev_tercihi
            // 
            this.groupBox_ev_tercihi.Controls.Add(this.rbKiralik);
            this.groupBox_ev_tercihi.Controls.Add(this.rbSatilik);
            this.groupBox_ev_tercihi.Location = new System.Drawing.Point(364, 13);
            this.groupBox_ev_tercihi.Name = "groupBox_ev_tercihi";
            this.groupBox_ev_tercihi.Size = new System.Drawing.Size(105, 95);
            this.groupBox_ev_tercihi.TabIndex = 16;
            this.groupBox_ev_tercihi.TabStop = false;
            this.groupBox_ev_tercihi.Text = "Ev Tercihi";
            // 
            // rbKiralik
            // 
            this.rbKiralik.AutoSize = true;
            this.rbKiralik.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKiralik.Location = new System.Drawing.Point(11, 52);
            this.rbKiralik.Name = "rbKiralik";
            this.rbKiralik.Size = new System.Drawing.Size(88, 23);
            this.rbKiralik.TabIndex = 5;
            this.rbKiralik.Text = "Kiralik Ev";
            this.rbKiralik.UseVisualStyleBackColor = true;
            // 
            // rbSatilik
            // 
            this.rbSatilik.AutoSize = true;
            this.rbSatilik.Checked = true;
            this.rbSatilik.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSatilik.Location = new System.Drawing.Point(11, 23);
            this.rbSatilik.Name = "rbSatilik";
            this.rbSatilik.Size = new System.Drawing.Size(84, 23);
            this.rbSatilik.TabIndex = 5;
            this.rbSatilik.TabStop = true;
            this.rbSatilik.Text = "Satilik Ev";
            this.rbSatilik.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTümü);
            this.groupBox2.Controls.Add(this.rbPasif);
            this.groupBox2.Controls.Add(this.rbAktif);
            this.groupBox2.Location = new System.Drawing.Point(253, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 120);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ev Durumu";
            // 
            // rbTümü
            // 
            this.rbTümü.AutoSize = true;
            this.rbTümü.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTümü.Location = new System.Drawing.Point(12, 86);
            this.rbTümü.Name = "rbTümü";
            this.rbTümü.Size = new System.Drawing.Size(61, 23);
            this.rbTümü.TabIndex = 6;
            this.rbTümü.TabStop = true;
            this.rbTümü.Text = "Tümü";
            this.rbTümü.UseVisualStyleBackColor = true;
            // 
            // rbPasif
            // 
            this.rbPasif.AutoSize = true;
            this.rbPasif.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPasif.Location = new System.Drawing.Point(12, 57);
            this.rbPasif.Name = "rbPasif";
            this.rbPasif.Size = new System.Drawing.Size(76, 23);
            this.rbPasif.TabIndex = 5;
            this.rbPasif.TabStop = true;
            this.rbPasif.Text = "Pasif Ev";
            this.rbPasif.UseVisualStyleBackColor = true;
            // 
            // rbAktif
            // 
            this.rbAktif.AutoSize = true;
            this.rbAktif.Checked = true;
            this.rbAktif.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAktif.Location = new System.Drawing.Point(11, 28);
            this.rbAktif.Name = "rbAktif";
            this.rbAktif.Size = new System.Drawing.Size(77, 23);
            this.rbAktif.TabIndex = 5;
            this.rbAktif.TabStop = true;
            this.rbAktif.Text = "Aktif Ev";
            this.rbAktif.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSonuc
            // 
            this.dataGridViewSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSonuc.Location = new System.Drawing.Point(12, 162);
            this.dataGridViewSonuc.Name = "dataGridViewSonuc";
            this.dataGridViewSonuc.Size = new System.Drawing.Size(567, 180);
            this.dataGridViewSonuc.TabIndex = 17;
            this.dataGridViewSonuc.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(28, 361);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 40);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Veriyi Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(155, 361);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(95, 40);
            this.btnGüncelle.TabIndex = 19;
            this.btnGüncelle.Text = "Veriyi Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Visible = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnEvResimGörüntüle
            // 
            this.btnEvResimGörüntüle.Location = new System.Drawing.Point(289, 361);
            this.btnEvResimGörüntüle.Name = "btnEvResimGörüntüle";
            this.btnEvResimGörüntüle.Size = new System.Drawing.Size(137, 40);
            this.btnEvResimGörüntüle.TabIndex = 20;
            this.btnEvResimGörüntüle.Text = "Ev Resimlerini Görüntüle";
            this.btnEvResimGörüntüle.UseVisualStyleBackColor = true;
            this.btnEvResimGörüntüle.Visible = false;
            this.btnEvResimGörüntüle.Click += new System.EventHandler(this.btnEvResimGörüntüle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Red;
            this.btnGeri.Location = new System.Drawing.Point(475, 361);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(91, 40);
            this.btnGeri.TabIndex = 22;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // EvSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(593, 422);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnEvResimGörüntüle);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEvAdresSorgulama);
            this.Controls.Add(this.dataGridViewSonuc);
            this.Controls.Add(this.groupBox_ev_tercihi);
            this.Controls.Add(this.groupBox_ev_adres_bilgileri);
            this.Controls.Add(this.groupBox2);
            this.Name = "EvSorgu";
            this.Text = "s";
            this.Load += new System.EventHandler(this.EvSorgu_Load);
            this.groupBox_ev_adres_bilgileri.ResumeLayout(false);
            this.groupBox_ev_tercihi.ResumeLayout(false);
            this.groupBox_ev_tercihi.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSonuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_ev_adres_bilgileri;
        private System.Windows.Forms.Button btnEvAdresSorgulama;
        private System.Windows.Forms.ComboBox comboBox_ilce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_il;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_ev_tercihi;
        private System.Windows.Forms.RadioButton rbKiralik;
        private System.Windows.Forms.RadioButton rbSatilik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPasif;
        private System.Windows.Forms.RadioButton rbAktif;
        private System.Windows.Forms.DataGridView dataGridViewSonuc;
        private System.Windows.Forms.RadioButton rbTümü;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnEvResimGörüntüle;
        private System.Windows.Forms.Button btnGeri;
    }
}