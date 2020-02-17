using System;

namespace WindowsFormsApp1
{
    partial class InformationManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationManage));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.stuIDInput = new System.Windows.Forms.TextBox();
            this.majorInput = new System.Windows.Forms.TextBox();
            this.schoolInput = new System.Windows.Forms.TextBox();
            this.roomInput = new System.Windows.Forms.TextBox();
            this.cardIDInput = new System.Windows.Forms.TextBox();
            this.jwxtPasswordInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.modify = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(295, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(205, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "统一用户登录密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(235, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "教务系统密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(280, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "宿舍号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.Location = new System.Drawing.Point(265, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "校园卡号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label7.Location = new System.Drawing.Point(295, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "学院";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.Location = new System.Drawing.Point(295, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "专业";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label9.Location = new System.Drawing.Point(295, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "学号";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.nameInput.Location = new System.Drawing.Point(338, 72);
            this.nameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(313, 29);
            this.nameInput.TabIndex = 11;
            // 
            // stuIDInput
            // 
            this.stuIDInput.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.stuIDInput.Location = new System.Drawing.Point(338, 112);
            this.stuIDInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stuIDInput.Name = "stuIDInput";
            this.stuIDInput.Size = new System.Drawing.Size(313, 29);
            this.stuIDInput.TabIndex = 12;
            // 
            // majorInput
            // 
            this.majorInput.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.majorInput.Location = new System.Drawing.Point(338, 152);
            this.majorInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.majorInput.Name = "majorInput";
            this.majorInput.Size = new System.Drawing.Size(313, 29);
            this.majorInput.TabIndex = 13;
            // 
            // schoolInput
            // 
            this.schoolInput.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.schoolInput.Location = new System.Drawing.Point(338, 192);
            this.schoolInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.schoolInput.Name = "schoolInput";
            this.schoolInput.Size = new System.Drawing.Size(313, 29);
            this.schoolInput.TabIndex = 14;
            // 
            // roomInput
            // 
            this.roomInput.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.roomInput.Location = new System.Drawing.Point(338, 232);
            this.roomInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roomInput.Name = "roomInput";
            this.roomInput.Size = new System.Drawing.Size(313, 29);
            this.roomInput.TabIndex = 15;
            // 
            // cardIDInput
            // 
            this.cardIDInput.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cardIDInput.Location = new System.Drawing.Point(338, 272);
            this.cardIDInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardIDInput.Name = "cardIDInput";
            this.cardIDInput.Size = new System.Drawing.Size(313, 29);
            this.cardIDInput.TabIndex = 16;
            // 
            // jwxtPasswordInput
            // 
            this.jwxtPasswordInput.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.jwxtPasswordInput.Location = new System.Drawing.Point(338, 312);
            this.jwxtPasswordInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jwxtPasswordInput.Name = "jwxtPasswordInput";
            this.jwxtPasswordInput.Size = new System.Drawing.Size(313, 29);
            this.jwxtPasswordInput.TabIndex = 17;
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.passwordInput.Location = new System.Drawing.Point(338, 352);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(313, 29);
            this.passwordInput.TabIndex = 18;
            // 
            // modify
            // 
            this.modify.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.modify.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modify.Location = new System.Drawing.Point(368, 438);
            this.modify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(82, 33);
            this.modify.TabIndex = 19;
            this.modify.Text = "修改";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modifyClick);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel.Location = new System.Drawing.Point(530, 438);
            this.cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(82, 33);
            this.cancel.TabIndex = 20;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.暨南大学_忠信笃敬_透明;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(338, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 286);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // InformationManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(946, 538);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.jwxtPasswordInput);
            this.Controls.Add(this.cardIDInput);
            this.Controls.Add(this.roomInput);
            this.Controls.Add(this.schoolInput);
            this.Controls.Add(this.majorInput);
            this.Controls.Add(this.stuIDInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InformationManage";
            this.Text = "暨南大学珠海校区学生自助平台";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox stuIDInput;
        private System.Windows.Forms.TextBox majorInput;
        private System.Windows.Forms.TextBox schoolInput;
        private System.Windows.Forms.TextBox roomInput;
        private System.Windows.Forms.TextBox cardIDInput;
        private System.Windows.Forms.TextBox jwxtPasswordInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button cancel;
    }
}