using MBTI.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MBTI
{
    public partial class QuestionControl : UserControl
    {
        private int questionNumber;
        List<ButtonNumber> buttonNumbers = new List<ButtonNumber>();

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
            CheckIsAlreadyClicked(e.Section);

            if(e.Label == "0" && e.Section == "a")
            {
                btnZeroA.Activate();
            }
            else if (e.Label == "1" && e.Section == "a")
            {
                btnOneA.Activate();
            }
            else if(e.Label == "2" && e.Section == "a")
            {
                btnTwoA.Activate();
            }
            else if (e.Label == "3" && e.Section == "a")
            {
                btnThreeA.Activate();
            }
            else if (e.Label == "4" && e.Section == "a")
            {
                btnFourA.Activate();
            }
            else if (e.Label == "5" && e.Section == "a")
            {
                btnFiveA.Activate();
            }
            else if (e.Label == "0" && e.Section == "b")
            {
                btnZeroB.Activate();
            }
            else if (e.Label == "1" && e.Section == "b")
            {
                btnOneB.Activate();
            }
            else if (e.Label == "2" && e.Section == "b")
            {
                btnTwoB.Activate();
            }
            else if (e.Label == "3" && e.Section == "b")
            {
                btnThreeB.Activate();
            }
            else if (e.Label == "4" && e.Section == "b")
            {
                btnFourB.Activate();
            }
            else if (e.Label == "5" && e.Section == "b")
            {
                btnFiveB.Activate();
            }

            OnButtonNumberClicked(e.Label, e.Section);
        }

        private void CheckIsAlreadyClicked(string section)
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

    }
}
