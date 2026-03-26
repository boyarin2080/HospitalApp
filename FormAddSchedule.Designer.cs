namespace WindowsFormsAppHospital
{
    partial class FormAddSchedule
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
            this.dgv_selectschedule = new System.Windows.Forms.DataGridView();
            this.btn_addschedule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_slotduration = new System.Windows.Forms.NumericUpDown();
            this.dtp_validfrom = new System.Windows.Forms.DateTimePicker();
            this.dtp_validuntil = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectschedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_slotduration)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_selectschedule
            // 
            this.dgv_selectschedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_selectschedule.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_selectschedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selectschedule.Location = new System.Drawing.Point(25, 24);
            this.dgv_selectschedule.Name = "dgv_selectschedule";
            this.dgv_selectschedule.RowHeadersWidth = 51;
            this.dgv_selectschedule.RowTemplate.Height = 24;
            this.dgv_selectschedule.Size = new System.Drawing.Size(1155, 306);
            this.dgv_selectschedule.TabIndex = 0;
            // 
            // btn_addschedule
            // 
            this.btn_addschedule.Location = new System.Drawing.Point(905, 357);
            this.btn_addschedule.Name = "btn_addschedule";
            this.btn_addschedule.Size = new System.Drawing.Size(259, 97);
            this.btn_addschedule.TabIndex = 1;
            this.btn_addschedule.Text = "Добавить расписание";
            this.btn_addschedule.UseVisualStyleBackColor = true;
            this.btn_addschedule.Click += new System.EventHandler(this.btn_addschedule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вы редактируете врача с ID = ";
            // 
            // numericUpDown_slotduration
            // 
            this.numericUpDown_slotduration.Location = new System.Drawing.Point(720, 357);
            this.numericUpDown_slotduration.Name = "numericUpDown_slotduration";
            this.numericUpDown_slotduration.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown_slotduration.TabIndex = 3;
            this.numericUpDown_slotduration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_slotduration.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // dtp_validfrom
            // 
            this.dtp_validfrom.Location = new System.Drawing.Point(680, 392);
            this.dtp_validfrom.MinDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtp_validfrom.Name = "dtp_validfrom";
            this.dtp_validfrom.Size = new System.Drawing.Size(200, 22);
            this.dtp_validfrom.TabIndex = 4;
            this.dtp_validfrom.Value = new System.DateTime(2026, 3, 25, 0, 0, 0, 0);
            // 
            // dtp_validuntil
            // 
            this.dtp_validuntil.Location = new System.Drawing.Point(680, 432);
            this.dtp_validuntil.MinDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtp_validuntil.Name = "dtp_validuntil";
            this.dtp_validuntil.Size = new System.Drawing.Size(200, 22);
            this.dtp_validuntil.TabIndex = 5;
            this.dtp_validuntil.Value = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Время приёма (мин):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Актуально с:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Актуально до:";
            // 
            // FormAddSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1198, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_validuntil);
            this.Controls.Add(this.dtp_validfrom);
            this.Controls.Add(this.numericUpDown_slotduration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addschedule);
            this.Controls.Add(this.dgv_selectschedule);
            this.Name = "FormAddSchedule";
            this.Text = "Добавление расписания";
            this.Load += new System.EventHandler(this.FormAddSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectschedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_slotduration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_selectschedule;
        private System.Windows.Forms.Button btn_addschedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_slotduration;
        private System.Windows.Forms.DateTimePicker dtp_validfrom;
        private System.Windows.Forms.DateTimePicker dtp_validuntil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}