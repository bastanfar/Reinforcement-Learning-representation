using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWindyGrid
{

    /// <summary>
    /// enum AlgorithmType:
    ///     The Algorithms which will be followed to learn the actor:
    /// </summary>
    public enum AlgorithmType
    {
        MonteCallo = 0,
        TD_Sarsa = 1,
        TD_QLearning = 2
    }
}
