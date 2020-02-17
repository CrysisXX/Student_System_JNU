namespace WindowsFormsApp1
{
    partial class WriteExcuse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteExcuse));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.previewButton = new System.Windows.Forms.Button();
            this.cancleButton = new System.Windows.Forms.Button();
            this.ExcuseReason = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F);
            this.label1.Location = new System.Drawing.Point(412, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "请假信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(271, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "请假时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(271, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "请假理由";
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Location = new System.Drawing.Point(344, 148);
            this.StartTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(128, 21);
            this.StartTimePicker.TabIndex = 6;
            this.StartTimePicker.ValueChanged += new System.EventHandler(this.StartTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(476, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "至";
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Location = new System.Drawing.Point(505, 148);
            this.EndTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(128, 21);
            this.EndTimePicker.TabIndex = 8;
            this.EndTimePicker.ValueChanged += new System.EventHandler(this.EndTimePicker_ValueChanged);
            // 
            // previewButton
            // 
            this.previewButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.previewButton.Location = new System.Drawing.Point(382, 461);
            this.previewButton.Margin = new System.Windows.Forms.Padding(2);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(90, 35);
            this.previewButton.TabIndex = 9;
            this.previewButton.Text = "预览";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // cancleButton
            // 
            this.cancleButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cancleButton.Location = new System.Drawing.Point(505, 461);
            this.cancleButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(90, 35);
            this.cancleButton.TabIndex = 10;
            this.cancleButton.Text = "取消";
            this.cancleButton.UseVisualStyleBackColor = true;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // ExcuseReason
            // 
            this.ExcuseReason.Location = new System.Drawing.Point(344, 190);
            this.ExcuseReason.Margin = new System.Windows.Forms.Padding(2);
            this.ExcuseReason.Name = "ExcuseReason";
            this.ExcuseReason.Size = new System.Drawing.Size(289, 197);
            this.ExcuseReason.TabIndex = 11;
            this.ExcuseReason.Text = "";
            this.ExcuseReason.TextChanged += new System.EventHandler(this.ExcuseReason_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.暨南大学_忠信笃敬_透明;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(337, 146);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 286);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // WriteExcuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(946, 538);
            this.Controls.Add(this.ExcuseReason);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WriteExcuse";
            this.Text = "暨南大学珠海校区学生自助平台";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.RichTextBox ExcuseReason;
    }
}