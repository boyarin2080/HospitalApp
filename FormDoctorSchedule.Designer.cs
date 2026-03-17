namespace WindowsFormsAppHospital
{
    partial class FormDoctorSchedule
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgv_doctor_schedule = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_doctor_icon = new System.Windows.Forms.PictureBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_doctor_fio = new System.Windows.Forms.ComboBox();
            this.dtp_schedule_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_specandhosp = new System.Windows.Forms.Label();
            this.cms_create_appointment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.записатьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctor_schedule)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_doctor_icon)).BeginInit();
            this.cms_create_appointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 608);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1133, 2);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // dgv_doctor_schedule
            // 
            this.dgv_doctor_schedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_doctor_schedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_doctor_schedule.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_doctor_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doctor_schedule.Location = new System.Drawing.Point(12, 205);
            this.dgv_doctor_schedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_doctor_schedule.Name = "dgv_doctor_schedule";
            this.dgv_doctor_schedule.ReadOnly = true;
            this.dgv_doctor_schedule.RowHeadersWidth = 51;
            this.dgv_doctor_schedule.RowTemplate.Height = 24;
            this.dgv_doctor_schedule.Size = new System.Drawing.Size(1109, 394);
            this.dgv_doctor_schedule.TabIndex = 8;
            this.dgv_doctor_schedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_doctor_schedule_CellContentClick);
            this.dgv_doctor_schedule.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_doctor_schedule_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pb_doctor_icon);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.cb_doctor_fio);
            this.panel1.Controls.Add(this.dtp_schedule_date);
            this.panel1.Controls.Add(this.lbl_specandhosp);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 144);
            this.panel1.TabIndex = 9;
            // 
            // pb_doctor_icon
            // 
            this.pb_doctor_icon.Location = new System.Drawing.Point(351, 13);
            this.pb_doctor_icon.Margin = new System.Windows.Forms.Padding(4);
            this.pb_doctor_icon.Name = "pb_doctor_icon";
            this.pb_doctor_icon.Size = new System.Drawing.Size(124, 108);
            this.pb_doctor_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_doctor_icon.TabIndex = 8;
            this.pb_doctor_icon.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(512, 28);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(133, 62);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Поиск";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_doctor_fio
            // 
            this.cb_doctor_fio.FormattingEnabled = true;
            this.cb_doctor_fio.Location = new System.Drawing.Point(65, 63);
            this.cb_doctor_fio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_doctor_fio.Name = "cb_doctor_fio";
            this.cb_doctor_fio.Size = new System.Drawing.Size(212, 24);
            this.cb_doctor_fio.TabIndex = 6;
            // 
            // dtp_schedule_date
            // 
            this.dtp_schedule_date.Location = new System.Drawing.Point(885, 62);
            this.dtp_schedule_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_schedule_date.Name = "dtp_schedule_date";
            this.dtp_schedule_date.Size = new System.Drawing.Size(188, 22);
            this.dtp_schedule_date.TabIndex = 5;
            // 
            // lbl_specandhosp
            // 
            this.lbl_specandhosp.AutoSize = true;
            this.lbl_specandhosp.Location = new System.Drawing.Point(61, 30);
            this.lbl_specandhosp.Name = "lbl_specandhosp";
            this.lbl_specandhosp.Size = new System.Drawing.Size(154, 16);
            this.lbl_specandhosp.TabIndex = 4;
            this.lbl_specandhosp.Text = "Врачи по параметрам:";
            // 
            // cms_create_appointment
            // 
            this.cms_create_appointment.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_create_appointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записатьсяToolStripMenuItem});
            this.cms_create_appointment.Name = "cms_create_appointment";
            this.cms_create_appointment.Size = new System.Drawing.Size(157, 28);
            // 
            // записатьсяToolStripMenuItem
            // 
            this.записатьсяToolStripMenuItem.Name = "записатьсяToolStripMenuItem";
            this.записатьсяToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.записатьсяToolStripMenuItem.Text = "Записаться";
            this.записатьсяToolStripMenuItem.Click += new System.EventHandler(this.записатьсяToolStripMenuItem_Click);
            // 
            // FormDoctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1133, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_doctor_schedule);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDoctorSchedule";
            this.Text = "Расписание врача";
            this.Load += new System.EventHandler(this.FormDoctorSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctor_schedule)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_doctor_icon)).EndInit();
            this.cms_create_appointment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dgv_doctor_schedule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_doctor_fio;
        private System.Windows.Forms.DateTimePicker dtp_schedule_date;
        private System.Windows.Forms.Label lbl_specandhosp;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ContextMenuStrip cms_create_appointment;
        private System.Windows.Forms.ToolStripMenuItem записатьсяToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_doctor_icon;
    }
}