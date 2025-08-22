using System.Runtime.CompilerServices;
using RandevuProject_DLBL.Models;
using Microsoft.EntityFrameworkCore;

namespace RandevuProject_WinUI
{
    public partial class Form1 : Form
    {
        private RandevuDbContext ctx = new RandevuDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDoctors(); //→ Doktor listesini combobox’a yüklemek
            LoadPatients(); //→ Hasta adını soyadını alıp ilgili tabloya kaydetmek
            LoadAppointmentTypes(); //→ Randevu tiplerini combobox’a yüklemek
            //LoadAvailableHours() → Saat comboBox’ını doldurmak, Seçilen saate göre bitiş saatini otomatik hesaplamak
            for (int i = 8; i < 19; i++)
            {
                comboBoxTimePicker.Items.Add(i.ToString("D2") + ":00");
                comboBoxTimePicker.Items.Add(i.ToString("D2") + ":30");
            }
            //GenerateAppointmentId() → Yeni GUID/Id üretmek
            //SaveAppointment() → Randevuyu kaydetmek 
            //CloseForm() → Formu kapatmak

        }

        private void ComboBox(object data, string displayMember, string valueMember, string text, ComboBox cmbBox)
        {
            cmbBox.DisplayMember = displayMember; //uida görünecek metin
            cmbBox.ValueMember = valueMember; //seçili öğenin değeri(kayıtta tutulacak veri)
            cmbBox.DataSource = data;
            cmbBox.SelectedIndex = -1; // Seçili öğe yok
            cmbBox.Text = text; // İlk öğe olarak gösterilecek metin
            cmbBox.DropDownStyle = ComboBoxStyle.DropDownList; // Kullanıcı metin giremesin, sadece seçim yapsın
        }

        private static readonly string DoctorRoleId = "532a11cc-2031-472b-b3f0-e8ad471b11bf";
        private void LoadDoctors()
        {
            try
            {
                var doctors = ctx.KisilerinRolleris
                    .AsNoTracking()
                    .Where(kr => kr.RoleId == DoctorRoleId)
                    .Select(kr => kr.User)
                    .Select(k => new
                    {
                        Id = k.Id,
                        FullName = (k.Name ?? "").Trim() + " " + (k.Surname ?? "").Trim()
                    })
                    .Distinct()
                    .OrderBy(k => k.FullName)
                    .ToList();

                // bu işlemin select sorrgusu:
                /*SELECT k.Id, (k.Name + ' ' + k.Surname) AS FullName
                FROM KisilerinRolleri kr
                JOIN Kisiler k ON k.Id = kr.UserId
                WHERE kr.RoleId = @DoctorRoleId
                GROUP BY k.Id, k.Name, k.Surname
                ORDER BY FullName;
                */
                ComboBox(doctors, "FullName", "Id", "Doktor Seçiniz", comboBoxDoctor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadPatients()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAppointmentTypes()
        {
            try
            {
                var data = ctx.RandevuTipleris.ToList();
                ComboBox(data, "TypeName", "Id", "Randevu Tipi Seçiniz", comboBoxAppointment);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxTimePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen saate göre bitiş saatini hesaplamak
            if (comboBoxTimePicker.SelectedIndex >= 0)
            {
                string selectedTime = comboBoxTimePicker.SelectedItem.ToString();
                if (DateTime.TryParse(selectedTime, out DateTime startTime))
                {
                    DateTime endTime = startTime.AddHours(1); // 1 saat ekleyerek bitiş saatini hesapla
                    labelEndTime.Text = "Bitiş Saati: " + endTime.ToString("HH:mm");
                }
                else
                {
                    labelEndTime.Text = "Bitiş Saati: Geçersiz Saat";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
