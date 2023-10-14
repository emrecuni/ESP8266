namespace ESP86
{
    partial class FormAbout
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelLinkedin = new System.Windows.Forms.LinkLabel();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.labelCommunication = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCommunication);
            this.groupBox1.Controls.Add(this.linkLabelGithub);
            this.groupBox1.Controls.Add(this.linkLabelLinkedin);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.labelDeveloper);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDeveloper.Location = new System.Drawing.Point(33, 201);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(130, 17);
            this.labelDeveloper.TabIndex = 0;
            this.labelDeveloper.Text = "Geliştirici: Emre Cüni";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ESP86.Properties.Resources.indir;
            this.pictureBox1.Location = new System.Drawing.Point(83, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelLinkedin
            // 
            this.linkLabelLinkedin.AutoSize = true;
            this.linkLabelLinkedin.Location = new System.Drawing.Point(93, 240);
            this.linkLabelLinkedin.Name = "linkLabelLinkedin";
            this.linkLabelLinkedin.Size = new System.Drawing.Size(54, 15);
            this.linkLabelLinkedin.TabIndex = 2;
            this.linkLabelLinkedin.TabStop = true;
            this.linkLabelLinkedin.Text = "Linkedin";
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(166, 240);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(43, 15);
            this.linkLabelGithub.TabIndex = 3;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "Github";
            // 
            // labelCommunication
            // 
            this.labelCommunication.AutoSize = true;
            this.labelCommunication.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCommunication.Location = new System.Drawing.Point(33, 240);
            this.labelCommunication.Name = "labelCommunication";
            this.labelCommunication.Size = new System.Drawing.Size(54, 17);
            this.labelCommunication.TabIndex = 4;
            this.labelCommunication.Text = "İletişim:";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(352, 344);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAbout";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Label labelCommunication;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.LinkLabel linkLabelLinkedin;
    }
}