namespace PACEBuzz
{
    partial class TeamScoreBoard
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
            this.cmdCorrect = new System.Windows.Forms.Button();
            this.cmdIncorrect = new System.Windows.Forms.Button();
            this.cmdNextQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCorrect
            // 
            this.cmdCorrect.Location = new System.Drawing.Point(32, 229);
            this.cmdCorrect.Name = "cmdCorrect";
            this.cmdCorrect.Size = new System.Drawing.Size(146, 40);
            this.cmdCorrect.TabIndex = 0;
            this.cmdCorrect.Text = "Correct";
            this.cmdCorrect.UseVisualStyleBackColor = true;
            // 
            // cmdIncorrect
            // 
            this.cmdIncorrect.Location = new System.Drawing.Point(184, 229);
            this.cmdIncorrect.Name = "cmdIncorrect";
            this.cmdIncorrect.Size = new System.Drawing.Size(146, 40);
            this.cmdIncorrect.TabIndex = 1;
            this.cmdIncorrect.Text = "Incorrect";
            this.cmdIncorrect.UseVisualStyleBackColor = true;
            // 
            // cmdNextQuestion
            // 
            this.cmdNextQuestion.Location = new System.Drawing.Point(466, 229);
            this.cmdNextQuestion.Name = "cmdNextQuestion";
            this.cmdNextQuestion.Size = new System.Drawing.Size(146, 40);
            this.cmdNextQuestion.TabIndex = 2;
            this.cmdNextQuestion.Text = "Next Question";
            this.cmdNextQuestion.UseVisualStyleBackColor = true;
            // 
            // TeamScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 290);
            this.Controls.Add(this.cmdNextQuestion);
            this.Controls.Add(this.cmdIncorrect);
            this.Controls.Add(this.cmdCorrect);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeamScoreBoard";
            this.Text = "TeamScoreBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCorrect;
        private System.Windows.Forms.Button cmdIncorrect;
        private System.Windows.Forms.Button cmdNextQuestion;
    }
}