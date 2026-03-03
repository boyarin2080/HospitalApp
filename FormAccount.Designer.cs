namespace WindowsFormsAppHospital
{
    partial class FormAccount
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
            this.btn_zapis_na_priem = new System.Windows.Forms.Button();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.lbl_you_are = new System.Windows.Forms.Label();
            this.btn_admin_func = new System.Windows.Forms.Button();
            this.btn_doctor_func = new System.Windows.Forms.Button();
            this.btn_my_appointments = new System.Windows.Forms.Button();
            this.llbl_edit_data = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_zapis_na_priem
            // 
            this.btn_zapis_na_priem.Location = new System.Drawing.Point(39, 261);
            this.btn_zapis_na_priem.Name = "btn_zapis_na_priem";
            this.btn_zapis_na_priem.Size = new System.Drawing.Size(253, 82);
            this.btn_zapis_na_priem.TabIndex = 0;
            this.btn_zapis_na_priem.Text = "Запись на приём";
            this.btn_zapis_na_priem.UseVisualStyleBackColor = true;
            this.btn_zapis_na_priem.Click += new System.EventHandler(this.btn_zapis_na_priem_Click);
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Location = new System.Drawing.Point(58, 46);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(107, 16);
            this.lbl_hello.TabIndex = 1;
            this.lbl_hello.Text = "Здравствуйте, ";
            // 
            // lbl_you_are
            // 
            this.lbl_you_are.AutoSize = true;
            this.lbl_you_are.Location = new System.Drawing.Point(58, 71);
            this.lbl_you_are.Name = "lbl_you_are";
            this.lbl_you_are.Size = new System.Drawing.Size(100, 16);
            this.lbl_you_are.TabIndex = 2;
            this.lbl_you_are.Text = "Вы вошли как: ";
            // 
            // btn_admin_func
            // 
            this.btn_admin_func.Location = new System.Drawing.Point(514, 261);
            this.btn_admin_func.Name = "btn_admin_func";
            this.btn_admin_func.Size = new System.Drawing.Size(253, 82);
            this.btn_admin_func.TabIndex = 3;
            this.btn_admin_func.Text = "Админ - панель";
            this.btn_admin_func.UseVisualStyleBackColor = true;
            this.btn_admin_func.Click += new System.EventHandler(this.btn_admin_func_Click);
            // 
            // btn_doctor_func
            // 
            this.btn_doctor_func.Location = new System.Drawing.Point(514, 365);
            this.btn_doctor_func.Name = "btn_doctor_func";
            this.btn_doctor_func.Size = new System.Drawing.Size(253, 82);
            this.btn_doctor_func.TabIndex = 4;
            this.btn_doctor_func.Text = "Доктор - панель";
            this.btn_doctor_func.UseVisualStyleBackColor = true;
            this.btn_doctor_func.Click += new System.EventHandler(this.btn_doctor_func_Click);
            // 
            // btn_my_appointments
            // 
            this.btn_my_appointments.Location = new System.Drawing.Point(39, 365);
            this.btn_my_appointments.Name = "btn_my_appointments";
            this.btn_my_appointments.Size = new System.Drawing.Size(253, 82);
            this.btn_my_appointments.TabIndex = 5;
            this.btn_my_appointments.Text = "Мои записи";
            this.btn_my_appointments.UseVisualStyleBackColor = true;
            this.btn_my_appointments.Click += new System.EventHandler(this.btn_my_appointments_Click);
            // 
            // llbl_edit_data
            // 
            this.llbl_edit_data.AutoSize = true;
            this.llbl_edit_data.Location = new System.Drawing.Point(61, 97);
            this.llbl_edit_data.Name = "llbl_edit_data";
            this.llbl_edit_data.Size = new System.Drawing.Size(160, 16);
            this.llbl_edit_data.TabIndex = 6;
            this.llbl_edit_data.TabStop = true;
            this.llbl_edit_data.Text = "Редактировать данные";
            this.llbl_edit_data.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_edit_data_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(432, 232);
            this.dataGridView1.TabIndex = 7;
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.llbl_edit_data);
            this.Controls.Add(this.btn_my_appointments);
            this.Controls.Add(this.btn_doctor_func);
            this.Controls.Add(this.btn_admin_func);
            this.Controls.Add(this.lbl_you_are);
            this.Controls.Add(this.lbl_hello);
            this.Controls.Add(this.btn_zapis_na_priem);
            this.Name = "FormAccount";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_zapis_na_priem;
        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.Label lbl_you_are;
        private System.Windows.Forms.Button btn_admin_func;
        private System.Windows.Forms.Button btn_doctor_func;
        private System.Windows.Forms.Button btn_my_appointments;
        private System.Windows.Forms.LinkLabel llbl_edit_data;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}