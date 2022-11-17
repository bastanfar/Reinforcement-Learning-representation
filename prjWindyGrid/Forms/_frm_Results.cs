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
    public partial class _frm_Results : Form
    {
        public _frm_Results()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _frm_Results_Load(object sender, EventArgs e)
        {
            btn_OK.Focus();
        }
    }
}
