using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTI.Data
{
    public class Program
    {
        private const int KIMDAEHEE = 7;

        static void Main(string[] args)
        {
            for(int i = 0; i < 10000; i++)
            {
                Simulation simulation = new Simulation(KIMDAEHEE);
                simulation.CreateTest();
                simulation.ChoiceQuestionsRandom();
                simulation.SetResult();
            }
        }
        
    }
}
