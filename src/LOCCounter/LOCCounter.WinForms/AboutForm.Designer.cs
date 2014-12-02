namespace LOCCounter.WinForms
{
    partial class AboutForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPSP = new System.Windows.Forms.Label();
            this.lblPSPTitle = new System.Windows.Forms.Label();
            this.lblContributeTitle = new System.Windows.Forms.Label();
            this.lblContribute = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.forkmePicture = new System.Windows.Forms.PictureBox();
            this.linkPSPBoK = new System.Windows.Forms.LinkLabel();
            this.linkTechnicalReport = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.forkmePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LOC Size Counter for .NET";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(14, 54);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(333, 50);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "This is an open source project developed to help thoso who use PSP (Personal Soft" +
    "ware Process).";
            // 
            // lblPSP
            // 
            this.lblPSP.Location = new System.Drawing.Point(1, 133);
            this.lblPSP.Name = "lblPSP";
            this.lblPSP.Size = new System.Drawing.Size(323, 37);
            this.lblPSP.TabIndex = 7;
            this.lblPSP.Text = "Would you like to learn more about PSP? \r\nCheck these references:";
            // 
            // lblPSPTitle
            // 
            this.lblPSPTitle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPSPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSPTitle.Location = new System.Drawing.Point(1, 104);
            this.lblPSPTitle.Name = "lblPSPTitle";
            this.lblPSPTitle.Size = new System.Drawing.Size(273, 23);
            this.lblPSPTitle.TabIndex = 8;
            this.lblPSPTitle.Text = "The Personal Software Process";
            this.lblPSPTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContributeTitle
            // 
            this.lblContributeTitle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblContributeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContributeTitle.Location = new System.Drawing.Point(1, 246);
            this.lblContributeTitle.Name = "lblContributeTitle";
            this.lblContributeTitle.Size = new System.Drawing.Size(273, 23);
            this.lblContributeTitle.TabIndex = 9;
            this.lblContributeTitle.Text = "Contribute!";
            this.lblContributeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContribute
            // 
            this.lblContribute.Location = new System.Drawing.Point(1, 273);
            this.lblContribute.Name = "lblContribute";
            this.lblContribute.Size = new System.Drawing.Size(323, 39);
            this.lblContribute.TabIndex = 10;
            this.lblContribute.Text = "Do you have a good idea? \r\nHelp us and contribute with the project!";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(259, 356);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 29);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // forkmePicture
            // 
            this.forkmePicture.Image = global::LOCCounter.WinForms.Properties.Resources.ForkMe;
            this.forkmePicture.Location = new System.Drawing.Point(12, 315);
            this.forkmePicture.Name = "forkmePicture";
            this.forkmePicture.Size = new System.Drawing.Size(181, 70);
            this.forkmePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forkmePicture.TabIndex = 13;
            this.forkmePicture.TabStop = false;
            this.forkmePicture.Click += new System.EventHandler(this.forkmePicture_Click);
            // 
            // linkPSPBoK
            // 
            this.linkPSPBoK.AutoSize = true;
            this.linkPSPBoK.Location = new System.Drawing.Point(14, 214);
            this.linkPSPBoK.Name = "linkPSPBoK";
            this.linkPSPBoK.Size = new System.Drawing.Size(160, 17);
            this.linkPSPBoK.TabIndex = 14;
            this.linkPSPBoK.TabStop = true;
            this.linkPSPBoK.Text = "PSP Book of Knowledge";
            this.linkPSPBoK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkTechnicalReport
            // 
            this.linkTechnicalReport.AutoSize = true;
            this.linkTechnicalReport.Location = new System.Drawing.Point(14, 184);
            this.linkTechnicalReport.Name = "linkTechnicalReport";
            this.linkTechnicalReport.Size = new System.Drawing.Size(156, 17);
            this.linkTechnicalReport.TabIndex = 15;
            this.linkTechnicalReport.TabStop = true;
            this.linkTechnicalReport.Text = "PSP - Technical Report";
            this.linkTechnicalReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTechnicalReport_LinkClicked);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(359, 397);
            this.Controls.Add(this.linkTechnicalReport);
            this.Controls.Add(this.linkPSPBoK);
            this.Controls.Add(this.forkmePicture);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblContribute);
            this.Controls.Add(this.lblContributeTitle);
            this.Controls.Add(this.lblPSPTitle);
            this.Controls.Add(this.lblPSP);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 444);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(377, 444);
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.forkmePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPSP;
        private System.Windows.Forms.Label lblPSPTitle;
        private System.Windows.Forms.Label lblContributeTitle;
        private System.Windows.Forms.Label lblContribute;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox forkmePicture;
        private System.Windows.Forms.LinkLabel linkPSPBoK;
        private System.Windows.Forms.LinkLabel linkTechnicalReport;
    }
}