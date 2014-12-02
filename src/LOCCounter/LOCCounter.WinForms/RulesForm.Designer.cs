namespace LOCCounter.WinForms
{
    partial class RulesForm
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
            this.toolStripRules = new System.Windows.Forms.ToolStrip();
            this.btnAddRule = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveRule = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.dataGridViewRules = new System.Windows.Forms.DataGridView();
            this.panelEditor = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.toolStripRules.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRules)).BeginInit();
            this.panelEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripRules
            // 
            this.toolStripRules.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripRules.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRule,
            this.btnRemoveRule});
            this.toolStripRules.Location = new System.Drawing.Point(0, 0);
            this.toolStripRules.Name = "toolStripRules";
            this.toolStripRules.Size = new System.Drawing.Size(708, 25);
            this.toolStripRules.TabIndex = 2;
            this.toolStripRules.Text = "toolStrip1";
            // 
            // btnAddRule
            // 
            this.btnAddRule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddRule.Image = global::LOCCounter.WinForms.Properties.Resources.Add_16;
            this.btnAddRule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(23, 22);
            this.btnAddRule.Text = "Add";
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // btnRemoveRule
            // 
            this.btnRemoveRule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveRule.Image = global::LOCCounter.WinForms.Properties.Resources.Remove_16;
            this.btnRemoveRule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveRule.Name = "btnRemoveRule";
            this.btnRemoveRule.Size = new System.Drawing.Size(23, 22);
            this.btnRemoveRule.Text = "Remove";
            this.btnRemoveRule.Click += new System.EventHandler(this.btnRemoveRule_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 186);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(708, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.btnUp, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.btnDown, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewRules, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(708, 161);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // btnUp
            // 
            this.btnUp.Image = global::LOCCounter.WinForms.Properties.Resources.ArrowUp_32;
            this.btnUp.Location = new System.Drawing.Point(668, 54);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(37, 23);
            this.btnUp.TabIndex = 1;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Image = global::LOCCounter.WinForms.Properties.Resources.ArrowDown_32;
            this.btnDown.Location = new System.Drawing.Point(668, 83);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(37, 23);
            this.btnDown.TabIndex = 2;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // dataGridViewRules
            // 
            this.dataGridViewRules.AutoGenerateColumns = false;
            this.dataGridViewRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.lOCValueDataGridViewTextBoxColumn});
            this.dataGridViewRules.DataSource = this.rulesBindingSource;
            this.dataGridViewRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRules.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewRules.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRules.Name = "dataGridViewRules";
            this.tableLayoutPanel.SetRowSpan(this.dataGridViewRules, 4);
            this.dataGridViewRules.RowTemplate.Height = 24;
            this.dataGridViewRules.Size = new System.Drawing.Size(659, 155);
            this.dataGridViewRules.TabIndex = 3;
            // 
            // panelEditor
            // 
            this.panelEditor.Controls.Add(this.splitter2);
            this.panelEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditor.Location = new System.Drawing.Point(0, 189);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(708, 230);
            this.panelEditor.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(607, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(512, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(89, 34);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lOCValueDataGridViewTextBoxColumn
            // 
            this.lOCValueDataGridViewTextBoxColumn.DataPropertyName = "LOCValue";
            this.lOCValueDataGridViewTextBoxColumn.HeaderText = "LOC Value";
            this.lOCValueDataGridViewTextBoxColumn.Name = "lOCValueDataGridViewTextBoxColumn";
            // 
            // rulesBindingSource
            // 
            this.rulesBindingSource.DataSource = typeof(LOCCounter.Domain.Rules.LOCSizeRuleBase);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 52);
            this.panel1.TabIndex = 10;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(708, 3);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 471);
            this.Controls.Add(this.panelEditor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.toolStripRules);
            this.Name = "RulesForm";
            this.Text = "Rules";
            this.toolStripRules.ResumeLayout(false);
            this.toolStripRules.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRules)).EndInit();
            this.panelEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripRules;
        private System.Windows.Forms.ToolStripButton btnAddRule;
        private System.Windows.Forms.ToolStripButton btnRemoveRule;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Panel panelEditor;
        private System.Windows.Forms.BindingSource rulesBindingSource;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridViewRules;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel1;
    }
}