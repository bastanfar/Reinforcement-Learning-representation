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
    public partial class _frm_AnimationSettings : Form
    {
        public bool getValue;
        public _frm_AnimationSettings()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            getValue = true;
            this.Close();
        }

        private void checkBox_Show_CheckedChanged(object sender, EventArgs e)
        {
            groupBox.Enabled = checkBox_Show.Checked;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
