using System;
using System.Drawing;
using System.Windows.Forms;

namespace MBTI
{
    public partial class ButtonNumber : UserControl
    {
        public bool IsChecked { get; set; } = false;

        public ButtonNumber()
        {
            InitializeComponent();
        }

        public string Label
        {
            get
            {
                return btnNumber.Text;
            }
            set
            {
                btnNumber.Text = value;
            }
        }

        public string Section { get; set; }

        public void Activate()
        {
            btnNumber.BackColor = Color.Gray;
            IsChecked = true;
        }

        public void DeActivate()
        {
            btnNumber.BackColor = Color.Aquamarine;
            IsChecked = false;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Activate();
            OnButtonNumberClicked(Label, Section);
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
