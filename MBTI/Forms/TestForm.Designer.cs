namespace MBTI.Forms
{
    partial class TestForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txeQuestionA = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txeQuestionB = new DevExpress.XtraEditors.TextEdit();
            this.questionControl1 = new MBTI.QuestionControl();
            this.lblProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txeQuestionA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeQuestionB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(796, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "시간 :";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(850, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(84, 23);
            this.lblTimer.TabIndex = 22;
            this.lblTimer.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Pyunji R", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl1.ImageOptions.SvgImage")));
            this.labelControl1.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.labelControl1.IndentBetweenImageAndText = 5;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(410, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 44);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "항목";
            // 
            // txeQuestionA
            // 
            this.txeQuestionA.EditValue = "1a";
            this.txeQuestionA.Location = new System.Drawing.Point(168, 95);
            this.txeQuestionA.Name = "txeQuestionA";
            this.txeQuestionA.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txeQuestionA.Properties.Appearance.Font = new System.Drawing.Font("HYPMokGak-Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txeQuestionA.Properties.Appearance.Options.UseBackColor = true;
            this.txeQuestionA.Properties.Appearance.Options.UseFont = true;
            this.txeQuestionA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txeQuestionA.Size = new System.Drawing.Size(609, 32);
            this.txeQuestionA.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(177, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 1);
            this.panel2.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(177, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 1);
            this.panel1.TabIndex = 31;
            // 
            // txeQuestionB
            // 
            this.txeQuestionB.EditValue = "1B";
            this.txeQuestionB.Location = new System.Drawing.Point(177, 306);
            this.txeQuestionB.Name = "txeQuestionB";
            this.txeQuestionB.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txeQuestionB.Properties.Appearance.Font = new System.Drawing.Font("HYPMokGak-Bold", 16.2F);
            this.txeQuestionB.Properties.Appearance.Options.UseBackColor = true;
            this.txeQuestionB.Properties.Appearance.Options.UseFont = true;
            this.txeQuestionB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txeQuestionB.Size = new System.Drawing.Size(600, 32);
            this.txeQuestionB.TabIndex = 30;
            // 
            // questionControl1
            // 
            this.questionControl1.Location = new System.Drawing.Point(21, 97);
            this.questionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.questionControl1.Name = "questionControl1";
            this.questionControl1.Size = new System.Drawing.Size(895, 370);
            this.questionControl1.TabIndex = 25;
            this.questionControl1.ButtonNumberClicked += new System.EventHandler<MBTI.QuestionControl.ButtonNumberClickedEventArgs>(this.questionControl1_ButtonNumberClicked);
            this.questionControl1.PreviousButtonClicked += new System.EventHandler<MBTI.QuestionControl.PreviousButtonClickedEventArgs>(this.questionControl1_PreviousButtonClicked);
            this.questionControl1.NextButtonClicked += new System.EventHandler<MBTI.QuestionControl.NextButtonClickedEventArgs>(this.questionControl1_NextButtonClicked);
            this.questionControl1.TestCreated += new System.EventHandler<MBTI.QuestionControl.TestCreatedEventArgs>(this.questionControl1_TestCreated);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(415, 503);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(101, 48);
            this.lblProgress.TabIndex = 32;
            this.lblProgress.Text = "1/48";
            // 
            // TestForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 594);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txeQuestionB);
            this.Controls.Add(this.txeQuestionA);
            this.Controls.Add(this.questionControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label2);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txeQuestionA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeQuestionB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private QuestionControl questionControl1;
        private DevExpress.XtraEditors.TextEdit txeQuestionA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txeQuestionB;
        private System.Windows.Forms.Label lblProgress;
    }
}