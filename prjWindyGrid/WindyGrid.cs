
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace prjWindyGrid
{
    /// <summary>
    /// class WindyGrid:
    ///     *** Is the core class of the program ***
    /// </summary>
    public class WindyGrid
    {
        // Members:
        internal static int MAX_NUM_of_EPISODES = 20000;

            // isAlgorithmCompleted: an array that each of its elements represents 
            //   whether the algorithm is done or not.
        private static bool[] isAlgorithmCompleted;

            // Specifies whether show first Episode of each algorithm by animation or not:
        private static bool SHOW_FIRST_EPISODE = false;

            // Specifies how often show the Episodes during algorithm execution:
        private static int SHOW_PERIODE = 1000;

        private Size gridSize;
        private int[] windValues;

        internal System.Windows.Forms.DataGridView dgGrid;
        private System.Windows.Forms.DataGridView dgWind;
        private System.Windows.Forms.Form parentForm;

        public static readonly Color color_Start = Color.Silver;
        public static readonly Color color_Terminal = Color.Gold;

            // directionStr: An array of strings 
            //  (e.g: -> or \/) to show the actions (e.g: Right or down) on the grid
        private static String[] directionStr = new string[4];


        internal Point startPoint = new Point(0, 0);

        private Point terminalPoint = new Point(1, 1);

        private Point currentPoint = new Point(0, 0);

            // AllEpisodesLengths: a 2-Dimentional array that each of its cells represents
            //   the length of i'th episode ('i' in row) for algorithm ('algorithm' in column)
        private int[,] AllEpisodesLengths = new int[MAX_NUM_of_EPISODES,3];

            // Time_Total: an array that each of its elements represents the 
            //   total time of running each of 3 algorithm
        private System.TimeSpan[] Time_Total = new TimeSpan[3];

            // Time_Wasted: an array that each of its elements represents 
            //   the WASTED TIME for showing episodes or showing the Policy graphically in one of 3 Algorithms
        private System.TimeSpan[] Time_Wasted = new TimeSpan[3];

        private int[] Number_of_Created_Episodes = new int[3];

        private ProgressBar prgrssBar_All;
        private ProgressBar prgrssBar_EpisodeLength;
        private Label lblEpisode_All;
        private Label lblEpisodeLength;
        private Label lbl_Algorithm_Parameters;

        // -----------------------------------------------------------------
        // -----------------------------------------------------------------
        // Methods:
        // -----------------------------------------------------------------

        #region Creator 

        // Creator:
        public WindyGrid(Form inParentForm,
                         DataGridView inDgGrid, DataGridView inDgWind,
                         ProgressBar inprgrssBar_All, ProgressBar inprgrssBar_EpisodeLength,
                         Label inLblEpisode_All, Label inLblEpisodeLength, Label in_Lbl_AlgorithmParameters)
        {
            MAX_NUM_of_EPISODES = 10000;
            this.parentForm = inParentForm;
            this.dgGrid = inDgGrid;
            this.dgWind = inDgWind;
            this.prgrssBar_All = inprgrssBar_All;
            this.prgrssBar_EpisodeLength = inprgrssBar_EpisodeLength;
            this.lblEpisode_All = inLblEpisode_All;
            this.lblEpisodeLength = inLblEpisodeLength;
            this.lbl_Algorithm_Parameters = in_Lbl_AlgorithmParameters;

            EpisodeAnimator.windyGrid = this;
            EpisodeAnimator.prgrssBar_EpisodeLength = this.prgrssBar_EpisodeLength;

            isAlgorithmCompleted = new bool[3];
            gridSize = new Size(10, 7);
            windValues = new int[10];
            resize_WindyGrid();

            directionStr[(int)ActionType.Up] = "/\\";
            directionStr[(int)ActionType.Down] = "\\/";
            directionStr[(int)ActionType.Left] = "<-";
            directionStr[(int)ActionType.Right] = "->";

            this.startPoint = new Point(3, 0);
            this.terminalPoint = new Point(3, 7);
            Set_WindValue(0, 0);
            Set_WindValue(1, 0);
            Set_WindValue(2, 0);
            Set_WindValue(3, 1);
            Set_WindValue(4, 1);
            Set_WindValue(5, 1);
            Set_WindValue(6, 2);
            Set_WindValue(7, 2);
            Set_WindValue(8, 1);
            Set_WindValue(9, 0);
            Refresh();
        }
        #endregion

        // -----------------------------------------------------------------

        #region Show Algorithms' Setings window & Set the changes 

        public void Show_Algorithms_Setings()
        {
            _frm_AlgorithmsSettings frm = new _frm_AlgorithmsSettings();
            frm.checkBox_ShowFirstEpisode.Checked = SHOW_FIRST_EPISODE;

            frm.txt_Max_Num_of_Episodes.Value = MAX_NUM_of_EPISODES;
            frm.txt_Show_Periode.Maximum = frm.txt_Max_Num_of_Episodes.Value;
            frm.txt_Show_Periode.Value = SHOW_PERIODE;

            frm.ShowDialog();

            if(frm.getValue == true)
            {
                MAX_NUM_of_EPISODES = decimal.ToInt32(frm.txt_Max_Num_of_Episodes.Value);
                SHOW_FIRST_EPISODE = frm.checkBox_ShowFirstEpisode.Checked;
                SHOW_PERIODE =decimal.ToInt32(frm.txt_Show_Periode.Value);
            }
        }

        #endregion

        // -----------------------------------------------------------------

        #region Show Results And Export them

        /// <summary>
        /// Shows the Results form to user
        /// </summary>
        public void Show_the_Results()
        {
            _frm_Results frm = new _frm_Results();
            frm.picSuccess_MC.Visible = isAlgorithmCompleted[0];
            frm.groupBox_MC.Enabled = isAlgorithmCompleted[0];

            frm.picSuccess_Sarsa.Visible = isAlgorithmCompleted[1];
            frm.groupBox_Sarsa.Enabled = isAlgorithmCompleted[1];

            frm.picSuccess_QL.Visible = isAlgorithmCompleted[2];
            frm.groupBox_QL.Enabled = isAlgorithmCompleted[2];


            frm.txt_Num_of_Episode_MC.Text = Number_of_Created_Episodes[0].ToString();
            frm.txt_Num_of_Episode_SARSA.Text = Number_of_Created_Episodes[1].ToString();
            frm.txt_Num_of_Episode_QL.Text = Number_of_Created_Episodes[2].ToString();

            frm.txt_TimeALL_MC.Text = Time_Total[0].ToString();
            frm.txt_TimeALL_SARSA.Text = Time_Total[1].ToString();
            frm.txt_TimeALL_QL.Text = Time_Total[2].ToString();

            frm.txt_TimeAnimation_MC.Text = Time_Wasted[0].ToString();
            frm.txt_TimeAnimation_SARSA.Text = Time_Wasted[1].ToString();
            frm.txt_TimeAnimation_QL.Text = Time_Wasted[2].ToString();

            frm.txtNetTime_MC.Text = (Time_Total[0] - Time_Wasted[0]).ToString();
            frm.txtNetTime_Sarsa.Text = (Time_Total[1] - Time_Wasted[1]).ToString();
            frm.txtNetTime_QL.Text = (Time_Total[2] - Time_Wasted[2]).ToString();

            frm.ShowDialog();
        }
        // End of Method: Show_the_Results

        // -----------------------------------------------------------------

        /// <summary>
        /// Exports all of the data about calculation of each 3 algorithms to a file
        /// </summary>
        public void Export_All_Episodes_lengths()
        {
            String FolderName = "#" + DateTime.Now.Year.ToString()
                                + "-" + DateTime.Now.Month.ToString()
                                + "-" + DateTime.Now.Day.ToString()
                                + "@" + DateTime.Now.Hour.ToString()
                                + "-" + DateTime.Now.Minute.ToString()
                                + "-" + DateTime.Now.Second.ToString()
                                +"\\";
            String fulDirectoryPath = Application.StartupPath.ToString() + "\\" + FolderName;

            // ------------------------------------

            String fileName = "Data.mat";
            try
            {
                // Create the directory (Folder)
                System.IO.Directory.CreateDirectory(fulDirectoryPath);
            }
            catch
            {
                MessageBox.Show("An Error is occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ** open the file:
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fulDirectoryPath + fileName);

            // ** Write the data in file:
            for (int i = 0; i < MAX_NUM_of_EPISODES; i++)
            {
                sw.WriteLine(AllEpisodesLengths[i, 0] + ","
                             + AllEpisodesLengths[i, 1] + ","
                             + AllEpisodesLengths[i, 2]);
            }
            // ** Close the file
            sw.Close();

            // ------------------------------------

            string fileName2 = "Parameters.txt";

            // ** open the file for Parameters:
            System.IO.StreamWriter sw2 = new System.IO.StreamWriter(fulDirectoryPath + fileName2);

            // ** Write the parameters in file:
            sw2.WriteLine(State.Get_the_Parameters_ToString());

            // ** Close the file
            sw2.Close();

            // ------------------------------------

            // ** Show success message
            MessageBox.Show("Data has successfuly exported to: "+
                            "\n"+ fulDirectoryPath + fileName +
                            "\n\nNow you can open MATLAB Aplication to view the Graphs"
                            ,"",MessageBoxButtons.OK , MessageBoxIcon.Information);
        }
        //End of Method: Export_All_Episodes_lengths

        #endregion

        // -----------------------------------------------------------------

        #region return Grid's Properties to show in Form (TextBoxes)

        public string GetGridSizeToString()
        {
            return this.gridSize.Height.ToString()
                     + "," + this.gridSize.Width.ToString();
        }

        public string GetStartPointTostring()
        {
            return startPoint.X.ToString() + "," + this.startPoint.Y.ToString();
        }

        public string GetGoalPointToString()
        {
            return terminalPoint.X.ToString() + "," + terminalPoint.Y.ToString();
        }

        #endregion

        // -----------------------------------------------------------------

        #region Check finished all algorithms

        public bool Is_Finished_All_the_Algorithms()
        {
            return(isAlgorithmCompleted[0] && isAlgorithmCompleted[1] && isAlgorithmCompleted[2]);
        }

        #endregion

        // -----------------------------------------------------------------

        #region Setting Grid's Size, Start, Goal & Wind

        public void Set_WindValue(int index, int windValue)
        {
            windValues[index] = windValue;
            write_WindWalues();
        }

        // -----------------------------------------------------------------

        public void Refresh()
        {
            this.clear_GridCells();
            this.write_Start_Goal_OnTheGrid();
            for (int i = 0; i < dgGrid.ColumnCount; i++)
            {
                for (int j = 0; j < dgGrid.RowCount; j++)
                {
                    dgGrid[i, j].Selected = false;
                }
            }
            this.dgGrid.Refresh();
            this.parentForm.Refresh();
        }

        // -----------------------------------------------------------------

        // Sets a Point 'p' to be the Start point
        public void Set_StartPoint(Point p)
        {
            // If the current position is Goal, Then: do nothing and return
            if (p == terminalPoint)
            {
                return;
            }

            // else: set this point to be Start Point
            startPoint.X = p.X;
            startPoint.Y = p.Y;

            // If the Grid's size has changed, then: move the Start point inside the grid
            if (p.X > gridSize.Height - 1)
            {
                startPoint.X = gridSize.Height - 1;
            }
            if (p.Y > gridSize.Width - 1)
            {
                startPoint.Y = gridSize.Width - 1;
            }
        }

        // -----------------------------------------------------------------

        // Setts a point 'p' to be the Goal point
        public void Set_GoalPoint(Point p)
        {
            // If the current position is Start, Then: do nothing and return
            if (p == startPoint)
            {
                return;
            }
            // else: set this point to be Goal Point
            terminalPoint.X = p.X;
            terminalPoint.Y = p.Y;

            // If the Grid's size has changed, then: move the Goal point inside the grid
            if (p.X > gridSize.Height - 1)
            {
                terminalPoint.X = gridSize.Height - 1;
            }
            if (p.Y > gridSize.Width - 1)
            {
                terminalPoint.Y = gridSize.Width - 1;
            }
        }

        // -----------------------------------------------------------------

        public void Set_Width(int inWidth)
        {
            this.gridSize.Width = inWidth;
            this.resize_WindyGrid();
            this.Reset_StartAndGoal();
        }

        public void Set_Height(int inHeight)
        {
            this.gridSize.Height = inHeight;
            this.resize_WindyGrid();
            this.Reset_StartAndGoal();
        }

        // -----------------------------------------------------------------

        public void Reset_StartAndGoal()
        {
            Set_StartPoint(startPoint);
            Set_GoalPoint(terminalPoint);

            clear_GridCells();
            write_Start_Goal_OnTheGrid();
            write_WindWalues();
        }


        // ________________________________________________________________________
        // Private mthods:
        // ________________________________________________________________________

        private void resize_WindyGrid()
        {
            Array.Resize(ref windValues, gridSize.Width);

            dgGrid.ColumnCount = gridSize.Width;
            dgGrid.RowCount = gridSize.Height;

            dgWind.ColumnCount = gridSize.Width;
            dgWind.RowCount = 1;

            int cellHeight = dgGrid.Height / dgGrid.RowCount;
            int cellWidth = dgGrid.Width / dgGrid.ColumnCount;

            for (int r = 0; r < dgGrid.RowCount; r++)
            {
                dgGrid.Rows[r].Height = cellHeight;
            }
            for (int c = 0; c < dgGrid.ColumnCount; c++)
            {
                dgGrid.Columns[c].Width = cellWidth;
                dgWind.Columns[c].Width = cellWidth;
            }

            dgGrid.Refresh();
            dgWind.Refresh();
        }

        private void write_Start_Goal_OnTheGrid()
        {
            dgGrid[startPoint.Y, startPoint.X].Value = "Start";
            dgGrid[startPoint.Y, startPoint.X].Style.BackColor = color_Start;
            dgGrid[terminalPoint.Y, terminalPoint.X].Value = "Goal";
            dgGrid[terminalPoint.Y, terminalPoint.X].Style.BackColor = color_Terminal;
            //solve the background color problem:
            dgGrid[startPoint.Y, startPoint.X].Selected = false;
            dgGrid[terminalPoint.Y, terminalPoint.X].Selected = false;
        }

        private void write_WindWalues()
        {
            for (int i = 0; i < gridSize.Width; i++)
            {
                dgWind[i, 0].Value = windValues[i];
            }
        }

        private void clear_GridCells()
        {
            for (int r = 0; r < dgGrid.Rows.Count; r++)
                for (int c = 0; c < dgGrid.Columns.Count; c++)
                {
                    dgGrid[c, r].Value = "";
                    dgGrid[c, r].Style.BackColor = Color.White;
                }
        }

        #endregion

        // -----------------------------------------------------------------

        #region other Settings 
        public void Show_AnimationSettings()
        {
            EpisodeAnimator.change_Animation_Settings();
        }

        #endregion

        // -----------------------------------------------------------------

        #region Actions (Up, Down, Left & Right)

        private Point do_Action(State p, ActionType in_action)
        {
            currentPoint = p.Position;

            Point nextPoint = new Point();
            switch (in_action)
            {
                case ActionType.Up:
                    {
                        nextPoint = moveUp();
                        p.Visit_Action(ActionType.Up);
                        break;
                    }
                case ActionType.Down:
                    {
                        nextPoint = moveDown();
                        p.Visit_Action(ActionType.Down);
                        break;
                    }
                case ActionType.Left:
                    {
                        nextPoint = moveLeft();
                        p.Visit_Action(ActionType.Left);
                        break;
                    }
                case ActionType.Right:
                    {
                        nextPoint = moveRight();
                        p.Visit_Action(ActionType.Right);
                        break;
                    }
            }
            return nextPoint;      //unreachable Code
        }

        //This methods are related to: gridSize & windValues[]
        public Point moveUp()
        {
            windEffect();
            if ((currentPoint.X - 1) >= 0)
            {
                currentPoint.X = currentPoint.X - 1;
            }
            if (currentPoint.X < 0)
                currentPoint.X = 0;
            if (currentPoint.X >= gridSize.Height)
                currentPoint.X = gridSize.Height - 1;

            return currentPoint;
        }

        public Point moveDown()
        {
            windEffect();
            if ((currentPoint.X + 1) < gridSize.Height)
            {
                currentPoint.X = currentPoint.X + 1;
            }
            if (currentPoint.X < 0)
                currentPoint.X = 0;
            if (currentPoint.X >= gridSize.Height)
                currentPoint.X = gridSize.Height - 1;
            return currentPoint;
        }

        public Point moveLeft()
        {
            windEffect();
            if ((currentPoint.Y - 1) >= 0)
            {
                currentPoint.Y = currentPoint.Y - 1;
            }
            if (currentPoint.X < 0)
                currentPoint.X = 0;
            if (currentPoint.X >= gridSize.Height)
                currentPoint.X = gridSize.Height - 1;

            return currentPoint;
        }

        public Point moveRight()
        {
            windEffect();
            if ((currentPoint.Y + 1) < gridSize.Width)
            {
                currentPoint.Y = currentPoint.Y + 1;
            }
            if (currentPoint.X < 0)
                currentPoint.X = 0;
            if (currentPoint.X >= gridSize.Height)
                currentPoint.X = gridSize.Height - 1;

            return currentPoint;
        }

        private void windEffect()
        {
            //if ((currentPoint.X - (windValues[currentPoint.Y]) >= 0))
            {
                currentPoint.X = currentPoint.X - (windValues[currentPoint.Y]);
            }
           /* else
            {
                currentPoint.X = 0;
            }*/
        }

        #endregion

        // -----------------------------------------------------------------

        #region Algorithms (((* the Main Part of Program *))) 

        public void RunAlgorithm(AlgorithmType algorithm)
        {
            // Store the time before strating the algorithm
            System.DateTime startTime = System.DateTime.Now;

            lbl_Algorithm_Parameters.Text = State.Get_the_Parameters_ToString(algorithm);
            lbl_Algorithm_Parameters.Refresh();

            switch (algorithm)
            {
                case AlgorithmType.MonteCallo:
                    {
                        Learn_MonteCarlo();
                        break;
                    }

                case AlgorithmType.TD_Sarsa:
                    {
                        Learn_TD_Sarsa();
                        break;
                    }

                case AlgorithmType.TD_QLearning:
                    {
                        Learn_TD_Qlearning();
                        break;
                    }
            } 
            // End of running one of algorithms

            // Store the time at the end of algorithm
            System.DateTime endTime = System.DateTime.Now;

            // Calculate the time htat take to calculation
            System.TimeSpan all_Time = endTime - startTime;
            

            this.Time_Total[(int)algorithm] = all_Time;

            isAlgorithmCompleted[(int)algorithm] = true;
            lbl_Algorithm_Parameters.Text = "parameters:";

            MessageBox.Show("Finished \n\n" + "Time to Calculate: " + all_Time.ToString());

        } //End of method: RunAlgorithm

        // ------------------------------------------------------------------------
        // ------------------------------------------------------------------------
        // ------------------------------------------------------------------------


        private void Learn_MonteCarlo()
        {
            State[,] s = new State[gridSize.Height, gridSize.Width];
            for (int r = 0; r < gridSize.Height; r++)
            {
                for (int c = 0; c < gridSize.Width; c++)
                {
                    s[r, c] = new State(r, c);
                    s[r, c].Set_InitialPolicy();
                }
            }
            State StartState = s[startPoint.X, startPoint.Y];
            State TerminalState = s[terminalPoint.X, terminalPoint.Y];
            
            State currentState;
            Point nextPoint;
            ActionType currentAction = new ActionType();
            int epizodeLength;

            prgrssBar_All.Maximum = MAX_NUM_of_EPISODES;

            // ** Start to create episodes for "MAX_NUM_of_EPISODES" times:
            for (int episodeCounter = 1; episodeCounter <= MAX_NUM_of_EPISODES; episodeCounter++)
            {
                currentState = StartState;
                epizodeLength = 1;

                if (episodeCounter % SHOW_PERIODE == 0 || episodeCounter == 1 || episodeCounter == MAX_NUM_of_EPISODES)
                {
                    EpisodeAnimator.Add_To_Episode(startPoint);
                }

                prgrssBar_All.Value = episodeCounter;
                lblEpisode_All.Text = episodeCounter.ToString() + " of " + prgrssBar_All.Maximum.ToString();
                lblEpisode_All.Refresh();

                // *** Create an Episode (num: episodeCounter)
                EpisodeAnimator.Clear_Episode();
                while (currentState != TerminalState)
                {
                    epizodeLength ++;
                    //lblEpisodeLength.Text = epizodeLength.ToString();
                    //lblEpisodeLength.Refresh();

                    currentAction = currentState.Select_Action();
                    nextPoint = do_Action(currentState, currentAction);

                    // Record the movements of each "show_period" episode or final Episode
                    if (episodeCounter % SHOW_PERIODE == 0 || episodeCounter == 1 || episodeCounter == MAX_NUM_of_EPISODES)                 
                    {
                        lblEpisodeLength.Text = epizodeLength.ToString();
                        lblEpisodeLength.Refresh();
                        EpisodeAnimator.Add_To_Episode(nextPoint);
                    }

                    currentState = s[nextPoint.X, nextPoint.Y];

                    //Add current reward to each Return(s,a) that was viewed along episode
                    foreach (State si in s)
                    {
                        si.Add_Reward_to_Return(-1);
                    }
                }
                // *** End of an Episode

                // Save the length of episode in the related palce:
                AllEpisodesLengths[episodeCounter-1, (int)AlgorithmType.MonteCallo] = epizodeLength;
                

                // At the end of each episode: Add returns to the Q and Set epsilon-policy
                foreach (State si in s)
                {
                    si.Update_Q_As_Average_of_Returns(episodeCounter);
                }

                // Show the episode's Animation:
                if (episodeCounter % SHOW_PERIODE == 0 || (episodeCounter == 1 && SHOW_FIRST_EPISODE) || (episodeCounter == MAX_NUM_of_EPISODES)) 
                {
                    EpisodeAnimator.Add_To_Episode(terminalPoint);
                    Time_Wasted[0] += EpisodeAnimator.Show_Episode_Animation();
                    lblEpisodeLength.Text = "";
                    lblEpisodeLength.Refresh();
                    //Time_Wasted[0] += show_the_Policy_on_Grid(s);
                }

            } 
            // ** End of Creating All Episodes

            Number_of_Created_Episodes[0] = MAX_NUM_of_EPISODES;      

            Time_Wasted[0] += show_the_Policy_on_Grid(s);
        }
        // End of method: Learn_MC

        //-------------------------------------------------------------------------
        // ------------------------------------------------------------------------
        // ------------------------------------------------------------------------


        private void Learn_TD_Sarsa()
        {
            State[,] s = new State[gridSize.Height, gridSize.Width];
            for (int r = 0; r < gridSize.Height; r++)
            {
                for (int c = 0; c < gridSize.Width; c++)
                {
                    s[r, c] = new State(r, c);
                    s[r, c].Set_InitialPolicy();
                }
            }
            State StartState = s[startPoint.X, startPoint.Y];
            State TerminalState = s[terminalPoint.X, terminalPoint.Y];

            State currentState;
            State nextState;
            ActionType currentAction = new ActionType();
            ActionType nextAction = new ActionType();
            Point nextPoint;

            prgrssBar_All.Maximum = MAX_NUM_of_EPISODES;
            // ** Start to create episodes for "MAX_NUM_of_EPISODES" times:
            for (int episodeCounter = 1; episodeCounter <= MAX_NUM_of_EPISODES; episodeCounter++)
            {
                currentState = StartState;
                int epizodeLength = 1;
                if (episodeCounter % SHOW_PERIODE == 0 || episodeCounter == 1 || episodeCounter == MAX_NUM_of_EPISODES)
                {
                    EpisodeAnimator.Add_To_Episode(startPoint);
                }

                prgrssBar_All.Value = episodeCounter;
                lblEpisode_All.Text = episodeCounter.ToString() + " of " + prgrssBar_All.Maximum.ToString();
                lblEpisode_All.Refresh();


                // *** Create an Episode (num: episodeCounter)
                currentAction = currentState.Select_Action();
                EpisodeAnimator.Clear_Episode();

                while (currentState != TerminalState)
                {
                    epizodeLength++;
                    //lblEpisodeLength.Text = epizodeLength.ToString();
                    //lblEpisodeLength.Refresh();

                    nextPoint = do_Action(currentState, currentAction);
                    nextState = s[nextPoint.X, nextPoint.Y];
                    nextAction = nextState.Select_Action();

                    currentState.Update_Q_by_Bootstaraping(episodeCounter, currentAction,-1, (nextState.Q[(int)nextAction]));

                    // Record the movements of each "show_period" episode or final Episode
                    if (episodeCounter % SHOW_PERIODE == 0 || episodeCounter == 1 || episodeCounter == MAX_NUM_of_EPISODES)                 
                    {
                        EpisodeAnimator.Add_To_Episode(nextPoint);
                        lblEpisodeLength.Text = epizodeLength.ToString();
                        lblEpisodeLength.Refresh();
                    }

                    currentState = nextState;
                    currentAction = nextAction;
                } 
                // *** End of an Episode

                // Save the length of episode in the related palce:
                AllEpisodesLengths[episodeCounter - 1, (int)AlgorithmType.TD_Sarsa] = epizodeLength;

                // Show the episode's animation:
                if (episodeCounter % SHOW_PERIODE == 0 || (episodeCounter == 1 && SHOW_FIRST_EPISODE) || (episodeCounter == MAX_NUM_of_EPISODES))
                {
                    EpisodeAnimator.Add_To_Episode(terminalPoint);
                    Time_Wasted[1] += EpisodeAnimator.Show_Episode_Animation();
                    lblEpisodeLength.Text = "";
                    lblEpisodeLength.Refresh();
                    //Time_Wasted[1] += show_the_Policy_on_Grid(s);
                }
            } 
            // ** End of Creating All Episodes

            Number_of_Created_Episodes[1] = MAX_NUM_of_EPISODES; 

            Time_Wasted[1] += show_the_Policy_on_Grid(s);
        } 
        //End of method: Learn_TD_Sarsa

        //-------------------------------------------------------------------------
        // ------------------------------------------------------------------------
        // ------------------------------------------------------------------------


        private void Learn_TD_Qlearning()
        {
            State[,] s = new State[gridSize.Height, gridSize.Width];
            for (int r = 0; r < gridSize.Height; r++)
            {
                for (int c = 0; c < gridSize.Width; c++)
                {
                    s[r, c] = new State(r, c);
                    s[r, c].Set_InitialPolicy();
                }
            }
            State StartState = s[startPoint.X, startPoint.Y];
            State TerminalState = s[terminalPoint.X, terminalPoint.Y];

            State currentState;
            State nextState;
            ActionType currentAction = new ActionType();

            Point nextPoint;
            prgrssBar_All.Maximum = MAX_NUM_of_EPISODES;

            // ** Start to create episodes for "MAX_NUM_of_EPISODES" times:
            for (int episodeCounter = 1; episodeCounter <= MAX_NUM_of_EPISODES; episodeCounter++)
            {
                currentState = StartState;
                int epizodeLength = 1;
                if (episodeCounter % SHOW_PERIODE == 0 || episodeCounter == 1 || episodeCounter == MAX_NUM_of_EPISODES)
                {
                    EpisodeAnimator.Add_To_Episode(startPoint);
                }

                prgrssBar_All.Value = episodeCounter;
                lblEpisode_All.Text = episodeCounter.ToString() + " of " + prgrssBar_All.Maximum.ToString();
                lblEpisode_All.Refresh();

                // *** Create an Episode (num: episodeCounter)
                EpisodeAnimator.Clear_Episode();

                while (currentState != TerminalState)
                {
                    epizodeLength++ ;
                    //lblEpisodeLength.Text = epizodeLength.ToString();
                    //lblEpisodeLength.Refresh();

                    currentAction = currentState.Select_Action();
                    nextPoint = do_Action(currentState, currentAction);
                    nextState = s[nextPoint.X, nextPoint.Y];

                    currentState.Update_Q_by_Bootstaraping(episodeCounter, currentAction, -1, (nextState.Get_Maximum_Q()));

                    // Record the movements of each "show_period" episode or final Episode
                    if (episodeCounter % SHOW_PERIODE == 0 || episodeCounter == 1 || episodeCounter == MAX_NUM_of_EPISODES)                 
                    {
                        EpisodeAnimator.Add_To_Episode(nextPoint);
                        lblEpisodeLength.Text = epizodeLength.ToString();
                        lblEpisodeLength.Refresh();
                    }

                    currentState = nextState;

                } 
                // *** End of an Episode

                // Save the length of episode in the related palce:
                AllEpisodesLengths[episodeCounter - 1, (int)AlgorithmType.TD_QLearning] = epizodeLength;

                // Show the episode's Animation:
                if (episodeCounter % SHOW_PERIODE == 0 || (episodeCounter == 1 && SHOW_FIRST_EPISODE) || (episodeCounter == MAX_NUM_of_EPISODES))
                {
                    EpisodeAnimator.Add_To_Episode(terminalPoint);
                    Time_Wasted[2] += EpisodeAnimator.Show_Episode_Animation();
                    lblEpisodeLength.Text = "";
                    lblEpisodeLength.Refresh();
                    //Time_Wasted[2] += show_the_Policy_on_Grid(s);
                }
            }  
            // ** End of Creating All Episodes 

            Number_of_Created_Episodes[2] = MAX_NUM_of_EPISODES; 

            Time_Wasted[2] += show_the_Policy_on_Grid(s);
        }
        //End of method: Learn_TD_Qlearning

        #endregion // Algorithms

        // -----------------------------------------------------------------

        #region Show Policy on Grid

        private TimeSpan show_the_Policy_on_Grid(State[,] s)
        {
            System.DateTime startTime = System.DateTime.Now;

                // Write the policy directions
            for (int r = 0; r < gridSize.Height; r++)
            {
                for (int c = 0; c < gridSize.Width; c++)
                {
                    dgGrid[c, r].Value = directionStr[(int) s[r, c].aStar];
                }
            }
            dgGrid[terminalPoint.Y, terminalPoint.X].Value = "Goal";

            MessageBox.Show("Click OK to continue ...");

                // Clean
            this.Refresh();

            System.DateTime endTime = System.DateTime.Now;

                // Return the time that has spended to show the episode:
            return (endTime - startTime);
        }
        // End of Method: show_the_Policy_on_Grid

        #endregion

        // -----------------------------------------------------------------

    }// End of Class: WindyGrid

}
// End of namespace: prjWindyGrid