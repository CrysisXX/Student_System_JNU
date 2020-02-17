namespace WindowsFormsApp1.com.group.Pages
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stuIDInput = new System.Windows.Forms.TextBox();
            this.majorInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 34);
            this.label1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.Location = new System.Drawing.Point(391, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 9;
            this.label8.Text = "提取规则";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label9.Location = new System.Drawing.Point(343, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 31);
            this.label9.TabIndex = 10;
            this.label9.Text = "通知来源地址";
            // 
            // stuIDInput
            // 
            this.stuIDInput.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.stuIDInput.Location = new System.Drawing.Point(507, 315);
            this.stuIDInput.Name = "stuIDInput";
            this.stuIDInput.Size = new System.Drawing.Size(468, 39);
            this.stuIDInput.TabIndex = 12;
            // 
            // majorInput
            // 
            this.majorInput.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.majorInput.Location = new System.Drawing.Point(507, 375);
            this.majorInput.Name = "majorInput";
            this.majorInput.Size = new System.Drawing.Size(468, 39);
            this.majorInput.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.暨南大学_忠信笃敬_透明;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(507, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 429);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.Location = new System.Drawing.Point(543, 692);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 20;
            this.button1.Text = "提取";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button2.Location = new System.Drawing.Point(777, 692);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 46);
            this.button2.TabIndex = 21;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1419, 807);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.majorInput);
            this.Controls.Add(this.stuIDInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "暨南大学珠海校区学生自助平台";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stuIDInput;
        private System.Windows.Forms.TextBox majorInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}