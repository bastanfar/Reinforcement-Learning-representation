using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWindyGrid
{
    /// <summary>
    /// enum ProgramStateType:
    ///     The states which the program can be.
    /// </summary>
    public enum ProgramStateType
    {
        Prepare = 0,
        Ready = 1,
        Busy_MonteCarlo = 2,
        Busy_TD_SARSA = 3,
        Busy_TD_QLearning = 4,
        ShowingResults = 5
    }
}
