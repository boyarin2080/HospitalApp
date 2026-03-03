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
            this.shamin_hospitalDataSet1 = new WindowsFormsAppHospital.shamin_hospitalDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.shamin_hospitalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_hello
            // 
            this.lb_hello.AutoSize = true;
            this.lb_hello.Location = new System.Drawing.Point(9, 7);
            this.lb_hello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_hello.Name = "lb_hello";
            this.lb_hello.Size = new System.Drawing.Size(83, 17);
            this.lb_hello.TabIndex = 0;
            this.lb_hello.Text = "Здравствуйте, ";
            this.lb_hello.UseCompatibleTextRendering = true;
            // 
            // cb_choose_spec
            // 
            this.cb_choose_spec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_choose_spec.FormattingEnabled = true;
            this.cb_choose_spec.Location = new System.Drawing.Point(62, 169);
            this.cb_choose_spec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_choose_spec.Name = "cb_choose_spec";
            this.cb_choose_spec.Size = new System.Drawing.Size(199, 21);
            this.cb_choose_spec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор врача:";
            // 
            // button_choose_doc
            // 
            this.button_choose_doc.Location = new System.Drawing.Point(63, 260);
            this.button_choose_doc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_choose_doc.Name = "button_choose_doc";
            this.button_choose_doc.Size = new System.Drawing.Size(197, 48);
            this.button_choose_doc.TabIndex = 4;
            this.button_choose_doc.Text = "Далее";
            this.button_choose_doc.UseVisualStyleBackColor = true;
            this.button_choose_doc.Click += new System.EventHandler(this.button_choose_doc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Отделение";
            // 
            // cb_hospital_choose
            // 
            this.cb_hospital_choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hospital_choose.FormattingEnabled = true;
            this.cb_hospital_choose.Location = new System.Drawing.Point(63, 107);
            this.cb_hospital_choose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_hospital_choose.Name = "cb_hospital_choose";
            this.cb_hospital_choose.Size = new System.Drawing.Size(198, 21);
            this.cb_hospital_choose.TabIndex = 5;
            // 
            // shamin_hospitalDataSet1
            // 
            this.shamin_hospitalDataSet1.DataSetName = "shamin_hospitalDataSet";
            this.shamin_hospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormSpecList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(342, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_hospital_choose);
            this.Controls.Add(this.button_choose_doc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_choose_spec);
            this.Controls.Add(this.lb_hello);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSpecList";
            this.Text = "FormSpecList";
            this.Load += new System.EventHandler(this.FormDoctorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shamin_hospitalDataSet1)).EndInit();
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
        private shamin_hospitalDataSet shamin_hospitalDataSet1;
    }
}