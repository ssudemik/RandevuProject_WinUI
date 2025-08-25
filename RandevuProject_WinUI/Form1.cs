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

            LoadPatient();
            LoadDoctors(); //→ Doktor listesini combobox’a yüklemek
            LoadAppointmentTypes(); //→ Randevu tiplerini combobox’a yüklemek
                                    //LoadAvailableHours() → Saat comboBox’ını doldurmak, Seçilen saate göre bitiş saatini otomatik hesaplamak
            for (int h = 8; h < 18; h++)
            {
                comboBoxTimePicker.Items.Add(new TimeSpan(h, 0, 0));  // 08:00
                comboBoxTimePicker.Items.Add(new TimeSpan(h, 30, 0)); // 08:30
            }
            comboBoxTimePicker.FormatString = @"hh\:mm";
            comboBoxTimePicker.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private static readonly string PatientRoleId = "609202f7-bea9-40c2-ad74-024887f26980";
        private void LoadPatient()
        {
            try
            {
                var patients = ctx.KisilerinRolleris
                    .AsNoTracking()
                    .Where(kr => kr.RoleId == PatientRoleId)
                    .Select(kr => kr.User)
                    .Select(k => new
                    {
                        Id = k.Id,
                        FullName = (k.Name ?? "").Trim() + " " + (k.Surname ?? "").Trim()
                    })
                    .Distinct()
                    .OrderBy(k => k.FullName)
                    .ToList();

                ComboBox(patients, "FullName", "Id", "Hasta Seçiniz", comboBoxPatiend);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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




        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Zorunlu alan kontrolleri
                if (comboBoxPatiend.SelectedValue == null)
                    throw new InvalidOperationException("Hasta seçiniz.");
                if (comboBoxDoctor.SelectedValue == null)
                    throw new InvalidOperationException("Doktor seçiniz.");
                if (comboBoxAppointment.SelectedValue == null)
                    throw new InvalidOperationException("Randevu tipi seçiniz.");
                if (comboBoxTimePicker.SelectedItem == null)
                    throw new InvalidOperationException("Saat seçiniz.");

                // 2) Seçimleri oku
                string patientId = comboBoxPatiend.SelectedValue.ToString();   // string PK
                string doctorId = comboBoxDoctor.SelectedValue.ToString();    // string PK
                byte typeId = Convert.ToByte(comboBoxAppointment.SelectedValue);

                DateTime date = dateTimePicker1.Value.Date;

                // Saat: ComboBox'a TimeSpan eklediğin için doğrudan al
                TimeSpan startTs = comboBoxTimePicker.SelectedItem is TimeSpan ts
                                    ? ts
                                    : TimeSpan.Parse(comboBoxTimePicker.SelectedItem!.ToString()!);

                DateTime start = date.Add(startTs);
                DateTime end = start.AddMinutes(60); // slot süresi

                // 3) (Önerilir) Aynı doktor için zaman çakışması kontrolü
                bool overlaps = ctx.Randevulars.Any(r =>
                    r.DoctorId == doctorId &&
                    (
                        (start >= r.AppointmentStartDate && start < r.AppointmentEndDate) ||
                        (end > r.AppointmentStartDate && end <= r.AppointmentEndDate) ||
                        (start <= r.AppointmentStartDate && end >= r.AppointmentEndDate)
                    )
                );
                if (overlaps)
                    throw new InvalidOperationException("Seçilen saat bu doktor için dolu.");

                // 4) Transaction içinde kaydet
                using var tx = ctx.Database.BeginTransaction();

                var newAppointment = new Randevular
                {
                    PatientId = patientId,                    // string
                    DoctorId = doctorId,                     // string
                    AppointmentTypeId = typeId,
                    AppointmentStartDate = start,
                    StartHour = start.ToString("HH:mm"),
                    AppointmentEndDate = end,
                    EndHour = end.ToString("HH:mm"),
                    IsPatientCome = false,
                    IsCancelled = false,
                    CancellReason = null
                };

                ctx.Randevulars.Add(newAppointment);
                ctx.SaveChanges();
                tx.Commit();

                MessageBox.Show("Randevu kaydı başarılı!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // İstersen formu temizle:
                // comboBoxPatiend.SelectedIndex = comboBoxDoctor.SelectedIndex = comboBoxAppointment.SelectedIndex = -1;
                // comboBoxTimePicker.SelectedIndex = -1;
                // labelEndTime.Text = "Bitiş Saati:";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu kaydedilirken hata: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
