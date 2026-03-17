namespace WindowsFormsAppHospital
{
    partial class FormDoctorPanel
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
            this.tableAdapterManager1 = new WindowsFormsAppHospital.my_appointmentsDataSetTableAdapters.TableAdapterManager();
            this.dgv_my_appointments = new System.Windows.Forms.DataGridView();
            this.pb_set = new System.Windows.Forms.PictureBox();
            this.btn_select_photo = new System.Windows.Forms.Button();
            this.btn_add_photo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_appointments)).BeginInit();
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
            this.dgv_my_appointments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_my_appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_my_appointments.Location = new System.Drawing.Point(372, 7);
            this.dgv_my_appointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_my_appointments.Name = "dgv_my_appointments";
            this.dgv_my_appointments.ReadOnly = true;
            this.dgv_my_appointments.RowHeadersVisible = false;
            this.dgv_my_appointments.RowHeadersWidth = 51;
            this.dgv_my_appointments.RowTemplate.Height = 24;
            this.dgv_my_appointments.Size = new System.Drawing.Size(644, 540);
            this.dgv_my_appointments.TabIndex = 8;
            // 
            // pb_set
            // 
            this.pb_set.Location = new System.Drawing.Point(33, 26);
            this.pb_set.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_set.Name = "pb_set";
            this.pb_set.Size = new System.Drawing.Size(172, 145);
            this.pb_set.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_set.TabIndex = 9;
            this.pb_set.TabStop = false;
            // 
            // btn_select_photo
            // 
            this.btn_select_photo.Location = new System.Drawing.Point(33, 190);
            this.btn_select_photo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_add_photo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add_photo.Name = "btn_add_photo";
            this.btn_add_photo.Size = new System.Drawing.Size(172, 65);
            this.btn_add_photo.TabIndex = 11;
            this.btn_add_photo.Text = "Добавить фото";
            this.btn_add_photo.UseVisualStyleBackColor = true;
            this.btn_add_photo.Click += new System.EventHandler(this.btn_add_photo_Click);
            // 
            // FormDoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_add_photo);
            this.Controls.Add(this.btn_select_photo);
            this.Controls.Add(this.pb_set);
            this.Controls.Add(this.dgv_my_appointments);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDoctorPanel";
            this.Text = "FormDoctorAcc";
            this.Load += new System.EventHandler(this.FormDoctorAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_appointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_set)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private my_appointmentsDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dgv_my_appointments;
        private System.Windows.Forms.PictureBox pb_set;
        private System.Windows.Forms.Button btn_select_photo;
        private System.Windows.Forms.Button btn_add_photo;
    }
}