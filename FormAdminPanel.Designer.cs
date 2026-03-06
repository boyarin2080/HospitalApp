namespace WindowsFormsAppHospital
{
    partial class FormAdminPanel
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
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.btn_EditAppointments = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSM_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_admin_utility = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_utility)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.Location = new System.Drawing.Point(27, 167);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(228, 76);
            this.btn_EditUser.TabIndex = 0;
            this.btn_EditUser.Text = "Выдача ролей пользователям";
            this.btn_EditUser.UseVisualStyleBackColor = true;
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // btn_EditAppointments
            // 
            this.btn_EditAppointments.Location = new System.Drawing.Point(27, 73);
            this.btn_EditAppointments.Name = "btn_EditAppointments";
            this.btn_EditAppointments.Size = new System.Drawing.Size(228, 74);
            this.btn_EditAppointments.TabIndex = 1;
            this.btn_EditAppointments.Text = "Редактировать записи";
            this.btn_EditAppointments.UseVisualStyleBackColor = true;
            this.btn_EditAppointments.Click += new System.EventHandler(this.btn_EditAppointments_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSM_Exit
            // 
            this.TSM_Exit.Name = "TSM_Exit";
            this.TSM_Exit.Size = new System.Drawing.Size(54, 20);
            this.TSM_Exit.Text = "Выход";
            this.TSM_Exit.Click += new System.EventHandler(this.TSM_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вы вошли как Администратор";
            // 
            // dgv_admin_utility
            // 
            this.dgv_admin_utility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin_utility.Location = new System.Drawing.Point(305, 40);
            this.dgv_admin_utility.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_admin_utility.Name = "dgv_admin_utility";
            this.dgv_admin_utility.ReadOnly = true;
            this.dgv_admin_utility.RowHeadersVisible = false;
            this.dgv_admin_utility.RowHeadersWidth = 51;
            this.dgv_admin_utility.RowTemplate.Height = 24;
            this.dgv_admin_utility.Size = new System.Drawing.Size(701, 492);
            this.dgv_admin_utility.TabIndex = 8;
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1034, 562);
            this.Controls.Add(this.dgv_admin_utility);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_EditAppointments);
            this.Controls.Add(this.btn_EditUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdminPanel";
            this.Text = "Панель Администратора";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_utility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.Button btn_EditAppointments;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSM_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_admin_utility;
    }
}