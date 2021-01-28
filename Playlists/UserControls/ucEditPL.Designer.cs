
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.bDeletePL = new System.Windows.Forms.Button();
            this.tWPL = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSelectedTrack = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSelectedPL = new System.Windows.Forms.TextBox();
            this.bAddTracks = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.bDeletePL);
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
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current playlists:";
            // 
            // bDeletePL
            // 
            this.bDeletePL.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bDeletePL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeletePL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bDeletePL.Location = new System.Drawing.Point(4, 404);
            this.bDeletePL.Name = "bDeletePL";
            this.bDeletePL.Size = new System.Drawing.Size(121, 32);
            this.bDeletePL.TabIndex = 4;
            this.bDeletePL.Text = "Delete Playlist";
            this.bDeletePL.UseVisualStyleBackColor = false;
            this.bDeletePL.Click += new System.EventHandler(this.bDeletePL_Click);
            // 
            // tWPL
            // 
            this.tWPL.HideSelection = false;
            this.tWPL.Location = new System.Drawing.Point(0, 57);
            this.tWPL.Name = "tWPL";
            this.tWPL.Size = new System.Drawing.Size(200, 341);
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
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.tbSelectedTrack);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.tbSelectedPL);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.bAddTracks);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.tWTr);
            this.splitContainer2.Size = new System.Drawing.Size(412, 504);
            this.splitContainer2.SplitterDistance = 137;
            this.splitContainer2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selected Track:";
            // 
            // tbSelectedTrack
            // 
            this.tbSelectedTrack.Location = new System.Drawing.Point(4, 209);
            this.tbSelectedTrack.Name = "tbSelectedTrack";
            this.tbSelectedTrack.Size = new System.Drawing.Size(130, 23);
            this.tbSelectedTrack.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selected Playlist:";
            // 
            // tbSelectedPL
            // 
            this.tbSelectedPL.Location = new System.Drawing.Point(4, 127);
            this.tbSelectedPL.Name = "tbSelectedPL";
            this.tbSelectedPL.Size = new System.Drawing.Size(130, 23);
            this.tbSelectedPL.TabIndex = 0;
            // 
            // bAddTracks
            // 
            this.bAddTracks.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bAddTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddTracks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAddTracks.Location = new System.Drawing.Point(3, 404);
            this.bAddTracks.Name = "bAddTracks";
            this.bAddTracks.Size = new System.Drawing.Size(121, 32);
            this.bAddTracks.TabIndex = 5;
            this.bAddTracks.Text = "Add Tracks";
            this.bAddTracks.UseVisualStyleBackColor = false;
            this.bAddTracks.Click += new System.EventHandler(this.buttonAddTracks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available tracks:";
            // 
            // tWTr
            // 
            this.tWTr.HideSelection = false;
            this.tWTr.Location = new System.Drawing.Point(3, 57);
            this.tWTr.Name = "tWTr";
            this.tWTr.Size = new System.Drawing.Size(200, 341);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tWPL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAddTracks;
        private System.Windows.Forms.Button bDeletePL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tWTr;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSelectedTrack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSelectedPL;
    }
}
