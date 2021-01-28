
namespace Playlists
{
    partial class ucTVAddAlbum
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.twAddAlbums = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bAddnewAlbum = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAlbumTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.twAddAlbums);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.bAddnewAlbum);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tbAlbumTitle);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2MinSize = 409;
            this.splitContainer1.Size = new System.Drawing.Size(622, 504);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // twAddAlbums
            // 
            this.twAddAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.twAddAlbums.HideSelection = false;
            this.twAddAlbums.Location = new System.Drawing.Point(3, 46);
            this.twAddAlbums.Name = "twAddAlbums";
            this.twAddAlbums.Size = new System.Drawing.Size(207, 458);
            this.twAddAlbums.TabIndex = 0;
            this.twAddAlbums.KeyDown += new System.Windows.Forms.KeyEventHandler(this.twAddAlbums_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artist/Albums:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "If you wish to delete an album,\r\nsimply select it in the treeview and hit \'Delete" +
    "\'!";
            // 
            // bAddnewAlbum
            // 
            this.bAddnewAlbum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bAddnewAlbum.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bAddnewAlbum.Cursor = System.Windows.Forms.Cursors.Default;
            this.bAddnewAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddnewAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAddnewAlbum.Location = new System.Drawing.Point(158, 254);
            this.bAddnewAlbum.Name = "bAddnewAlbum";
            this.bAddnewAlbum.Size = new System.Drawing.Size(116, 25);
            this.bAddnewAlbum.TabIndex = 4;
            this.bAddnewAlbum.Text = "Add";
            this.bAddnewAlbum.UseVisualStyleBackColor = false;
            this.bAddnewAlbum.Click += new System.EventHandler(this.bAddnewAlbum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Then enter the album you want to add to that artist!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select artist in menu to the left.";
            // 
            // tbAlbumTitle
            // 
            this.tbAlbumTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbAlbumTitle.Location = new System.Drawing.Point(123, 225);
            this.tbAlbumTitle.Name = "tbAlbumTitle";
            this.tbAlbumTitle.Size = new System.Drawing.Size(188, 23);
            this.tbAlbumTitle.TabIndex = 1;
            this.tbAlbumTitle.TextChanged += new System.EventHandler(this.tbAlbumTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(123, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Album title:";
            // 
            // ucTVAddAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucTVAddAlbum";
            this.Size = new System.Drawing.Size(622, 504);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView twAddAlbums;
        private System.Windows.Forms.Button bAddnewAlbum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAlbumTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}
