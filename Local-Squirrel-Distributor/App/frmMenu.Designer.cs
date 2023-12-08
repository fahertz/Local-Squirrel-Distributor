namespace Local_Squirrel_Distributor.App
{
    partial class frmMenu
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
            this.lblProgramVersion = new System.Windows.Forms.Label();
            this.txtProgramVersion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProgramVersion
            // 
            this.lblProgramVersion.AutoSize = true;
            this.lblProgramVersion.Location = new System.Drawing.Point(12, 9);
            this.lblProgramVersion.Name = "lblProgramVersion";
            this.lblProgramVersion.Size = new System.Drawing.Size(84, 13);
            this.lblProgramVersion.TabIndex = 0;
            this.lblProgramVersion.Text = "Program Version";
            // 
            // txtProgramVersion
            // 
            this.txtProgramVersion.Location = new System.Drawing.Point(15, 25);
            this.txtProgramVersion.Name = "txtProgramVersion";
            this.txtProgramVersion.Size = new System.Drawing.Size(81, 20);
            this.txtProgramVersion.TabIndex = 1;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProgramVersion);
            this.Controls.Add(this.lblProgramVersion);
            this.Name = "frmMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgramVersion;
        private System.Windows.Forms.TextBox txtProgramVersion;
    }
}