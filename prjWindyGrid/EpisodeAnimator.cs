using System;
using System.Drawing;
using System.Windows.Forms;

namespace prjWindyGrid
{
    /// <summary>
    /// class EpisodeAnimation:
    ///     This Class is used only to show episodes (a consequence of cells) in the grid and in animation form
    /// </summary>
    static class EpisodeAnimator
    {
        // Members:

            // DELAY: the delay between two actions in episode (miliSeconds)
        private static int DELAY = 10;

        private static bool show_the_Episode = true;
        private static bool flash_When_Reached_Goal = true;
        private static bool maintain_the_Footprint = true;

            // windyGrid: an object of WindyGrid Class, which contains this class
        internal static WindyGrid windyGrid;

            // prgrssBar_EpisodeLength: tha ProgressBar control on the main form to show the progress of episode
        internal static ProgressBar prgrssBar_EpisodeLength;

            // pointArray: the list of points to show as an episode:
        private static System.Collections.Queue pointArray = new System.Collections.Queue();

            // color:
        private static Color[] path_color = new Color[7];
        private static Color footprintColor;

            // path: the points that show the path through Start point to Goal Point
            //       it contains 7 points: 
            //       6 points (0-5) show the head, and one point (6) show the footprint 
        private static Point[] path = new Point[7];


        // ----------------------------------------------------------------------------
        // Methods:
        // ----------------------------------------------------------------------------

        #region Creator
        /// <summary>
        /// Creator: Sets colors of the path.
        /// </summary>
        static EpisodeAnimator()
        {
                // Set the Colors for head of the path
            path_color[0] = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(10))))); //Color.Green;
            path_color[1] = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(220)))), ((int)(((byte)(50))))); //Color.LimeGreen;
            path_color[2] = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100))))); //Color.LawnGreen;
            path_color[3] = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(150))))); //Color.LawnGreen;
            path_color[4] = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200))))); //Color.PaleGreen;
            path_color[5] = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220))))); //Color.SpringGreen;
            footprintColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230))))); //Color.Honeydew;
            path_color[6] = footprintColor;
        }
        //End of Creator
        #endregion

        // ----------------------------------------------------------------------------

        #region Show Episode in Animation

        /// <summary>
        /// Adds a point to list of points in episode. 
        /// This method should be used during the calculation of an episode.
        /// </summary>
        /// <param name="inPoint">Point to add in the list</param>
        public static void Add_To_Episode(Point inPoint)
        {
            pointArray.Enqueue(inPoint);
        }
        // End of Method: Add_To_Episode

        // ----------------------------------------------------------------------------

        /// <summary>
        /// Clears the list of points. 
        /// this method should be used after showing the episode, when we want to create a new one.
        /// </summary>
        public static void Clear_Episode()
        {
            pointArray.Clear();
            prgrssBar_EpisodeLength.Value = 1;
        }
        // End of Method: Clear_Episode

        // ----------------------------------------------------------------------------

        /// <summary>
        /// Shows the path from Start to Goal.
        /// </summary>
        /// <returns>The time that left to show the episode</returns>
        public static TimeSpan Show_Episode_Animation()
        {
            System.DateTime startTime = System.DateTime.Now;
            System.DateTime endTime;

            if (!show_the_Episode)
            {
                endTime = System.DateTime.Now;
                return (endTime - startTime);
            }

            int i, j;

            prgrssBar_EpisodeLength.Maximum = pointArray.Count;
            prgrssBar_EpisodeLength.Value = 0;
            prgrssBar_EpisodeLength.Visible = true;
            prgrssBar_EpisodeLength.Refresh();

                // 1- Prepare the head of path
            for (i = 0; i < path.Length; i++)
            {
                path[i] = windyGrid.startPoint;
            }

            if (pointArray.Count > path.Length)
            {
                for (i = 0; i < path.Length; i++)
                {
                    for (j = i; j > 0; j--)
                    {
                        path[j] = path[j - 1];
                    }
                    if (pointArray.Count != 0)
                    {
                        path[0] = (Point)pointArray.Dequeue();
                        prgrssBar_EpisodeLength.Value++;
                        //windyGrid.dgGrid[point[0].Y, point[0].X].Value = curActionNumber.ToString();
                        //curActionNumber++;
                    }

                    for (j = 0; j <= i; j++)
                    {
                        windyGrid.dgGrid[path[j].Y, path[j].X].Style.BackColor = path_color[j];
                    }
                    windyGrid.dgGrid.Refresh();
                    System.Threading.Thread.Sleep(DELAY);
                }
            }


                // *** 2- Start to show the path until Terminal state is reached:
            while (pointArray.Count > 0)
            {
                for (i = path.Length - 1; i > 0; i--)
                {
                    path[i] = path[i - 1];
                }

                path[0] = (Point)pointArray.Dequeue();
                //if (prgrssBar_EpisodeLength.Value < prgrssBar_EpisodeLength.Maximum)
                {
                    prgrssBar_EpisodeLength.Value++;
                    prgrssBar_EpisodeLength.Refresh();
                }

                    //write the path's step in the grid: (((Disabed)))
                //windyGrid.dgGrid[point[0].Y, point[0].X].Value = curActionNumber.ToString();
                //curActionNumber++;

                for (i = path.Length - 1; i >= 0; i--)
                {
                    windyGrid.dgGrid[path[i].Y, path[i].X].Style.BackColor = path_color[i];
                }
                //windyGrid.dgGrid[point[6].Y, point[6].X].Value = "";
                windyGrid.dgGrid.Refresh();
           
                System.Threading.Thread.Sleep(DELAY);
                windyGrid.dgGrid.Refresh();
            }
                // *** End of episode (the Terminal state is reached)


            prgrssBar_EpisodeLength.Value = prgrssBar_EpisodeLength.Maximum;
            prgrssBar_EpisodeLength.Refresh();
            prgrssBar_EpisodeLength.Refresh();
            prgrssBar_EpisodeLength.Refresh();


                // Clean the path's head
            for (i = 0 ; i < path.Length ; i++)
            {
                windyGrid.dgGrid[path[i].Y, path[i].X].Style.BackColor = path_color[6];
            }

                // 3- Flash at the goal point:
            if (flash_When_Reached_Goal)
            {
                windyGrid.dgGrid.Refresh();
                windyGrid.dgGrid[path[0].Y, path[0].X].Style.BackColor = path_color[0];
                windyGrid.dgGrid.Refresh();
                System.Threading.Thread.Sleep(500);
                windyGrid.dgGrid[path[0].Y, path[0].X].Style.BackColor = WindyGrid.color_Terminal;
                windyGrid.dgGrid.Refresh();
                System.Threading.Thread.Sleep(500);
                windyGrid.dgGrid[path[0].Y, path[0].X].Style.BackColor = path_color[0];
                windyGrid.dgGrid.Refresh();
                System.Threading.Thread.Sleep(500);
                windyGrid.dgGrid[path[0].Y, path[0].X].Style.BackColor = WindyGrid.color_Terminal;
                windyGrid.dgGrid.Refresh();
                System.Threading.Thread.Sleep(500);
            }

                // 4- finish the show:

            /*    // Ask user about settings:
            if (MessageBox.Show("Current episode is finished." + "\n"
                            + "Do you want to change animation speed?\n"
                            + "Press Yes to change settings, or Press No to Continue ..."
                            , "",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                change_Animation_Settings();
            }
            */
            prgrssBar_EpisodeLength.Visible = false;
            windyGrid.Refresh();
            
            endTime = System.DateTime.Now;

                // Return the time that has spended to show the episode:
            return (endTime - startTime);
        }
        // End of Method: Show_Episode_Animation

        #endregion

        // ----------------------------------------------------------------------------

        #region change_Animation_Settings

        /// <summary>
        /// Shows the form of Animation Settings and changes the DELAY according to user's command.
        /// </summary>
        public static void change_Animation_Settings()
        {
            _frm_AnimationSettings frm = new _frm_AnimationSettings();
            frm.checkBox_Show.Checked = show_the_Episode;
            frm.txtDelay.Value = DELAY;
            frm.checkBox_Flash.Checked = flash_When_Reached_Goal;
            frm.checkBox_Maintain_Footprint.Checked = maintain_the_Footprint;
            frm.ShowDialog();
            if (frm.getValue == true)
            {
                DELAY = decimal.ToInt32(frm.txtDelay.Value);
                flash_When_Reached_Goal = frm.checkBox_Flash.Checked;
                maintain_the_Footprint = frm.checkBox_Maintain_Footprint.Checked;
                show_the_Episode = frm.checkBox_Show.Checked;

                if (frm.checkBox_Maintain_Footprint.Checked == false)
                {
                    path_color[path_color.Length - 1] = Color.White;
                }
                else
                {
                    path_color[path_color.Length - 1] = footprintColor;
                }
            }
        }
        // End of Method: change_Animation_Settings
        #endregion

        // ----------------------------------------------------------------------------

    }
    // End of Class: EpisodeAnimation

}
