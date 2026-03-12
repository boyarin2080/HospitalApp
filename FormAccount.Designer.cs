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
            this.components = new System.ComponentModel.Container();
            this.btn_zapis_na_priem = new System.Windows.Forms.Button();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.lbl_you_are = new System.Windows.Forms.Label();
            this.btn_admin_func = new System.Windows.Forms.Button();
            this.btn_doctor_func = new System.Windows.Forms.Button();
            this.btn_my_appointments = new System.Windows.Forms.Button();
            this.llbl_edit_data = new System.Windows.Forms.LinkLabel();
            this.dgv_my_appointments = new System.Windows.Forms.DataGridView();
            this.vwmyappointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.my_appointmentsDataSet = new WindowsFormsAppHospital.my_appointmentsDataSet();
            this.vw_my_appointmentsTableAdapter = new WindowsFormsAppHospital.my_appointmentsDataSetTableAdapters.vw_my_appointmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_appointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwmyappointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_appointmentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_zapis_na_priem
            // 
            this.btn_zapis_na_priem.Location = new System.Drawing.Point(36, 156);
            this.btn_zapis_na_priem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lbl_hello.Location = new System.Drawing.Point(33, 33);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(107, 16);
            this.lbl_hello.TabIndex = 1;
            this.lbl_hello.Text = "Здравствуйте, ";
            // 
            // lbl_you_are
            // 
            this.lbl_you_are.AutoSize = true;
            this.lbl_you_are.Location = new System.Drawing.Point(35, 69);
            this.lbl_you_are.Name = "lbl_you_are";
            this.lbl_you_are.Size = new System.Drawing.Size(100, 16);
            this.lbl_you_are.TabIndex = 2;
            this.lbl_you_are.Text = "Вы вошли как: ";
            // 
            // btn_admin_func
            // 
            this.btn_admin_func.Location = new System.Drawing.Point(36, 361);
            this.btn_admin_func.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_admin_func.Name = "btn_admin_func";
            this.btn_admin_func.Size = new System.Drawing.Size(253, 82);
            this.btn_admin_func.TabIndex = 3;
            this.btn_admin_func.Text = "Админ - панель";
            this.btn_admin_func.UseVisualStyleBackColor = true;
            this.btn_admin_func.Click += new System.EventHandler(this.btn_admin_func_Click);
            // 
            // btn_doctor_func
            // 
            this.btn_doctor_func.Location = new System.Drawing.Point(36, 465);
            this.btn_doctor_func.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_doctor_func.Name = "btn_doctor_func";
            this.btn_doctor_func.Size = new System.Drawing.Size(253, 82);
            this.btn_doctor_func.TabIndex = 4;
            this.btn_doctor_func.Text = "Доктор - панель";
            this.btn_doctor_func.UseVisualStyleBackColor = true;
            this.btn_doctor_func.Click += new System.EventHandler(this.btn_doctor_func_Click);
            // 
            // btn_my_appointments
            // 
            this.btn_my_appointments.Location = new System.Drawing.Point(36, 260);
            this.btn_my_appointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.llbl_edit_data.Location = new System.Drawing.Point(33, 101);
            this.llbl_edit_data.Name = "llbl_edit_data";
            this.llbl_edit_data.Size = new System.Drawing.Size(160, 16);
            this.llbl_edit_data.TabIndex = 6;
            this.llbl_edit_data.TabStop = true;
            this.llbl_edit_data.Text = "Редактировать данные";
            this.llbl_edit_data.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_edit_data_LinkClicked);
            // 
            // dgv_my_appointments
            // 
            this.dgv_my_appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_my_appointments.Location = new System.Drawing.Point(325, 12);
            this.dgv_my_appointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_my_appointments.Name = "dgv_my_appointments";
            this.dgv_my_appointments.ReadOnly = true;
            this.dgv_my_appointments.RowHeadersVisible = false;
            this.dgv_my_appointments.RowHeadersWidth = 51;
            this.dgv_my_appointments.RowTemplate.Height = 24;
            this.dgv_my_appointments.Size = new System.Drawing.Size(965, 540);
            this.dgv_my_appointments.TabIndex = 7;
            // 
            // vwmyappointmentsBindingSource
            // 
            this.vwmyappointmentsBindingSource.DataMember = "vw_my_appointments";
            this.vwmyappointmentsBindingSource.DataSource = this.my_appointmentsDataSet;
            // 
            // my_appointmentsDataSet
            // 
            this.my_appointmentsDataSet.DataSetName = "my_appointmentsDataSet";
            this.my_appointmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_my_appointmentsTableAdapter
            // 
            this.vw_my_appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1323, 572);
            this.Controls.Add(this.dgv_my_appointments);
            this.Controls.Add(this.llbl_edit_data);
            this.Controls.Add(this.btn_my_appointments);
            this.Controls.Add(this.btn_doctor_func);
            this.Controls.Add(this.btn_admin_func);
            this.Controls.Add(this.lbl_you_are);
            this.Controls.Add(this.lbl_hello);
            this.Controls.Add(this.btn_zapis_na_priem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAccount";
            this.Text = "Личный Кабинет";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_appointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwmyappointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_appointmentsDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_my_appointments;
        private my_appointmentsDataSet my_appointmentsDataSet;
        private System.Windows.Forms.BindingSource vwmyappointmentsBindingSource;
        private my_appointmentsDataSetTableAdapters.vw_my_appointmentsTableAdapter vw_my_appointmentsTableAdapter;
    }
}