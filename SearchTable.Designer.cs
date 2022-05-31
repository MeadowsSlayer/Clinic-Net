
namespace Clinic_Net
{
    partial class SearchTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTable));
            this.search = new System.Windows.Forms.RichTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patients = new System.Windows.Forms.Button();
            this.doctors = new System.Windows.Forms.Button();
            this.areas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Change = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.more = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.search.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(12, 70);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(932, 46);
            this.search.TabIndex = 2;
            this.search.Text = "";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.SearchButton.Location = new System.Drawing.Point(950, 70);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(115, 46);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.cab,
            this.diagnosis,
            this.doc_id});
            this.table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table.Location = new System.Drawing.Point(12, 122);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowTemplate.Height = 25;
            this.table.Size = new System.Drawing.Size(1053, 426);
            this.table.TabIndex = 4;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.FillWeight = 200F;
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // surname
            // 
            this.surname.FillWeight = 200F;
            this.surname.HeaderText = "Фамилия";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 200;
            // 
            // cab
            // 
            this.cab.FillWeight = 50F;
            this.cab.HeaderText = "Палата";
            this.cab.Name = "cab";
            this.cab.ReadOnly = true;
            this.cab.Width = 54;
            // 
            // diagnosis
            // 
            this.diagnosis.HeaderText = "Диагноз";
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.ReadOnly = true;
            this.diagnosis.Width = 200;
            // 
            // doc_id
            // 
            this.doc_id.HeaderText = "Доктор";
            this.doc_id.Name = "doc_id";
            this.doc_id.ReadOnly = true;
            this.doc_id.Width = 305;
            // 
            // patients
            // 
            this.patients.BackColor = System.Drawing.Color.Gray;
            this.patients.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.patients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patients.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patients.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.patients.Location = new System.Drawing.Point(104, 0);
            this.patients.Name = "patients";
            this.patients.Size = new System.Drawing.Size(308, 64);
            this.patients.TabIndex = 5;
            this.patients.Text = "Пациенты";
            this.patients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patients.UseVisualStyleBackColor = false;
            this.patients.Click += new System.EventHandler(this.list1_Click);
            // 
            // doctors
            // 
            this.doctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.doctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctors.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doctors.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.doctors.Location = new System.Drawing.Point(411, -1);
            this.doctors.Name = "doctors";
            this.doctors.Size = new System.Drawing.Size(326, 65);
            this.doctors.TabIndex = 6;
            this.doctors.Text = "Доктора";
            this.doctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctors.UseVisualStyleBackColor = false;
            this.doctors.Click += new System.EventHandler(this.doctors_Click);
            // 
            // areas
            // 
            this.areas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.areas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.areas.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.areas.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.areas.Location = new System.Drawing.Point(736, -1);
            this.areas.Name = "areas";
            this.areas.Size = new System.Drawing.Size(342, 65);
            this.areas.TabIndex = 7;
            this.areas.Text = "Участки";
            this.areas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.areas.UseVisualStyleBackColor = false;
            this.areas.Click += new System.EventHandler(this.list3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.patients);
            this.panel1.Controls.Add(this.doctors);
            this.panel1.Controls.Add(this.areas);
            this.panel1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 65);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Change.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.Change.Location = new System.Drawing.Point(12, 554);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(128, 35);
            this.Change.TabIndex = 8;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.admin_mod_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.delete.Location = new System.Drawing.Point(937, 553);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(128, 35);
            this.delete.TabIndex = 9;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.create.Location = new System.Drawing.Point(803, 553);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(128, 35);
            this.create.TabIndex = 10;
            this.create.Text = "Добавить";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // more
            // 
            this.more.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.more.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.more.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.more.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.more.Location = new System.Drawing.Point(146, 554);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(128, 35);
            this.more.TabIndex = 11;
            this.more.Text = "Подробнее";
            this.more.UseVisualStyleBackColor = false;
            this.more.Click += new System.EventHandler(this.more_Click);
            // 
            // SearchTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1077, 600);
            this.Controls.Add(this.more);
            this.Controls.Add(this.create);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.search);
            this.Name = "SearchTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clinic +";
            this.Load += new System.EventHandler(this.SearchTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox search;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cab;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_id;
        private System.Windows.Forms.Button patients;
        private System.Windows.Forms.Button doctors;
        private System.Windows.Forms.Button areas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button more;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}