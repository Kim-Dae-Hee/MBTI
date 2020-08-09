using DevExpress.XtraEditors;
using MBTI.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MBTI
{
    public partial class ChartResultForm : XtraForm
    {
        private Test test;

        public ChartResultForm()
        {
            InitializeComponent();
        }

        public ChartResultForm(Test test)
        {
            this.test = test;
        }

        private void ChartResultForm_Load(object sender, System.EventArgs e)
        {
            Dictionary<string, int> sumGrades = new Dictionary<string, int>();

            var responses = DataRepository.Response.Get(test.TestId);

            foreach (Response response in responses)
            {
                string type = response.Question.Type;
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
                MessageBox.Show($"{sumGrades[key]}");
            }


        }
    }
}