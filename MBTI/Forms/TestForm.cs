using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MBTI.Data;

namespace MBTI.Forms
{
    public partial class TestForm : XtraForm
    {
        private int questionNumber = 1;
        private int userId;
        private int gradeA = 0;
        private int gradeB = 0;
        private Test test;

        Timer t = new Timer();

        public TestForm()
        {
            InitializeComponent();
            //timer1.Start();
        }

        public TestForm(int userId) : this()
        {
            this.userId = userId;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            test = new Test();
            test.UserId = userId;
            test.StartAt = DateTime.Now;

            DataRepository.Test.Insert(test);

            QuestionLoad(questionNumber);
                 
            t.Tick += new EventHandler(t_Tick);
            t.Start();

        }

        private void QuestionLoad(int questionNumber)
        {
            Question questionA = DataRepository.Question.Get(questionNumber.ToString() + "a");
            Question questionB = DataRepository.Question.Get(questionNumber.ToString() + "b");

            txeQuestionA.Text = questionA.Id + " " + questionA.Text;
            txeQuestionB.Text = questionB.Id + " " + questionB.Text;

        }

        private void t_Tick(object sender, EventArgs e)
        {
            
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            string time = "";

            if (hour < 10)
            {
                time += "0" + hour;
            }
            else
                time += hour;
            time += ":";

            if (minute < 10)
            {
                time += "0" + minute;
            }
            else
                time += minute;
            time += ":";

            if (second < 10)
            {
                time += "0" + second;
            }
            else
                time += second;

            label3.Text = time;
           
        }
       
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(gradeA + gradeB != 5)
            {
                MessageBox.Show("합이 5여야 합니다.");
                return;
            }
            else
            {
                InsertResponse("a");
                InsertResponse("b");
            }

            if (questionNumber == 48)
                return;

            questionNumber++;
            QuestionLoad(questionNumber);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (gradeA + gradeB != 5)
            {
                MessageBox.Show("합이 5여야 합니다.");
                return;
            }
          
            if (questionNumber == 0)
                return;

            questionNumber--;
            QuestionLoad(questionNumber);
        }

        private void InsertResponse(string section)
        {
            Response response = new Response();
            response.TestId = test.TestId;
            response.QuestionId = questionNumber.ToString() + section;
            response.Grade = section == "a" ? gradeA : gradeB;
            DataRepository.Response.Insert(response);
        }

       
        private void questionControl1_ButtonNumberClicked(object sender, QuestionControl.ButtonNumberClickedEventArgs e)
        {
            if (e.Section == "a")
                gradeA = int.Parse(e.Label);
            else
                gradeB = int.Parse(e.Label);
        }
    }
}