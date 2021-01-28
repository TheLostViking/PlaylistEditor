
namespace Playlists
{
    partial class ucNewPL
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
            this.tbPLName = new System.Windows.Forms.TextBox();
            this.lbEnterPLname = new System.Windows.Forms.Label();
            this.bSavePL = new System.Windows.Forms.Button();
            this.bCancelPL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPLName
            // 
            this.tbPLName.Location = new System.Drawing.Point(164, 223);
            this.tbPLName.Name = "tbPLName";
            this.tbPLName.Size = new System.Drawing.Size(254, 23);
            this.tbPLName.TabIndex = 0;
            this.tbPLName.TextChanged += new System.EventHandler(this.tbPLName_TextChanged);
            // 
            // lbEnterPLname
            // 
            this.lbEnterPLname.AutoSize = true;
            this.lbEnterPLname.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEnterPLname.Location = new System.Drawing.Point(119, 166);
            this.lbEnterPLname.Name = "lbEnterPLname";
            this.lbEnterPLname.Size = new System.Drawing.Size(361, 25);
            this.lbEnterPLname.TabIndex = 1;
            this.lbEnterPLname.Text = "Enter the name of your new playlist: ";
            // 
            // bSavePL
            // 
            this.bSavePL.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bSavePL.Cursor = System.Windows.Forms.Cursors.Default;
            this.bSavePL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSavePL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bSavePL.Location = new System.Drawing.Point(164, 303);
            this.bSavePL.Name = "bSavePL";
            this.bSavePL.Size = new System.Drawing.Size(75, 23);
            this.bSavePL.TabIndex = 2;
            this.bSavePL.Text = "Save";
            this.bSavePL.UseVisualStyleBackColor = false;
            this.bSavePL.Click += new System.EventHandler(this.buttonSavePL_Click);
            // 
            // bCancelPL
            // 
            this.bCancelPL.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bCancelPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelPL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bCancelPL.Location = new System.Drawing.Point(343, 303);
            this.bCancelPL.Name = "bCancelPL";
            this.bCancelPL.Size = new System.Drawing.Size(75, 23);
            this.bCancelPL.TabIndex = 3;
            this.bCancelPL.Text = "Cancel";
            this.bCancelPL.UseVisualStyleBackColor = false;
            this.bCancelPL.Click += new System.EventHandler(this.buttonCancelPL_Click);
            // 
            // ucNewPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.bCancelPL);
            this.Controls.Add(this.bSavePL);
            this.Controls.Add(this.lbEnterPLname);
            this.Controls.Add(this.tbPLName);
            this.Name = "ucNewPL";
            this.Size = new System.Drawing.Size(622, 504);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPLName;
        private System.Windows.Forms.Label lbEnterPLname;
        private System.Windows.Forms.Button bSavePL;
        private System.Windows.Forms.Button bCancelPL;
    }
}
