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
            this.SuspendLayout();
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(257, 277);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(249, 67);
            this.btn_reg.TabIndex = 0;
            this.btn_reg.Text = "Зарегистрироваться";
            this.btn_reg.UseVisualStyleBackColor = true;
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reg);
            this.Name = "FormReg";
            this.Text = "FormReg";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_reg;
    }
}