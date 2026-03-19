namespace WindowsFormsAppHospital
{
    partial class FormDoctorAcc
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
            this.tableAdapterManager1 = new WindowsFormsAppHospital.my_appointmentsDataSetTableAdapters.TableAdapterManager();
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
            this.vwmyappointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hdb1103DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hdb1103DataSet = new WindowsFormsAppHospital.hdb1103DataSet();
            this.pb_set = new System.Windows.Forms.PictureBox();
            this.btn_select_photo = new System.Windows.Forms.Button();
            this.btn_add_photo = new System.Windows.Forms.Button();
            this.btn_upload_appointments = new System.Windows.Forms.Button();
            this.vw_my_appointmentsTableAdapter = new WindowsFormsAppHospital.hdb1103DataSetTableAdapters.vw_my_appointmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_appointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwmyappointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdb1103DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdb1103DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_set)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsAppHospital.my_appointmentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.dgv_my_appointments.DataSource = this.vwmyappointmentsBindingSource;
            this.dgv_my_appointments.Location = new System.Drawing.Point(275, 11);
            this.dgv_my_appointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_my_appointments.Name = "dgv_my_appointments";
            this.dgv_my_appointments.ReadOnly = true;
            this.dgv_my_appointments.RowHeadersVisible = false;
            this.dgv_my_appointments.RowHeadersWidth = 51;
            this.dgv_my_appointments.RowTemplate.Height = 24;
            this.dgv_my_appointments.Size = new System.Drawing.Size(833, 550);
            this.dgv_my_appointments.TabIndex = 8;
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
            // vwmyappointmentsBindingSource
            // 
            this.vwmyappointmentsBindingSource.DataMember = "vw_my_appointments";
            this.vwmyappointmentsBindingSource.DataSource = this.hdb1103DataSetBindingSource;
            // 
            // hdb1103DataSetBindingSource
            // 
            this.hdb1103DataSetBindingSource.DataSource = this.hdb1103DataSet;
            this.hdb1103DataSetBindingSource.Position = 0;
            // 
            // hdb1103DataSet
            // 
            this.hdb1103DataSet.DataSetName = "hdb1103DataSet";
            this.hdb1103DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pb_set
            // 
            this.pb_set.Location = new System.Drawing.Point(33, 26);
            this.pb_set.Margin = new System.Windows.Forms.Padding(4);
            this.pb_set.Name = "pb_set";
            this.pb_set.Size = new System.Drawing.Size(172, 145);
            this.pb_set.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_set.TabIndex = 9;
            this.pb_set.TabStop = false;
            // 
            // btn_select_photo
            // 
            this.btn_select_photo.Location = new System.Drawing.Point(33, 190);
            this.btn_select_photo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_select_photo.Name = "btn_select_photo";
            this.btn_select_photo.Size = new System.Drawing.Size(172, 65);
            this.btn_select_photo.TabIndex = 10;
            this.btn_select_photo.Text = "Выбрать фото";
            this.btn_select_photo.UseVisualStyleBackColor = true;
            this.btn_select_photo.Click += new System.EventHandler(this.btn_select_photo_Click);
            // 
            // btn_add_photo
            // 
            this.btn_add_photo.Location = new System.Drawing.Point(33, 262);
            this.btn_add_photo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_photo.Name = "btn_add_photo";
            this.btn_add_photo.Size = new System.Drawing.Size(172, 65);
            this.btn_add_photo.TabIndex = 11;
            this.btn_add_photo.Text = "Добавить фото";
            this.btn_add_photo.UseVisualStyleBackColor = true;
            this.btn_add_photo.Click += new System.EventHandler(this.btn_add_photo_Click);
            // 
            // btn_upload_appointments
            // 
            this.btn_upload_appointments.Location = new System.Drawing.Point(33, 378);
            this.btn_upload_appointments.Margin = new System.Windows.Forms.Padding(4);
            this.btn_upload_appointments.Name = "btn_upload_appointments";
            this.btn_upload_appointments.Size = new System.Drawing.Size(172, 65);
            this.btn_upload_appointments.TabIndex = 12;
            this.btn_upload_appointments.Text = "Обновить записи";
            this.btn_upload_appointments.UseVisualStyleBackColor = true;
            this.btn_upload_appointments.Click += new System.EventHandler(this.btn_upload_appointments_Click);
            // 
            // vw_my_appointmentsTableAdapter
            // 
            this.vw_my_appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // FormDoctorAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1120, 572);
            this.Controls.Add(this.btn_upload_appointments);
            this.Controls.Add(this.btn_add_photo);
            this.Controls.Add(this.btn_select_photo);
            this.Controls.Add(this.pb_set);
            this.Controls.Add(this.dgv_my_appointments);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDoctorAcc";
            this.Text = "FormDoctorAcc";
            this.Load += new System.EventHandler(this.FormDoctorAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_appointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwmyappointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdb1103DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdb1103DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_set)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private my_appointmentsDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dgv_my_appointments;
        private System.Windows.Forms.PictureBox pb_set;
        private System.Windows.Forms.Button btn_select_photo;
        private System.Windows.Forms.Button btn_add_photo;
        private System.Windows.Forms.Button btn_upload_appointments;
        private System.Windows.Forms.BindingSource hdb1103DataSetBindingSource;
        private hdb1103DataSet hdb1103DataSet;
        private System.Windows.Forms.BindingSource vwmyappointmentsBindingSource;
        private hdb1103DataSetTableAdapters.vw_my_appointmentsTableAdapter vw_my_appointmentsTableAdapter;
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
    }
}