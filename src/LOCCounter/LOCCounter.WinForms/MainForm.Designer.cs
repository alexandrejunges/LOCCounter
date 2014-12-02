namespace LOCCounter.WinForms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.lblFile = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TotalLOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfMethods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageMethodSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openRulesDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLOCSize = new System.Windows.Forms.MaskedTextBox();
            this.lblNumberOfClasses = new System.Windows.Forms.Label();
            this.txtNumberOfClasses = new System.Windows.Forms.MaskedTextBox();
            this.lblTotalLocSize = new System.Windows.Forms.Label();
            this.txtAvgSize = new System.Windows.Forms.MaskedTextBox();
            this.groupFileDefinition = new System.Windows.Forms.GroupBox();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locClassInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locSizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupFileDefinition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locClassInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locSizeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(24, 71);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(30, 17);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "File";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(915, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadRulesToolStripMenuItem,
            this.rulesToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // loadRulesToolStripMenuItem
            // 
            this.loadRulesToolStripMenuItem.Name = "loadRulesToolStripMenuItem";
            this.loadRulesToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.loadRulesToolStripMenuItem.Text = "Load Rules";
            this.loadRulesToolStripMenuItem.Click += new System.EventHandler(this.loadRulesToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Define the class, project or solution to count the LOC size.";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(60, 68);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(464, 22);
            this.txtFile.TabIndex = 2;
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Class, Project, Solution|*.cs;*.csproj;*.sln;";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.ShowReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(530, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCount
            // 
            this.btnCount.Enabled = false;
            this.btnCount.Location = new System.Drawing.Point(456, 96);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(68, 34);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classNameDataGridViewTextBoxColumn,
            this.TotalLOC,
            this.NumberOfMethods,
            this.AverageMethodSize});
            this.dataGridView1.DataSource = this.locClassInfoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(891, 398);
            this.dataGridView1.TabIndex = 10;
            // 
            // TotalLOC
            // 
            this.TotalLOC.DataPropertyName = "TotalLOC";
            this.TotalLOC.HeaderText = "Total LOC";
            this.TotalLOC.Name = "TotalLOC";
            this.TotalLOC.ReadOnly = true;
            this.TotalLOC.Width = 150;
            // 
            // NumberOfMethods
            // 
            this.NumberOfMethods.DataPropertyName = "NumberOfMethods";
            this.NumberOfMethods.HeaderText = "Number Of Methods";
            this.NumberOfMethods.Name = "NumberOfMethods";
            this.NumberOfMethods.ReadOnly = true;
            this.NumberOfMethods.Width = 160;
            // 
            // AverageMethodSize
            // 
            this.AverageMethodSize.DataPropertyName = "AverageMethodSize";
            this.AverageMethodSize.HeaderText = "Average Method Size";
            this.AverageMethodSize.Name = "AverageMethodSize";
            this.AverageMethodSize.ReadOnly = true;
            this.AverageMethodSize.Width = 170;
            // 
            // openRulesDialog
            // 
            this.openRulesDialog.Filter = "Rule File|*.xml;";
            this.openRulesDialog.RestoreDirectory = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "LOC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Average class size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "LOC";
            // 
            // txtLOCSize
            // 
            this.txtLOCSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locSizeBindingSource, "TotalLOC", true));
            this.txtLOCSize.Location = new System.Drawing.Point(144, 18);
            this.txtLOCSize.Name = "txtLOCSize";
            this.txtLOCSize.ReadOnly = true;
            this.txtLOCSize.Size = new System.Drawing.Size(127, 22);
            this.txtLOCSize.TabIndex = 11;
            this.txtLOCSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumberOfClasses
            // 
            this.lblNumberOfClasses.AutoSize = true;
            this.lblNumberOfClasses.Location = new System.Drawing.Point(11, 49);
            this.lblNumberOfClasses.Name = "lblNumberOfClasses";
            this.lblNumberOfClasses.Size = new System.Drawing.Size(127, 17);
            this.lblNumberOfClasses.TabIndex = 3;
            this.lblNumberOfClasses.Text = "Number of Classes";
            // 
            // txtNumberOfClasses
            // 
            this.txtNumberOfClasses.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locSizeBindingSource, "NumberOfClasses", true));
            this.txtNumberOfClasses.Location = new System.Drawing.Point(144, 46);
            this.txtNumberOfClasses.Name = "txtNumberOfClasses";
            this.txtNumberOfClasses.ReadOnly = true;
            this.txtNumberOfClasses.Size = new System.Drawing.Size(127, 22);
            this.txtNumberOfClasses.TabIndex = 12;
            this.txtNumberOfClasses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalLocSize
            // 
            this.lblTotalLocSize.AutoSize = true;
            this.lblTotalLocSize.Location = new System.Drawing.Point(12, 21);
            this.lblTotalLocSize.Name = "lblTotalLocSize";
            this.lblTotalLocSize.Size = new System.Drawing.Size(103, 17);
            this.lblTotalLocSize.TabIndex = 4;
            this.lblTotalLocSize.Text = "Total LOC Size";
            // 
            // txtAvgSize
            // 
            this.txtAvgSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locSizeBindingSource, "AverageLOCSizePerClass", true));
            this.txtAvgSize.Location = new System.Drawing.Point(144, 74);
            this.txtAvgSize.Name = "txtAvgSize";
            this.txtAvgSize.ReadOnly = true;
            this.txtAvgSize.Size = new System.Drawing.Size(127, 22);
            this.txtAvgSize.TabIndex = 13;
            this.txtAvgSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupFileDefinition
            // 
            this.groupFileDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFileDefinition.Controls.Add(this.txtAvgSize);
            this.groupFileDefinition.Controls.Add(this.lblTotalLocSize);
            this.groupFileDefinition.Controls.Add(this.txtNumberOfClasses);
            this.groupFileDefinition.Controls.Add(this.lblNumberOfClasses);
            this.groupFileDefinition.Controls.Add(this.txtLOCSize);
            this.groupFileDefinition.Controls.Add(this.label4);
            this.groupFileDefinition.Controls.Add(this.label2);
            this.groupFileDefinition.Controls.Add(this.label3);
            this.groupFileDefinition.Location = new System.Drawing.Point(12, 136);
            this.groupFileDefinition.Name = "groupFileDefinition";
            this.groupFileDefinition.Size = new System.Drawing.Size(891, 102);
            this.groupFileDefinition.TabIndex = 2;
            this.groupFileDefinition.TabStop = false;
            this.groupFileDefinition.Text = "General Information";
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "Class Name";
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            this.classNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locClassInfoBindingSource
            // 
            this.locClassInfoBindingSource.DataSource = typeof(LOCCounter.Domain.LOCClassInfo);
            // 
            // locSizeBindingSource
            // 
            this.locSizeBindingSource.DataSource = typeof(LOCCounter.Domain.LOCSizeCounter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 654);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupFileDefinition);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "LOC Size Counter";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupFileDefinition.ResumeLayout(false);
            this.groupFileDefinition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locClassInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locSizeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource locClassInfoBindingSource;
        private System.Windows.Forms.ToolStripMenuItem loadRulesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openRulesDialog;
        private System.Windows.Forms.BindingSource locSizeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfMethods;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageMethodSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtLOCSize;
        private System.Windows.Forms.Label lblNumberOfClasses;
        private System.Windows.Forms.MaskedTextBox txtNumberOfClasses;
        private System.Windows.Forms.Label lblTotalLocSize;
        private System.Windows.Forms.MaskedTextBox txtAvgSize;
        private System.Windows.Forms.GroupBox groupFileDefinition;
    }
}

