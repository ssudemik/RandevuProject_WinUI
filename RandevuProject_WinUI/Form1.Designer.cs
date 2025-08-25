namespace RandevuProject_WinUI
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxDoctor = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBoxAppointment = new ComboBox();
            comboBoxTimePicker = new ComboBox();
            buttonSave = new Button();
            buttonClose = new Button();
            labelEndTime = new Label();
            label12 = new Label();
            comboBoxPatiend = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 169);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Doktor Seçimi :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 231);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "Tarih Seçimi :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 228);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 4;
            label5.Text = "Saat Seçimi :";
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(191, 164);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(250, 28);
            comboBoxDoctor.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(555, 169);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 9;
            label6.Text = "Randevu Tipi :";
            label6.Click += label6_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(191, 226);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // comboBoxAppointment
            // 
            comboBoxAppointment.FormattingEnabled = true;
            comboBoxAppointment.Location = new Point(699, 161);
            comboBoxAppointment.Name = "comboBoxAppointment";
            comboBoxAppointment.Size = new Size(250, 28);
            comboBoxAppointment.TabIndex = 11;
            // 
            // comboBoxTimePicker
            // 
            comboBoxTimePicker.FormattingEnabled = true;
            comboBoxTimePicker.Location = new Point(699, 228);
            comboBoxTimePicker.Name = "comboBoxTimePicker";
            comboBoxTimePicker.Size = new Size(250, 28);
            comboBoxTimePicker.TabIndex = 12;
            comboBoxTimePicker.SelectedIndexChanged += comboBoxTimePicker_SelectedIndexChanged;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonSave.Location = new Point(824, 319);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(125, 31);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonClose.Location = new Point(53, 319);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(125, 31);
            buttonClose.TabIndex = 14;
            buttonClose.Text = "Kapat";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelEndTime
            // 
            labelEndTime.AutoSize = true;
            labelEndTime.Location = new Point(555, 285);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new Size(0, 20);
            labelEndTime.TabIndex = 15;
            labelEndTime.Click += label7_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9.2F, FontStyle.Bold);
            label12.Location = new Point(51, 50);
            label12.Name = "label12";
            label12.Size = new Size(219, 21);
            label12.TabIndex = 26;
            label12.Text = "Randevu Kayıt Oluşturma :";
            // 
            // comboBoxPatiend
            // 
            comboBoxPatiend.FormattingEnabled = true;
            comboBoxPatiend.Location = new Point(192, 105);
            comboBoxPatiend.Name = "comboBoxPatiend";
            comboBoxPatiend.Size = new Size(250, 28);
            comboBoxPatiend.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 110);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 27;
            label1.Text = "Hasta Seçimi :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 400);
            Controls.Add(comboBoxPatiend);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(labelEndTime);
            Controls.Add(buttonClose);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxTimePicker);
            Controls.Add(comboBoxAppointment);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(comboBoxDoctor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Randevu Oluşturma";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxDoctor;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxAppointment;
        private ComboBox comboBoxTimePicker;
        private Button buttonSave;
        private Button buttonClose;
        private Label labelEndTime;
        private Label label12;
        private ComboBox comboBoxPatiend;
        private Label label1;
    }
}
