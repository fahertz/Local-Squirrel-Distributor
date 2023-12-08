namespace Local_Squirrel_Distributor
{
    partial class frmUpdateScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbSearchingForUpdates = new System.Windows.Forms.PictureBox();
            this.lblSearchingForUpdates = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.pcbDownload = new System.Windows.Forms.PictureBox();
            this.lblInstall = new System.Windows.Forms.Label();
            this.pcbInstall = new System.Windows.Forms.PictureBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.pcbUpdate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchingForUpdates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbSearchingForUpdates
            // 
            this.pcbSearchingForUpdates.Location = new System.Drawing.Point(31, 32);
            this.pcbSearchingForUpdates.Name = "pcbSearchingForUpdates";
            this.pcbSearchingForUpdates.Size = new System.Drawing.Size(20, 20);
            this.pcbSearchingForUpdates.TabIndex = 0;
            this.pcbSearchingForUpdates.TabStop = false;
            // 
            // lblSearchingForUpdates
            // 
            this.lblSearchingForUpdates.AutoSize = true;
            this.lblSearchingForUpdates.Location = new System.Drawing.Point(57, 36);
            this.lblSearchingForUpdates.Name = "lblSearchingForUpdates";
            this.lblSearchingForUpdates.Size = new System.Drawing.Size(122, 13);
            this.lblSearchingForUpdates.TabIndex = 1;
            this.lblSearchingForUpdates.Text = "Searching for Updates...";
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(57, 62);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(121, 13);
            this.lblDownload.TabIndex = 3;
            this.lblDownload.Text = "Downloading Updates...";
            // 
            // pcbDownload
            // 
            this.pcbDownload.Location = new System.Drawing.Point(31, 58);
            this.pcbDownload.Name = "pcbDownload";
            this.pcbDownload.Size = new System.Drawing.Size(20, 20);
            this.pcbDownload.TabIndex = 2;
            this.pcbDownload.TabStop = false;
            // 
            // lblInstall
            // 
            this.lblInstall.AutoSize = true;
            this.lblInstall.Location = new System.Drawing.Point(57, 88);
            this.lblInstall.Name = "lblInstall";
            this.lblInstall.Size = new System.Drawing.Size(100, 13);
            this.lblInstall.TabIndex = 5;
            this.lblInstall.Text = "Installing Updates...";
            // 
            // pcbInstall
            // 
            this.pcbInstall.Location = new System.Drawing.Point(31, 84);
            this.pcbInstall.Name = "pcbInstall";
            this.pcbInstall.Size = new System.Drawing.Size(20, 20);
            this.pcbInstall.TabIndex = 4;
            this.pcbInstall.TabStop = false;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(57, 114);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(114, 13);
            this.lblUpdate.TabIndex = 7;
            this.lblUpdate.Text = "Updating Application...";
            // 
            // pcbUpdate
            // 
            this.pcbUpdate.Location = new System.Drawing.Point(31, 110);
            this.pcbUpdate.Name = "pcbUpdate";
            this.pcbUpdate.Size = new System.Drawing.Size(20, 20);
            this.pcbUpdate.TabIndex = 6;
            this.pcbUpdate.TabStop = false;
            // 
            // frmUpdateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 154);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.pcbUpdate);
            this.Controls.Add(this.lblInstall);
            this.Controls.Add(this.pcbInstall);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.pcbDownload);
            this.Controls.Add(this.lblSearchingForUpdates);
            this.Controls.Add(this.pcbSearchingForUpdates);
            this.Name = "frmUpdateScreen";
            this.Text = "Update Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchingForUpdates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSearchingForUpdates;
        private System.Windows.Forms.Label lblSearchingForUpdates;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.PictureBox pcbDownload;
        private System.Windows.Forms.Label lblInstall;
        private System.Windows.Forms.PictureBox pcbInstall;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.PictureBox pcbUpdate;
    }
}

