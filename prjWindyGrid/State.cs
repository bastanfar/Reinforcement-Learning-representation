using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace prjWindyGrid
{
    /// <summary>
    /// Class state:
    ///     Each instance of this class represents a state (cell) of Windy-Grid
    ///     Each state contains its Position in the Grid, also contains values of Q(s,a) 
    ///     and Return (Return(s,a)) in the last episode.
    /// </summary>
    public class State
    {

        // Members:
        private static readonly double GAMA = 0.9;

            // Epsilon: it seems that, in MC: 0.4 or more, and in TD low value is  better
        private static readonly double EPSILON_MC = 0.4;

        private static readonly double EPSILON_TD = 0.05;

        private static readonly double ALPHA = 0.01;

        //-------------------------------------------------------

            // Position: is the Position of state (cell) in the Grid 
        public Point Position;

            // ACTIONs_COUNT: Number of all possible Actions 
        private static readonly int ACTIONs_COUNT = 4;

            // pi[a]: the Probability of selecting action a when the actor is in this cell
        private double[] pi = new double[ACTIONs_COUNT];

            // aStar: the best action in current cell (the action that has a maximum Q)
        public ActionType aStar;

            // Q[a]: the Action-Value function (Q(s,a))
        public double[] Q = new double[ACTIONs_COUNT];

            // visited_in_Episode[a]: shows that which action of this state is visited during the Episode
            //                        this member is used in MC method
        private bool[] visited_in_Episode = new bool[ACTIONs_COUNT]; 

            // Return[a]: is sum of all rewards starting from action a to terminal_state 
            //            this member is used in MC method
        private double[] Return = new double[ACTIONs_COUNT];

            // gamaPower[a]: the power of GAMA, in calculation of Return[a] 
            //               this member is used in MC method
        private int[] gamaPower = new int[ACTIONs_COUNT];

            // randomGen: the random generator
        private Random randomGen = new Random();
        private static double random_Number;
        private static ActionType selected_Action = new ActionType();
       
        // --------------------------------------------------
        // Methods:

        //Creator:
        public State(int row, int column)
        {
            this.Position.X = row;
            this.Position.Y = column;
        }

        // --------------------------------------------------
        
        /// <summary>
        /// Sets an arbitrary policy for the state
        /// </summary>
        public void Set_InitialPolicy()
        {
            this.pi[0] = 0.25;      // up
            this.pi[1] = 0.25;      // down
            this.pi[2] = 0.25;      // left
            this.pi[3] = 0.25;      // right
        }
        // End of Method: Set_InitialPolicy

        // --------------------------------------------------
        /// <summary>
        /// Selects an Action acording to Epsilon-Soft Policy (Which is saved in pi)
        ///     this method is used in all 3 Algorithms to select action in order to continuing the episode
        /// </summary>
        /// <returns>Returns the selected action</returns>
        public ActionType Select_Action()
        {
                // Create a random number between 0 and 1
            random_Number = randomGen.NextDouble();
                
                // Check that which action should be returned according to the random number
            if (random_Number <= pi[0])
                selected_Action = ActionType.Up;
            else if (random_Number <= pi[0] + pi[1])
                selected_Action = ActionType.Down;
            else if (random_Number <= pi[0] + pi[1] + pi[2])
                selected_Action = ActionType.Left;
            else if (random_Number <= pi[0] + pi[1] + pi[2] + pi[3])
                selected_Action = ActionType.Right;

                // Return the selected action
            return selected_Action;
        }
        // End of Method: Select_Action

        // --------------------------------------------------
        /// <summary>
        /// Selects an Action, acording to an arbitrary policy. 
        ///     This method is to use in Exploring Starts
        ///     !!! Only used in MONTE CARLO
        /// </summary>
        /// <returns>Returns the selected action</returns>
        public ActionType Select_Action_Exploring()
        {
            random_Number = randomGen.NextDouble();

            if (random_Number <= 1 / 4)
                selected_Action = ActionType.Up;
            else if (random_Number <= 2 / 4)
                selected_Action = ActionType.Down;
            else if (random_Number <= 3 / 4)
                selected_Action = ActionType.Left;
            else if (random_Number <= 1)
                selected_Action = ActionType.Right;
            return selected_Action;
        }
        // End of Method: Select_Action_Exploring


        // --------------------------------------------------
        /// <summary>
        /// Gets an action a, and sets visited_In_Episode[a] to be true. 
        ///     By this operation, the following Rewards will be added to Return(s,a). 
        ///     !!! Called Only in MONTE CARLO
        /// </summary>
        /// <param name="action">is the action which is visited during the episode</param>
        public void Visit_Action(ActionType action)
        {
            this.visited_in_Episode[(int)action] = true;
        }
        // End of Method: Visit_Action

        // --------------------------------------------------
        /// <summary>
        /// Gets reward of the action, and adds tha reward to state's Return 
        ///     in this way, it checks all actions (a) which are visited in Episode, 
        ///     then adds ((GAMA^gamaPower[a])* reward) to the return[a]. 
        ///     !!!! Only used in MONTECARLO
        /// </summary>
        /// <param name="reward">the reward that was gain</param>
        public void Add_Reward_to_Return(double reward)
        {
            for (int act = 0; act < 4; act++)
            {
                if (visited_in_Episode[act] == true)
                {
                    this.Return[act] += ( Math.Pow(GAMA, gamaPower[act]) * reward );
                    gamaPower[act]++;
                }
            }
        }
        // End of Method: Add_Reward_to_Return

        // --------------------------------------------------
        /// <summary>
        /// Updates Q values for each action a that is visited during the episode. 
        /// then, it resets values of Return, gamaPower and visited_in_Episode. 
        /// Finally updates the Epsilon soft policy
        ///     !!!! This method is clalled "AT THE END OF each episode" 
        ///     (in MONTE-CARLO)
        /// </summary>
        public void Update_Q_As_Average_of_Returns(double k)
        {
            for (int act = 0; act < 4; act++)
            {
                if (visited_in_Episode[act] == true)
                {
                                    // (1/k) or (ALPHA)
                    this.Q[act] +=  (  (1/k)  * (this.Return[act] - this.Q[act])   );
                }
                Return[act] = 0;
                visited_in_Episode[act] = false;
                gamaPower[act] = 0;
            }
            this.Update_EpsilonSoft_Policy(EPSILON_MC);
        }
        // End of Method: Update_Q_As_Average_of_Returns

        // --------------------------------------------------
        /// <summary>
        /// Updates Q (Average of Returns), acording to Bootstraping in the TD Method
        ///     !!!! This method is clalled "DURING each episode" 
        ///     (in Temporad Difference Methods)
        /// </summary>
        /// <param name="Action">the Action which is done during the episode</param>
        /// <param name="reward">the gained Reward </param>
        /// <param name="value">the value to add to the Q average</param>
        public void Update_Q_by_Bootstaraping(double k, ActionType Action, double reward, double value)
        {
                                    // (1/k) or ALPHA 
            this.Q[(int)Action] += ((ALPHA) * ((reward + (GAMA * value) - this.Q[(int)Action])));

            this.Update_EpsilonSoft_Policy(EPSILON_TD);
        }
        // End of Method: Update_Q_By_Bootstaraping

        // --------------------------------------------------
        /// <summary>
        ///     !!! This method is used in Q-Learning Algorithm
        /// </summary>
        /// <returns>the maximum value of Q[a] between 4 values</returns>
        public double Get_Maximum_Q()
        {
            int maxi = 0;
            if (this.Q[1] > Q[maxi])
                maxi = 1;
            if (this.Q[2] > Q[maxi])
                maxi = 2;
            if (this.Q[3] > Q[maxi])
                maxi = 3;
            return Q[maxi];
        }
        // End of Method: Get_Maximum_Q

        // --------------------------------------------------
        /// <summary>
        /// Selects action which has Maximum value of Q (i.e.: argmax Q(s,a)) 
        ///     to be the optimal action in this state (or a*). 
        ///     Then sets a probability of (EPSILON / 4) to each pi[a], 
        ///     and adds (1-Epsilon) to pi[a*]
        /// </summary>
        private void Update_EpsilonSoft_Policy(double epsilonValue)
        {
            int maxi = 0;
            if (this.Q[1] > Q[maxi])
                maxi = 1;
            if (this.Q[2] > Q[maxi])
                maxi = 2;
            if (this.Q[3] > Q[maxi])
                maxi = 3;

            aStar = (ActionType) maxi;

            for (int i = 0; i < 4; i++)
            {
                pi[i] = epsilonValue / 4;
            }
            pi[maxi] += 1 - epsilonValue;
        }
        // End of Method: Update_EpsilonSoft_Policy
        
        // --------------------------------------------------


        public static string Get_the_Parameters_ToString()
        {
            string retStr = "Parameters:  \n";
            retStr += "     Algorithm       GAMA  Epsilon  Alpha \n";
            retStr += "__________________________________________________________\n\n";
            retStr += "     Monte Carle   : " + GAMA.ToString() + "  " + EPSILON_MC.ToString() + "  " + "None" + "\n";
            retStr += "     TD SARSA      : " + GAMA.ToString() + "  " + EPSILON_TD.ToString() + "  " + ALPHA.ToString() + "\n";
            retStr += "     TD Q-Learning : " + GAMA.ToString() + "  " + EPSILON_TD.ToString() + "  " + ALPHA.ToString() + "\n";

            return retStr;
        }

        public static string Get_the_Parameters_ToString(AlgorithmType algorithm)
        {
            string retStr = "Parameters: \n";
            string space = "               ";

            if (algorithm == AlgorithmType.MonteCallo)
            {
                retStr += space + "GAMA   =" + GAMA.ToString() + "\n";
                retStr += space + "Epsilon =" + EPSILON_MC.ToString() + "\n";
                retStr += space + "Alpha   =" + "None";
            }
            else if (algorithm == AlgorithmType.TD_Sarsa)
            {
                retStr += space + "GAMA   =" + GAMA.ToString() + "\n";
                retStr += space + "Epsilon =" + EPSILON_TD.ToString() + "\n";
                retStr += space + "Alpha   =" + ALPHA.ToString();
            }
            else if (algorithm == AlgorithmType.TD_QLearning)
            {
                retStr += space + "GAMA   =" + GAMA.ToString() + "\n";
                retStr += space + "Epsilon =" + EPSILON_TD.ToString() + "\n";
                retStr += space + "Alpha   =" + ALPHA.ToString();
            }
            return retStr;
        }

        // --------------------------------------------------

    } // End of Class: State

}
// End of namespace: prjWindyGrid