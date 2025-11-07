using PassaparollaBusinenssLayer.Abstract;
using PassaparollaBusinenssLayer.Concreate;
using PassaparollaBusinenssLayer.Valitadion;
using PassaparollaDataAccessLayer.EntityFramework;
using PassaparollaEntityLayer.ConCreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaparollaPresentationLayer.Formlar
{
    public partial class AdminAnaForm : Form
    {
        private readonly string _adsoyad;
        private IAdminService _adminService;
        private AdminValidation _adminValidation;
        private SorularValidation _sorularValidation;

        private void InitializeServices()
        {
            _adminValidation = new AdminValidation();
            _sorularValidation = new SorularValidation();
            _adminService = new AdminManager(new EFAdminDal(), _adminValidation, _sorularValidation);
        }
        private void Temizle(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is RichTextBox ric) ric.Clear();
                else if (item is TextBox txt) txt.Clear();
                else if (item is RadioButton rd) rd.Checked = false;
                else if (item.HasChildren) Temizle(item);
            }
        }
        private void AktifListeleme()
        {
            var values = _adminService.TGetDurumList(true);
            dataGridView1.DataSource = values;
            dataGridView1.Columns["ID"].Visible = false;
        }
        private void PasifListeleme()
        {
            var values = _adminService.TGetDurumList(false);
            dataGridView2.DataSource = values;
            dataGridView2.Columns["ID"].Visible = false;
        }
        public AdminAnaForm(string adsoyad)
        {
            InitializeComponent();
            _adsoyad = adsoyad;
            InitializeServices();
        }

        public AdminAnaForm()
        {
            InitializeComponent();
            InitializeServices();
        }

        private void AdminAnaForm_Load(object sender, EventArgs e)
        {
            #region datagrid
            DataGridView[] dataGrids = new DataGridView[] { dataGridView1, dataGridView2 };
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 230, 250); // Başlık arka planı
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = Color.Black; // Başlık yazısı
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(100, 150, 255); // Başlık seçili rengi
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.BackColor = Color.FromArgb(245, 245, 245); // Satır arka planı
            cellStyle.ForeColor = Color.Black; // Yazı rengi
            cellStyle.SelectionBackColor = Color.FromArgb(100, 150, 255); // Seçili satır mavi
            cellStyle.SelectionForeColor = Color.White; // Seçili satır yazısı beyaz
            cellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);

            for (int i = 0; i < dataGrids.Length; i++)
            {
                if (dataGrids[i] == dataGridView1)
                {
                    dataGrids[i].AllowUserToAddRows = false;
                    dataGrids[i].AllowUserToResizeColumns = false;
                    dataGrids[i].AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGrids[i].BackgroundColor = SystemColors.ControlLightLight;
                    dataGrids[i].BorderStyle = BorderStyle.None;
                    dataGrids[i].CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dataGrids[i].ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dataGrids[i].ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    dataGrids[i].Dock = DockStyle.None;
                    dataGrids[i].ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
                    dataGrids[i].DefaultCellStyle = cellStyle;
                    dataGrids[i].EnableHeadersVisualStyles = false;
                    dataGrids[i].AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
                    dataGrids[i].GridColor = Color.FromArgb(210, 220, 240);
                    dataGrids[i].Location = new Point(10, 226);
                    dataGrids[i].Name = "dataGridView1";
                    dataGrids[i].ReadOnly = true;
                    dataGrids[i].RowHeadersVisible = false;
                    dataGrids[i].SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGrids[i].Size = new Size(953, 194);
                    dataGrids[i].TabIndex = 20;
                }
                if (dataGrids[i] == dataGridView2)
                {
                    dataGrids[i].AllowUserToAddRows = false;
                    dataGrids[i].AllowUserToResizeColumns = false;
                    dataGrids[i].AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGrids[i].BackgroundColor = SystemColors.ControlLightLight;
                    dataGrids[i].BorderStyle = BorderStyle.None;
                    dataGrids[i].CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dataGrids[i].ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dataGrids[i].ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    dataGrids[i].Dock = DockStyle.None;
                    dataGrids[i].ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
                    dataGrids[i].DefaultCellStyle = cellStyle;
                    dataGrids[i].EnableHeadersVisualStyles = false;
                    dataGrids[i].AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
                    dataGrids[i].GridColor = Color.FromArgb(210, 220, 240);
                    dataGrids[i].Location = new Point(10, 469);
                    dataGrids[i].Name = "dataGridView2";
                    dataGrids[i].ReadOnly = true;
                    dataGrids[i].RowHeadersVisible = false;
                    dataGrids[i].SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGrids[i].Size = new Size(953, 209);
                    dataGrids[i].TabIndex = 20;
                }
            }

            #endregion
            lblAdminAdSoyad.Text = _adsoyad;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            #region AktifSoruList
            AktifListeleme();
            #endregion
            #region PasifSoruList
            PasifListeleme();
            #endregion
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var addedsoru = new Sorular()
            {
                Soru = ricSoru.Text,
                Harf = txtHarf.Text,
                Cevap = txtCevap.Text,
                Durum = rdAktif.Checked ? true : false
            };
            _adminService.TInsert(addedsoru);
            var result = MessageBox.Show("Soru başarılı bir şekilde eklendi.Listelemek istiyormusunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (DialogResult.Yes == result)
            {
                AktifListeleme();
                PasifListeleme();
                Temizle(this);
            }
            else
            {
                Temizle(this);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int soruID = int.Parse(lblSoruID.Text);
            var updatedSoru = _adminService.TGetByID(soruID);

            updatedSoru.Soru = ricSoru.Text;
            updatedSoru.Harf = txtHarf.Text;
            updatedSoru.Cevap = txtCevap.Text;
            updatedSoru.Durum = rdAktif.Checked ? true : false;
            _adminService.TUpdate(updatedSoru);

            var result = MessageBox.Show("Soru başarılı bir şekilde güncellendi.Listelemek istiyormusunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (DialogResult.Yes == result)
            {
                AktifListeleme();
                PasifListeleme();
                Temizle(this);
            }
            else
            {
                Temizle(this);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secılen = dataGridView1.SelectedCells[0].RowIndex;
            bool status = Convert.ToBoolean(dataGridView1.Rows[secılen].Cells[4].Value);
            if (status)
            {
                rdAktif.Checked = true;
            }
            else
            {
                rdPasif.Checked = true;
            }
            lblSoruID.Text = dataGridView1.Rows[secılen].Cells[0].Value.ToString();
            txtHarf.Text = dataGridView1.Rows[secılen].Cells[1].Value.ToString();
            ricSoru.Text = dataGridView1.Rows[secılen].Cells[2].Value.ToString();
            txtCevap.Text = dataGridView1.Rows[secılen].Cells[3].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int soruıd = int.Parse(lblSoruID.Text);
            _adminService.TDelete(soruıd);

            var result = MessageBox.Show("Soru başarılı bir şekilde silindi.Listelemek istiyormusunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (DialogResult.Yes == result)
            {
                AktifListeleme();
                PasifListeleme();
                Temizle(this);
            }
            else
            {
                Temizle(this);
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secılen = dataGridView2.SelectedCells[0].RowIndex;
            bool status = Convert.ToBoolean(dataGridView2.Rows[secılen].Cells[4].Value);
            if (status)
            {
                rdAktif.Checked = true;
            }
            else
            {
                rdPasif.Checked = true;
            }
            lblSoruID.Text = dataGridView2.Rows[secılen].Cells[0].Value.ToString();
            txtHarf.Text = dataGridView2.Rows[secılen].Cells[1].Value.ToString();
            ricSoru.Text = dataGridView2.Rows[secılen].Cells[2].Value.ToString();
            txtCevap.Text = dataGridView2.Rows[secılen].Cells[3].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle(this);
        }

        private void btnHarfeGöreGetir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHarf.Text) && Regex.IsMatch(txtHarf.Text, "^[A-ZÇĞİÖŞÜ]$"))
            {
                var values = _adminService.TDurumandHarfeGöreListe(txtHarf.Text, true);
                dataGridView1.DataSource = values;
                dataGridView1.Columns["ID"].Visible = false;
                var values1 = _adminService.TDurumandHarfeGöreListe(txtHarf.Text, false);
                dataGridView2.DataSource = values1;
                dataGridView2.Columns["ID"].Visible = false;
            }
            else
            {
                MessageBox.Show("Girilen Harf değerini kontrol ediniz. Büyük olmasına ve boş olmamasına dikkat ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHarf.Text = "";
            }
            
        }
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSoruSayfası frmSoruSayfası = new FrmSoruSayfası();
            frmSoruSayfası.Show();
            this.Hide();
        }
    }
}
