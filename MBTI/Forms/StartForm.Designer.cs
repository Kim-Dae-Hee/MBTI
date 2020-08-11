namespace MBTI
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txeName = new DevExpress.XtraEditors.TextEdit();
            this.txeMail = new DevExpress.XtraEditors.TextEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeMail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름 :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "이메일 :";
            // 
            // txeName
            // 
            this.txeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txeName.Location = new System.Drawing.Point(223, 106);
            this.txeName.Name = "txeName";
            this.txeName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txeName.Properties.Appearance.Options.UseBackColor = true;
            this.txeName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txeName.Size = new System.Drawing.Size(197, 26);
            this.txeName.TabIndex = 3;
            // 
            // txeMail
            // 
            this.txeMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txeMail.Location = new System.Drawing.Point(223, 136);
            this.txeMail.Name = "txeMail";
            this.txeMail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txeMail.Size = new System.Drawing.Size(197, 26);
            this.txeMail.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(66, 193);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(438, 533);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.btnStart.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnStart.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnStart.Appearance.Options.UseBackColor = true;
            this.btnStart.Appearance.Options.UseFont = true;
            this.btnStart.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.Control;
            this.btnStart.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnStart.AppearanceHovered.BackColor = System.Drawing.Color.Teal;
            this.btnStart.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnStart.AppearanceHovered.Options.UseBackColor = true;
            this.btnStart.AppearanceHovered.Options.UseForeColor = true;
            this.btnStart.AppearancePressed.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStart.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnStart.AppearancePressed.Options.UseBackColor = true;
            this.btnStart.AppearancePressed.Options.UseForeColor = true;
            this.btnStart.Location = new System.Drawing.Point(223, 639);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 42);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "검사 시작";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pyunji R", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(93, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 44);
            this.label3.TabIndex = 7;
            this.label3.Text = "MBTI 성격 유형 검사지";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 730);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txeMail);
            this.Controls.Add(this.txeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(585, 770);
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBTI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeMail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txeName;
        private DevExpress.XtraEditors.TextEdit txeMail;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
