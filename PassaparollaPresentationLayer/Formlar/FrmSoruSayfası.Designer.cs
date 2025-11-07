namespace PassaparollaPresentationLayer.Formlar
{
    partial class FrmSoruSayfası
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Modern Designer

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTarihBilgileri = new System.Windows.Forms.Label();
            this.lblTimeText = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblQuestionNoText = new System.Windows.Forms.Label();
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.lblTotalQText = new System.Windows.Forms.Label();
            this.lblTotalQ = new System.Windows.Forms.Label();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.groupBoxAnswer = new System.Windows.Forms.GroupBox();
            this.linkStart = new System.Windows.Forms.LinkLabel();
            this.linkAnswer = new System.Windows.Forms.LinkLabel();
            this.linkPass = new System.Windows.Forms.LinkLabel();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.lblPassCount = new System.Windows.Forms.Label();
            this.lblPassText = new System.Windows.Forms.Label();
            this.lblWrongCount = new System.Windows.Forms.Label();
            this.lblRightCount = new System.Windows.Forms.Label();
            this.lblWrongText = new System.Windows.Forms.Label();
            this.lblRightText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLetters = new System.Windows.Forms.Panel();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.groupBoxQuestion.SuspendLayout();
            this.groupBoxAnswer.SuspendLayout();
            this.groupBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.panelHeader.Controls.Add(this.btnCıkıs);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.lblAdSoyad);
            this.panelHeader.Controls.Add(this.lblTarihBilgileri);
            this.panelHeader.Controls.Add(this.lblTimeText);
            this.panelHeader.Controls.Add(this.lblTime);
            this.panelHeader.Controls.Add(this.lblQuestionNoText);
            this.panelHeader.Controls.Add(this.lblQuestionNo);
            this.panelHeader.Controls.Add(this.lblTotalQText);
            this.panelHeader.Controls.Add(this.lblTotalQ);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(946, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hoşgeldiniz ";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblAdSoyad.Location = new System.Drawing.Point(780, 44);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 25);
            this.lblAdSoyad.TabIndex = 9;
            // 
            // lblTarihBilgileri
            // 
            this.lblTarihBilgileri.AutoSize = true;
            this.lblTarihBilgileri.Location = new System.Drawing.Point(670, 18);
            this.lblTarihBilgileri.Name = "lblTarihBilgileri";
            this.lblTarihBilgileri.Size = new System.Drawing.Size(0, 20);
            this.lblTarihBilgileri.TabIndex = 7;
            // 
            // lblTimeText
            // 
            this.lblTimeText.AutoSize = true;
            this.lblTimeText.Location = new System.Drawing.Point(20, 18);
            this.lblTimeText.Name = "lblTimeText";
            this.lblTimeText.Size = new System.Drawing.Size(41, 20);
            this.lblTimeText.TabIndex = 1;
            this.lblTimeText.Text = "Süre:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(75, 14);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 25);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00";
            // 
            // lblQuestionNoText
            // 
            this.lblQuestionNoText.AutoSize = true;
            this.lblQuestionNoText.Location = new System.Drawing.Point(20, 45);
            this.lblQuestionNoText.Name = "lblQuestionNoText";
            this.lblQuestionNoText.Size = new System.Drawing.Size(66, 20);
            this.lblQuestionNoText.TabIndex = 3;
            this.lblQuestionNoText.Text = "Soru No:";
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblQuestionNo.Location = new System.Drawing.Point(100, 42);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(34, 25);
            this.lblQuestionNo.TabIndex = 4;
            this.lblQuestionNo.Text = "00";
            // 
            // lblTotalQText
            // 
            this.lblTotalQText.AutoSize = true;
            this.lblTotalQText.Location = new System.Drawing.Point(160, 45);
            this.lblTotalQText.Name = "lblTotalQText";
            this.lblTotalQText.Size = new System.Drawing.Size(96, 20);
            this.lblTotalQText.TabIndex = 5;
            this.lblTotalQText.Text = "Toplam Soru:";
            // 
            // lblTotalQ
            // 
            this.lblTotalQ.AutoSize = true;
            this.lblTotalQ.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalQ.Location = new System.Drawing.Point(270, 42);
            this.lblTotalQ.Name = "lblTotalQ";
            this.lblTotalQ.Size = new System.Drawing.Size(34, 25);
            this.lblTotalQ.TabIndex = 6;
            this.lblTotalQ.Text = "00";
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.richTextBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxQuestion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.richTextBoxQuestion.ForeColor = System.Drawing.Color.White;
            this.richTextBoxQuestion.Location = new System.Drawing.Point(10, 30);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.ReadOnly = true;
            this.richTextBoxQuestion.Size = new System.Drawing.Size(430, 100);
            this.richTextBoxQuestion.TabIndex = 0;
            this.richTextBoxQuestion.Text = "";
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.Controls.Add(this.richTextBoxQuestion);
            this.groupBoxQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.groupBoxQuestion.ForeColor = System.Drawing.Color.White;
            this.groupBoxQuestion.Location = new System.Drawing.Point(461, 100);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Size = new System.Drawing.Size(450, 159);
            this.groupBoxQuestion.TabIndex = 2;
            this.groupBoxQuestion.TabStop = false;
            this.groupBoxQuestion.Text = "Soru";
            // 
            // groupBoxAnswer
            // 
            this.groupBoxAnswer.Controls.Add(this.linkStart);
            this.groupBoxAnswer.Controls.Add(this.linkAnswer);
            this.groupBoxAnswer.Controls.Add(this.linkPass);
            this.groupBoxAnswer.Controls.Add(this.txtAnswer);
            this.groupBoxAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxAnswer.ForeColor = System.Drawing.Color.White;
            this.groupBoxAnswer.Location = new System.Drawing.Point(461, 265);
            this.groupBoxAnswer.Name = "groupBoxAnswer";
            this.groupBoxAnswer.Size = new System.Drawing.Size(450, 120);
            this.groupBoxAnswer.TabIndex = 3;
            this.groupBoxAnswer.TabStop = false;
            this.groupBoxAnswer.Text = "Cevap";
            // 
            // linkStart
            // 
            this.linkStart.AutoSize = true;
            this.linkStart.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.linkStart.LinkColor = System.Drawing.Color.Cyan;
            this.linkStart.Location = new System.Drawing.Point(10, 65);
            this.linkStart.Name = "linkStart";
            this.linkStart.Size = new System.Drawing.Size(54, 25);
            this.linkStart.TabIndex = 1;
            this.linkStart.TabStop = true;
            this.linkStart.Text = "Başla";
            this.linkStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStart_LinkClicked);
            // 
            // linkAnswer
            // 
            this.linkAnswer.AutoSize = true;
            this.linkAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.linkAnswer.LinkColor = System.Drawing.Color.Lime;
            this.linkAnswer.Location = new System.Drawing.Point(150, 65);
            this.linkAnswer.Name = "linkAnswer";
            this.linkAnswer.Size = new System.Drawing.Size(76, 25);
            this.linkAnswer.TabIndex = 2;
            this.linkAnswer.TabStop = true;
            this.linkAnswer.Text = "Cevapla";
            this.linkAnswer.Visible = false;
            this.linkAnswer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAnswer_LinkClicked);
            // 
            // linkPass
            // 
            this.linkPass.AutoSize = true;
            this.linkPass.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.linkPass.LinkColor = System.Drawing.Color.Orange;
            this.linkPass.Location = new System.Drawing.Point(270, 65);
            this.linkPass.Name = "linkPass";
            this.linkPass.Size = new System.Drawing.Size(39, 25);
            this.linkPass.TabIndex = 3;
            this.linkPass.TabStop = true;
            this.linkPass.Text = "Pas";
            this.linkPass.Visible = false;
            this.linkPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPass_LinkClicked);
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtAnswer.Location = new System.Drawing.Point(10, 30);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(430, 29);
            this.txtAnswer.TabIndex = 0;
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.lblPassCount);
            this.groupBoxStats.Controls.Add(this.lblPassText);
            this.groupBoxStats.Controls.Add(this.lblWrongCount);
            this.groupBoxStats.Controls.Add(this.lblRightCount);
            this.groupBoxStats.Controls.Add(this.lblWrongText);
            this.groupBoxStats.Controls.Add(this.lblRightText);
            this.groupBoxStats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxStats.ForeColor = System.Drawing.Color.White;
            this.groupBoxStats.Location = new System.Drawing.Point(461, 386);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(450, 82);
            this.groupBoxStats.TabIndex = 4;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Durum";
            // 
            // lblPassCount
            // 
            this.lblPassCount.AutoSize = true;
            this.lblPassCount.Location = new System.Drawing.Point(340, 30);
            this.lblPassCount.Name = "lblPassCount";
            this.lblPassCount.Size = new System.Drawing.Size(28, 21);
            this.lblPassCount.TabIndex = 5;
            this.lblPassCount.Text = "00";
            // 
            // lblPassText
            // 
            this.lblPassText.AutoSize = true;
            this.lblPassText.Location = new System.Drawing.Point(290, 30);
            this.lblPassText.Name = "lblPassText";
            this.lblPassText.Size = new System.Drawing.Size(40, 21);
            this.lblPassText.TabIndex = 4;
            this.lblPassText.Text = "Pas:";
            // 
            // lblWrongCount
            // 
            this.lblWrongCount.AutoSize = true;
            this.lblWrongCount.Location = new System.Drawing.Point(220, 30);
            this.lblWrongCount.Name = "lblWrongCount";
            this.lblWrongCount.Size = new System.Drawing.Size(28, 21);
            this.lblWrongCount.TabIndex = 3;
            this.lblWrongCount.Text = "00";
            // 
            // lblRightCount
            // 
            this.lblRightCount.AutoSize = true;
            this.lblRightCount.Location = new System.Drawing.Point(80, 30);
            this.lblRightCount.Name = "lblRightCount";
            this.lblRightCount.Size = new System.Drawing.Size(28, 21);
            this.lblRightCount.TabIndex = 1;
            this.lblRightCount.Text = "00";
            // 
            // lblWrongText
            // 
            this.lblWrongText.AutoSize = true;
            this.lblWrongText.Location = new System.Drawing.Point(150, 30);
            this.lblWrongText.Name = "lblWrongText";
            this.lblWrongText.Size = new System.Drawing.Size(59, 21);
            this.lblWrongText.TabIndex = 2;
            this.lblWrongText.Text = "Yanlış:";
            // 
            // lblRightText
            // 
            this.lblRightText.AutoSize = true;
            this.lblRightText.Location = new System.Drawing.Point(10, 30);
            this.lblRightText.Name = "lblRightText";
            this.lblRightText.Size = new System.Drawing.Size(62, 21);
            this.lblRightText.TabIndex = 0;
            this.lblRightText.Text = "Doğru:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlLetters
            // 
            this.pnlLetters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.pnlLetters.Location = new System.Drawing.Point(20, 100);
            this.pnlLetters.Name = "pnlLetters";
            this.pnlLetters.Size = new System.Drawing.Size(424, 404);
            this.pnlLetters.TabIndex = 1;
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCıkıs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCıkıs.ForeColor = System.Drawing.Color.White;
            this.btnCıkıs.Location = new System.Drawing.Point(912, 0);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(33, 34);
            this.btnCıkıs.TabIndex = 21;
            this.btnCıkıs.Text = "X";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // FrmSoruSayfası
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(946, 516);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.groupBoxAnswer);
            this.Controls.Add(this.groupBoxQuestion);
            this.Controls.Add(this.pnlLetters);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSoruSayfası";
            this.Text = "PassaParola Oyunu";
            this.Load += new System.EventHandler(this.FrmSoruSayfası_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxAnswer.ResumeLayout(false);
            this.groupBoxAnswer.PerformLayout();
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTimeText;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblQuestionNoText;
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Label lblTotalQText;
        private System.Windows.Forms.Label lblTotalQ;
        private System.Windows.Forms.Panel pnlLetters;
        private System.Windows.Forms.GroupBox groupBoxQuestion;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private System.Windows.Forms.GroupBox groupBoxAnswer;
        private System.Windows.Forms.LinkLabel linkStart;
        private System.Windows.Forms.LinkLabel linkAnswer;
        private System.Windows.Forms.LinkLabel linkPass;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label lblRightText;
        private System.Windows.Forms.Label lblRightCount;
        private System.Windows.Forms.Label lblWrongText;
        private System.Windows.Forms.Label lblWrongCount;
        private System.Windows.Forms.Label lblPassText;
        private System.Windows.Forms.Label lblPassCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTarihBilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button btnCıkıs;
    }
}
