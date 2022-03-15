
namespace PersonelUygulmasi
{
    partial class AnaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPersonel = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonSD = new System.Windows.Forms.TextBox();
            this.txtEmailSD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoyisimSD = new System.Windows.Forms.TextBox();
            this.txtIsimSD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTestKayitEkle = new System.Windows.Forms.Button();
            this.btnJsonYukle = new System.Windows.Forms.Button();
            this.btnJsonAl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPersonel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Listesi";
            // 
            // lbPersonel
            // 
            this.lbPersonel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPersonel.FormattingEnabled = true;
            this.lbPersonel.Location = new System.Drawing.Point(3, 16);
            this.lbPersonel.Name = "lbPersonel";
            this.lbPersonel.Size = new System.Drawing.Size(308, 524);
            this.lbPersonel.TabIndex = 0;
            this.lbPersonel.SelectedIndexChanged += new System.EventHandler(this.lbPersonel_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTelefon);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSoyisim);
            this.groupBox2.Controls.Add(this.txtIsim);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(358, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Personel Ekle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Controls.Add(this.btnDuzenle);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTelefonSD);
            this.groupBox3.Controls.Add(this.txtEmailSD);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSoyisimSD);
            this.groupBox3.Controls.Add(this.txtIsimSD);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(358, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 269);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel Sil / Düzenle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(21, 42);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(308, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(21, 92);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(308, 20);
            this.txtSoyisim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email Adres";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(21, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(21, 178);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(308, 20);
            this.txtTelefon.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(21, 204);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(308, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(21, 212);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(157, 23);
            this.btnDuzenle.TabIndex = 26;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Telefon";
            // 
            // txtTelefonSD
            // 
            this.txtTelefonSD.Location = new System.Drawing.Point(21, 186);
            this.txtTelefonSD.Name = "txtTelefonSD";
            this.txtTelefonSD.Size = new System.Drawing.Size(308, 20);
            this.txtTelefonSD.TabIndex = 24;
            // 
            // txtEmailSD
            // 
            this.txtEmailSD.Location = new System.Drawing.Point(21, 143);
            this.txtEmailSD.Name = "txtEmailSD";
            this.txtEmailSD.Size = new System.Drawing.Size(308, 20);
            this.txtEmailSD.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Soyisim";
            // 
            // txtSoyisimSD
            // 
            this.txtSoyisimSD.Location = new System.Drawing.Point(21, 100);
            this.txtSoyisimSD.Name = "txtSoyisimSD";
            this.txtSoyisimSD.Size = new System.Drawing.Size(308, 20);
            this.txtSoyisimSD.TabIndex = 20;
            // 
            // txtIsimSD
            // 
            this.txtIsimSD.Location = new System.Drawing.Point(21, 50);
            this.txtIsimSD.Name = "txtIsimSD";
            this.txtIsimSD.Size = new System.Drawing.Size(308, 20);
            this.txtIsimSD.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "İsim";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(184, 212);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(145, 23);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTestKayitEkle
            // 
            this.btnTestKayitEkle.Location = new System.Drawing.Point(26, 580);
            this.btnTestKayitEkle.Name = "btnTestKayitEkle";
            this.btnTestKayitEkle.Size = new System.Drawing.Size(75, 23);
            this.btnTestKayitEkle.TabIndex = 3;
            this.btnTestKayitEkle.Text = "Test Kayıtları Ekle";
            this.btnTestKayitEkle.UseVisualStyleBackColor = true;
            this.btnTestKayitEkle.Click += new System.EventHandler(this.btnTestKayitEkle_Click);
            // 
            // btnJsonYukle
            // 
            this.btnJsonYukle.Location = new System.Drawing.Point(358, 580);
            this.btnJsonYukle.Name = "btnJsonYukle";
            this.btnJsonYukle.Size = new System.Drawing.Size(178, 23);
            this.btnJsonYukle.TabIndex = 4;
            this.btnJsonYukle.Text = "Json Yükle";
            this.btnJsonYukle.UseVisualStyleBackColor = true;
            this.btnJsonYukle.Click += new System.EventHandler(this.btnJsonYukle_Click);
            // 
            // btnJsonAl
            // 
            this.btnJsonAl.Location = new System.Drawing.Point(542, 580);
            this.btnJsonAl.Name = "btnJsonAl";
            this.btnJsonAl.Size = new System.Drawing.Size(152, 23);
            this.btnJsonAl.TabIndex = 5;
            this.btnJsonAl.Text = "Json Al";
            this.btnJsonAl.UseVisualStyleBackColor = true;
            this.btnJsonAl.Click += new System.EventHandler(this.btnJsonAl_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 675);
            this.Controls.Add(this.btnJsonAl);
            this.Controls.Add(this.btnJsonYukle);
            this.Controls.Add(this.btnTestKayitEkle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbPersonel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonSD;
        private System.Windows.Forms.TextBox txtEmailSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoyisimSD;
        private System.Windows.Forms.TextBox txtIsimSD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTestKayitEkle;
        private System.Windows.Forms.Button btnJsonYukle;
        private System.Windows.Forms.Button btnJsonAl;
    }
}