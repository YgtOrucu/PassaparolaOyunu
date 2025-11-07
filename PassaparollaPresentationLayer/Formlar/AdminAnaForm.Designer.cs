using System.Drawing;

namespace PassaparollaPresentationLayer.Formlar
{
    partial class AdminAnaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdminAdSoyad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHarfeGöreGetir = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblSoruID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdPasif = new System.Windows.Forms.RadioButton();
            this.rdAktif = new System.Windows.Forms.RadioButton();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.ricSoru = new System.Windows.Forms.RichTextBox();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoşgeldiniz:";
            // 
            // lblAdminAdSoyad
            // 
            this.lblAdminAdSoyad.AutoSize = true;
            this.lblAdminAdSoyad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdminAdSoyad.ForeColor = System.Drawing.Color.Silver;
            this.lblAdminAdSoyad.Location = new System.Drawing.Point(135, 20);
            this.lblAdminAdSoyad.Name = "lblAdminAdSoyad";
            this.lblAdminAdSoyad.Size = new System.Drawing.Size(0, 21);
            this.lblAdminAdSoyad.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.lblSoruID);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.rdPasif);
            this.groupBox1.Controls.Add(this.rdAktif);
            this.groupBox1.Controls.Add(this.txtCevap);
            this.groupBox1.Controls.Add(this.ricSoru);
            this.groupBox1.Controls.Add(this.txtHarf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(24, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 700);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soru Yönetimi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHarfeGöreGetir);
            this.groupBox3.Controls.Add(this.btnListele);
            this.groupBox3.Controls.Add(this.btnEkle);
            this.groupBox3.Controls.Add(this.btnTemizle);
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Controls.Add(this.btnGüncelle);
            this.groupBox3.Location = new System.Drawing.Point(504, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 150);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnHarfeGöreGetir
            // 
            this.btnHarfeGöreGetir.BackColor = System.Drawing.Color.YellowGreen;
            this.btnHarfeGöreGetir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHarfeGöreGetir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHarfeGöreGetir.Location = new System.Drawing.Point(149, 86);
            this.btnHarfeGöreGetir.Name = "btnHarfeGöreGetir";
            this.btnHarfeGöreGetir.Size = new System.Drawing.Size(127, 35);
            this.btnHarfeGöreGetir.TabIndex = 19;
            this.btnHarfeGöreGetir.Text = "Harfe Göre L.";
            this.btnHarfeGöreGetir.UseVisualStyleBackColor = false;
            this.btnHarfeGöreGetir.Click += new System.EventHandler(this.btnHarfeGöreGetir_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.SkyBlue;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListele.Location = new System.Drawing.Point(16, 32);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(127, 35);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Tan;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEkle.Location = new System.Drawing.Point(291, 32);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(127, 35);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Bisque;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemizle.Location = new System.Drawing.Point(291, 86);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(127, 35);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Khaki;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSil.Location = new System.Drawing.Point(16, 86);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 35);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Gold;
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGüncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGüncelle.Location = new System.Drawing.Point(149, 32);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(127, 35);
            this.btnGüncelle.TabIndex = 7;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Aktif Sorular";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pasif Sorular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Location = new System.Drawing.Point(10, 469);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(953, 209);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // lblSoruID
            // 
            this.lblSoruID.Location = new System.Drawing.Point(6, 164);
            this.lblSoruID.Name = "lblSoruID";
            this.lblSoruID.Size = new System.Drawing.Size(60, 23);
            this.lblSoruID.TabIndex = 3;
            this.lblSoruID.Text = "SoruID";
            this.lblSoruID.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(10, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(953, 194);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // rdPasif
            // 
            this.rdPasif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdPasif.Location = new System.Drawing.Point(226, 139);
            this.rdPasif.Name = "rdPasif";
            this.rdPasif.Size = new System.Drawing.Size(117, 24);
            this.rdPasif.TabIndex = 5;
            this.rdPasif.Text = "Pasif Sorular";
            // 
            // rdAktif
            // 
            this.rdAktif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdAktif.Location = new System.Drawing.Point(85, 139);
            this.rdAktif.Name = "rdAktif";
            this.rdAktif.Size = new System.Drawing.Size(120, 24);
            this.rdAktif.TabIndex = 4;
            this.rdAktif.Text = "Aktif Sorular";
            // 
            // txtCevap
            // 
            this.txtCevap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCevap.Location = new System.Drawing.Point(321, 100);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(164, 27);
            this.txtCevap.TabIndex = 3;
            // 
            // ricSoru
            // 
            this.ricSoru.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ricSoru.Location = new System.Drawing.Point(86, 26);
            this.ricSoru.Name = "ricSoru";
            this.ricSoru.Size = new System.Drawing.Size(399, 60);
            this.ricSoru.TabIndex = 1;
            this.ricSoru.Text = "";
            // 
            // txtHarf
            // 
            this.txtHarf.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHarf.Location = new System.Drawing.Point(86, 100);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(149, 27);
            this.txtHarf.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soru :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Durum :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(241, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cevap :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Harf :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(766, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Soru Sayfası Geçiş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCıkıs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCıkıs.ForeColor = System.Drawing.Color.White;
            this.btnCıkıs.Location = new System.Drawing.Point(969, 6);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(33, 34);
            this.btnCıkıs.TabIndex = 20;
            this.btnCıkıs.Text = "X";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // AdminAnaForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 780);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAdminAdSoyad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli - Soru Yönetimi";
            this.Load += new System.EventHandler(this.AdminAnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdminAdSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdPasif;
        private System.Windows.Forms.RadioButton rdAktif;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.RichTextBox ricSoru;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSoruID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHarfeGöreGetir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCıkıs;
    }
}