
namespace Clinic_Net
{
    partial class ChangePatientInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePatientInfo));
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diagnosis = new System.Windows.Forms.ComboBox();
            this.medbook_link = new System.Windows.Forms.RichTextBox();
            this.chamber = new System.Windows.Forms.ComboBox();
            this.doctor = new System.Windows.Forms.ComboBox();
            this.sname = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.RichTextBox();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(190, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 28);
            this.label8.TabIndex = 37;
            this.label8.Text = "Изменение информации о пациенте";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(38, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cancel.Location = new System.Drawing.Point(420, 484);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(128, 35);
            this.cancel.TabIndex = 35;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.change.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.change.Location = new System.Drawing.Point(554, 484);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(128, 35);
            this.change.TabIndex = 34;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(396, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 28);
            this.label7.TabIndex = 33;
            this.label7.Text = "Лечащий Врач";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(396, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 32;
            this.label6.Text = "Диагноз";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(396, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "Палата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Дата Рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ссылка на мед. книжку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Имя";
            // 
            // diagnosis
            // 
            this.diagnosis.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.diagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diagnosis.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diagnosis.FormattingEnabled = true;
            this.diagnosis.Location = new System.Drawing.Point(396, 255);
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Size = new System.Drawing.Size(286, 45);
            this.diagnosis.TabIndex = 26;
            // 
            // medbook_link
            // 
            this.medbook_link.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.medbook_link.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medbook_link.Location = new System.Drawing.Point(38, 422);
            this.medbook_link.Multiline = false;
            this.medbook_link.Name = "medbook_link";
            this.medbook_link.Size = new System.Drawing.Size(644, 43);
            this.medbook_link.TabIndex = 25;
            this.medbook_link.Text = "";
            // 
            // chamber
            // 
            this.chamber.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.chamber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chamber.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chamber.FormattingEnabled = true;
            this.chamber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.chamber.Location = new System.Drawing.Point(396, 180);
            this.chamber.Name = "chamber";
            this.chamber.Size = new System.Drawing.Size(286, 45);
            this.chamber.TabIndex = 24;
            // 
            // doctor
            // 
            this.doctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.doctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.doctor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doctor.Location = new System.Drawing.Point(396, 334);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(286, 45);
            this.doctor.TabIndex = 23;
            // 
            // sname
            // 
            this.sname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sname.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sname.Location = new System.Drawing.Point(38, 257);
            this.sname.Multiline = false;
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(286, 43);
            this.sname.TabIndex = 22;
            this.sname.Text = "";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.name.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(38, 180);
            this.name.Multiline = false;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(286, 43);
            this.name.TabIndex = 21;
            this.name.Text = "";
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // dateofbirth
            // 
            this.dateofbirth.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateofbirth.Location = new System.Drawing.Point(38, 336);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(286, 43);
            this.dateofbirth.TabIndex = 20;
            // 
            // ChangePatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(721, 534);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.change);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.medbook_link);
            this.Controls.Add(this.chamber);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dateofbirth);
            this.Name = "ChangePatientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clinic +";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox diagnosis;
        private System.Windows.Forms.RichTextBox medbook_link;
        private System.Windows.Forms.ComboBox chamber;
        private System.Windows.Forms.ComboBox doctor;
        private System.Windows.Forms.RichTextBox sname;
        private System.Windows.Forms.RichTextBox name;
        private System.Windows.Forms.DateTimePicker dateofbirth;
    }
}