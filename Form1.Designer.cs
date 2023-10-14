namespace ESP86
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxTextboxs = new System.Windows.Forms.GroupBox();
            this.labelLoadCell = new System.Windows.Forms.Label();
            this.labelHeartBeat = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.textBoxLoadCell = new System.Windows.Forms.TextBox();
            this.textBoxHeartBeat = new System.Windows.Forms.TextBox();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.buttonCloseConnection = new System.Windows.Forms.Button();
            this.buttonStartLoop = new System.Windows.Forms.Button();
            this.buttonReceiveData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReceivedData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSendedData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxTextboxs.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Turquoise;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.connectionToolStripMenuItem.Text = "Bağlantı Ayarları";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.aboutToolStripMenuItem.Text = "Hakkında";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Enabled = false;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxTextboxs);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxButtons);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(711, 329);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBoxTextboxs
            // 
            this.groupBoxTextboxs.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBoxTextboxs.Controls.Add(this.labelLoadCell);
            this.groupBoxTextboxs.Controls.Add(this.labelHeartBeat);
            this.groupBoxTextboxs.Controls.Add(this.labelTemperature);
            this.groupBoxTextboxs.Controls.Add(this.textBoxLoadCell);
            this.groupBoxTextboxs.Controls.Add(this.textBoxHeartBeat);
            this.groupBoxTextboxs.Controls.Add(this.textBoxTemperature);
            this.groupBoxTextboxs.Location = new System.Drawing.Point(14, 202);
            this.groupBoxTextboxs.Name = "groupBoxTextboxs";
            this.groupBoxTextboxs.Size = new System.Drawing.Size(195, 115);
            this.groupBoxTextboxs.TabIndex = 1;
            this.groupBoxTextboxs.TabStop = false;
            // 
            // labelLoadCell
            // 
            this.labelLoadCell.AutoSize = true;
            this.labelLoadCell.Location = new System.Drawing.Point(11, 83);
            this.labelLoadCell.Name = "labelLoadCell";
            this.labelLoadCell.Size = new System.Drawing.Size(59, 15);
            this.labelLoadCell.TabIndex = 5;
            this.labelLoadCell.Text = "LoadCell:";
            // 
            // labelHeartBeat
            // 
            this.labelHeartBeat.AutoSize = true;
            this.labelHeartBeat.Location = new System.Drawing.Point(28, 54);
            this.labelHeartBeat.Name = "labelHeartBeat";
            this.labelHeartBeat.Size = new System.Drawing.Size(42, 15);
            this.labelHeartBeat.TabIndex = 4;
            this.labelHeartBeat.Text = "Nabız:";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(18, 27);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(52, 15);
            this.labelTemperature.TabIndex = 3;
            this.labelTemperature.Text = "Sıcaklık:";
            // 
            // textBoxLoadCell
            // 
            this.textBoxLoadCell.Location = new System.Drawing.Point(76, 80);
            this.textBoxLoadCell.Name = "textBoxLoadCell";
            this.textBoxLoadCell.ReadOnly = true;
            this.textBoxLoadCell.Size = new System.Drawing.Size(113, 21);
            this.textBoxLoadCell.TabIndex = 2;
            // 
            // textBoxHeartBeat
            // 
            this.textBoxHeartBeat.Location = new System.Drawing.Point(76, 51);
            this.textBoxHeartBeat.Name = "textBoxHeartBeat";
            this.textBoxHeartBeat.ReadOnly = true;
            this.textBoxHeartBeat.Size = new System.Drawing.Size(113, 21);
            this.textBoxHeartBeat.TabIndex = 1;
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Location = new System.Drawing.Point(76, 24);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.ReadOnly = true;
            this.textBoxTemperature.Size = new System.Drawing.Size(113, 21);
            this.textBoxTemperature.TabIndex = 0;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBoxButtons.Controls.Add(this.buttonCloseConnection);
            this.groupBoxButtons.Controls.Add(this.buttonStartLoop);
            this.groupBoxButtons.Controls.Add(this.buttonReceiveData);
            this.groupBoxButtons.Location = new System.Drawing.Point(14, 16);
            this.groupBoxButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxButtons.Size = new System.Drawing.Size(195, 180);
            this.groupBoxButtons.TabIndex = 0;
            this.groupBoxButtons.TabStop = false;
            // 
            // buttonCloseConnection
            // 
            this.buttonCloseConnection.BackColor = System.Drawing.Color.Cyan;
            this.buttonCloseConnection.Location = new System.Drawing.Point(8, 120);
            this.buttonCloseConnection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCloseConnection.Name = "buttonCloseConnection";
            this.buttonCloseConnection.Size = new System.Drawing.Size(179, 44);
            this.buttonCloseConnection.TabIndex = 2;
            this.buttonCloseConnection.Text = "Bağlantıyı Kapat";
            this.buttonCloseConnection.UseVisualStyleBackColor = false;
            this.buttonCloseConnection.Click += new System.EventHandler(this.buttonCloseConnection_ClickAsync);
            // 
            // buttonStartLoop
            // 
            this.buttonStartLoop.BackColor = System.Drawing.Color.Cyan;
            this.buttonStartLoop.Location = new System.Drawing.Point(8, 70);
            this.buttonStartLoop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStartLoop.Name = "buttonStartLoop";
            this.buttonStartLoop.Size = new System.Drawing.Size(179, 44);
            this.buttonStartLoop.TabIndex = 1;
            this.buttonStartLoop.Text = "Döngü Başlat";
            this.buttonStartLoop.UseVisualStyleBackColor = false;
            this.buttonStartLoop.Click += new System.EventHandler(this.buttonStartLoop_Click);
            // 
            // buttonReceiveData
            // 
            this.buttonReceiveData.BackColor = System.Drawing.Color.Cyan;
            this.buttonReceiveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonReceiveData.Location = new System.Drawing.Point(8, 20);
            this.buttonReceiveData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonReceiveData.Name = "buttonReceiveData";
            this.buttonReceiveData.Size = new System.Drawing.Size(179, 44);
            this.buttonReceiveData.TabIndex = 0;
            this.buttonReceiveData.Text = "Veri Al";
            this.buttonReceiveData.UseVisualStyleBackColor = false;
            this.buttonReceiveData.Click += new System.EventHandler(this.buttonReceiveData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate,
            this.ColumnReceivedData,
            this.ColumnSendedData});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(485, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnDate
            // 
            this.ColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDate.HeaderText = "Tarih";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnReceivedData
            // 
            this.ColumnReceivedData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnReceivedData.HeaderText = "Gelen Veri";
            this.ColumnReceivedData.Name = "ColumnReceivedData";
            this.ColumnReceivedData.ReadOnly = true;
            // 
            // ColumnSendedData
            // 
            this.ColumnSendedData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSendedData.HeaderText = "Giden Veri";
            this.ColumnSendedData.Name = "ColumnSendedData";
            this.ColumnSendedData.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(711, 353);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESP8266";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxTextboxs.ResumeLayout(false);
            this.groupBoxTextboxs.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button buttonStartLoop;
        private System.Windows.Forms.Button buttonReceiveData;
        private System.Windows.Forms.GroupBox groupBoxTextboxs;
        private System.Windows.Forms.Label labelLoadCell;
        private System.Windows.Forms.Label labelHeartBeat;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.TextBox textBoxLoadCell;
        private System.Windows.Forms.TextBox textBoxHeartBeat;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReceivedData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSendedData;
        private System.Windows.Forms.Button buttonCloseConnection;
    }
}

