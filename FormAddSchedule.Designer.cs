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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectschedule)).BeginInit();
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
            // 
            // FormAddSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1198, 493);
            this.Controls.Add(this.btn_addschedule);
            this.Controls.Add(this.dgv_selectschedule);
            this.Name = "FormAddSchedule";
            this.Text = "Добавление расписания";
            this.Load += new System.EventHandler(this.FormAddSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectschedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_selectschedule;
        private System.Windows.Forms.Button btn_addschedule;
    }
}