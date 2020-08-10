using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MBTI.Data;

namespace MBTI.Forms
{
    public partial class TestForm : XtraForm
    {

        private int userId;
        private Test test;
        private Stopwatch stopwatch = new Stopwatch();
        StringBuilder time = new StringBuilder();
        private int gradeA;
        private int gradeB;
        public TestForm()
        {
            InitializeComponent();
        }

        public TestForm(int userId) : this()
        {
            this.userId = userId;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            QuestionLoad(1);

            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(TimerTick);

            stopwatch.Start();
            timer.Start();

        }

        private void TimerTick(object sender, EventArgs e)
        {
            time.Clear();

            int hours = stopwatch.Elapsed.Hours;
            int minutes = stopwatch.Elapsed.Minutes;
            int seconds = stopwatch.Elapsed.Seconds;

            if (hours < 10)
                time.Append("0" + hours.ToString());
            else
                time.Append(hours.ToString());

            time.Append(":");

            if (minutes < 10)
                time.Append("0" + minutes.ToString());
            else
                time.Append(minutes.ToString());

            time.Append(":");

            if (seconds < 10)
                time.Append("0" + seconds.ToString());
            else
                time.Append(seconds.ToString());

            lblTimer.Text = time.ToString();
        }

        private void QuestionLoad(int questionNumber)
        {
            Question questionA = DataRepository.Question.Get(questionNumber.ToString() + "a");
            Question questionB = DataRepository.Question.Get(questionNumber.ToString() + "b");

            StringBuilder text = new StringBuilder();
            text.Append(questionA.Id + " " + questionA.Text);
            txeQuestionA.Text = text.ToString();
            text.Clear();

            text.Append(questionB.Id + " " + questionB.Text);
            txeQuestionB.Text = text.ToString();
            text.Clear();

            lblProgress.Text = questionNumber.ToString() + " " + "/ 48";
        }

        private void InsertResponse(int questionNumber, string section, int gradeA, int gradeB)
        {
            Response response = new Response();
            response.TestId = test.TestId;
            response.QuestionId = questionNumber.ToString() + section;
            response.Grade = section == "a" ? gradeA : gradeB;
            //MessageBox.Show($"{response.QuestionId} {response.Grade}");
            DataRepository.Response.Insert(response);

            gradeA = -1;
            gradeB = -1;
        }

        private void UpdateResponse(int questionNumber, string section, int gradeA, int gradeB)
        {
            Response response = DataRepository.Response.Get(test.TestId).Find(x => x.QuestionId == questionNumber.ToString() + section);
            response.Grade = section == "a" ? gradeA : gradeB;
            //MessageBox.Show($"{response.QuestionId} {response.Grade}");
            DataRepository.Response.Update(response);

        }

        private void questionControl1_NextButtonClicked(object sender, QuestionControl.NextButtonClickedEventArgs e)
        {
            QuestionLoad(e.QuestionNumber);

            try
            {
                InsertResponse(e.QuestionNumber - 1, "a", e.GradeA, e.GradeB);
                InsertResponse(e.QuestionNumber - 1, "b", e.GradeA, e.GradeB);
            }
            catch
            {
                UpdateResponse(e.QuestionNumber - 1, "a", e.GradeA, e.GradeB);
                UpdateResponse(e.QuestionNumber - 1, "b", e.GradeA, e.GradeB);
            }

            if (e.QuestionNumber == 48)
                btnComplete.Visible = true;
            else
                btnComplete.Visible = false;

            gradeA = e.GradeA;
            gradeB = e.GradeB;
        }

        private void questionControl1_ButtonNumberClicked(object sender, QuestionControl.ButtonNumberClickedEventArgs e)
        {
            if (e.Section == "a")
                gradeA = int.Parse(e.Label);
            else
                gradeB = int.Parse(e.Label);
        }

        private void questionControl1_PreviousButtonClicked(object sender, QuestionControl.PreviousButtonClickedEventArgs e)
        {
            QuestionLoad(e.QuestionNumber);
            gradeA = e.GradeA;
            gradeB = e.GradeB;
        }

        private void questionControl1_TestCreated(object sender, QuestionControl.TestCreatedEventArgs e)
        {
            test = e.Test;
            test.UserId = userId;
            test.StartAt = DateTime.Now;

            DataRepository.Test.Update(test);
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (gradeA + gradeB != 5)
            {
                MessageBox.Show("합이 5가 되어야 합니다.");
                return;
            }

            try
            {
                InsertResponse(48, "a", gradeA, gradeB);
                InsertResponse(48, "b", gradeA, gradeB);
            }
            catch
            {
                UpdateResponse(48, "a", gradeA, gradeB);
                UpdateResponse(48, "b", gradeA, gradeB);
            }

            test.FinishAt = DateTime.Now;

            DataRepository.Test.Update(test);

            ResultForm resultForm = new ResultForm(test);
            resultForm.ShowDialog();

            Close();
        }
    }
}