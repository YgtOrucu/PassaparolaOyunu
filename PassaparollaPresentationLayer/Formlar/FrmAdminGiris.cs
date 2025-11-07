using PassaparollaBusinenssLayer.Abstract;
using PassaparollaBusinenssLayer.Concreate;
using PassaparollaBusinenssLayer.Valitadion;
using PassaparollaDataAccessLayer.Context;
using PassaparollaDataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaparollaPresentationLayer.Formlar
{
    public partial class FrmAdminGiris : Form
    {
        private readonly IAdminService _adminService;
        private readonly AdminValidation _adminValidation;
        private readonly SorularValidation _sorularValidation;
        public FrmAdminGiris()
        {
            _adminValidation = new AdminValidation();
            _sorularValidation = new SorularValidation();
            _adminService = new AdminManager(new EFAdminDal(), _adminValidation, _sorularValidation);
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                var admin = _adminService.TGetAdminUsers(txtKullanıcı.Text, txtSifre.Text);

                if (admin != null)
                {
                    if(admin.RoleID == 1)
                    {
                        string adsoyad = admin.AD + " " + admin.SOYAD;
                        AdminAnaForm adminAnaForm = new AdminAnaForm(adsoyad);
                        adminAnaForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        string adsoyad = admin.AD + " " + admin.SOYAD;
                        FrmSoruSayfası frmSoruSayfası = new FrmSoruSayfası(adsoyad);
                        frmSoruSayfası.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı ❌", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKullanıcı.Text = ""; txtSifre.Text = "";
                }
            }
            catch (ValidationException ex)
            {
                // 🔥 FluentValidation hataları buraya düşer
                var mesaj = ex.ToString();
                MessageBox.Show(mesaj, "Validasyon Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Diğer olası hatalar
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
