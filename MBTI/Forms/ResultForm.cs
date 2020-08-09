using DevExpress.XtraEditors;
using MBTI.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MBTI
{
    public partial class ResultForm : XtraForm
    {
        private Test test;
        public ResultForm()
        {
            InitializeComponent();
        }

       
        /*
        public ResultForm(Test test) : this()
        {
            this.test = test;
        }
        */

        private void ResultForm_Load(object sender, System.EventArgs e)
        {
         
            List<PieChartResult> resultSection1 = new List<PieChartResult>();
            List<PieChartResult> resultSection2 = new List<PieChartResult>();
            List<PieChartResult> resultSection3 = new List<PieChartResult>();
            List<PieChartResult> resultSection4 = new List<PieChartResult>();

            Dictionary<string, int> sumGrades = new Dictionary<string, int>();
            var responses = DataRepository.Response.Get(66);

            foreach (Response response in responses)
            {
                string type = DataRepository.Question.Get(response.QuestionId).Type;

                if (sumGrades.ContainsKey(type))
                {
                    sumGrades[type] += (int)response.Grade;
                }
                else
                {
                    sumGrades[type] = (int)response.Grade;
                }
            }

            foreach (string key in sumGrades.Keys)
            {
                PieChartResult resultReader = new PieChartResult();
                resultReader.Type = key;
                resultReader.Grade = sumGrades[key];

                if (key == "E" || key == "I")
                {
                    resultSection1.Add(resultReader);
                }
                else if (key == "S" || key == "N")
                {
                    resultSection2.Add(resultReader);
                }
                else if (key == "T" || key == "F")
                {
                    resultSection3.Add(resultReader);
                }
                else if (key == "J" || key == "P")
                {
                    resultSection4.Add(resultReader);
                }

            }

            dgvResult.Rows.Add(sumGrades["E"], sumGrades["I"], sumGrades["S"], sumGrades["N"], sumGrades["T"], sumGrades["F"], sumGrades["J"], sumGrades["P"]);

            bdsSection1.DataSource = resultSection1;
            bdsSection2.DataSource = resultSection2;
            bdsSection3.DataSource = resultSection3;
            bdsSection4.DataSource = resultSection4;

        }

     
    }
}
