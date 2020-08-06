﻿namespace MBTI.Forms
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.btnPrevious = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.btnNext = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txeQuestionA = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txeQuestionB = new DevExpress.XtraEditors.TextEdit();
            this.questionControl1 = new MBTI.QuestionControl();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeQuestionA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeQuestionB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            windowsUIButtonImageOptions5.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions5.SvgImage")));
            this.btnPrevious.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.btnPrevious.Location = new System.Drawing.Point(12, 256);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 81);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            windowsUIButtonImageOptions6.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions6.SvgImage")));
            this.btnNext.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.btnNext.Location = new System.Drawing.Point(868, 256);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 81);
            this.btnNext.TabIndex = 14;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.progressBarControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBarControl1.Location = new System.Drawing.Point(399, 521);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarControl1.Properties.Maximum = 48;
            this.progressBarControl1.Properties.PercentView = false;
            this.progressBarControl1.Properties.ProgressKind = DevExpress.XtraEditors.Controls.ProgressKind.Vertical;
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(162, 22);
            this.progressBarControl1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(809, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "시간 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(850, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "00:00:00";
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
            this.questionControl1.Location = new System.Drawing.Point(146, 97);
            this.questionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.questionControl1.Name = "questionControl1";
            this.questionControl1.Size = new System.Drawing.Size(652, 357);
            this.questionControl1.TabIndex = 25;
            this.questionControl1.ButtonNumberClicked += new System.EventHandler<MBTI.QuestionControl.ButtonNumberClickedEventArgs>(this.questionControl1_ButtonNumberClicked);
            // 
            // TestForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txeQuestionB);
            this.Controls.Add(this.txeQuestionA);
            this.Controls.Add(this.questionControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeQuestionA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeQuestionB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnPrevious;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnNext;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private QuestionControl questionControl1;
        private DevExpress.XtraEditors.TextEdit txeQuestionA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txeQuestionB;
    }
}