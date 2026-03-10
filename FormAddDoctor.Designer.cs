namespace WindowsFormsAppHospital
{
    partial class FormAddDoctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddDoctor = new System.Windows.Forms.Button();
            this.cb_choose_spec = new System.Windows.Forms.ComboBox();
            this.cb_hospital_choose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь: ";
            // 
            // btn_AddDoctor
            // 
            this.btn_AddDoctor.Location = new System.Drawing.Point(38, 168);
            this.btn_AddDoctor.Name = "btn_AddDoctor";
            this.btn_AddDoctor.Size = new System.Drawing.Size(187, 47);
            this.btn_AddDoctor.TabIndex = 1;
            this.btn_AddDoctor.Text = "Добавить врача";
            this.btn_AddDoctor.UseVisualStyleBackColor = true;
            this.btn_AddDoctor.Click += new System.EventHandler(this.btn_AddDoctor_Click);
            // 
            // cb_choose_spec
            // 
            this.cb_choose_spec.FormattingEnabled = true;
            this.cb_choose_spec.Location = new System.Drawing.Point(38, 70);
            this.cb_choose_spec.Name = "cb_choose_spec";
            this.cb_choose_spec.Size = new System.Drawing.Size(187, 21);
            this.cb_choose_spec.TabIndex = 2;
            // 
            // cb_hospital_choose
            // 
            this.cb_hospital_choose.FormattingEnabled = true;
            this.cb_hospital_choose.Location = new System.Drawing.Point(38, 120);
            this.cb_hospital_choose.Name = "cb_hospital_choose";
            this.cb_hospital_choose.Size = new System.Drawing.Size(187, 21);
            this.cb_hospital_choose.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Специальность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отделение: ";
            // 
            // FormAddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(270, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_hospital_choose);
            this.Controls.Add(this.cb_choose_spec);
            this.Controls.Add(this.btn_AddDoctor);
            this.Controls.Add(this.label1);
            this.Name = "FormAddDoctor";
            this.Text = "Добавить врача";
            this.Load += new System.EventHandler(this.AddDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddDoctor;
        private System.Windows.Forms.ComboBox cb_choose_spec;
        private System.Windows.Forms.ComboBox cb_hospital_choose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}