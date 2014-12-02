using LOCCounter.Domain.Rules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOCCounter.WinForms
{
    // TODO - Finish
    public partial class RulesForm : Form
    {
        private List<LOCSizeRuleBase> _Rules;

        public RulesForm(IEnumerable<LOCSizeRuleBase> rules)
        {
            InitializeComponent();

            _Rules = rules.ToList();
            rulesBindingSource.DataSource = _Rules;
        }

        private void MoveRule(bool up)
        {
            var rule = rulesBindingSource.Current;
            var ruleIndex = rulesBindingSource.IndexOf(rule);
            
            rulesBindingSource.Remove(rule);
            rulesBindingSource.Insert(ruleIndex + (up ? 1 : -1), rule);
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveRule_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveRule(true);
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveRule(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}