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
            this.btnRollback = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProgramVersion
            // 
            this.lblProgramVersion.AutoSize = true;
            this.lblProgramVersion.Location = new System.Drawing.Point(183, 16);
            this.lblProgramVersion.Name = "lblProgramVersion";
            this.lblProgramVersion.Size = new System.Drawing.Size(84, 13);
            this.lblProgramVersion.TabIndex = 0;
            this.lblProgramVersion.Text = "Program Version";
            // 
            // txtProgramVersion
            // 
            this.txtProgramVersion.Location = new System.Drawing.Point(167, 32);
            this.txtProgramVersion.Name = "txtProgramVersion";
            this.txtProgramVersion.Size = new System.Drawing.Size(127, 20);
            this.txtProgramVersion.TabIndex = 1;
            // 
            // btnRollback
            // 
            this.btnRollback.Location = new System.Drawing.Point(164, 58);
            this.btnRollback.Name = "btnRollback";
            this.btnRollback.Size = new System.Drawing.Size(130, 46);
            this.btnRollback.TabIndex = 2;
            this.btnRollback.Text = "Rollback Version";
            this.btnRollback.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(395, 81);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 111);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRollback);
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
        private System.Windows.Forms.Button btnRollback;
        private System.Windows.Forms.Button btnExit;
    }
}