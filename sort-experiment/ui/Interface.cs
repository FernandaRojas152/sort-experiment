using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sort_experiment.model;

namespace sort_experiment.ui
{
    
    public partial class Interface : Form
    {
        private Experiment experiment;
        public Interface()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            experiment = new Experiment();
            txtQuicksortH.Text = "100";
            txtQuicksortTh.Text = "1000";
            txtSelectionH.Text = "100";
            txtSelectionTh.Text = "1000";
        }
    }
}
