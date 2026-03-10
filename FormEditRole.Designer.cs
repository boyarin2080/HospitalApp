namespace WindowsFormsAppHospital
{
    partial class FormEditRole
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
            this.cb_SelectRole = new System.Windows.Forms.ComboBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.btn_editrole = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_SelectRole
            // 
            this.cb_SelectRole.FormattingEnabled = true;
            this.cb_SelectRole.Location = new System.Drawing.Point(33, 55);
            this.cb_SelectRole.Name = "cb_SelectRole";
            this.cb_SelectRole.Size = new System.Drawing.Size(194, 21);
            this.cb_SelectRole.TabIndex = 0;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(41, 25);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(171, 13);
            this.lbl_role.TabIndex = 1;
            this.lbl_role.Text = "Выберите присваеваемую роль:";
            // 
            // btn_editrole
            // 
            this.btn_editrole.Location = new System.Drawing.Point(67, 115);
            this.btn_editrole.Name = "btn_editrole";
            this.btn_editrole.Size = new System.Drawing.Size(124, 49);
            this.btn_editrole.TabIndex = 2;
            this.btn_editrole.Text = "Изменить";
            this.btn_editrole.UseVisualStyleBackColor = true;
            this.btn_editrole.Click += new System.EventHandler(this.btn_editrole_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текущая роль пользователя: ";
            // 
            // FormEditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(270, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_editrole);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.cb_SelectRole);
            this.Name = "FormEditRole";
            this.Text = "Изменение роли";
            this.Load += new System.EventHandler(this.FormEditRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_SelectRole;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Button btn_editrole;
        private System.Windows.Forms.Label label1;
    }
}