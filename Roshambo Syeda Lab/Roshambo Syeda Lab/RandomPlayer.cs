using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Syeda_Lab
{
    internal class RandomPlayer : Player
    {
       // Random random = new Random();
        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            Roshambo randomRoshambo = (Roshambo)random.Next(Enum.GetNames(typeof(Roshambo)).Length);
            return randomRoshambo;
        }
    }
}
