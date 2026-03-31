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
            this.aidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияПользователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяЗаписиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жалобаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.диагнозDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwmyappointmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hdb1103DataSet = new WindowsFormsAppHospital.hdb1103DataSet();
            this.vwmyappointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.my_appointmentsDataSet = new WindowsFormsAppHospital.my_appointmentsDataSet();
            this.vw_my_appointmentsTableAdapter = new WindowsFormsAppHospital.my_appointmentsDataSetTableAdapters.vw_my_appointmentsTableAdapter();
            this.vw_my_appointmentsTableAdapter1 = new WindowsFormsAppHospital.hdb1103DataSetTableAdapters.vw_my_appointmentsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_appointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwmyappointmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdb1103DataSet)).BeginInit();
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
            this.dgv_my_appointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_my_appointments.AutoGenerateColumns = false;
            this.dgv_my_appointments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_my_appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_my_appointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aidDataGridViewTextBoxColumn,
            this.фамилияПользователяDataGridViewTextBoxColumn,
            this.специальностьВрачаDataGridViewTextBoxColumn,
            this.фамилияВрачаDataGridViewTextBoxColumn,
            this.времяЗаписиDataGridViewTextBoxColumn,
            this.жалобаDataGridViewTextBoxColumn,
            this.диагнозDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.patientidDataGridViewTextBoxColumn,
            this.doctoridDataGridViewTextBoxColumn});
            this.dgv_my_appointments.DataSource = this.vwmyappointmentsBindingSource1;
            this.dgv_my_appointments.Location = new System.Drawing.Point(309, 33);
            this.dgv_my_appointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_my_appointments.Name = "dgv_my_appointments";
            this.dgv_my_appointments.ReadOnly = true;
            this.dgv_my_appointments.RowHeadersVisible = false;
            this.dgv_my_appointments.RowHeadersWidth = 51;
            this.dgv_my_appointments.RowTemplate.Height = 24;
            this.dgv_my_appointments.Size = new System.Drawing.Size(893, 518);
            this.dgv_my_appointments.TabIndex = 7;
            // 
            // aidDataGridViewTextBoxColumn
            // 
            this.aidDataGridViewTextBoxColumn.DataPropertyName = "Aid";
            this.aidDataGridViewTextBoxColumn.HeaderText = "ID Записи";
            this.aidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aidDataGridViewTextBoxColumn.Name = "aidDataGridViewTextBoxColumn";
            this.aidDataGridViewTextBoxColumn.ReadOnly = true;
            this.aidDataGridViewTextBoxColumn.Width = 70;
            // 
            // фамилияПользователяDataGridViewTextBoxColumn
            // 
            this.фамилияПользователяDataGridViewTextBoxColumn.DataPropertyName = "Фамилия Пользователя";
            this.фамилияПользователяDataGridViewTextBoxColumn.HeaderText = "Фамилия Пользователя";
            this.фамилияПользователяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияПользователяDataGridViewTextBoxColumn.Name = "фамилияПользователяDataGridViewTextBoxColumn";
            this.фамилияПользователяDataGridViewTextBoxColumn.ReadOnly = true;
            this.фамилияПользователяDataGridViewTextBoxColumn.Width = 125;
            // 
            // специальностьВрачаDataGridViewTextBoxColumn
            // 
            this.специальностьВрачаDataGridViewTextBoxColumn.DataPropertyName = "Специальность врача";
            this.специальностьВрачаDataGridViewTextBoxColumn.HeaderText = "Специальность врача";
            this.специальностьВрачаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.специальностьВрачаDataGridViewTextBoxColumn.Name = "специальностьВрачаDataGridViewTextBoxColumn";
            this.специальностьВрачаDataGridViewTextBoxColumn.ReadOnly = true;
            this.специальностьВрачаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияВрачаDataGridViewTextBoxColumn
            // 
            this.фамилияВрачаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия Врача";
            this.фамилияВрачаDataGridViewTextBoxColumn.HeaderText = "Фамилия Врача";
            this.фамилияВрачаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияВрачаDataGridViewTextBoxColumn.Name = "фамилияВрачаDataGridViewTextBoxColumn";
            this.фамилияВрачаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фамилияВрачаDataGridViewTextBoxColumn.Width = 125;
            // 
            // времяЗаписиDataGridViewTextBoxColumn
            // 
            this.времяЗаписиDataGridViewTextBoxColumn.DataPropertyName = "Время записи";
            this.времяЗаписиDataGridViewTextBoxColumn.HeaderText = "Время записи";
            this.времяЗаписиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяЗаписиDataGridViewTextBoxColumn.Name = "времяЗаписиDataGridViewTextBoxColumn";
            this.времяЗаписиDataGridViewTextBoxColumn.ReadOnly = true;
            this.времяЗаписиDataGridViewTextBoxColumn.Width = 125;
            // 
            // жалобаDataGridViewTextBoxColumn
            // 
            this.жалобаDataGridViewTextBoxColumn.DataPropertyName = "Жалоба";
            this.жалобаDataGridViewTextBoxColumn.HeaderText = "Жалоба";
            this.жалобаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.жалобаDataGridViewTextBoxColumn.Name = "жалобаDataGridViewTextBoxColumn";
            this.жалобаDataGridViewTextBoxColumn.ReadOnly = true;
            this.жалобаDataGridViewTextBoxColumn.Width = 125;
            // 
            // диагнозDataGridViewTextBoxColumn
            // 
            this.диагнозDataGridViewTextBoxColumn.DataPropertyName = "Диагноз";
            this.диагнозDataGridViewTextBoxColumn.HeaderText = "Диагноз";
            this.диагнозDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.диагнозDataGridViewTextBoxColumn.Name = "диагнозDataGridViewTextBoxColumn";
            this.диагнозDataGridViewTextBoxColumn.ReadOnly = true;
            this.диагнозDataGridViewTextBoxColumn.Width = 125;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.ReadOnly = true;
            this.статусDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientidDataGridViewTextBoxColumn
            // 
            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "patient_id";
            this.patientidDataGridViewTextBoxColumn.HeaderText = "patient_id";
            this.patientidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
            this.patientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientidDataGridViewTextBoxColumn.Visible = false;
            this.patientidDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctoridDataGridViewTextBoxColumn
            // 
            this.doctoridDataGridViewTextBoxColumn.DataPropertyName = "doctor_id";
            this.doctoridDataGridViewTextBoxColumn.HeaderText = "doctor_id";
            this.doctoridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctoridDataGridViewTextBoxColumn.Name = "doctoridDataGridViewTextBoxColumn";
            this.doctoridDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctoridDataGridViewTextBoxColumn.Visible = false;
            this.doctoridDataGridViewTextBoxColumn.Width = 125;
            // 
            // vwmyappointmentsBindingSource1
            // 
            this.vwmyappointmentsBindingSource1.DataMember = "vw_my_appointments";
            this.vwmyappointmentsBindingSource1.DataSource = this.hdb1103DataSet;
            // 
            // hdb1103DataSet
            // 
            this.hdb1103DataSet.DataSetName = "hdb1103DataSet";
            this.hdb1103DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // vw_my_appointmentsTableAdapter1
            // 
            this.vw_my_appointmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Мои записи:";
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1217, 565);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.vwmyappointmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdb1103DataSet)).EndInit();
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
        private hdb1103DataSet hdb1103DataSet;
        private System.Windows.Forms.BindingSource vwmyappointmentsBindingSource1;
        private hdb1103DataSetTableAdapters.vw_my_appointmentsTableAdapter vw_my_appointmentsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияПользователяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяЗаписиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жалобаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn диагнозDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}