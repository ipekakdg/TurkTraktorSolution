namespace TurkTraktorProje
{
    partial class DepoIslemleri
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
            this.dgwDepolar = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDepoSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDepoGuncelle = new System.Windows.Forms.Button();
            this.btnDepoEkle = new System.Windows.Forms.Button();
            this.txtDepoAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepoSehir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepoUlke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepoAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeriDepolar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepolar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDepolar
            // 
            this.dgwDepolar.BackgroundColor = System.Drawing.Color.White;
            this.dgwDepolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepolar.GridColor = System.Drawing.Color.Black;
            this.dgwDepolar.Location = new System.Drawing.Point(50, 344);
            this.dgwDepolar.Margin = new System.Windows.Forms.Padding(2);
            this.dgwDepolar.Name = "dgwDepolar";
            this.dgwDepolar.RowHeadersWidth = 62;
            this.dgwDepolar.RowTemplate.Height = 28;
            this.dgwDepolar.Size = new System.Drawing.Size(584, 120);
            this.dgwDepolar.TabIndex = 7;
            this.dgwDepolar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwpersoneller_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnDepoSil);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(293, 255);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(341, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Depo Sil";
            // 
            // btnDepoSil
            // 
            this.btnDepoSil.BackColor = System.Drawing.Color.White;
            this.btnDepoSil.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepoSil.ForeColor = System.Drawing.Color.Black;
            this.btnDepoSil.Location = new System.Drawing.Point(267, 23);
            this.btnDepoSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnDepoSil.Name = "btnDepoSil";
            this.btnDepoSil.Size = new System.Drawing.Size(70, 23);
            this.btnDepoSil.TabIndex = 14;
            this.btnDepoSil.Text = "SİL";
            this.btnDepoSil.UseVisualStyleBackColor = false;
            this.btnDepoSil.Click += new System.EventHandler(this.btnDepoSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnDepoGuncelle);
            this.groupBox1.Controls.Add(this.btnDepoEkle);
            this.groupBox1.Controls.Add(this.txtDepoAdres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDepoSehir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDepoUlke);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDepoAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(293, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(341, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo İslemleri";
            // 
            // btnDepoGuncelle
            // 
            this.btnDepoGuncelle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepoGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnDepoGuncelle.Location = new System.Drawing.Point(267, 58);
            this.btnDepoGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnDepoGuncelle.Name = "btnDepoGuncelle";
            this.btnDepoGuncelle.Size = new System.Drawing.Size(70, 23);
            this.btnDepoGuncelle.TabIndex = 11;
            this.btnDepoGuncelle.Text = "GÜNCELLE";
            this.btnDepoGuncelle.UseVisualStyleBackColor = true;
            this.btnDepoGuncelle.Click += new System.EventHandler(this.btnDepoGuncelle_Click);
            // 
            // btnDepoEkle
            // 
            this.btnDepoEkle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepoEkle.ForeColor = System.Drawing.Color.Black;
            this.btnDepoEkle.Location = new System.Drawing.Point(267, 85);
            this.btnDepoEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnDepoEkle.Name = "btnDepoEkle";
            this.btnDepoEkle.Size = new System.Drawing.Size(70, 22);
            this.btnDepoEkle.TabIndex = 10;
            this.btnDepoEkle.Text = "EKLE";
            this.btnDepoEkle.UseVisualStyleBackColor = true;
            this.btnDepoEkle.Click += new System.EventHandler(this.btnDepoEkle_Click);
            // 
            // txtDepoAdres
            // 
            this.txtDepoAdres.Location = new System.Drawing.Point(133, 57);
            this.txtDepoAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepoAdres.Name = "txtDepoAdres";
            this.txtDepoAdres.Size = new System.Drawing.Size(125, 20);
            this.txtDepoAdres.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Depo Şehir : ";
            // 
            // txtDepoSehir
            // 
            this.txtDepoSehir.Location = new System.Drawing.Point(133, 84);
            this.txtDepoSehir.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepoSehir.Name = "txtDepoSehir";
            this.txtDepoSehir.Size = new System.Drawing.Size(125, 20);
            this.txtDepoSehir.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depo Ülke : ";
            // 
            // txtDepoUlke
            // 
            this.txtDepoUlke.Location = new System.Drawing.Point(133, 109);
            this.txtDepoUlke.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepoUlke.Name = "txtDepoUlke";
            this.txtDepoUlke.Size = new System.Drawing.Size(125, 20);
            this.txtDepoUlke.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Depo Adres : ";
            // 
            // txtDepoAdi
            // 
            this.txtDepoAdi.Location = new System.Drawing.Point(133, 29);
            this.txtDepoAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepoAdi.Name = "txtDepoAdi";
            this.txtDepoAdi.Size = new System.Drawing.Size(125, 20);
            this.txtDepoAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depo Adı : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TurkTraktorProje.Properties.Resources._2621727_810x458;
            this.pictureBox1.Location = new System.Drawing.Point(49, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnGeriDepolar
            // 
            this.btnGeriDepolar.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriDepolar.BackgroundImage = global::TurkTraktorProje.Properties.Resources.gerii;
            this.btnGeriDepolar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeriDepolar.Location = new System.Drawing.Point(49, 8);
            this.btnGeriDepolar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeriDepolar.Name = "btnGeriDepolar";
            this.btnGeriDepolar.Size = new System.Drawing.Size(49, 42);
            this.btnGeriDepolar.TabIndex = 8;
            this.btnGeriDepolar.UseVisualStyleBackColor = false;
            this.btnGeriDepolar.Click += new System.EventHandler(this.btnGeriDepolar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TurkTraktorProje.Properties.Resources.TurkTraktorLogo;
            this.pictureBox2.Location = new System.Drawing.Point(235, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "silmek istediğiniz satırın en soluna tıklayınız !";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Depo silmek için verilerin listelendiği ekranda";
            // 
            // DepoIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TurkTraktorProje.Properties.Resources.giris1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 485);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGeriDepolar);
            this.Controls.Add(this.dgwDepolar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DepoIslemleri";
            this.Text = "Depolar";
            this.Load += new System.EventHandler(this.DepoIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepolar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDepolar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDepoSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDepoGuncelle;
        private System.Windows.Forms.Button btnDepoEkle;
        private System.Windows.Forms.TextBox txtDepoAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepoSehir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepoUlke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepoAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeriDepolar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}