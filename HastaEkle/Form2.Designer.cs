namespace HastaEkle
{
    partial class Form2
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
            label11 = new Label();
            comboBoxGender = new ComboBox();
            label10 = new Label();
            textBoxTC = new TextBox();
            label9 = new Label();
            textBoxPhone = new TextBox();
            textBoxMail = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonClose2 = new Button();
            buttonSave2 = new Button();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 9.2F, FontStyle.Bold);
            label11.Location = new Point(52, 37);
            label11.Name = "label11";
            label11.Size = new Size(197, 21);
            label11.TabIndex = 38;
            label11.Text = "Hasta Kayıt Oluşturma :";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(190, 177);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(250, 28);
            comboBoxGender.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(52, 185);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 36;
            label10.Text = "Cinsiyet :";
            // 
            // textBoxTC
            // 
            textBoxTC.Location = new Point(698, 178);
            textBoxTC.Name = "textBoxTC";
            textBoxTC.Size = new Size(250, 27);
            textBoxTC.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(560, 185);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 34;
            label9.Text = "TC No :";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(698, 120);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(250, 27);
            textBoxPhone.TabIndex = 33;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(698, 72);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(250, 27);
            textBoxMail.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(560, 127);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 31;
            label7.Text = "Telefon  :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(560, 75);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 30;
            label8.Text = "E-Mail :";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(190, 124);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(250, 27);
            textBoxSurname.TabIndex = 29;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(190, 76);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(250, 27);
            textBoxName.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 131);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 27;
            label2.Text = "Soyisim :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 79);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 26;
            label1.Text = "İsim :";
            // 
            // buttonClose2
            // 
            buttonClose2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonClose2.Location = new Point(52, 248);
            buttonClose2.Name = "buttonClose2";
            buttonClose2.Size = new Size(125, 31);
            buttonClose2.TabIndex = 40;
            buttonClose2.Text = "Kapat";
            buttonClose2.UseVisualStyleBackColor = true;
            buttonClose2.Click += buttonClose2_Click;
            // 
            // buttonSave2
            // 
            buttonSave2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonSave2.Location = new Point(823, 248);
            buttonSave2.Name = "buttonSave2";
            buttonSave2.Size = new Size(125, 31);
            buttonSave2.TabIndex = 39;
            buttonSave2.Text = "Kaydet";
            buttonSave2.UseVisualStyleBackColor = true;
            buttonSave2.Click += buttonSave2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 336);
            Controls.Add(buttonClose2);
            Controls.Add(buttonSave2);
            Controls.Add(label11);
            Controls.Add(comboBoxGender);
            Controls.Add(label10);
            Controls.Add(textBoxTC);
            Controls.Add(label9);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxMail);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Hasta Kayıt Formu :";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private ComboBox comboBoxGender;
        private Label label10;
        private TextBox textBoxTC;
        private Label label9;
        private TextBox textBoxPhone;
        private TextBox textBoxMail;
        private Label label7;
        private Label label8;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private Button buttonClose2;
        private Label labelEndTime;
        private Button buttonClose;
        private Button buttonSave2;
    }
}
