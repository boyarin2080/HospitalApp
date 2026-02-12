namespace WindowsFormsAppHospital
{
    partial class FormReg
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
            this.btn_reg = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_patronymic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.CV = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.dTP_birth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_pass_2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(142, 295);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(249, 67);
            this.btn_reg.TabIndex = 0;
            this.btn_reg.Text = "Зарегистрироваться";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(77, 68);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(175, 22);
            this.tb_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(77, 114);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(175, 22);
            this.tb_surname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество";
            // 
            // tb_patronymic
            // 
            this.tb_patronymic.Location = new System.Drawing.Point(77, 164);
            this.tb_patronymic.Name = "tb_patronymic";
            this.tb_patronymic.Size = new System.Drawing.Size(175, 22);
            this.tb_patronymic.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер телефона";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(288, 68);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(175, 22);
            this.tb_phone.TabIndex = 7;
            // 
            // CV
            // 
            this.CV.AutoSize = true;
            this.CV.Location = new System.Drawing.Point(285, 95);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(136, 16);
            this.CV.TabIndex = 10;
            this.CV.Text = "Электронная почта";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(287, 114);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(175, 22);
            this.tb_email.TabIndex = 9;
            // 
            // dTP_birth
            // 
            this.dTP_birth.Location = new System.Drawing.Point(77, 217);
            this.dTP_birth.Name = "dTP_birth";
            this.dTP_birth.Size = new System.Drawing.Size(174, 22);
            this.dTP_birth.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата рождения";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(241, 374);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 16);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Войти";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(288, 164);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(176, 22);
            this.tb_pass.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Пароль";
            // 
            // tb_pass_2
            // 
            this.tb_pass_2.Location = new System.Drawing.Point(286, 217);
            this.tb_pass_2.Name = "tb_pass_2";
            this.tb_pass_2.Size = new System.Drawing.Size(176, 22);
            this.tb_pass_2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Подтвердите пароль";
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 424);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_pass_2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dTP_birth);
            this.Controls.Add(this.CV);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_patronymic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_reg);
            this.Name = "FormReg";
            this.Text = "FormReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_patronymic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label CV;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.DateTimePicker dTP_birth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_pass_2;
        private System.Windows.Forms.Label label7;
    }
}