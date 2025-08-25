using RandevuProject_DLBL.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
namespace HastaEkle
{
    public partial class Form2 : Form
    {
        private RandevuDbContext ctx = new RandevuDbContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //→ Cinsiyet combobox’ını doldurmak
            comboBoxGender.Items.AddRange(new string[] { "K", "E" });
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;

            textBoxTC.MaxLength = 11;
            textBoxPhone.MaxLength = 11;

            textBoxTC.KeyPress += OnlyDigits_KeyPress;
            textBoxPhone.KeyPress += OnlyDigits_KeyPress;
        }

        private void OnlyDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam girişine izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Geçersiz karakteri engelle
            }
        }
        private readonly ErrorProvider _ep = new ErrorProvider();
        private bool ValidateInputs()
        {
            _ep.Clear();
            bool ok = true;

            // TC No: 11 hane, tümü rakam
            if (textBoxTC.Text.Length != 11 || !textBoxTC.Text.All(char.IsDigit))
            {
                _ep.SetError(textBoxTC, "TC No 11 haneli olmalı (sadece rakam).");
                ok = false;
            }

            // Telefon: 10–11 hane, tümü rakam
            if (textBoxPhone.Text.Length < 10 || textBoxPhone.Text.Length > 11 || !textBoxPhone.Text.All(char.IsDigit))
            {
                _ep.SetError(textBoxPhone, "Telefon 10-11 hane olmalı (sadece rakam).");
                ok = false;
            }

            // E-posta: basit desen (en az bir @ ve alan)
            var email = textBoxMail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email) ||
                !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                _ep.SetError(textBoxMail, "Geçerli bir e-posta girin (örn. ad@alan.com).");
                ok = false;
            }

            // İsim/soyisim/cinsiyet de boş olmasın
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                _ep.SetError(textBoxName, "İsim zorunlu.");
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxSurname.Text))
            {
                _ep.SetError(textBoxSurname, "Soyisim zorunlu.");
                ok = false;
            }
            if (comboBoxGender.SelectedIndex < 0)
            {
                _ep.SetError(comboBoxGender, "Cinsiyet seçiniz.");
                ok = false;
            }

            return ok;
        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;
                // 1) Zorunlu alan kontrolü
                string tckn = textBoxTC.Text.Trim();
                string name = textBoxName.Text.Trim();
                string sname = textBoxSurname.Text.Trim();
                string email = textBoxMail.Text.Trim();
                string phone = textBoxPhone.Text.Trim();
                string gender = comboBoxGender.SelectedItem?.ToString();

               

                // 2) Aynı TC ile kayıt var mı?
                var existing = ctx.Kisilers.FirstOrDefault(x => x.TCNo == tckn);

                if (existing != null)
                {
                    MessageBox.Show("Bu TC No ile kayıt zaten mevcut.", "Bilgi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 3) Yeni kayıt oluştur
                var kisi = new Kisiler
                {
                    Id = Guid.NewGuid(), //kendisi guid oluştursun diye. 
                    CreatedDate = DateTime.Now,
                    TCNo = tckn,
                    Name = name,
                    Surname = sname,
                    Email = email,
                    PhoneNumber = phone,
                    Gender = gender    
                };

                ctx.Kisilers.Add(kisi);
                ctx.SaveChanges();

                MessageBox.Show("Hasta kaydı oluşturuldu.", "Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında hata: " + ex.Message,
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void ClearForm()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxMail.Clear();
            textBoxPhone.Clear();
            textBoxTC.Clear();
            comboBoxGender.SelectedIndex = -1;
            textBoxName.Focus();
        }
    }
}
