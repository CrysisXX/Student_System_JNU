namespace WindowsFormsApp1.com.group.Pages
{
    partial class ValidateWindow
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
            this.VcodePic = new System.Windows.Forms.PictureBox();
            this.VcodeInput = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VcodePic)).BeginInit();
            this.SuspendLayout();
            // 
            // VcodePic
            // 
            this.VcodePic.Location = new System.Drawing.Point(116, 44);
            this.VcodePic.Name = "VcodePic";
            this.VcodePic.Size = new System.Drawing.Size(100, 50);
            this.VcodePic.TabIndex = 0;
            this.VcodePic.TabStop = false;
            // 
            // VcodeInput
            // 
            this.VcodeInput.Location = new System.Drawing.Point(101, 114);
            this.VcodeInput.Name = "VcodeInput";
            this.VcodeInput.Size = new System.Drawing.Size(100, 25);
            this.VcodeInput.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(116, 157);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(72, 26);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ValidateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 215);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.VcodeInput);
            this.Controls.Add(this.VcodePic);
            this.Name = "ValidateWindow";
            this.Text = "ValidateWindow";
            ((System.ComponentModel.ISupportInitialize)(this.VcodePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox VcodePic;
        private System.Windows.Forms.TextBox VcodeInput;
        private System.Windows.Forms.Button btnConfirm;
    }
}