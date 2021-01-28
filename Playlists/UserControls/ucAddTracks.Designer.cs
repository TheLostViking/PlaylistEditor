
namespace Playlists
{
    partial class ucAddTracks
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
            this.twAlbums = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.saveTracks = new System.Windows.Forms.Button();
            this.bAddRows = new System.Windows.Forms.Button();
            this.tbTrackTitle = new System.Windows.Forms.TextBox();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.lbTrackLength = new System.Windows.Forms.Label();
            this.tbTrackMin = new System.Windows.Forms.TextBox();
            this.lbTrackTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.daGrTracks = new System.Windows.Forms.DataGridView();
            this.cTrackTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTrackLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daGrTracks)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.twAlbums);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(622, 504);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // twAlbums
            // 
            this.twAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twAlbums.Location = new System.Drawing.Point(0, 0);
            this.twAlbums.Name = "twAlbums";
            this.twAlbums.Size = new System.Drawing.Size(207, 504);
            this.twAlbums.TabIndex = 0;
            this.twAlbums.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.twAlbums.KeyDown += new System.Windows.Forms.KeyEventHandler(this.twAlbums_KeyDown);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.saveTracks);
            this.splitContainer2.Panel1.Controls.Add(this.bAddRows);
            this.splitContainer2.Panel1.Controls.Add(this.tbTrackTitle);
            this.splitContainer2.Panel1.Controls.Add(this.lbMinutes);
            this.splitContainer2.Panel1.Controls.Add(this.lbTrackLength);
            this.splitContainer2.Panel1.Controls.Add(this.tbTrackMin);
            this.splitContainer2.Panel1.Controls.Add(this.lbTrackTitle);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.daGrTracks);
            this.splitContainer2.Size = new System.Drawing.Size(411, 504);
            this.splitContainer2.SplitterDistance = 150;
            this.splitContainer2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adds track to album -->";
            // 
            // saveTracks
            // 
            this.saveTracks.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.saveTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTracks.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveTracks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveTracks.Location = new System.Drawing.Point(228, 111);
            this.saveTracks.Name = "saveTracks";
            this.saveTracks.Size = new System.Drawing.Size(120, 25);
            this.saveTracks.TabIndex = 4;
            this.saveTracks.Text = "Save Changes";
            this.saveTracks.UseVisualStyleBackColor = false;
            this.saveTracks.Click += new System.EventHandler(this.saveTracks_Click);
            // 
            // bAddRows
            // 
            this.bAddRows.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bAddRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddRows.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bAddRows.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAddRows.Location = new System.Drawing.Point(228, 81);
            this.bAddRows.Name = "bAddRows";
            this.bAddRows.Size = new System.Drawing.Size(120, 25);
            this.bAddRows.TabIndex = 3;
            this.bAddRows.Text = "Add";
            this.bAddRows.UseVisualStyleBackColor = false;
            this.bAddRows.Click += new System.EventHandler(this.bAddRows_Click);
            // 
            // tbTrackTitle
            // 
            this.tbTrackTitle.Location = new System.Drawing.Point(3, 52);
            this.tbTrackTitle.Name = "tbTrackTitle";
            this.tbTrackTitle.Size = new System.Drawing.Size(154, 23);
            this.tbTrackTitle.TabIndex = 1;
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Location = new System.Drawing.Point(194, 34);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(76, 15);
            this.lbMinutes.TabIndex = 8;
            this.lbMinutes.Text = "(In Min : Sec)";
            // 
            // lbTrackLength
            // 
            this.lbTrackLength.AutoSize = true;
            this.lbTrackLength.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTrackLength.Location = new System.Drawing.Point(194, 9);
            this.lbTrackLength.Name = "lbTrackLength";
            this.lbTrackLength.Size = new System.Drawing.Size(188, 25);
            this.lbTrackLength.TabIndex = 7;
            this.lbTrackLength.Text = "Enter track length:";
            // 
            // tbTrackMin
            // 
            this.tbTrackMin.Location = new System.Drawing.Point(194, 52);
            this.tbTrackMin.Name = "tbTrackMin";
            this.tbTrackMin.Size = new System.Drawing.Size(154, 23);
            this.tbTrackMin.TabIndex = 2;
            // 
            // lbTrackTitle
            // 
            this.lbTrackTitle.AutoSize = true;
            this.lbTrackTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTrackTitle.Location = new System.Drawing.Point(0, 9);
            this.lbTrackTitle.Name = "lbTrackTitle";
            this.lbTrackTitle.Size = new System.Drawing.Size(166, 25);
            this.lbTrackTitle.TabIndex = 6;
            this.lbTrackTitle.Text = "Enter track title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Saves edits on rows below -->";
            // 
            // daGrTracks
            // 
            this.daGrTracks.AllowUserToAddRows = false;
            this.daGrTracks.AllowUserToResizeColumns = false;
            this.daGrTracks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.daGrTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daGrTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTrackTitle,
            this.cTrackLength});
            this.daGrTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daGrTracks.Location = new System.Drawing.Point(0, 0);
            this.daGrTracks.Name = "daGrTracks";
            this.daGrTracks.RowHeadersVisible = false;
            this.daGrTracks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.daGrTracks.RowTemplate.Height = 25;
            this.daGrTracks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.daGrTracks.Size = new System.Drawing.Size(411, 350);
            this.daGrTracks.TabIndex = 5;
            this.daGrTracks.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.daGrTracks_CellValueChanged);
            this.daGrTracks.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.daGrTracks_UserDeletingRow);
            // 
            // cTrackTitle
            // 
            this.cTrackTitle.HeaderText = "Title";
            this.cTrackTitle.Name = "cTrackTitle";
            // 
            // cTrackLength
            // 
            this.cTrackLength.HeaderText = "Length";
            this.cTrackLength.Name = "cTrackLength";
            // 
            // ucAddTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucAddTracks";
            this.Size = new System.Drawing.Size(622, 504);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daGrTracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;            
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrackTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrackLength;           
        private System.Windows.Forms.TextBox tbTrackMin;
        private System.Windows.Forms.Button bAddRows;
        private System.Windows.Forms.TextBox tbTrackTitle;
        private System.Windows.Forms.DataGridView daGrTracks;
        private System.Windows.Forms.TreeView twAlbums;
        private System.Windows.Forms.Label lbTrackLength;
        private System.Windows.Forms.Label lbTrackTitle;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Button saveTracks;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
