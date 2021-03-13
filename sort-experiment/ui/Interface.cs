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
        private Quicksort quickSort;
        public Interface()
        {
            InitializeComponent();
            experiment = new Experiment();
            quickSort = new Quicksort();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            experiment.generateArray(10);
            txtSelection.Text = experiment.Selection()+"";
            experiment.generateArray(10);
            txtQuicksort.Text = quickSort.quickSort(experiment.GetArr(), 0, experiment.GetArr().Length-1)+"";
            experiment.generateArray(100);
            txtSelectionH.Text = experiment.Selection()+"";
            experiment.generateArray(100);
            txtQuicksortH.Text = quickSort.quickSort(experiment.GetArr(), 0, experiment.GetArr().Length-1)+"";
            experiment.generateArray(1000);
            txtSelectionTh.Text = experiment.Selection()+"";
            experiment.generateArray(1000);
            txtQuicksortTh.Text = quickSort.quickSort(experiment.GetArr(), 0, experiment.GetArr().Length-1)+"";
        }
    }
}
