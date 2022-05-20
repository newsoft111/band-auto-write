namespace BandProgram
{
    partial class PostingAddForm
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
            this.radioFolder = new System.Windows.Forms.RadioButton();
            this.radioImageOpen = new System.Windows.Forms.RadioButton();
            this.ImageListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.postContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioFolder
            // 
            this.radioFolder.AutoSize = true;
            this.radioFolder.Location = new System.Drawing.Point(129, 195);
            this.radioFolder.Name = "radioFolder";
            this.radioFolder.Size = new System.Drawing.Size(72, 17);
            this.radioFolder.TabIndex = 17;
            this.radioFolder.Text = "폴더 열기";
            this.radioFolder.UseVisualStyleBackColor = true;
            // 
            // radioImageOpen
            // 
            this.radioImageOpen.AutoSize = true;
            this.radioImageOpen.Checked = true;
            this.radioImageOpen.Location = new System.Drawing.Point(60, 195);
            this.radioImageOpen.Name = "radioImageOpen";
            this.radioImageOpen.Size = new System.Drawing.Size(72, 17);
            this.radioImageOpen.TabIndex = 16;
            this.radioImageOpen.TabStop = true;
            this.radioImageOpen.Text = "사진 열기";
            this.radioImageOpen.UseVisualStyleBackColor = true;
            // 
            // ImageListView
            // 
            this.ImageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ImageListView.FullRowSelect = true;
            this.ImageListView.GridLines = true;
            this.ImageListView.Location = new System.Drawing.Point(10, 218);
            this.ImageListView.MultiSelect = false;
            this.ImageListView.Name = "ImageListView";
            this.ImageListView.Size = new System.Drawing.Size(247, 134);
            this.ImageListView.TabIndex = 15;
            this.ImageListView.UseCompatibleStateImageBehavior = false;
            this.ImageListView.View = System.Windows.Forms.View.Details;
            this.ImageListView.DoubleClick += new System.EventHandler(this.ImageListView_DoubleClick);
            this.ImageListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageListView_MouseDown);
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
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(207, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "열기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.openImageBtnClick);
            // 
            // btnAddPost
            // 
            this.btnAddPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPost.Location = new System.Drawing.Point(10, 358);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(246, 53);
            this.btnAddPost.TabIndex = 14;
            this.btnAddPost.Text = "추가하기";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.postingAddBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "이미지";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "내용";
            // 
            // postContent
            // 
            this.postContent.Location = new System.Drawing.Point(10, 43);
            this.postContent.Multiline = true;
            this.postContent.Name = "postContent";
            this.postContent.Size = new System.Drawing.Size(247, 144);
            this.postContent.TabIndex = 11;
            // 
            // PostingAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 423);
            this.Controls.Add(this.radioFolder);
            this.Controls.Add(this.radioImageOpen);
            this.Controls.Add(this.ImageListView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postContent);
            this.Name = "PostingAddForm";
            this.Text = "포스트추가";
            this.Load += new System.EventHandler(this.PostingAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioFolder;
        private System.Windows.Forms.RadioButton radioImageOpen;
        private System.Windows.Forms.ListView ImageListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox postContent;
    }
}