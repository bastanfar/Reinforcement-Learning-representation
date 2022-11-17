using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjWindyGrid
{
    public partial class _frm_AlgorithmsSettings : Form
    {
        public bool getValue;

        public _frm_AlgorithmsSettings()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            getValue = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Max_Num_of_Episodes_ValueChanged(object sender, EventArgs e)
        {
            txt_Show_Periode.Maximum = txt_Max_Num_of_Episodes.Value;
        }
    }
}
