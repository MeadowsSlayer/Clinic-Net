
namespace Clinic_Net
{
    partial class EditDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDoctor));
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.spec = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doc_spec = new System.Windows.Forms.ComboBox();
            this.doc_area = new System.Windows.Forms.ComboBox();
            this.doc_time = new System.Windows.Forms.ComboBox();
            this.sname = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.RichTextBox();
            this.fname = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(221, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 28);
            this.label8.TabIndex = 55;
            this.label8.Text = "Изменение информации о враче";
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
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cancel.Location = new System.Drawing.Point(420, 399);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(128, 35);
            this.cancel.TabIndex = 53;
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
            this.change.Location = new System.Drawing.Point(554, 399);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(128, 35);
            this.change.TabIndex = 52;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time.Location = new System.Drawing.Point(396, 303);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(144, 28);
            this.time.TabIndex = 51;
            this.time.Text = "Время приема";
            // 
            // spec
            // 
            this.spec.AutoSize = true;
            this.spec.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spec.Location = new System.Drawing.Point(396, 226);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(152, 28);
            this.spec.TabIndex = 50;
            this.spec.Text = "Специальность";
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.area.Location = new System.Drawing.Point(396, 149);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(83, 28);
            this.area.TabIndex = 49;
            this.area.Text = "Участок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 46;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Имя";
            // 
            // doc_spec
            // 
            this.doc_spec.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.doc_spec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doc_spec.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doc_spec.FormattingEnabled = true;
            this.doc_spec.Location = new System.Drawing.Point(396, 255);
            this.doc_spec.Name = "doc_spec";
            this.doc_spec.Size = new System.Drawing.Size(286, 45);
            this.doc_spec.TabIndex = 44;
            // 
            // doc_area
            // 
            this.doc_area.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.doc_area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doc_area.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doc_area.FormattingEnabled = true;
            this.doc_area.Location = new System.Drawing.Point(396, 180);
            this.doc_area.Name = "doc_area";
            this.doc_area.Size = new System.Drawing.Size(286, 45);
            this.doc_area.TabIndex = 42;
            // 
            // doc_time
            // 
            this.doc_time.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.doc_time.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.doc_time.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.doc_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doc_time.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doc_time.Location = new System.Drawing.Point(396, 334);
            this.doc_time.Name = "doc_time";
            this.doc_time.Size = new System.Drawing.Size(286, 45);
            this.doc_time.TabIndex = 41;
            // 
            // sname
            // 
            this.sname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sname.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sname.Location = new System.Drawing.Point(38, 257);
            this.sname.Multiline = false;
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(286, 43);
            this.sname.TabIndex = 40;
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
            this.name.TabIndex = 39;
            this.name.Text = "";
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fname.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fname.Location = new System.Drawing.Point(38, 334);
            this.fname.Multiline = false;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(286, 43);
            this.fname.TabIndex = 56;
            this.fname.Text = "";
            // 
            // EditDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(721, 454);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.change);
            this.Controls.Add(this.time);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doc_spec);
            this.Controls.Add(this.doc_area);
            this.Controls.Add(this.doc_time);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.name);
            this.Name = "EditDoctor";
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
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label spec;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox doc_spec;
        private System.Windows.Forms.ComboBox doc_area;
        private System.Windows.Forms.ComboBox doc_time;
        private System.Windows.Forms.RichTextBox sname;
        private System.Windows.Forms.RichTextBox name;
        private System.Windows.Forms.RichTextBox fname;
    }
}