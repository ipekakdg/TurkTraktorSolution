namespace TurkTraktorProje
{
    partial class SiparisIslemleri
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
            this.dgwSiparisler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSiparislerMusteriId = new System.Windows.Forms.ComboBox();
            this.btnSiparisiİptalEt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiparisDetayEkle = new System.Windows.Forms.Button();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSiparisToplamTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgwSiparisDetay = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGeriSiparisEkle = new System.Windows.Forms.Button();
            this.dtpSiparis = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSiparisler)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSiparisDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSiparisler
            // 
            this.dgwSiparisler.BackgroundColor = System.Drawing.Color.White;
            this.dgwSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSiparisler.GridColor = System.Drawing.Color.Black;
            this.dgwSiparisler.Location = new System.Drawing.Point(25, 348);
            this.dgwSiparisler.Margin = new System.Windows.Forms.Padding(2);
            this.dgwSiparisler.Name = "dgwSiparisler";
            this.dgwSiparisler.RowHeadersWidth = 62;
            this.dgwSiparisler.RowTemplate.Height = 28;
            this.dgwSiparisler.Size = new System.Drawing.Size(576, 120);
            this.dgwSiparisler.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dtpSiparis);
            this.groupBox1.Controls.Add(this.cbxSiparislerMusteriId);
            this.groupBox1.Controls.Add(this.btnSiparisiİptalEt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSiparisDetayEkle);
            this.groupBox1.Controls.Add(this.btnSiparisEkle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSiparisToplamTutar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(311, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(289, 216);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş İslemleri";
            // 
            // cbxSiparislerMusteriId
            // 
            this.cbxSiparislerMusteriId.FormattingEnabled = true;
            this.cbxSiparislerMusteriId.Location = new System.Drawing.Point(135, 34);
            this.cbxSiparislerMusteriId.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSiparislerMusteriId.Name = "cbxSiparislerMusteriId";
            this.cbxSiparislerMusteriId.Size = new System.Drawing.Size(125, 21);
            this.cbxSiparislerMusteriId.TabIndex = 14;
            // 
            // btnSiparisiİptalEt
            // 
            this.btnSiparisiİptalEt.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisiİptalEt.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisiİptalEt.Location = new System.Drawing.Point(168, 174);
            this.btnSiparisiİptalEt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiparisiİptalEt.Name = "btnSiparisiİptalEt";
            this.btnSiparisiİptalEt.Size = new System.Drawing.Size(81, 22);
            this.btnSiparisiİptalEt.TabIndex = 13;
            this.btnSiparisiİptalEt.Text = "İşlemi İptal Et";
            this.btnSiparisiİptalEt.UseVisualStyleBackColor = true;
            this.btnSiparisiİptalEt.Click += new System.EventHandler(this.btnSiparisiİptalEt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sipariş Detayı eklemek için Lütfen Tıklayınız... ";
            // 
            // btnSiparisDetayEkle
            // 
            this.btnSiparisDetayEkle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisDetayEkle.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisDetayEkle.Location = new System.Drawing.Point(101, 142);
            this.btnSiparisDetayEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiparisDetayEkle.Name = "btnSiparisDetayEkle";
            this.btnSiparisDetayEkle.Size = new System.Drawing.Size(124, 23);
            this.btnSiparisDetayEkle.TabIndex = 11;
            this.btnSiparisDetayEkle.Text = "Detay Ekle";
            this.btnSiparisDetayEkle.UseVisualStyleBackColor = true;
            this.btnSiparisDetayEkle.Click += new System.EventHandler(this.btnSiparisDetayEkle_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisEkle.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisEkle.Location = new System.Drawing.Point(79, 174);
            this.btnSiparisEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(70, 22);
            this.btnSiparisEkle.TabIndex = 10;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Müşteri Adı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toplam Tutar : ";
            // 
            // txtSiparisToplamTutar
            // 
            this.txtSiparisToplamTutar.Location = new System.Drawing.Point(135, 89);
            this.txtSiparisToplamTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSiparisToplamTutar.Name = "txtSiparisToplamTutar";
            this.txtSiparisToplamTutar.Size = new System.Drawing.Size(125, 20);
            this.txtSiparisToplamTutar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sipariş Tarihi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TurkTraktorProje.Properties.Resources.siparis;
            this.pictureBox1.Location = new System.Drawing.Point(25, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dgwSiparisDetay
            // 
            this.dgwSiparisDetay.BackgroundColor = System.Drawing.Color.White;
            this.dgwSiparisDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSiparisDetay.GridColor = System.Drawing.Color.Black;
            this.dgwSiparisDetay.Location = new System.Drawing.Point(25, 493);
            this.dgwSiparisDetay.Margin = new System.Windows.Forms.Padding(2);
            this.dgwSiparisDetay.Name = "dgwSiparisDetay";
            this.dgwSiparisDetay.RowHeadersWidth = 62;
            this.dgwSiparisDetay.RowTemplate.Height = 28;
            this.dgwSiparisDetay.Size = new System.Drawing.Size(576, 120);
            this.dgwSiparisDetay.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Siparişler : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 475);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sipariş Detayı : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TurkTraktorProje.Properties.Resources.TurkTraktorLogo;
            this.pictureBox2.Location = new System.Drawing.Point(213, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnGeriSiparisEkle
            // 
            this.btnGeriSiparisEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriSiparisEkle.BackgroundImage = global::TurkTraktorProje.Properties.Resources.gerii;
            this.btnGeriSiparisEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeriSiparisEkle.Location = new System.Drawing.Point(27, 16);
            this.btnGeriSiparisEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeriSiparisEkle.Name = "btnGeriSiparisEkle";
            this.btnGeriSiparisEkle.Size = new System.Drawing.Size(49, 42);
            this.btnGeriSiparisEkle.TabIndex = 16;
            this.btnGeriSiparisEkle.UseVisualStyleBackColor = false;
            this.btnGeriSiparisEkle.Click += new System.EventHandler(this.btnGeriSiparisEkle_Click);
            // 
            // dtpSiparis
            // 
            this.dtpSiparis.Location = new System.Drawing.Point(135, 61);
            this.dtpSiparis.Name = "dtpSiparis";
            this.dtpSiparis.Size = new System.Drawing.Size(124, 20);
            this.dtpSiparis.TabIndex = 15;
            // 
            // SiparisIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TurkTraktorProje.Properties.Resources.giris1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 632);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGeriSiparisEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgwSiparisDetay);
            this.Controls.Add(this.dgwSiparisler);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SiparisIslemleri";
            this.Text = "Siparisler";
            this.Load += new System.EventHandler(this.Siparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSiparisler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSiparisDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSiparisler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSiparisDetayEkle;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSiparisToplamTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiparisiİptalEt;
        private System.Windows.Forms.DataGridView dgwSiparisDetay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxSiparislerMusteriId;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGeriSiparisEkle;
        private System.Windows.Forms.DateTimePicker dtpSiparis;
    }
}