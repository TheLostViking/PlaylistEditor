
namespace Playlists
{
    partial class ucAddArtist
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNewArtist = new System.Windows.Forms.TextBox();
            this.buttonCancelArtist = new System.Windows.Forms.Button();
            this.buttonSaveArtist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter new artist:";
            // 
            // tbNewArtist
            // 
            this.tbNewArtist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewArtist.Location = new System.Drawing.Point(217, 200);
            this.tbNewArtist.Name = "tbNewArtist";
            this.tbNewArtist.Size = new System.Drawing.Size(200, 23);
            this.tbNewArtist.TabIndex = 1;
            this.tbNewArtist.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonCancelArtist
            // 
            this.buttonCancelArtist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancelArtist.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonCancelArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelArtist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCancelArtist.Location = new System.Drawing.Point(342, 241);
            this.buttonCancelArtist.Name = "buttonCancelArtist";
            this.buttonCancelArtist.Size = new System.Drawing.Size(75, 28);
            this.buttonCancelArtist.TabIndex = 5;
            this.buttonCancelArtist.Text = "Cancel";
            this.buttonCancelArtist.UseVisualStyleBackColor = false;
            this.buttonCancelArtist.Click += new System.EventHandler(this.buttonCancelArtist_Click);
            // 
            // buttonSaveArtist
            // 
            this.buttonSaveArtist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSaveArtist.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSaveArtist.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSaveArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveArtist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSaveArtist.Location = new System.Drawing.Point(217, 241);
            this.buttonSaveArtist.Name = "buttonSaveArtist";
            this.buttonSaveArtist.Size = new System.Drawing.Size(75, 28);
            this.buttonSaveArtist.TabIndex = 4;
            this.buttonSaveArtist.Text = "Save";
            this.buttonSaveArtist.UseVisualStyleBackColor = false;
            this.buttonSaveArtist.Click += new System.EventHandler(this.buttonSaveArtist_Click);
            // 
            // ucAddArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.buttonCancelArtist);
            this.Controls.Add(this.buttonSaveArtist);
            this.Controls.Add(this.tbNewArtist);
            this.Controls.Add(this.label1);
            this.Name = "ucAddArtist";
            this.Size = new System.Drawing.Size(622, 504);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNewArtist;
        private System.Windows.Forms.Button buttonCancelArtist;
        private System.Windows.Forms.Button buttonSaveArtist;
    }
}
