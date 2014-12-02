using LOCCounter.Domain;
using LOCCounter.Domain.Rules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOCCounter.WinForms
{
    public partial class MainForm : Form
    {
        private string _RuleFile;
        private List<LOCSizeRuleBase> _Rules;

        private LOCSizeCounter _LOCSizeCounter;

        public MainForm()
        {
            InitializeComponent();

            _Rules = new List<LOCSizeRuleBase>();
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            btnCount.Enabled = !string.IsNullOrEmpty(txtFile.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFile.Text = openFileDialog.FileName;
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtFile.Text))
            {
                MessageBox.Show("Attention: The informed file does not exist.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Rules.Count == 0)
            {
                MessageBox.Show("Attention: There are no rules defined to the counting.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LOCSizeCounter = new LOCSizeCounter(openFileDialog.FileName, _Rules);
            _LOCSizeCounter.Count();
            locSizeBindingSource.DataSource = _LOCSizeCounter;
            locClassInfoBindingSource.DataSource = _LOCSizeCounter.Classes;
        }

        private void loadRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openRulesDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    _Rules = LOCLib.ReadCountingSizeRules(openRulesDialog.FileName);
                    MessageBox.Show(this, "Rules loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenRules();
                }
                catch
                {
                    MessageBox.Show(this, "An error occurred trying to load the rules. Try another file.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRules();
        }
        private void OpenRules()
        {
            using (var rulesForm = new RulesForm(_Rules))
            {
                rulesForm.ShowDialog(this);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog(this);
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}