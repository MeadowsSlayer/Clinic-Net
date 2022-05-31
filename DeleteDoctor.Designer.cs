
namespace Clinic_Net
{
    partial class DeleteDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDoctor));
            this.doc_time = new System.Windows.Forms.RichTextBox();
            this.doc_spec = new System.Windows.Forms.RichTextBox();
            this.doc_area = new System.Windows.Forms.RichTextBox();
            this.fname = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.spec = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // doc_time
            // 
            this.doc_time.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.doc_time.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doc_time.Location = new System.Drawing.Point(396, 337);
            this.doc_time.Multiline = false;
            this.doc_time.Name = "doc_time";
            this.doc_time.ReadOnly = true;
            this.doc_time.Size = new System.Drawing.Size(286, 43);
            this.doc_time.TabIndex = 107;
            this.doc_time.Text = "";
            // 
            // doc_spec
            // 
            this.doc_spec.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.doc_spec.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doc_spec.Location = new System.Drawing.Point(396, 260);
            this.doc_spec.Multiline = false;
            this.doc_spec.Name = "doc_spec";
            this.doc_spec.ReadOnly = true;
            this.doc_spec.Size = new System.Drawing.Size(286, 43);
            this.doc_spec.TabIndex = 106;
            this.doc_spec.Text = "";
            // 
            // doc_area
            // 
            this.doc_area.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.doc_area.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doc_area.Location = new System.Drawing.Point(396, 183);
            this.doc_area.Multiline = false;
            this.doc_area.Name = "doc_area";
            this.doc_area.ReadOnly = true;
            this.doc_area.Size = new System.Drawing.Size(286, 43);
            this.doc_area.TabIndex = 105;
            this.doc_area.Text = "";
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fname.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fname.Location = new System.Drawing.Point(38, 337);
            this.fname.Multiline = false;
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Size = new System.Drawing.Size(286, 43);
            this.fname.TabIndex = 104;
            this.fname.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(283, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 28);
            this.label8.TabIndex = 103;
            this.label8.Text = "Удаление врача";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(38, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cancel.Location = new System.Drawing.Point(38, 402);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(128, 35);
            this.cancel.TabIndex = 101;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.delete.Location = new System.Drawing.Point(554, 402);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(128, 35);
            this.delete.TabIndex = 100;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time.Location = new System.Drawing.Point(396, 306);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(144, 28);
            this.time.TabIndex = 99;
            this.time.Text = "Время приема";
            // 
            // spec
            // 
            this.spec.AutoSize = true;
            this.spec.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spec.Location = new System.Drawing.Point(396, 229);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(152, 28);
            this.spec.TabIndex = 98;
            this.spec.Text = "Специальность";
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.area.Location = new System.Drawing.Point(396, 152);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(83, 28);
            this.area.TabIndex = 97;
            this.area.Text = "Участок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 96;
            this.label4.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 95;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 94;
            this.label1.Text = "Имя";
            // 
            // sname
            // 
            this.sname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sname.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sname.Location = new System.Drawing.Point(38, 260);
            this.sname.Multiline = false;
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            this.sname.Size = new System.Drawing.Size(286, 43);
            this.sname.TabIndex = 93;
            this.sname.Text = "";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.name.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(38, 183);
            this.name.Multiline = false;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(286, 43);
            this.name.TabIndex = 92;
            this.name.Text = "";
            // 
            // DeleteDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(721, 454);
            this.Controls.Add(this.doc_time);
            this.Controls.Add(this.doc_spec);
            this.Controls.Add(this.doc_area);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.time);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.name);
            this.Name = "DeleteDoctor";
            this.Text = "Clinic +";
            this.Load += new System.EventHandler(this.DeleteDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox doc_time;
        private System.Windows.Forms.RichTextBox doc_spec;
        private System.Windows.Forms.RichTextBox doc_area;
        private System.Windows.Forms.RichTextBox fname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label spec;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox sname;
        private System.Windows.Forms.RichTextBox name;
    }
}