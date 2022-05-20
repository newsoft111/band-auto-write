namespace BandProgram
{
    partial class NewPostForm
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
            this.btnAddPost = new System.Windows.Forms.Button();
            this.chkAddComment = new System.Windows.Forms.CheckBox();
            this.Comment_GroupBox = new System.Windows.Forms.GroupBox();
            this.radioCommentFolder = new System.Windows.Forms.RadioButton();
            this.radioCommentImage = new System.Windows.Forms.RadioButton();
            this.commentImageList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCommentImageOpen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCommentContent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPostFolder = new System.Windows.Forms.RadioButton();
            this.radioPostImage = new System.Windows.Forms.RadioButton();
            this.postImageList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPostImageOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPostContent = new System.Windows.Forms.TextBox();
            this.Comment_GroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPost
            // 
            this.btnAddPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPost.Location = new System.Drawing.Point(200, 357);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(246, 32);
            this.btnAddPost.TabIndex = 22;
            this.btnAddPost.Text = "추가하기";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // chkAddComment
            // 
            this.chkAddComment.AutoSize = true;
            this.chkAddComment.Location = new System.Drawing.Point(520, 10);
            this.chkAddComment.Name = "chkAddComment";
            this.chkAddComment.Size = new System.Drawing.Size(90, 16);
            this.chkAddComment.TabIndex = 33;
            this.chkAddComment.Text = "댓글 추가 작성";
            this.chkAddComment.UseVisualStyleBackColor = true;
            this.chkAddComment.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Comment_GroupBox
            // 
            this.Comment_GroupBox.Controls.Add(this.radioCommentFolder);
            this.Comment_GroupBox.Controls.Add(this.radioCommentImage);
            this.Comment_GroupBox.Controls.Add(this.commentImageList);
            this.Comment_GroupBox.Controls.Add(this.btnCommentImageOpen);
            this.Comment_GroupBox.Controls.Add(this.label5);
            this.Comment_GroupBox.Controls.Add(this.txtCommentContent);
            this.Comment_GroupBox.Enabled = false;
            this.Comment_GroupBox.Location = new System.Drawing.Point(318, 31);
            this.Comment_GroupBox.Name = "Comment_GroupBox";
            this.Comment_GroupBox.Size = new System.Drawing.Size(300, 317);
            this.Comment_GroupBox.TabIndex = 34;
            this.Comment_GroupBox.TabStop = false;
            this.Comment_GroupBox.Text = "댓글원고 추가";
            // 
            // radioCommentFolder
            // 
            this.radioCommentFolder.AutoSize = true;
            this.radioCommentFolder.Location = new System.Drawing.Point(125, 164);
            this.radioCommentFolder.Name = "radioCommentFolder";
            this.radioCommentFolder.Size = new System.Drawing.Size(65, 16);
            this.radioCommentFolder.TabIndex = 38;
            this.radioCommentFolder.Text = "폴더 열기";
            this.radioCommentFolder.UseVisualStyleBackColor = true;
            // 
            // radioCommentImage
            // 
            this.radioCommentImage.AutoSize = true;
            this.radioCommentImage.Checked = true;
            this.radioCommentImage.Location = new System.Drawing.Point(56, 164);
            this.radioCommentImage.Name = "radioCommentImage";
            this.radioCommentImage.Size = new System.Drawing.Size(65, 16);
            this.radioCommentImage.TabIndex = 37;
            this.radioCommentImage.TabStop = true;
            this.radioCommentImage.Text = "사진 열기";
            this.radioCommentImage.UseVisualStyleBackColor = true;
            // 
            // commentImageList
            // 
            this.commentImageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.commentImageList.FullRowSelect = true;
            this.commentImageList.GridLines = true;
            this.commentImageList.HideSelection = false;
            this.commentImageList.Location = new System.Drawing.Point(6, 186);
            this.commentImageList.MultiSelect = false;
            this.commentImageList.Name = "commentImageList";
            this.commentImageList.Size = new System.Drawing.Size(288, 124);
            this.commentImageList.TabIndex = 36;
            this.commentImageList.UseCompatibleStateImageBehavior = false;
            this.commentImageList.View = System.Windows.Forms.View.Details;
            this.commentImageList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.commentImageList_MouseDown);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "사진 이름";
            this.columnHeader5.Width = 171;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "크기";
            this.columnHeader6.Width = 112;
            // 
            // btnCommentImageOpen
            // 
            this.btnCommentImageOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommentImageOpen.Location = new System.Drawing.Point(230, 160);
            this.btnCommentImageOpen.Name = "btnCommentImageOpen";
            this.btnCommentImageOpen.Size = new System.Drawing.Size(64, 24);
            this.btnCommentImageOpen.TabIndex = 34;
            this.btnCommentImageOpen.Text = "열기";
            this.btnCommentImageOpen.UseVisualStyleBackColor = true;
            this.btnCommentImageOpen.Click += new System.EventHandler(this.btnCommentImageOpen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "이미지";
            // 
            // txtCommentContent
            // 
            this.txtCommentContent.Location = new System.Drawing.Point(6, 24);
            this.txtCommentContent.Multiline = true;
            this.txtCommentContent.Name = "txtCommentContent";
            this.txtCommentContent.Size = new System.Drawing.Size(288, 133);
            this.txtCommentContent.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioPostFolder);
            this.groupBox2.Controls.Add(this.radioPostImage);
            this.groupBox2.Controls.Add(this.postImageList);
            this.groupBox2.Controls.Add(this.btnPostImageOpen);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPostContent);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 317);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "포스팅원고 추가";
            // 
            // radioPostFolder
            // 
            this.radioPostFolder.AutoSize = true;
            this.radioPostFolder.Location = new System.Drawing.Point(125, 164);
            this.radioPostFolder.Name = "radioPostFolder";
            this.radioPostFolder.Size = new System.Drawing.Size(65, 16);
            this.radioPostFolder.TabIndex = 38;
            this.radioPostFolder.Text = "폴더 열기";
            this.radioPostFolder.UseVisualStyleBackColor = true;
            // 
            // radioPostImage
            // 
            this.radioPostImage.AutoSize = true;
            this.radioPostImage.Checked = true;
            this.radioPostImage.Location = new System.Drawing.Point(56, 164);
            this.radioPostImage.Name = "radioPostImage";
            this.radioPostImage.Size = new System.Drawing.Size(65, 16);
            this.radioPostImage.TabIndex = 37;
            this.radioPostImage.TabStop = true;
            this.radioPostImage.Text = "사진 열기";
            this.radioPostImage.UseVisualStyleBackColor = true;
            // 
            // postImageList
            // 
            this.postImageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.postImageList.FullRowSelect = true;
            this.postImageList.GridLines = true;
            this.postImageList.HideSelection = false;
            this.postImageList.Location = new System.Drawing.Point(6, 186);
            this.postImageList.MultiSelect = false;
            this.postImageList.Name = "postImageList";
            this.postImageList.Size = new System.Drawing.Size(288, 124);
            this.postImageList.TabIndex = 36;
            this.postImageList.UseCompatibleStateImageBehavior = false;
            this.postImageList.View = System.Windows.Forms.View.Details;
            this.postImageList.DoubleClick += new System.EventHandler(this.ImageListView_DoubleClick);
            this.postImageList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageListView_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "사진 이름";
            this.columnHeader1.Width = 171;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "크기";
            this.columnHeader2.Width = 112;
            // 
            // btnPostImageOpen
            // 
            this.btnPostImageOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostImageOpen.Location = new System.Drawing.Point(230, 160);
            this.btnPostImageOpen.Name = "btnPostImageOpen";
            this.btnPostImageOpen.Size = new System.Drawing.Size(64, 24);
            this.btnPostImageOpen.TabIndex = 34;
            this.btnPostImageOpen.Text = "열기";
            this.btnPostImageOpen.UseVisualStyleBackColor = true;
            this.btnPostImageOpen.Click += new System.EventHandler(this.openImageBtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "이미지";
            // 
            // txtPostContent
            // 
            this.txtPostContent.Location = new System.Drawing.Point(6, 24);
            this.txtPostContent.Multiline = true;
            this.txtPostContent.Name = "txtPostContent";
            this.txtPostContent.Size = new System.Drawing.Size(288, 133);
            this.txtPostContent.TabIndex = 33;
            // 
            // NewPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Comment_GroupBox);
            this.Controls.Add(this.chkAddComment);
            this.Controls.Add(this.btnAddPost);
            this.Name = "NewPostForm";
            this.Text = "NewPostForm";
            this.Load += new System.EventHandler(this.PostingAddForm_Load);
            this.Comment_GroupBox.ResumeLayout(false);
            this.Comment_GroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.CheckBox chkAddComment;
        private System.Windows.Forms.GroupBox Comment_GroupBox;
        private System.Windows.Forms.RadioButton radioCommentFolder;
        private System.Windows.Forms.RadioButton radioCommentImage;
        private System.Windows.Forms.ListView commentImageList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnCommentImageOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCommentContent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioPostFolder;
        private System.Windows.Forms.RadioButton radioPostImage;
        private System.Windows.Forms.ListView postImageList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnPostImageOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPostContent;
    }
}