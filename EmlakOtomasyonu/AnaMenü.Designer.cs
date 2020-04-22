namespace EmlakOtomasyonu
{
    partial class AnaMenü
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
            this.btnEvEkle = new System.Windows.Forms.Button();
            this.btnEvSorgu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvEkle
            // 
            this.btnEvEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEvEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEvEkle.Location = new System.Drawing.Point(33, 108);
            this.btnEvEkle.Name = "btnEvEkle";
            this.btnEvEkle.Size = new System.Drawing.Size(151, 98);
            this.btnEvEkle.TabIndex = 0;
            this.btnEvEkle.Text = "Ev Ekle";
            this.btnEvEkle.UseVisualStyleBackColor = false;
            this.btnEvEkle.Click += new System.EventHandler(this.btnEvEkle_Click);
            // 
            // btnEvSorgu
            // 
            this.btnEvSorgu.BackColor = System.Drawing.SystemColors.Info;
            this.btnEvSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEvSorgu.Location = new System.Drawing.Point(227, 108);
            this.btnEvSorgu.Name = "btnEvSorgu";
            this.btnEvSorgu.Size = new System.Drawing.Size(151, 98);
            this.btnEvSorgu.TabIndex = 0;
            this.btnEvSorgu.Text = "Evleri Sorgula / Listele";
            this.btnEvSorgu.UseVisualStyleBackColor = false;
            this.btnEvSorgu.Click += new System.EventHandler(this.btnEvSorgu_Click);
            // 
            // AnaMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 318);
            this.Controls.Add(this.btnEvSorgu);
            this.Controls.Add(this.btnEvEkle);
            this.Name = "AnaMenü";
            this.Text = "AnaMenü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvEkle;
        private System.Windows.Forms.Button btnEvSorgu;
    }
}