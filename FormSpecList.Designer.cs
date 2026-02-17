namespace WindowsFormsAppHospital
{
    partial class FormSpecList
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
            this.lb_hello = new System.Windows.Forms.Label();
            this.cb_choose_spec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_choose_doc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_hospital_choose = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_hello
            // 
            this.lb_hello.AutoSize = true;
            this.lb_hello.Location = new System.Drawing.Point(12, 9);
            this.lb_hello.Name = "lb_hello";
            this.lb_hello.Size = new System.Drawing.Size(98, 20);
            this.lb_hello.TabIndex = 0;
            this.lb_hello.Text = "Здравствуйте, ";
            this.lb_hello.UseCompatibleTextRendering = true;
            // 
            // cb_choose_spec
            // 
            this.cb_choose_spec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_choose_spec.FormattingEnabled = true;
            this.cb_choose_spec.Location = new System.Drawing.Point(31, 186);
            this.cb_choose_spec.Name = "cb_choose_spec";
            this.cb_choose_spec.Size = new System.Drawing.Size(228, 24);
            this.cb_choose_spec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор врача:";
            // 
            // button_choose_doc
            // 
            this.button_choose_doc.Location = new System.Drawing.Point(172, 297);
            this.button_choose_doc.Name = "button_choose_doc";
            this.button_choose_doc.Size = new System.Drawing.Size(263, 59);
            this.button_choose_doc.TabIndex = 4;
            this.button_choose_doc.Text = "Далее";
            this.button_choose_doc.UseVisualStyleBackColor = true;
            this.button_choose_doc.Click += new System.EventHandler(this.button_choose_doc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Отделение";
            // 
            // cb_hospital_choose
            // 
            this.cb_hospital_choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hospital_choose.FormattingEnabled = true;
            this.cb_hospital_choose.Location = new System.Drawing.Point(32, 110);
            this.cb_hospital_choose.Name = "cb_hospital_choose";
            this.cb_hospital_choose.Size = new System.Drawing.Size(228, 24);
            this.cb_hospital_choose.TabIndex = 5;
            // 
            // FormSpecList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_hospital_choose);
            this.Controls.Add(this.button_choose_doc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_choose_spec);
            this.Controls.Add(this.lb_hello);
            this.Name = "FormSpecList";
            this.Text = "FormSpecList";
            this.Load += new System.EventHandler(this.FormDoctorList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_hello;
        private System.Windows.Forms.ComboBox cb_choose_spec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_choose_doc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_hospital_choose;
    }
}