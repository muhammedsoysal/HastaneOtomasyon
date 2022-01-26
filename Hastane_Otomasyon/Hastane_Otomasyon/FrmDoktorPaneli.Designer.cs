namespace Hastane_Otomasyon
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnSıl = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 255);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnGüncelle.Location = new System.Drawing.Point(74, 230);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(155, 34);
            this.BtnGüncelle.TabIndex = 8;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSıl
            // 
            this.BtnSıl.BackColor = System.Drawing.Color.Red;
            this.BtnSıl.Location = new System.Drawing.Point(154, 190);
            this.BtnSıl.Name = "BtnSıl";
            this.BtnSıl.Size = new System.Drawing.Size(75, 34);
            this.BtnSıl.TabIndex = 7;
            this.BtnSıl.Text = "Sil";
            this.BtnSıl.UseVisualStyleBackColor = false;
            this.BtnSıl.Click += new System.EventHandler(this.BtnSıl_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.Lime;
            this.BtnEkle.Location = new System.Drawing.Point(74, 190);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 34);
            this.BtnEkle.TabIndex = 6;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Soyad:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(74, 45);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(155, 30);
            this.TxtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(74, 9);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(155, 30);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(74, 154);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(155, 30);
            this.TxtSifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "Sifre:";
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(74, 81);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(155, 31);
            this.CmbBrans.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Branş:";
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(74, 118);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(155, 30);
            this.MskTc.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "TC:";
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(864, 273);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSıl);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbBrans);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Corbel", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnSıl;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label label8;
    }
}