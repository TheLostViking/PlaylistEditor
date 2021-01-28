
namespace Playlists
{
    partial class ucEditPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEditPL));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tWPL = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bAddTracks = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bDeletePL = new System.Windows.Forms.Button();
            this.tbSelectedTrack = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSelectedPL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tWTr = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGreen;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tWPL);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(622, 504);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current playlists:";
            // 
            // tWPL
            // 
            this.tWPL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tWPL.HideSelection = false;
            this.tWPL.Location = new System.Drawing.Point(0, 57);
            this.tWPL.Name = "tWPL";
            this.tWPL.Size = new System.Drawing.Size(206, 447);
            this.tWPL.TabIndex = 0;
            this.tWPL.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.tWPL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.bAddTracks);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.bDeletePL);
            this.splitContainer2.Panel1.Controls.Add(this.tbSelectedTrack);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.tbSelectedPL);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.tWTr);
            this.splitContainer2.Size = new System.Drawing.Size(412, 504);
            this.splitContainer2.SplitterDistance = 202;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 120);
            this.label5.TabIndex = 0;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // bAddTracks
            // 
            this.bAddTracks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bAddTracks.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bAddTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddTracks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAddTracks.Location = new System.Drawing.Point(32, 186);
            this.bAddTracks.Name = "bAddTracks";
            this.bAddTracks.Size = new System.Drawing.Size(130, 32);
            this.bAddTracks.TabIndex = 5;
            this.bAddTracks.Text = "Add Tracks";
            this.bAddTracks.UseVisualStyleBackColor = false;
            this.bAddTracks.Click += new System.EventHandler(this.buttonAddTracks_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selected Track:";
            // 
            // bDeletePL
            // 
            this.bDeletePL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bDeletePL.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bDeletePL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeletePL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bDeletePL.Location = new System.Drawing.Point(32, 242);
            this.bDeletePL.Name = "bDeletePL";
            this.bDeletePL.Size = new System.Drawing.Size(130, 32);
            this.bDeletePL.TabIndex = 4;
            this.bDeletePL.Text = "Delete Playlist";
            this.bDeletePL.UseVisualStyleBackColor = false;
            this.bDeletePL.Click += new System.EventHandler(this.bDeletePL_Click);
            // 
            // tbSelectedTrack
            // 
            this.tbSelectedTrack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSelectedTrack.Location = new System.Drawing.Point(32, 134);
            this.tbSelectedTrack.Name = "tbSelectedTrack";
            this.tbSelectedTrack.Size = new System.Drawing.Size(130, 23);
            this.tbSelectedTrack.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selected Playlist:";
            // 
            // tbSelectedPL
            // 
            this.tbSelectedPL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSelectedPL.Location = new System.Drawing.Point(32, 75);
            this.tbSelectedPL.Name = "tbSelectedPL";
            this.tbSelectedPL.Size = new System.Drawing.Size(130, 23);
            this.tbSelectedPL.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available tracks:";
            // 
            // tWTr
            // 
            this.tWTr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tWTr.HideSelection = false;
            this.tWTr.Location = new System.Drawing.Point(0, 57);
            this.tWTr.Name = "tWTr";
            this.tWTr.Size = new System.Drawing.Size(206, 447);
            this.tWTr.TabIndex = 0;
            this.tWTr.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tWTr_AfterSelect);
            // 
            // ucEditPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucEditPL";
            this.Size = new System.Drawing.Size(622, 504);
            this.Load += new System.EventHandler(this.ucEditPL_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tWPL;
        private System.Windows.Forms.Button bAddTracks;
        private System.Windows.Forms.Button bDeletePL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tWTr;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSelectedTrack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSelectedPL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}
