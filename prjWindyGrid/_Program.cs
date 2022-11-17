/* 
 * In the name of GOD
 *
 *  A Project for Machine Learning (Expert Systems & Knowledge-Engineering Course)
 *      C# (C-Sharp) Code for training Windy Grid 
 *      using Monte Carlo and TD (SRSA and Q-Learning) algorithms.
 *           
 *  Description:
 *      This Program is to training an Actor to pass from an state (S) to another -
 *      state (G) using 3 Algorithms: (Monte Carlo), (TD SARSA) & (TD Q-Learning)
 * 
 *  Author: Aliasghar Bastanfar
 *      Thanks to my supervisor: Dr. Jamshid Bagherzadeh
 *
 *  Disclaimer:  
 *      All code is provided on an "AS IS" basis, without warranty. The author 
 *      makes no representation, or warranty, either express or implied, with 
 *      respect to the code, its quality, accuracy, or fitness for a specific 
 *      purpose. Therefore, the author shall not have any liability to you or any 
 *      other person or entity with respect to any liability, loss, or damage 
 *      caused or alleged to have been caused directly or indirectly by the code
 *      provided.  This includes, but is not limited to, interruption of service, 
 *      loss of data, loss of profits, or consequential damages from the use of 
 *      this code.
 *
 *  Support e-Mail: 
 *      aa.bastanfar@gmail.com
 *  
 *  Year: 2011
 */
// --------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace prjWindyGrid
{
    /// <summary>
    /// class: _Program
    ///         starting class in the Application.
    /// </summary>
    static class _Program
    {
        public static ProgramStateType prgState = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new _frmMain());
        }
    } // End of Class: Program

}
