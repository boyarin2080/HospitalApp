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
            this.components = new System.ComponentModel.Container();
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.btn_EditAppointments = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSM_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_AllAppointments = new System.Windows.Forms.DataGridView();
            this.cms_EditAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_AllUsers = new System.Windows.Forms.DataGridView();
            this.cms_EditUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_EditRole = new System.Windows.Forms.ToolStripMenuItem();
            this.csm_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_deleteuser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllAppointments)).BeginInit();
            this.cms_EditAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllUsers)).BeginInit();
            this.cms_EditUsers.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1285, 24);
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
            // dgv_AllAppointments
            // 
            this.dgv_AllAppointments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_AllAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllAppointments.Location = new System.Drawing.Point(289, 40);
            this.dgv_AllAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_AllAppointments.Name = "dgv_AllAppointments";
            this.dgv_AllAppointments.ReadOnly = true;
            this.dgv_AllAppointments.RowHeadersVisible = false;
            this.dgv_AllAppointments.RowHeadersWidth = 51;
            this.dgv_AllAppointments.RowTemplate.Height = 24;
            this.dgv_AllAppointments.Size = new System.Drawing.Size(928, 431);
            this.dgv_AllAppointments.TabIndex = 8;
            this.dgv_AllAppointments.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_admin_utility_CellMouseClick);
            // 
            // cms_EditAppointments
            // 
            this.cms_EditAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_edit,
            this.cms_remove});
            this.cms_EditAppointments.Name = "contextMenuStrip1";
            this.cms_EditAppointments.Size = new System.Drawing.Size(155, 48);
            // 
            // cms_edit
            // 
            this.cms_edit.Name = "cms_edit";
            this.cms_edit.Size = new System.Drawing.Size(154, 22);
            this.cms_edit.Text = "Редактировать";
            this.cms_edit.Click += new System.EventHandler(this.cms_edit_Click);
            // 
            // cms_remove
            // 
            this.cms_remove.Name = "cms_remove";
            this.cms_remove.Size = new System.Drawing.Size(154, 22);
            this.cms_remove.Text = "Удалить";
            this.cms_remove.Click += new System.EventHandler(this.cms_remove_Click);
            // 
            // dgv_AllUsers
            // 
            this.dgv_AllUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_AllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllUsers.Location = new System.Drawing.Point(289, 40);
            this.dgv_AllUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_AllUsers.Name = "dgv_AllUsers";
            this.dgv_AllUsers.ReadOnly = true;
            this.dgv_AllUsers.RowHeadersVisible = false;
            this.dgv_AllUsers.RowHeadersWidth = 51;
            this.dgv_AllUsers.RowTemplate.Height = 24;
            this.dgv_AllUsers.Size = new System.Drawing.Size(928, 431);
            this.dgv_AllUsers.TabIndex = 9;
            this.dgv_AllUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_AllUsers_CellMouseClick);
            // 
            // cms_EditUsers
            // 
            this.cms_EditUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_EditRole,
            this.csm_edit,
            this.cms_deleteuser});
            this.cms_EditUsers.Name = "cms_EditUsers";
            this.cms_EditUsers.Size = new System.Drawing.Size(159, 70);
            // 
            // cms_EditRole
            // 
            this.cms_EditRole.Name = "cms_EditRole";
            this.cms_EditRole.Size = new System.Drawing.Size(158, 22);
            this.cms_EditRole.Text = "Изменить роль";
            this.cms_EditRole.Click += new System.EventHandler(this.cms_EditRole_Click);
            // 
            // csm_edit
            // 
            this.csm_edit.Name = "csm_edit";
            this.csm_edit.Size = new System.Drawing.Size(158, 22);
            this.csm_edit.Text = "Редактировать";
            // 
            // cms_deleteuser
            // 
            this.cms_deleteuser.Name = "cms_deleteuser";
            this.cms_deleteuser.Size = new System.Drawing.Size(158, 22);
            this.cms_deleteuser.Text = "Удалить";
            this.cms_deleteuser.Click += new System.EventHandler(this.cms_deleteuser_Click);
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1285, 562);
            this.Controls.Add(this.dgv_AllUsers);
            this.Controls.Add(this.dgv_AllAppointments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_EditAppointments);
            this.Controls.Add(this.btn_EditUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdminPanel";
            this.Text = "Панель Администратора";
            this.Load += new System.EventHandler(this.FormAdminPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllAppointments)).EndInit();
            this.cms_EditAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllUsers)).EndInit();
            this.cms_EditUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.Button btn_EditAppointments;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSM_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_AllAppointments;
        private System.Windows.Forms.ContextMenuStrip cms_EditAppointments;
        private System.Windows.Forms.ToolStripMenuItem cms_edit;
        private System.Windows.Forms.ToolStripMenuItem cms_remove;
        private System.Windows.Forms.DataGridView dgv_AllUsers;
        private System.Windows.Forms.ContextMenuStrip cms_EditUsers;
        private System.Windows.Forms.ToolStripMenuItem cms_EditRole;
        private System.Windows.Forms.ToolStripMenuItem csm_edit;
        private System.Windows.Forms.ToolStripMenuItem cms_deleteuser;
    }
}