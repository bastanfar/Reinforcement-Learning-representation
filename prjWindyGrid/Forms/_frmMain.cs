
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
    public partial class _frmMain : Form
    {

        // Members:

        WindyGrid windyGrid;
        Point clickedCell = new Point(0, 0);
        int selectedColumn;


        // ------------------------------------------------------------------------------
        // Methods:
        // ------------------------------------------------------------------------------

        #region Creator
        // Creator:
        public _frmMain()
        {
            InitializeComponent();

            windyGrid = new WindyGrid(this, this.dgGrid, this.dgWind,
                                     this.prgrssBar_All , this.prgrssBar_EpisodeLength ,
                                     this.lblEpisode_ALL, lblEpisodeLength , this.lbl_Algorithm_Parameters);
            this.write_GridProperties_on_TextBoxes();
            set_PrepareState();
        }
        #endregion

        // ---------------------------------------------------------------------

        #region Buttons  

        private void btn_AcceptGridProperties_Click(object sender, EventArgs e)
        {
            set_ReadyState();
        }

        private void btn_AlgrorithmSetting_Click(object sender, EventArgs e)
        {
            windyGrid.Show_Algorithms_Setings();
        }

        private void btn_AnimSettinsa_Click(object sender, EventArgs e)
        {
            windyGrid.Show_AnimationSettings();
        }

        private void btn_RestartProg_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_Start_MC_Click(object sender, EventArgs e)
        {
            set_BusyState(AlgorithmType.MonteCallo);
            this.Refresh();
            
            windyGrid.RunAlgorithm(AlgorithmType.MonteCallo);

            set_ReadyState();
            this.Refresh();
        }

        private void btn_Start_TD_Sarsa_Click(object sender, EventArgs e)
        {
            set_BusyState(AlgorithmType.TD_Sarsa);
            this.Refresh();
            
            windyGrid.RunAlgorithm(AlgorithmType.TD_Sarsa);

            set_ReadyState();
            this.Refresh();
        }

        private void btn_StartTD__QL_Click(object sender, EventArgs e)
        {
            set_BusyState(AlgorithmType.TD_QLearning);
            this.Refresh();
            
            windyGrid.RunAlgorithm(AlgorithmType.TD_QLearning);

            set_ReadyState();
            this.Refresh();
        }

        private void btn_Export_Data_Click(object sender, EventArgs e)
        {
            windyGrid.Export_All_Episodes_lengths();
        }

        private void btn_Results_Click(object sender, EventArgs e)
        {
            windyGrid.Show_the_Results();
        }

        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm_About aboutForm = new _frm_About();
            aboutForm.ShowDialog();
        }

        #endregion

        // ---------------------------------------------------------------------

        #region Setting Program's States  

        private void set_PrepareState()
        {
            _Program.prgState = ProgramStateType.Prepare;
            this.groupBox_GridSettings.Enabled = true;
            this.dgWind.Enabled = true;
            this.groupBox_Operation.Enabled = false;
            this.groupBox_Results.Enabled = false;
            this.lblEpisode_ALL.Text = "";
            this.lblEpisodeLength.Text = "";
            this.lbl_Algorithm_Parameters.Text = "";
            lbl_M1.Hide();
            lbl_M2.Hide();

            lblStatus_Help.Text = " (Preparation) Define your own settings for the Grid or Click Ok";
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgGrid.Cursor = System.Windows.Forms.Cursors.Cross;
        }
        // End of method: set_PrepareState


        private void set_ReadyState()
        {
            _Program.prgState = ProgramStateType.Ready;
            this.groupBox_GridSettings.Enabled = false;
            this.dgWind.Enabled = false;
            this.groupBox_Operation.Enabled = true;
            this.groupBox_Results.Enabled = true;

            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCurrentOperation.Text = "";
            this.lblEpisode_ALL.Text = "";
            this.lblEpisodeLength.Text = "";
            this.lbl_Algorithm_Parameters.Text = "";
            this.prgrssBar_All.Value = 0;
            lbl_M1.Hide();
            lbl_M2.Hide();

            if (windyGrid.Is_Finished_All_the_Algorithms())
            {
                set_ShowResultsState();
            }
            else
            {
                lblStatus_Help.Text = " (Ready) Cick on one of Algorithmas, to Start Learning";
            }
        }
        // End of method: set_ReadyState


        private void set_BusyState(AlgorithmType Algorithm)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            switch (Algorithm)
            {
                case AlgorithmType.MonteCallo:
                    {
                        _Program.prgState = ProgramStateType.Busy_MonteCarlo;
                        btn_Start_MC.Enabled = false;
                        lblStatus_Help.Text = " (Busy) The Actor is Learning, using Monte Calrlo Method.";
                        lblCurrentOperation.Text = "Training with Monte Carlo";
                        break;
                    }
                case AlgorithmType.TD_Sarsa:
                    {
                        _Program.prgState = ProgramStateType.Busy_TD_SARSA;
                        btn_Start_TD_Sarsa.Enabled = false;
                        lblStatus_Help.Text = "  (Busy) The Actor is Learning, using TD SARSA Method.";
                        lblCurrentOperation.Text = "Training with TD SARSA";
                        break;
                    }

                case AlgorithmType.TD_QLearning:
                    {

                        _Program.prgState = ProgramStateType.Busy_TD_QLearning;
                        btn_StartTD__QL.Enabled = false;
                        lblStatus_Help.Text = "  (Busy) The Actor is Learning, using TD Q-Learning Method.";
                        lblCurrentOperation.Text = "Training with TD Q-Learning";
                        break;
                    }
            }
            lbl_M1.Show();
            lbl_M2.Show();
            groupBox_Settings.Enabled = false;
        }
        // End of method: set_BusyState


        public void set_ShowResultsState()
        {
            lblStatus_Help.Text = " Finished All of the Algorithmas. Click on the Show Results to see the results";
            groupBox_Settings.Enabled = false;
        }
        // End of method: set_ShowResultsState

        #endregion

        // ---------------------------------------------------------------------

        #region Change Grid's properties   

        // ---------------------------------------------------------------------
        // Change Size of the Windy Grid 
        private void txtGridRows_ValueChanged(object sender, EventArgs e)
        {
            windyGrid.Set_Height(decimal.ToInt32(this.txtGridRows.Value));
            this.write_GridProperties_on_TextBoxes();
        }

        private void txtGridCols_ValueChanged(object sender, EventArgs e)
        {
            windyGrid.Set_Width(decimal.ToInt32(this.txtGridCols.Value));
            this.write_GridProperties_on_TextBoxes();
        }


        // ---------------------------------------------------------------------

        // Setting "Start Point" to be the clickedCell, if the user is clicked on the menu
        private void mnu_SetStartHere_Click(object sender, EventArgs e)
        {
            windyGrid.Set_StartPoint(clickedCell);
            windyGrid.Reset_StartAndGoal();
            this.write_GridProperties_on_TextBoxes();
        }

        // Setting "Goal Point" to be the clickedCell, if the user is clicked on the menu
        private void mnu_SetGoalHere_Click(object sender, EventArgs e)
        {
            windyGrid.Set_GoalPoint(clickedCell);
            windyGrid.Reset_StartAndGoal();
            this.write_GridProperties_on_TextBoxes();
        }
        // ---------------------------------------------------------------------

        // Write the information of Grid into textBoxes:
        private void write_GridProperties_on_TextBoxes()
        {
            txtStartPoint.Text = windyGrid.GetStartPointTostring();
            txtGoalPoint.Text = windyGrid.GetGoalPointToString();
        }

        // ---------------------------------------------------------------------


        // If the user doubleClicked or rightClicked on the Grid, 
        //          Then: Save current position and Show the menu to the user.
        private void dgGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_Program.prgState == ProgramStateType.Prepare)
            {
                //When the user DoubleClicked at Grid cell, 
                //          Show the menu and Store the cell number in the clickedCell
                mnu_Context_StartGoal.Show(MousePosition);
                this.clickedCell.X = e.RowIndex;
                this.clickedCell.Y = e.ColumnIndex;
            }
        }
        private void dgGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_Program.prgState == ProgramStateType.Prepare)
            {
            //When the user Right-Clicked at Grid cell, 
            //          Show the menu and Store the cell number in the clickedCell
                if (e.Button == MouseButtons.Right)
                {
                    mnu_Context_StartGoal.Show(MousePosition);
                    this.clickedCell.X = e.RowIndex;
                    this.clickedCell.Y = e.ColumnIndex;
                }
            }
        }

        // ---------------------------------------------------------------------

        private void dgGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblStatusPosition.Text = e.RowIndex.ToString() + "," + e.ColumnIndex.ToString();
        }

        private void dgGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            lblStatusPosition.Text = "     ";
        }

        // ---------------------------------------------------------------------

        private void dgWind_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectedColumn = e.ColumnIndex;
                
                txtWind.Value = Int32.Parse( dgWind[e.ColumnIndex, 0].Value.ToString());
                txtWind.Location = dgWind.Location;
                txtWind.Left =  dgWind.Left + (e.ColumnIndex * (dgWind.Width / dgWind.ColumnCount));
                txtWind.Height= (dgWind.Width / dgWind.ColumnCount);

                txtWind.Show();
            }
        }

        private void txtWind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                windyGrid.Set_WindValue(selectedColumn, decimal.ToInt32( txtWind.Value));
                txtWind.Hide();
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtWind.Hide();
            }
            if (e.KeyCode == Keys.Right)
            {
                dgWind[selectedColumn + 1, 0].Selected = true;
            }
        }

        private void txtWind_VisibleChanged(object sender, EventArgs e)
        {
            if (txtWind.Visible)
            {
                txtWind.Focus();
            }
        }

        private void txtWind_Leave(object sender, EventArgs e)
        {
            txtWind.Hide();
        }

        private void txtWind_ValueChanged(object sender, EventArgs e)
        {
            windyGrid.Set_WindValue(selectedColumn, decimal.ToInt32(txtWind.Value));
        }

        private void splitContainer1_Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            txtWind.Hide();
        }


        private void txtStartPoint_Click(object sender, EventArgs e)
        {
            show_RightClick_message();
        }

        private void txtGoalPoint_Click(object sender, EventArgs e)
        {
            show_RightClick_message();
        }

        private void show_RightClick_message()
        {
            MessageBox.Show("To set the Start or Goal Point, Please do RightClick or DoubleClick on your desired cell in the Grid", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        #endregion 

        // ---------------------------------------------------------------------

    } // End of Class: frmMain

}
