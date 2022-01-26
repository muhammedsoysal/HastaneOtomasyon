namespace Hastane_Otomasyon
{
    partial class FrmBrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrans));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBransAd = new System.Windows.Forms.TextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 143);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGüncelle.Location = new System.Drawing.Point(99, 125);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(114, 34);
            this.BtnGüncelle.TabIndex = 58;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Magenta;
            this.BtnSil.Location = new System.Drawing.Point(161, 85);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(52, 34);
            this.BtnSil.TabIndex = 57;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEkle.Location = new System.Drawing.Point(99, 85);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(52, 34);
            this.BtnEkle.TabIndex = 56;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Brans Ad:";
            // 
            // TxtBransAd
            // 
            this.TxtBransAd.Location = new System.Drawing.Point(99, 49);
            this.TxtBransAd.Name = "TxtBransAd";
            this.TxtBransAd.Size = new System.Drawing.Size(114, 30);
            this.TxtBransAd.TabIndex = 54;
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(99, 13);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(114, 30);
            this.Txtid.TabIndex = 52;
            this.Txtid.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Brans id:";
            // 
            // FrmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(615, 173);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBransAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtid);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Corbel", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmBrans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brans Paneli";
            this.Load += new System.EventHandler(this.FrmBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBransAd;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label1;
    }
}