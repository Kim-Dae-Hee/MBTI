using MBTI.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MBTI
{
    public partial class QuestionControl : UserControl
    {
        private int questionNumber = 1;
        List<ButtonNumber> buttonNumbers = new List<ButtonNumber>();
        private int gradeA;
        private int gradeB;
        private Test test;

        public QuestionControl()
        {
            InitializeComponent();

            buttonNumbers.Add(btnZeroA);
            buttonNumbers.Add(btnOneA);
            buttonNumbers.Add(btnTwoA);
            buttonNumbers.Add(btnThreeA);
            buttonNumbers.Add(btnFourA);
            buttonNumbers.Add(btnFiveA);

            buttonNumbers.Add(btnZeroB);
            buttonNumbers.Add(btnOneB);
            buttonNumbers.Add(btnTwoB);
            buttonNumbers.Add(btnThreeB);
            buttonNumbers.Add(btnFourB);
            buttonNumbers.Add(btnFiveB);

        }

        public QuestionControl(int questionNumber) : this()
        {
            this.questionNumber = questionNumber;
        }

        private void btnZeroA_ButtonNumberClicked(object sender, ButtonNumber.ButtonNumberClickedEventArgs e)
        {
            ClickedButtonNumberClear(e.Section);
            ButtonNumberClick(e.Label, e.Section);
           
            OnButtonNumberClicked(e.Label, e.Section);
        }

        private void ButtonNumberClick(string label, string section)
        {
            if (label == "0" && section == "a")
            {
                gradeA = 0;
                btnZeroA.Activate();
            }
            else if (label == "1" && section == "a")
            {
                gradeA = 1;
                btnOneA.Activate();
            }
            else if (label == "2" && section == "a")
            {
                gradeA = 2;
                btnTwoA.Activate();
            }
            else if (label == "3" && section == "a")
            {
                gradeA = 3;
                btnThreeA.Activate();
            }
            else if (label == "4" && section == "a")
            {
                gradeA = 4;
                btnFourA.Activate();
            }
            else if (label == "5" && section == "a")
            {
                gradeA = 5;
                btnFiveA.Activate();
            }
            else if (label == "0" && section == "b")
            {
                gradeB = 0;
                btnZeroB.Activate();
            }
            else if (label == "1" && section == "b")
            {
                gradeB = 1;
                btnOneB.Activate();
            }
            else if (label == "2" && section == "b")
            {
                gradeB = 2;
                btnTwoB.Activate();
            }
            else if (label == "3" && section == "b")
            {
                gradeB = 3;
                btnThreeB.Activate();
            }
            else if (label == "4" && section == "b")
            {
                gradeB = 4;
                btnFourB.Activate();
            }
            else if (label == "5" && section == "b")
            {
                gradeB = 5;
                btnFiveB.Activate();
            }
        }

        private void ClickedButtonNumberClear(string section)
        {
            if(section == "a")
            {
                for(int i = 0; i < buttonNumbers.Count / 2; i ++)
                {
                    buttonNumbers[i].DeActivate();
                }
            }
            else // section == "b"
            {
                for(int i = buttonNumbers.Count / 2; i < buttonNumbers.Count; i++)
                {
                    buttonNumbers[i].DeActivate();
                }
            }
        }

        private void QuestionControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            test = new Test();
            DataRepository.Test.Insert(test);
            OnTestCreated(test);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (questionNumber == 48)
                return;

            if(gradeA+gradeB != 5)
            {
                MessageBox.Show("합이 5가 되어야 합니다.");
                return;
            }

            ClickedButtonNumberClear("a");
            ClickedButtonNumberClear("b");
            questionNumber++;
            OnNextButtonClicked(gradeA, gradeB, questionNumber);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (questionNumber == 0)
                return;

            ClickedButtonNumberClear("a");
            ClickedButtonNumberClear("b");
            questionNumber--;

            List<Response> responses = DataRepository.Response.Get(test.TestId, questionNumber);
            foreach(Response response in responses)
            {
                ButtonNumberClick(response.Grade.ToString(), response.QuestionId[1].ToString());
                
            }

            OnPreviousButtonClicked(gradeA, gradeB, questionNumber);
        }

        #region ButtonNumberClicked event things for C# 3.0
        public event EventHandler<ButtonNumberClickedEventArgs> ButtonNumberClicked;

        protected virtual void OnButtonNumberClicked(ButtonNumberClickedEventArgs e)
        {
            if (ButtonNumberClicked != null)
                ButtonNumberClicked(this, e);
        }

        private ButtonNumberClickedEventArgs OnButtonNumberClicked(string label, string section)
        {
            ButtonNumberClickedEventArgs args = new ButtonNumberClickedEventArgs(label, section);
            OnButtonNumberClicked(args);

            return args;
        }

        private ButtonNumberClickedEventArgs OnButtonNumberClickedForOut()
        {
            ButtonNumberClickedEventArgs args = new ButtonNumberClickedEventArgs();
            OnButtonNumberClicked(args);

            return args;
        }

        public class ButtonNumberClickedEventArgs : EventArgs
        {
            public string Label { get; set; }
            public string Section { get; set; }

            public ButtonNumberClickedEventArgs()
            {
            }

            public ButtonNumberClickedEventArgs(string label, string section)
            {
                Label = label;
                Section = section;
            }
        }
        #endregion
        #region PreviousButtonClicked event things for C# 3.0
        public event EventHandler<PreviousButtonClickedEventArgs> PreviousButtonClicked;

        protected virtual void OnPreviousButtonClicked(PreviousButtonClickedEventArgs e)
        {
            if (PreviousButtonClicked != null)
                PreviousButtonClicked(this, e);
        }

        private PreviousButtonClickedEventArgs OnPreviousButtonClicked(int gradeA, int gradeB, int questionNumber)
        {
            PreviousButtonClickedEventArgs args = new PreviousButtonClickedEventArgs(gradeA, gradeB, questionNumber);
            OnPreviousButtonClicked(args);

            return args;
        }

        private PreviousButtonClickedEventArgs OnPreviousButtonClickedForOut()
        {
            PreviousButtonClickedEventArgs args = new PreviousButtonClickedEventArgs();
            OnPreviousButtonClicked(args);

            return args;
        }

        public class PreviousButtonClickedEventArgs : EventArgs
        {
            public int GradeA { get; set; }
            public int GradeB { get; set; }
            public int QuestionNumber { get; set; }

            public PreviousButtonClickedEventArgs()
            {
            }

            public PreviousButtonClickedEventArgs(int gradeA, int gradeB, int questionNumber)
            {
                GradeA = gradeA;
                GradeB = gradeB;
                QuestionNumber = questionNumber;
            }
        }
        #endregion
        #region NextButtonClicked event things for C# 3.0
        public event EventHandler<NextButtonClickedEventArgs> NextButtonClicked;

        protected virtual void OnNextButtonClicked(NextButtonClickedEventArgs e)
        {
            if (NextButtonClicked != null)
                NextButtonClicked(this, e);
        }

        private NextButtonClickedEventArgs OnNextButtonClicked(int gradeA, int gradeB, int questionNumber)
        {
            NextButtonClickedEventArgs args = new NextButtonClickedEventArgs(gradeA, gradeB, questionNumber);
            OnNextButtonClicked(args);

            return args;
        }

        private NextButtonClickedEventArgs OnNextButtonClickedForOut()
        {
            NextButtonClickedEventArgs args = new NextButtonClickedEventArgs();
            OnNextButtonClicked(args);

            return args;
        }

        public class NextButtonClickedEventArgs : EventArgs
        {
            public int GradeA { get; set; }
            public int GradeB { get; set; }
            public int QuestionNumber { get; set; }

            public NextButtonClickedEventArgs()
            {
            }

            public NextButtonClickedEventArgs(int gradeA, int gradeB, int questionNumber)
            {
                GradeA = gradeA;
                GradeB = gradeB;
                QuestionNumber = questionNumber;
            }
        }
        #endregion
        #region TestCreated event things for C# 3.0
        public event EventHandler<TestCreatedEventArgs> TestCreated;

        protected virtual void OnTestCreated(TestCreatedEventArgs e)
        {
            if (TestCreated != null)
                TestCreated(this, e);
        }

        private TestCreatedEventArgs OnTestCreated(Test test)
        {
            TestCreatedEventArgs args = new TestCreatedEventArgs(test);
            OnTestCreated(args);

            return args;
        }

        private TestCreatedEventArgs OnTestCreatedForOut()
        {
            TestCreatedEventArgs args = new TestCreatedEventArgs();
            OnTestCreated(args);

            return args;
        }

        public class TestCreatedEventArgs : EventArgs
        {
            public Test Test { get; set; }

            public TestCreatedEventArgs()
            {
            }

            public TestCreatedEventArgs(Test test)
            {
                Test = test;
            }
        }
        #endregion
    }
}
