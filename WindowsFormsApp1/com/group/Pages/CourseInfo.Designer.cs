namespace WindowsFormsApp1
{
    partial class CourseInfo
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
            this.gpaButton = new System.Windows.Forms.Button();
            this.courseInfoButton = new System.Windows.Forms.Button();
            this.courseChooseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KnowledgeGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(485, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "主修培养方案课程信息查询";
            // 
            // gpaButton
            // 
            this.gpaButton.Location = new System.Drawing.Point(49, 64);
            this.gpaButton.Name = "gpaButton";
            this.gpaButton.Size = new System.Drawing.Size(171, 33);
            this.gpaButton.TabIndex = 4;
            this.gpaButton.Text = "学分要求及已获学分";
            this.gpaButton.UseVisualStyleBackColor = true;
            // 
            // courseInfoButton
            // 
            this.courseInfoButton.Location = new System.Drawing.Point(235, 64);
            this.courseInfoButton.Name = "courseInfoButton";
            this.courseInfoButton.Size = new System.Drawing.Size(95, 33);
            this.courseInfoButton.TabIndex = 5;
            this.courseInfoButton.Text = "课程信息";
            this.courseInfoButton.UseVisualStyleBackColor = true;
            // 
            // courseChooseButton
            // 
            this.courseChooseButton.Location = new System.Drawing.Point(341, 64);
            this.courseChooseButton.Name = "courseChooseButton";
            this.courseChooseButton.Size = new System.Drawing.Size(75, 33);
            this.courseChooseButton.TabIndex = 6;
            this.courseChooseButton.Text = "选择课程";
            this.courseChooseButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseCategory,
            this.CourseNumber,
            this.CourseName,
            this.Credit,
            this.TotalHours,
            this.Term,
            this.KnowledgeGroup,
            this.Score});
            this.dataGridView1.Location = new System.Drawing.Point(49, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 436);
            this.dataGridView1.TabIndex = 14;
            // 
            // CourseCategory
            // 
            this.CourseCategory.HeaderText = "课程类别";
            this.CourseCategory.Name = "CourseCategory";
            // 
            // CourseNumber
            // 
            this.CourseNumber.HeaderText = "课程编号";
            this.CourseNumber.Name = "CourseNumber";
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            // 
            // Credit
            // 
            this.Credit.HeaderText = "学分数";
            this.Credit.Name = "Credit";
            // 
            // TotalHours
            // 
            this.TotalHours.HeaderText = "总学时";
            this.TotalHours.Name = "TotalHours";
            // 
            // Term
            // 
            this.Term.HeaderText = "学期";
            this.Term.Name = "Term";
            // 
            // KnowledgeGroup
            // 
            this.KnowledgeGroup.HeaderText = "知识群";
            this.KnowledgeGroup.Name = "KnowledgeGroup";
            // 
            // Score
            // 
            this.Score.HeaderText = "已获成绩";
            this.Score.Name = "Score";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(1135, 144);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 33);
            this.Refresh.TabIndex = 15;
            this.Refresh.Text = "更新";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // CourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 672);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.courseChooseButton);
            this.Controls.Add(this.courseInfoButton);
            this.Controls.Add(this.gpaButton);
            this.Controls.Add(this.label1);
            this.Name = "CourseInfo";
            this.Text = "CourseInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gpaButton;
        private System.Windows.Forms.Button courseInfoButton;
        private System.Windows.Forms.Button courseChooseButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn KnowledgeGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Button Refresh;
    }
}