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
            this.tableAdapterManager1 = new WindowsFormsAppHospital.my_appointmentsDataSetTableAdapters.TableAdapterManager();
            this.dgv_my_appointments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_appointments)).BeginInit();
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
            this.dgv_my_appointments.Location = new System.Drawing.Point(279, 6);
            this.dgv_my_appointments.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_my_appointments.Name = "dgv_my_appointments";
            this.dgv_my_appointments.ReadOnly = true;
            this.dgv_my_appointments.RowHeadersVisible = false;
            this.dgv_my_appointments.RowHeadersWidth = 51;
            this.dgv_my_appointments.RowTemplate.Height = 24;
            this.dgv_my_appointments.Size = new System.Drawing.Size(483, 439);
            this.dgv_my_appointments.TabIndex = 8;
            // 
            // FormDoctorAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_my_appointments);
            this.Name = "FormDoctorAcc";
            this.Text = "FormDoctorAcc";
            this.Load += new System.EventHandler(this.FormDoctorAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_appointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private my_appointmentsDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dgv_my_appointments;
    }
}