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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            comboBoxDoctor = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBoxAppointment = new ComboBox();
            comboBoxTimePicker = new ComboBox();
            buttonSave = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 56);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "İsim :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 108);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyisim :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 161);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Doktor Seçimi :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 223);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "Tarih Seçimi :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(551, 223);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 4;
            label5.Text = "Saat Seçimi :";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(187, 53);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(250, 27);
            textBoxName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(187, 101);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(250, 27);
            textBoxSurname.TabIndex = 6;
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(187, 156);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(250, 28);
            comboBoxDoctor.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(551, 164);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 9;
            label6.Text = "Randevu Tipi :";
            label6.Click += label6_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(187, 218);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // comboBoxAppointment
            // 
            comboBoxAppointment.FormattingEnabled = true;
            comboBoxAppointment.Location = new Point(695, 156);
            comboBoxAppointment.Name = "comboBoxAppointment";
            comboBoxAppointment.Size = new Size(250, 28);
            comboBoxAppointment.TabIndex = 11;
            // 
            // comboBoxTimePicker
            // 
            comboBoxTimePicker.FormattingEnabled = true;
            comboBoxTimePicker.Location = new Point(695, 223);
            comboBoxTimePicker.Name = "comboBoxTimePicker";
            comboBoxTimePicker.Size = new Size(250, 28);
            comboBoxTimePicker.TabIndex = 12;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(820, 346);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(125, 31);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(49, 346);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(125, 31);
            buttonClose.TabIndex = 14;
            buttonClose.Text = "Kapat";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 414);
            Controls.Add(buttonClose);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxTimePicker);
            Controls.Add(comboBoxAppointment);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(comboBoxDoctor);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Randevu Oluşturma";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private ComboBox comboBoxDoctor;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxAppointment;
        private ComboBox comboBoxTimePicker;
        private Button buttonSave;
        private Button buttonClose;
    }
}
