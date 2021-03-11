using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sort_experiment.ui
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtQuicksortH.Text = "100";
            txtQuicksortTh.Text = "1000";
            txtSelectionH.Text = "100";
            txtSelectionTh.Text = "1000";
        }
    }
}
