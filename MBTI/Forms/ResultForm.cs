using DevExpress.XtraEditors;
using MBTI.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MBTI
{
    public partial class ResultForm : XtraForm
    {
        private Test test;
        private Dictionary<string, int> personalityTypes = new Dictionary<string, int>()
        {
            ["ISTJ"] = 1, ["ISFJ"] = 2, ["ISTP"] = 3, ["ISFP"] = 4,
            ["INFJ"] = 5, ["INTJ"] = 6, ["INFP"] = 7, ["INTP"] = 8,
            ["ESTP"] = 9, ["ESFP"] = 10,["ESTJ"] = 11,["ESFJ"] = 12,
            ["ENFP"] = 13,["ENTP"] = 14,["ENFJ"] = 15,["ENTJ"] = 16
        };

        public ResultForm()
        {
            InitializeComponent();
        }
       
        public ResultForm(Test test) : this()
        {
            this.test = test;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> sumGrades = GetSumGrades();
            string personalityType = GetPersonalityType(sumGrades);

            ShowPieChart(sumGrades);
            SetTableSettings(sumGrades);
            SetPersonality(personalityType);
        }

        private void SetPersonality(string personalityType)
        {
            
            // DB에 personalityType 저장
            test.PersonalityTypeId = personalityTypes[personalityType];
            DataRepository.Test.Update(test);

            // lblType, lblCharacteristic
            PersonalityType myPersonalityType = DataRepository.PersonalityType.Get((int)test.PersonalityTypeId);
            //PersonalityType myPersonalityType = DataRepository.PersonalityType.Get(personalityTypes[personalityType]);
            
            lblType.Text = myPersonalityType.Type;
            lblCharacteristic.Text = myPersonalityType.Characteristic;
        }

        private string GetPersonalityType(Dictionary<string, int> sumGrades)
        {
            StringBuilder personalityType = new StringBuilder();

            personalityType.Append(sumGrades["E"] >= sumGrades["I"] ? "E" : "I");
            personalityType.Append(sumGrades["S"] >= sumGrades["N"] ? "S" : "N");
            personalityType.Append(sumGrades["T"] >= sumGrades["F"] ? "T" : "F");
            personalityType.Append(sumGrades["J"] >= sumGrades["P"] ? "J" : "P");

            return personalityType.ToString();
        }

        private void SetTableSettings(Dictionary<string, int> sumGrades)
        {
            dgvResult.DefaultCellStyle.SelectionBackColor = dgvResult.DefaultCellStyle.BackColor;
            dgvResult.DefaultCellStyle.SelectionForeColor = dgvResult.DefaultCellStyle.ForeColor;
            dgvResult.Rows.Add(sumGrades["E"], sumGrades["I"], sumGrades["S"], sumGrades["N"], sumGrades["T"], sumGrades["F"], sumGrades["J"], sumGrades["P"]);
        }

        private Dictionary<string, int> GetSumGrades()
        {
            Dictionary<string, int> sumGrades = new Dictionary<string, int>();
            var responses = DataRepository.Response.Get(test.TestId);

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

            return sumGrades;
        }

        private void ShowPieChart(Dictionary<string, int> sumGrades)
        {
            List<PieChartResult> resultSection1 = new List<PieChartResult>();
            List<PieChartResult> resultSection2 = new List<PieChartResult>();
            List<PieChartResult> resultSection3 = new List<PieChartResult>();
            List<PieChartResult> resultSection4 = new List<PieChartResult>();

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

            bdsSection1.DataSource = resultSection1;
            bdsSection2.DataSource = resultSection2;
            bdsSection3.DataSource = resultSection3;
            bdsSection4.DataSource = resultSection4;
        }

    }
}

