namespace MBTI
{
    partial class QuestionControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionControl));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrevious = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.btnNext = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.btnFiveB = new MBTI.ButtonNumber();
            this.btnOneA = new MBTI.ButtonNumber();
            this.btnTwoA = new MBTI.ButtonNumber();
            this.btnThreeA = new MBTI.ButtonNumber();
            this.btnFourA = new MBTI.ButtonNumber();
            this.btnZeroB = new MBTI.ButtonNumber();
            this.btnOneB = new MBTI.ButtonNumber();
            this.btnTwoB = new MBTI.ButtonNumber();
            this.btnThreeB = new MBTI.ButtonNumber();
            this.btnFourB = new MBTI.ButtonNumber();
            this.btnFiveA = new MBTI.ButtonNumber();
            this.btnZeroA = new MBTI.ButtonNumber();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pyunji R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(48, -37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(551, 32);
            this.label5.TabIndex = 37;
            this.label5.Text = "1a. 나는 행동에 집착하고 활동과 행동을 지향한다";
            // 
            // btnPrevious
            // 
            windowsUIButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions1.SvgImage")));
            this.btnPrevious.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.btnPrevious.Location = new System.Drawing.Point(43, 124);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 81);
            this.btnPrevious.TabIndex = 65;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            windowsUIButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions2.SvgImage")));
            this.btnNext.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.btnNext.Location = new System.Drawing.Point(817, 124);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 81);
            this.btnNext.TabIndex = 66;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFiveB
            // 
            this.btnFiveB.IsChecked = false;
            this.btnFiveB.Label = "5";
            this.btnFiveB.Location = new System.Drawing.Point(646, 196);
            this.btnFiveB.Name = "btnFiveB";
            this.btnFiveB.Section = "b";
            this.btnFiveB.Size = new System.Drawing.Size(85, 113);
            this.btnFiveB.TabIndex = 64;
            this.btnFiveB.ButtonNumberClicked += new System.EventHandler<MBTI.ButtonNumber.ButtonNumberClickedEventArgs>(this.btnZeroA_ButtonNumberClicked);
            // 
            // btnOneA
            // 
            this.btnOneA.IsChecked = false;
            this.btnOneA.Label = "1";
            this.btnOneA.Location = new System.Drawing.Point(282, 25);
            this.btnOneA.Name = "btnOneA";
            this.btnOneA.Section = "a";
            this.btnOneA.Size = new System.Drawing.Size(85, 95);
            this.btnOneA.TabIndex = 63;
            this.btnOneA.ButtonNumberClicked += new System.EventHandler<MBTI.ButtonNumber.ButtonNumberClickedEventArgs>(this.btnZeroA_ButtonNumberClicked);
            // 
            // btnTwoA
            // 
            this.btnTwoA.IsChecked = false;
            this.btnTwoA.Label = "2";
            this.btnTwoA.Location = new System.Drawing.Point(373, 25);
            this.btnTwoA.Name = "btnTwoA";
            this.btnTwoA.Section = "a";
            this.btnTwoA.Size = new System.Drawing.Size(85, 95);
            this.btnTwoA.TabIndex = 62;
            this.btnTwoA.ButtonNumberClicked += new System.EventHandler<MBTI.ButtonNumber.ButtonNumberClickedEventArgs>(this.btnZeroA_ButtonNumberClicked);
            // 
            // btnThreeA
            // 
            this.btnThreeA.IsChecked = false;
            this.btnThreeA.Label = "3";
            this.btnThreeA.Location = new System.Drawing.Point(464, 25);
            this.btnThreeA.Name = "btnThreeA";
            this.btnThreeA.Section = "a";
            this.btnThreeA.Size = new System.Drawing.Size(85, 95);
            this.btnThreeA.TabIndex = 61;
            this.btnThreeA.ButtonNumberClicked += new System.EventHandler<MBTI.ButtonNumber.ButtonNumberClickedEventArgs>(this.btnZeroA_ButtonNumberClicked);
            // 
            // btnFourA
            // 
            this.btnFourA.IsChecked = false;
            this.btnFourA.Label = "4";
            this.btnFourA.Location = new System.Drawing.Point(555, 25);
            this.btnFourA.Name = "btnFourA";
            this.btnFourA.Section = "a";
            this.btnFourA.Size = new System.Drawing.Size(85, 95);
            this.btnFourA.TabIndex = 60;
            this.btnFourA.ButtonNumberClicked += new System.EventHandler<MBTI.ButtonNumber.ButtonNumberClickedEventArgs>(this.btnZeroA_ButtonNumberClicked);
            // 
            // btnZeroB
            // 
            this.btnZeroB.IsChecked = false;
            this.btnZeroB.Label = "0";
            this.btnZeroB.Location = new System.Drawing.Point(191, 196);
            this.btnZeroB.Name = "btnZeroB";
            this.btnZeroB.Section = "b";
            this.btnZeroB.Size = new System.Drawing.Size(85, 113);
            this.btnZeroB.TabIndex = 59;
            this.btnZeroB.ButtonNumberClicked += new System.EventHandler<MBTI.ButtonNumber.ButtonNumberClickedEventArgs>(this.btnZeroA_ButtonNumberClicked);
            // 
            // btnOneB
            // 
            this.btnOneB.IsChecked = false;
            this.btnOneB.Label = "1";
            this.btnOneB.Location = new System.Drawing.Point(282, 196);
            this.btnOneB.Name = "btnOneB";
            this.btnOneB.Section = "b";
            this.btnOneB.Size = new System.Drawing.Size(85, 113);
            this.btnOneB.TabIndex = 58;
            this.btnOneB.ButtonNumberClicked += new System.EventHandler<MBTI.ButtonNumber.ButtonNumberClickedEventArgs>(this.btnZeroA_ButtonNumberClicked);
            // 
            // btnTwoB
            // 
            this.btnTwoB.IsChecked = false;
            this.btnTwoB.Label = "2";
            this.btnTwoB.Location = new System.Drawing.Point(373, 196);
            this.btnTwoB.Name = "btnTwoB";
            this.btnTwoB.Section = "b";
            this.btnTwoB.Size = new System.Drawing.Size(85, 113);
            this.btnTwoB.TabIndex = 57;
            this.btnTwoB.ButtonNumberClicked += new System.EventHandler<MBTI.ButtonNumber.ButtonNumberClickedEventArgs>(this.btnZeroA_ButtonNumberClicked);
            // 
            // btnThreeB
            // 
            this.btnThreeB.IsChecked = false;
            this.btnThreeB.Label = "3";
            this.btnThreeB.Location = new System.Drawing.Point(464, 196);
            this.btnThreeB.Name = "btnThreeB";
            this.btnThreeB.Section = "b";
            this.btnThreeB.Size = new System.Drawing.Size(85, 113);
            this.btnThreeB.TabIndex = 56;
            this.btnThreeB.ButtonNumberClicked += new System.EventHandler<MBTI.ButtonNumber.ButtonNumberClickedEventArgs>(this.btnZeroA_ButtonNumberClicked);
            // 
            // btnFourB
            // 
            this.btnFourB.IsChecked = false;
            this.btnFourB.Label = "4";
            this.btnFourB.Location = new System.Drawing.Point(555, 196);
            this.btnFourB.Name = "btnFourB";
            this.btnFourB.Section = "b";
            this.btnFourB.Size = new System.Drawing.Size(85, 113);
            this.btnFourB.TabIndex = 55;
            this.btnFourB.ButtonNumberClicked += new System.EventHandler<MBTI.ButtonNumber.ButtonNumberClickedEventArgs>(this.btnZeroA_ButtonNumberClicked);
            // 
            // btnFiveA
            // 
            this.btnFiveA.IsChecked = false;
            this.btnFiveA.Label = "5";
            this.btnFiveA.Location = new System.Drawing.Point(646, 25);
            this.btnFiveA.Name = "btnFiveA";
            this.btnFiveA.Section = "a";
            this.btnFiveA.Size = new System.Drawing.Size(85, 95);
            this.btnFiveA.TabIndex = 53;
            this.btnFiveA.ButtonNumberClicked += new System.EventHandler<MBTI.ButtonNumber.ButtonNumberClickedEventArgs>(this.btnZeroA_ButtonNumberClicked);
            // 
            // btnZeroA
            // 
            this.btnZeroA.IsChecked = false;
            this.btnZeroA.Label = "0";
            this.btnZeroA.Location = new System.Drawing.Point(191, 25);
            this.btnZeroA.Name = "btnZeroA";
            this.btnZeroA.Section = "a";
            this.btnZeroA.Size = new System.Drawing.Size(85, 95);
            this.btnZeroA.TabIndex = 52;
            this.btnZeroA.ButtonNumberClicked += new System.EventHandler<MBTI.ButtonNumber.ButtonNumberClickedEventArgs>(this.btnZeroA_ButtonNumberClicked);
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFiveB);
            this.Controls.Add(this.btnOneA);
            this.Controls.Add(this.btnTwoA);
            this.Controls.Add(this.btnThreeA);
            this.Controls.Add(this.btnFourA);
            this.Controls.Add(this.btnZeroB);
            this.Controls.Add(this.btnOneB);
            this.Controls.Add(this.btnTwoB);
            this.Controls.Add(this.btnThreeB);
            this.Controls.Add(this.btnFourB);
            this.Controls.Add(this.btnFiveA);
            this.Controls.Add(this.btnZeroA);
            this.Controls.Add(this.label5);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(916, 357);
            this.Load += new System.EventHandler(this.QuestionControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private ButtonNumber btnZeroA;
        private ButtonNumber btnFiveA;
        private ButtonNumber btnFourB;
        private ButtonNumber btnThreeB;
        private ButtonNumber btnTwoB;
        private ButtonNumber btnOneB;
        private ButtonNumber btnZeroB;
        private ButtonNumber btnThreeA;
        private ButtonNumber btnTwoA;
        private ButtonNumber btnOneA;
        private ButtonNumber btnFiveB;
        private ButtonNumber btnFourA;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnPrevious;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnNext;
    }
}
