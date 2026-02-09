namespace WindowsFormsAppHospital
{
    partial class FormLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.linkLb_reg = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(124, 247);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(206, 78);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Авторизоваться";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(121, 198);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(206, 22);
            this.tb_password.TabIndex = 1;
            this.tb_password.Text = "qwerty";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(124, 138);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(206, 22);
            this.tb_login.TabIndex = 2;
            this.tb_login.Text = "user@mail.ru";
            // 
            // linkLb_reg
            // 
            this.linkLb_reg.AutoSize = true;
            this.linkLb_reg.Location = new System.Drawing.Point(150, 343);
            this.linkLb_reg.Name = "linkLb_reg";
            this.linkLb_reg.Size = new System.Drawing.Size(155, 16);
            this.linkLb_reg.TabIndex = 3;
            this.linkLb_reg.TabStop = true;
            this.linkLb_reg.Text = "Я не зарегистрирован";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин (email)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLb_reg);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.btn_login);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.LinkLabel linkLb_reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

