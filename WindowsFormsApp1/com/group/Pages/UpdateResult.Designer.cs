namespace WindowsFormsApp1
{
    partial class UpdateResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateResult));
            this.label1 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F);
            this.label1.Location = new System.Drawing.Point(536, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "修改成功";
            // 
            // loginButton
            // 
            this.yesButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.yesButton.Location = new System.Drawing.Point(560, 306);
            this.yesButton.Name = "loginButton";
            this.yesButton.Size = new System.Drawing.Size(134, 47);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "确定";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // UpdateResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateResult";
            this.Text = "暨南大学珠海校区学生自助系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesButton;
    }
}