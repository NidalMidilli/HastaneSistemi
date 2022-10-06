namespace HastaneSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtg_hastaliste = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_hastaad = new System.Windows.Forms.TextBox();
            this.txt_teshis = new System.Windows.Forms.TextBox();
            this.txt_hastasoyad = new System.Windows.Forms.TextBox();
            this.txt_hastano = new System.Windows.Forms.TextBox();
            this.lbl_hastano = new System.Windows.Forms.Label();
            this.lbl_hastaad = new System.Windows.Forms.Label();
            this.lbl_hastasoyad = new System.Windows.Forms.Label();
            this.lbl_teshis = new System.Windows.Forms.Label();
            this.lbl_ilac = new System.Windows.Forms.Label();
            this.txt_ilac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.lbl_hosgeldin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hastaliste)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_hastaliste
            // 
            this.dtg_hastaliste.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtg_hastaliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hastaliste.Location = new System.Drawing.Point(290, 65);
            this.dtg_hastaliste.Name = "dtg_hastaliste";
            this.dtg_hastaliste.RowTemplate.Height = 25;
            this.dtg_hastaliste.Size = new System.Drawing.Size(476, 166);
            this.dtg_hastaliste.TabIndex = 5;
            this.dtg_hastaliste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_hastaliste_CellContentClick);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Lime;
            this.btn_ekle.Location = new System.Drawing.Point(290, 262);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(92, 38);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.BackColor = System.Drawing.Color.Yellow;
            this.btn_duzenle.Location = new System.Drawing.Point(493, 259);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(92, 37);
            this.btn_duzenle.TabIndex = 7;
            this.btn_duzenle.Text = "DÜZENLE";
            this.btn_duzenle.UseVisualStyleBackColor = false;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.Location = new System.Drawing.Point(674, 259);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(92, 37);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_hastaad
            // 
            this.txt_hastaad.BackColor = System.Drawing.Color.Tan;
            this.txt_hastaad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_hastaad.Location = new System.Drawing.Point(24, 326);
            this.txt_hastaad.Multiline = true;
            this.txt_hastaad.Name = "txt_hastaad";
            this.txt_hastaad.Size = new System.Drawing.Size(100, 23);
            this.txt_hastaad.TabIndex = 9;
            // 
            // txt_teshis
            // 
            this.txt_teshis.BackColor = System.Drawing.Color.Tan;
            this.txt_teshis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_teshis.Location = new System.Drawing.Point(25, 371);
            this.txt_teshis.Multiline = true;
            this.txt_teshis.Name = "txt_teshis";
            this.txt_teshis.Size = new System.Drawing.Size(100, 23);
            this.txt_teshis.TabIndex = 10;
            // 
            // txt_hastasoyad
            // 
            this.txt_hastasoyad.BackColor = System.Drawing.Color.Tan;
            this.txt_hastasoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_hastasoyad.Location = new System.Drawing.Point(147, 326);
            this.txt_hastasoyad.Multiline = true;
            this.txt_hastasoyad.Name = "txt_hastasoyad";
            this.txt_hastasoyad.Size = new System.Drawing.Size(100, 23);
            this.txt_hastasoyad.TabIndex = 11;
            // 
            // txt_hastano
            // 
            this.txt_hastano.BackColor = System.Drawing.Color.Tan;
            this.txt_hastano.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_hastano.Location = new System.Drawing.Point(24, 277);
            this.txt_hastano.Multiline = true;
            this.txt_hastano.Name = "txt_hastano";
            this.txt_hastano.Size = new System.Drawing.Size(100, 23);
            this.txt_hastano.TabIndex = 12;
            // 
            // lbl_hastano
            // 
            this.lbl_hastano.AutoSize = true;
            this.lbl_hastano.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hastano.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_hastano.Location = new System.Drawing.Point(24, 258);
            this.lbl_hastano.Name = "lbl_hastano";
            this.lbl_hastano.Size = new System.Drawing.Size(85, 16);
            this.lbl_hastano.TabIndex = 13;
            this.lbl_hastano.Text = "Hasta Numarası";
            // 
            // lbl_hastaad
            // 
            this.lbl_hastaad.AutoSize = true;
            this.lbl_hastaad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hastaad.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_hastaad.Location = new System.Drawing.Point(25, 303);
            this.lbl_hastaad.Name = "lbl_hastaad";
            this.lbl_hastaad.Size = new System.Drawing.Size(53, 16);
            this.lbl_hastaad.TabIndex = 14;
            this.lbl_hastaad.Text = "Hasta Adı";
            // 
            // lbl_hastasoyad
            // 
            this.lbl_hastasoyad.AutoSize = true;
            this.lbl_hastasoyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hastasoyad.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_hastasoyad.Location = new System.Drawing.Point(147, 303);
            this.lbl_hastasoyad.Name = "lbl_hastasoyad";
            this.lbl_hastasoyad.Size = new System.Drawing.Size(70, 16);
            this.lbl_hastasoyad.TabIndex = 15;
            this.lbl_hastasoyad.Text = "Hasta Soyadı";
            // 
            // lbl_teshis
            // 
            this.lbl_teshis.AutoSize = true;
            this.lbl_teshis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_teshis.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_teshis.Location = new System.Drawing.Point(24, 352);
            this.lbl_teshis.Name = "lbl_teshis";
            this.lbl_teshis.Size = new System.Drawing.Size(72, 16);
            this.lbl_teshis.TabIndex = 16;
            this.lbl_teshis.Text = "Teşhis Bilgisi";
            // 
            // lbl_ilac
            // 
            this.lbl_ilac.AutoSize = true;
            this.lbl_ilac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ilac.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ilac.Location = new System.Drawing.Point(147, 352);
            this.lbl_ilac.Name = "lbl_ilac";
            this.lbl_ilac.Size = new System.Drawing.Size(58, 16);
            this.lbl_ilac.TabIndex = 17;
            this.lbl_ilac.Text = "İlaç Bilgisi";
            // 
            // txt_ilac
            // 
            this.txt_ilac.BackColor = System.Drawing.Color.Tan;
            this.txt_ilac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ilac.Location = new System.Drawing.Point(147, 371);
            this.txt_ilac.Multiline = true;
            this.txt_ilac.Name = "txt_ilac";
            this.txt_ilac.Size = new System.Drawing.Size(100, 23);
            this.txt_ilac.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 35);
            this.label1.TabIndex = 20;
            this.label1.Text = "HASTA TAKİP SİSTEMİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kullaniciadi.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(147, 90);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(66, 26);
            this.lbl_kullaniciadi.TabIndex = 21;
            this.lbl_kullaniciadi.Text = "label2";
            this.lbl_kullaniciadi.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_hosgeldin
            // 
            this.lbl_hosgeldin.AutoSize = true;
            this.lbl_hosgeldin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hosgeldin.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_hosgeldin.Location = new System.Drawing.Point(12, 90);
            this.lbl_hosgeldin.Name = "lbl_hosgeldin";
            this.lbl_hosgeldin.Size = new System.Drawing.Size(104, 26);
            this.lbl_hosgeldin.TabIndex = 22;
            this.lbl_hosgeldin.Text = "HOŞGELDİN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_hosgeldin);
            this.Controls.Add(this.lbl_kullaniciadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ilac);
            this.Controls.Add(this.lbl_ilac);
            this.Controls.Add(this.lbl_teshis);
            this.Controls.Add(this.lbl_hastasoyad);
            this.Controls.Add(this.lbl_hastaad);
            this.Controls.Add(this.lbl_hastano);
            this.Controls.Add(this.txt_hastano);
            this.Controls.Add(this.txt_hastasoyad);
            this.Controls.Add(this.txt_teshis);
            this.Controls.Add(this.txt_hastaad);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dtg_hastaliste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hastaliste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_hastaliste;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_hastaad;
        private System.Windows.Forms.TextBox txt_teshis;
        private System.Windows.Forms.TextBox txt_hastasoyad;
        private System.Windows.Forms.TextBox txt_hastano;
        private System.Windows.Forms.Label lbl_hastano;
        private System.Windows.Forms.Label lbl_hastaad;
        private System.Windows.Forms.Label lbl_hastasoyad;
        private System.Windows.Forms.Label lbl_teshis;
        private System.Windows.Forms.Label lbl_ilac;
        private System.Windows.Forms.TextBox txt_ilac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.Label lbl_hosgeldin;
    }
}
