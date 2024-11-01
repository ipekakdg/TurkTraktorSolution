namespace TurkTraktorProje
{
    partial class SaticiIslemleri
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
            this.dgwSaticilar = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaticiSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaticiGuncelle = new System.Windows.Forms.Button();
            this.btnSaticiEkle = new System.Windows.Forms.Button();
            this.txtSaticiTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaticiAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaticiSehir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaticiUlke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaticiAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGeriSaticilar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSaticilar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSaticilar
            // 
            this.dgwSaticilar.BackgroundColor = System.Drawing.Color.White;
            this.dgwSaticilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSaticilar.GridColor = System.Drawing.Color.Black;
            this.dgwSaticilar.Location = new System.Drawing.Point(41, 380);
            this.dgwSaticilar.Margin = new System.Windows.Forms.Padding(2);
            this.dgwSaticilar.Name = "dgwSaticilar";
            this.dgwSaticilar.RowHeadersWidth = 62;
            this.dgwSaticilar.RowTemplate.Height = 28;
            this.dgwSaticilar.Size = new System.Drawing.Size(820, 120);
            this.dgwSaticilar.TabIndex = 7;
            this.dgwSaticilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSaticilar_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnSaticiSil);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(511, 278);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(350, 73);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satıcı Sil";
            // 
            // btnSaticiSil
            // 
            this.btnSaticiSil.BackColor = System.Drawing.Color.White;
            this.btnSaticiSil.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaticiSil.ForeColor = System.Drawing.Color.Black;
            this.btnSaticiSil.Location = new System.Drawing.Point(271, 27);
            this.btnSaticiSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaticiSil.Name = "btnSaticiSil";
            this.btnSaticiSil.Size = new System.Drawing.Size(70, 23);
            this.btnSaticiSil.TabIndex = 14;
            this.btnSaticiSil.Text = "SİL";
            this.btnSaticiSil.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSaticiGuncelle);
            this.groupBox1.Controls.Add(this.btnSaticiEkle);
            this.groupBox1.Controls.Add(this.txtSaticiTelefon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSaticiAdres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSaticiSehir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSaticiUlke);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSaticiAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(511, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(350, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satıcı İslemleri";
            // 
            // btnSaticiGuncelle
            // 
            this.btnSaticiGuncelle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaticiGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnSaticiGuncelle.Location = new System.Drawing.Point(268, 65);
            this.btnSaticiGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaticiGuncelle.Name = "btnSaticiGuncelle";
            this.btnSaticiGuncelle.Size = new System.Drawing.Size(70, 23);
            this.btnSaticiGuncelle.TabIndex = 11;
            this.btnSaticiGuncelle.Text = "GÜNCELLE";
            this.btnSaticiGuncelle.UseVisualStyleBackColor = true;
            this.btnSaticiGuncelle.Click += new System.EventHandler(this.btnSaticiGuncelle_Click);
            // 
            // btnSaticiEkle
            // 
            this.btnSaticiEkle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaticiEkle.ForeColor = System.Drawing.Color.Black;
            this.btnSaticiEkle.Location = new System.Drawing.Point(268, 100);
            this.btnSaticiEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaticiEkle.Name = "btnSaticiEkle";
            this.btnSaticiEkle.Size = new System.Drawing.Size(70, 22);
            this.btnSaticiEkle.TabIndex = 10;
            this.btnSaticiEkle.Text = "EKLE";
            this.btnSaticiEkle.UseVisualStyleBackColor = true;
            this.btnSaticiEkle.Click += new System.EventHandler(this.btnSaticiEkle_Click);
            // 
            // txtSaticiTelefon
            // 
            this.txtSaticiTelefon.Location = new System.Drawing.Point(133, 56);
            this.txtSaticiTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaticiTelefon.Name = "txtSaticiTelefon";
            this.txtSaticiTelefon.Size = new System.Drawing.Size(125, 20);
            this.txtSaticiTelefon.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Satıcı Telefon : ";
            // 
            // txtSaticiAdres
            // 
            this.txtSaticiAdres.Location = new System.Drawing.Point(133, 81);
            this.txtSaticiAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaticiAdres.Name = "txtSaticiAdres";
            this.txtSaticiAdres.Size = new System.Drawing.Size(125, 20);
            this.txtSaticiAdres.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Satıcı Şehir : ";
            // 
            // txtSaticiSehir
            // 
            this.txtSaticiSehir.Location = new System.Drawing.Point(133, 108);
            this.txtSaticiSehir.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaticiSehir.Name = "txtSaticiSehir";
            this.txtSaticiSehir.Size = new System.Drawing.Size(125, 20);
            this.txtSaticiSehir.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Satıcı Ülke : ";
            // 
            // txtSaticiUlke
            // 
            this.txtSaticiUlke.Location = new System.Drawing.Point(133, 133);
            this.txtSaticiUlke.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaticiUlke.Name = "txtSaticiUlke";
            this.txtSaticiUlke.Size = new System.Drawing.Size(125, 20);
            this.txtSaticiUlke.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Satıcı Adres : ";
            // 
            // txtSaticiAdi
            // 
            this.txtSaticiAdi.Location = new System.Drawing.Point(133, 29);
            this.txtSaticiAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaticiAdi.Name = "txtSaticiAdi";
            this.txtSaticiAdi.Size = new System.Drawing.Size(125, 20);
            this.txtSaticiAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satıcı Adı : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TurkTraktorProje.Properties.Resources.serbest_zamanli;
            this.pictureBox1.Location = new System.Drawing.Point(40, 111);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 224);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TurkTraktorProje.Properties.Resources.TurkTraktorLogo;
            this.pictureBox2.Location = new System.Drawing.Point(227, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnGeriSaticilar
            // 
            this.btnGeriSaticilar.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriSaticilar.BackgroundImage = global::TurkTraktorProje.Properties.Resources.gerii;
            this.btnGeriSaticilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeriSaticilar.Location = new System.Drawing.Point(41, 27);
            this.btnGeriSaticilar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeriSaticilar.Name = "btnGeriSaticilar";
            this.btnGeriSaticilar.Size = new System.Drawing.Size(49, 42);
            this.btnGeriSaticilar.TabIndex = 10;
            this.btnGeriSaticilar.UseVisualStyleBackColor = false;
            this.btnGeriSaticilar.Click += new System.EventHandler(this.btnGeriSaticilar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "silmek istediğiniz satırın en soluna tıklayınız !";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Satıcı silmek için verilerin listelendiği ekranda";
            // 
            // SaticiIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TurkTraktorProje.Properties.Resources.giris1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 572);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGeriSaticilar);
            this.Controls.Add(this.dgwSaticilar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SaticiIslemleri";
            this.Text = "Saticilar";
            this.Load += new System.EventHandler(this.SaticiIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSaticilar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSaticilar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaticiSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaticiGuncelle;
        private System.Windows.Forms.Button btnSaticiEkle;
        private System.Windows.Forms.TextBox txtSaticiTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaticiAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaticiSehir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaticiUlke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaticiAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGeriSaticilar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}