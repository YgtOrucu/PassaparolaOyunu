using PassaparollaBusinenssLayer.Abstract;
using PassaparollaBusinenssLayer.Concreate;
using PassaparollaBusinenssLayer.Valitadion;
using PassaparollaDataAccessLayer.Abstract;
using PassaparollaDataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PassaparollaPresentationLayer.Formlar
{
    public partial class FrmSoruSayfası : Form
    {
        private IAdminService _adminService;
        private AdminValidation _adminValidation;
        private SorularValidation _sorularValidation;
        private string _adsoyad;
        Dictionary<string, string> GetAllQuestion = new Dictionary<string, string>();
        Dictionary<string, string> GetPassQuestion = new Dictionary<string, string>();
        List<int> getpasSoruNo = new List<int>();
        Button[] HarfButtons = new Button[26];

        int soruno; int pasIndex = 0; int pas = 0, dogru = 0, yanlıs = 0;
        string currentanswer;
        bool pasmode = false;
        private void InitializeServices()
        {
            _adminValidation = new AdminValidation();
            _sorularValidation = new SorularValidation();
            _adminService = new AdminManager(new EFAdminDal(), _adminValidation, _sorularValidation);
        }
        public FrmSoruSayfası()
        {
            InitializeComponent();
            InitializeServices();
        }

        public FrmSoruSayfası(string adsoyad)
        {
            InitializeComponent();
            InitializeServices();
            _adsoyad = adsoyad;
        }

        private void OyunBitti()
        {
            timer1.Stop();
            lblQuestionNo.Text = GetAllQuestion.Count().ToString();
            linkAnswer.Enabled = false;
            linkPass.Enabled = false;
            richTextBoxQuestion.Clear();
            txtAnswer.Clear();
            var result = MessageBox.Show(
                "🎉 Tüm soruları tamamladınız!\n\nSonuçlarınızı görmek ister misiniz?",
                "Oyun Bitti",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                // Oyun sonunda göstermek istediğin veriler
                int dogru = int.Parse(lblRightCount.Text);
                int yanlis = int.Parse(lblWrongCount.Text);
                int pas = int.Parse(lblPassCount.Text);
                int toplam = dogru + yanlis + pas;

                string mesaj =
                    "📊 SONUÇLAR 📊\n\n" +
                    $"✅ Doğru Sayısı : {dogru}\n" +
                    $"❌ Yanlış Sayısı : {yanlis}\n" +
                    $"⏭️ Pas Sayısı : {pas}\n" +
                    $"🕒 Toplam Süre : {lblTime.Text} sn\n" +
                    $"🏁 Toplam Soru : {toplam}\n\n" +
                    "Tebrikler! 🎯";

                MessageBox.Show(mesaj, "Sonuçlar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Oyun sonuçları gösterilmeden kapatıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void FrmSoruSayfası_Load(object sender, EventArgs e)
        {
            lblTarihBilgileri.Text = DateTime.Now.ToString("f");
            lblAdSoyad.Text = _adsoyad;
            #region GetAllQuestion
            var values = _adminService.TGetDurumList(true);
            lblTotalQ.Text = values.Count.ToString();
            foreach (var item in values)
            {
                GetAllQuestion.Add(item.Soru, item.Cevap);
            }
            #endregion
            #region GetButtons

            // Önce paneli temizle (tekrar yüklemelerde sorun olmasın)
            pnlLetters.SuspendLayout();
            pnlLetters.Controls.Clear();

            // Harf dizisi (A'dan Z'ye)
            char[] harfler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            // Boyut/ölçü ayarları
            int butonSize = 37;                 // buton çapı
            int margin = 8;                     // buton ile panel kenarı arası boşluk
            int panelW = Math.Max(1, pnlLetters.ClientSize.Width);
            int panelH = Math.Max(1, pnlLetters.ClientSize.Height);

            // radius hesaplama; negatif olmamasına dikkat et
            int radius = Math.Min(panelW, panelH) / 2 - (butonSize / 2) - margin;
            if (radius < 30)
            {
                // Panel çok küçükse butonları küçült
                butonSize = Math.Max(28, Math.Min(panelW, panelH) / 6);
                radius = Math.Min(panelW, panelH) / 2 - (butonSize / 2) - margin;
            }

            int centerX = panelW / 2;
            int centerY = panelH / 2;

            int n = harfler.Length; // 26

            for (int i = 0; i < n; i++)
            {
                // Başlangıç 90° yukarı: -PI/2
                double angle = (i * (2 * Math.PI / n)) - Math.PI / 2.0;

                int x = centerX + (int)(radius * Math.Cos(angle)) - butonSize / 2;
                int y = centerY + (int)(radius * Math.Sin(angle)) - butonSize / 2;

                Button btn = new Button();
                btn.SetBounds(x, y, butonSize, butonSize); // hem konum hem boyut
                btn.Text = harfler[i].ToString();
                btn.Name = "btn" + harfler[i]; // benzersiz isim
                btn.Tag = i;
                btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(70, 90, 110);
                btn.ForeColor = Color.White;
                btn.Cursor = Cursors.Hand;
                btn.Visible = true;
                btn.Enabled = false; // istersen başlangıçta pasif

                // Yuvarlak yapmak için Region (GraphicsPath kullan)
                var gp = new System.Drawing.Drawing2D.GraphicsPath();
                gp.AddEllipse(0, 0, butonSize, butonSize);
                btn.Region = new Region(gp);
                pnlLetters.Controls.Add(btn);
                HarfButtons[i] = btn;
            }

            pnlLetters.ResumeLayout();
            #endregion
        }

        private void linkStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!timer1.Enabled) timer1.Start();
            soruno = 1;
            var ilksoru = GetAllQuestion.ElementAt(soruno - 1);
            richTextBoxQuestion.Text = ilksoru.Key;
            currentanswer = ilksoru.Value;

            lblQuestionNo.Text = soruno.ToString();
            linkAnswer.Visible = true;
            linkPass.Visible = true;
            linkStart.Visible = false;
        }

        private void linkAnswer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string kullancıAnswer = txtAnswer.Text;
            if (txtAnswer.Text == currentanswer)
            {
                if (!pasmode)
                {
                    HarfButtons[soruno - 1].BackColor = Color.Green;
                }
                else
                {
                    HarfButtons[getpasSoruNo[pasIndex] - 1].BackColor = Color.Green;
                    pas--;
                    lblPassCount.Text = pas.ToString();
                }
                dogru++;
                lblRightCount.Text = dogru.ToString();
            }
            else
            {
                if (!pasmode)
                    HarfButtons[soruno - 1].BackColor = Color.Red;
                else
                {
                    HarfButtons[getpasSoruNo[pasIndex] - 1].BackColor = Color.Red;
                    pas--;
                    lblPassCount.Text = pas.ToString();
                }

                yanlıs++;
                lblWrongCount.Text = yanlıs.ToString();
            }
            txtAnswer.Clear();
            if (!pasmode)
            {
                soruno++;
                if (soruno <= GetAllQuestion.Count)
                {
                    var sonrakiSoru = GetAllQuestion.ElementAt(soruno - 1);
                    richTextBoxQuestion.Text = sonrakiSoru.Key;
                    currentanswer = sonrakiSoru.Value;
                    lblQuestionNo.Text = soruno.ToString();
                }
                else
                {
                    if (GetPassQuestion.Count > 0)
                    {
                        pasmode = true;
                        pasIndex = 0;

                        var sonrakiSoru = GetPassQuestion.ElementAt(pasIndex);
                        richTextBoxQuestion.Text = sonrakiSoru.Key;
                        currentanswer = sonrakiSoru.Value;
                        lblQuestionNo.Text = getpasSoruNo[pasIndex].ToString();

                        linkPass.Enabled = false;
                    }
                    else
                    {
                        OyunBitti();
                    }
                }
            }
            else
            {
                pasIndex++;
                if (pasIndex < GetPassQuestion.Count)
                {
                    var sonrakiSoru = GetPassQuestion.ElementAt(pasIndex);
                    richTextBoxQuestion.Text = sonrakiSoru.Key;
                    currentanswer = sonrakiSoru.Value;
                    lblQuestionNo.Text = getpasSoruNo[pasIndex].ToString();
                }
                else
                {
                    OyunBitti();
                }
            }
        }

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string soru = GetAllQuestion.ElementAt(soruno - 1).Key.ToString();
            string cevap = GetAllQuestion.ElementAt(soruno - 1).Value.ToString();

            HarfButtons[soruno - 1].BackColor = Color.Gold;
            GetPassQuestion.Add(soru, cevap);
            getpasSoruNo.Add(soruno);
            pas++;
            lblPassCount.Text = pas.ToString();

            soruno++;
            if (soruno <= GetAllQuestion.Count)
            {
                var sonrakiSoru = GetAllQuestion.ElementAt(soruno - 1);
                richTextBoxQuestion.Text = sonrakiSoru.Key;
                currentanswer = sonrakiSoru.Value;
                lblQuestionNo.Text = soruno.ToString();
                txtAnswer.Clear();
            }
            else
            {
                // Sorular bittiğinde, pas varsa o tura geç
                if (GetPassQuestion.Count > 0)
                {
                    pasmode = true;
                    pasIndex = 0;

                    var sonrakiSoru = GetPassQuestion.ElementAt(pasIndex);
                    richTextBoxQuestion.Text = sonrakiSoru.Key;
                    currentanswer = sonrakiSoru.Value;
                    lblQuestionNo.Text = getpasSoruNo[pasIndex].ToString();

                    linkPass.Enabled = false;
                }
                else
                {
                    OyunBitti();
                }
            }
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int süre = 300;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (süre >= 0)
            {
                int minutes = süre / 60;
                int seconds = süre % 60;
                lblTime.Text = $"{minutes:D2}:{seconds:D2}";
                süre--;
            }
            else
            {
                lblTime.Text = "Süreniz Bitmiştir";
                linkAnswer.Enabled = false;
                linkPass.Enabled = false;
                timer1.Stop();
            }
        }
    }
}
