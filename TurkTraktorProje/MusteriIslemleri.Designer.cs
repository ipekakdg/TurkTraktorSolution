namespace TurkTraktorProje
{
    partial class MusteriIslemleri
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
            this.dgwMusteriler = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.txtMusteriTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusteriAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriSehir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriUlke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGeriMusteriler = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMusteriler
            // 
            this.dgwMusteriler.BackgroundColor = System.Drawing.Color.White;
            this.dgwMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriler.GridColor = System.Drawing.Color.Black;
            this.dgwMusteriler.Location = new System.Drawing.Point(58, 360);
            this.dgwMusteriler.Margin = new System.Windows.Forms.Padding(2);
            this.dgwMusteriler.Name = "dgwMusteriler";
            this.dgwMusteriler.RowHeadersWidth = 62;
            this.dgwMusteriler.RowTemplate.Height = 28;
            this.dgwMusteriler.Size = new System.Drawing.Size(604, 120);
            this.dgwMusteriler.TabIndex = 7;
            this.dgwMusteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriler_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnMusteriSil);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(301, 274);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(361, 62);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Sil";
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.Color.White;
            this.btnMusteriSil.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSil.ForeColor = System.Drawing.Color.Black;
            this.btnMusteriSil.Location = new System.Drawing.Point(277, 22);
            this.btnMusteriSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(70, 23);
            this.btnMusteriSil.TabIndex = 14;
            this.btnMusteriSil.Text = "SİL";
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnMusteriGuncelle);
            this.groupBox1.Controls.Add(this.btnMusteriEkle);
            this.groupBox1.Controls.Add(this.txtMusteriTelefon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMusteriAdres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMusteriSehir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMusteriUlke);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMusteriAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(301, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(361, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İslemleri";
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(277, 77);
            this.btnMusteriGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(70, 23);
            this.btnMusteriGuncelle.TabIndex = 11;
            this.btnMusteriGuncelle.Text = "GÜNCELLE";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.Black;
            this.btnMusteriEkle.Location = new System.Drawing.Point(277, 104);
            this.btnMusteriEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(70, 22);
            this.btnMusteriEkle.TabIndex = 10;
            this.btnMusteriEkle.Text = "EKLE";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.Location = new System.Drawing.Point(133, 56);
            this.txtMusteriTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.Size = new System.Drawing.Size(125, 20);
            this.txtMusteriTelefon.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon : ";
            // 
            // txtMusteriAdres
            // 
            this.txtMusteriAdres.Location = new System.Drawing.Point(133, 81);
            this.txtMusteriAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.Size = new System.Drawing.Size(125, 20);
            this.txtMusteriAdres.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şehir : ";
            // 
            // txtMusteriSehir
            // 
            this.txtMusteriSehir.Location = new System.Drawing.Point(133, 108);
            this.txtMusteriSehir.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusteriSehir.Name = "txtMusteriSehir";
            this.txtMusteriSehir.Size = new System.Drawing.Size(125, 20);
            this.txtMusteriSehir.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ülke : ";
            // 
            // txtMusteriUlke
            // 
            this.txtMusteriUlke.Location = new System.Drawing.Point(133, 133);
            this.txtMusteriUlke.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusteriUlke.Name = "txtMusteriUlke";
            this.txtMusteriUlke.Size = new System.Drawing.Size(125, 20);
            this.txtMusteriUlke.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adres : ";
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(133, 29);
            this.txtMusteriAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(125, 20);
            this.txtMusteriAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TurkTraktorProje.Properties.Resources.musteriprofil;
            this.pictureBox1.Location = new System.Drawing.Point(57, 107);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 229);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TurkTraktorProje.Properties.Resources.TurkTraktorLogo;
            this.pictureBox2.Location = new System.Drawing.Point(227, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnGeriMusteriler
            // 
            this.btnGeriMusteriler.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriMusteriler.BackgroundImage = global::TurkTraktorProje.Properties.Resources.gerii;
            this.btnGeriMusteriler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeriMusteriler.Location = new System.Drawing.Point(57, 8);
            this.btnGeriMusteriler.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeriMusteriler.Name = "btnGeriMusteriler";
            this.btnGeriMusteriler.Size = new System.Drawing.Size(49, 42);
            this.btnGeriMusteriler.TabIndex = 10;
            this.btnGeriMusteriler.UseVisualStyleBackColor = false;
            this.btnGeriMusteriler.Click += new System.EventHandler(this.btnGeriMusteriler_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 34);
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
            this.label7.Location = new System.Drawing.Point(8, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Müşteri silmek için verilerin listelendiği ekranda";
            // 
            // MusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TurkTraktorProje.Properties.Resources.giris1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 509);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGeriMusteriler);
            this.Controls.Add(this.dgwMusteriler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MusteriIslemleri";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.MusteriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMusteriler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox txtMusteriTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMusteriAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteriSehir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteriUlke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGeriMusteriler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}