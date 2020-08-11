namespace MBTI
{
    partial class ButtonNumber
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
            this.btnNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNumber
            // 
            this.btnNumber.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNumber.Font = new System.Drawing.Font("NanumGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNumber.Location = new System.Drawing.Point(3, 18);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(78, 70);
            this.btnNumber.TabIndex = 40;
            this.btnNumber.Text = "0";
            this.btnNumber.UseVisualStyleBackColor = false;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // ButtonNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNumber);
            this.Name = "ButtonNumber";
            this.Size = new System.Drawing.Size(85, 95);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumber;
    }
}
