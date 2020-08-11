using MBTI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBTI
{
    public partial class SimulationForm : Form
    {
        public SimulationForm()
        {
            InitializeComponent();
        }

        private void SimulationForm_Load(object sender, EventArgs e)
        {
            List<SimulationReader> simulationReaders= GetSimulationResult();
            ShowSimulationResult(simulationReaders);
        }

        private List<SimulationReader> GetSimulationResult()
        {
            var personalityTypesCount = new Dictionary<int, int>();

            var tests = DataRepository.Test.GetAll();

            foreach (Test test in tests)
            {
                int key = (int)test.PersonalityTypeId;
                
                if (personalityTypesCount.ContainsKey(key))
                {
                    personalityTypesCount[key] += 1;
                }
                else
                {
                    personalityTypesCount[key] = 1;
                }
            }

            List<SimulationReader> simulationReaders = new List<SimulationReader>();

            foreach(int key in personalityTypesCount.Keys)
            {
                SimulationReader simulationReader = new SimulationReader();
                string personalityType = DataRepository.PersonalityType.Get(key).Type;
                simulationReader.Series = personalityType;
                simulationReader.Argument = personalityType.Substring(0, 4);
                simulationReader.Value = personalityTypesCount[key];
                simulationReaders.Add(simulationReader);
            }

            return simulationReaders;
        }

        private void ShowSimulationResult(List<SimulationReader> simulationReaders)
        {
            //MessageBox.Show($"{simulationReaders.Count}");
            bdsSimulation.DataSource = simulationReaders;
        }


    }
}
