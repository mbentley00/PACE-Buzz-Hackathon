namespace PACEBuzz
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblBuzzersDetected = new System.Windows.Forms.Label();
            this.lblMinBonusCountdown = new System.Windows.Forms.Label();
            this.lblMinQuestionController = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.imgMinIncorrect = new System.Windows.Forms.PictureBox();
            this.imgMinCorrect = new System.Windows.Forms.PictureBox();
            this.imgScore = new System.Windows.Forms.PictureBox();
            this.imgPause = new System.Windows.Forms.PictureBox();
            this.imgPlay = new System.Windows.Forms.PictureBox();
            this.imgMinExit = new System.Windows.Forms.PictureBox();
            this.imgMinForceLastLight = new System.Windows.Forms.PictureBox();
            this.imgMinHelp = new System.Windows.Forms.PictureBox();
            this.imgMinSettings = new System.Windows.Forms.PictureBox();
            this.imgMinRefresh = new System.Windows.Forms.PictureBox();
            this.imgMinLightCheck = new System.Windows.Forms.PictureBox();
            this.imgMinReset = new System.Windows.Forms.PictureBox();
            this.imgMinNextBuzz = new System.Windows.Forms.PictureBox();
            this.imgMinBonusCountdown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinIncorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinForceLastLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinLightCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinNextBuzz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinBonusCountdown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuzzersDetected
            // 
            this.lblBuzzersDetected.Location = new System.Drawing.Point(52, 10);
            this.lblBuzzersDetected.Name = "lblBuzzersDetected";
            this.lblBuzzersDetected.Size = new System.Drawing.Size(23, 18);
            this.lblBuzzersDetected.TabIndex = 24;
            this.lblBuzzersDetected.Text = "0";
            // 
            // lblMinBonusCountdown
            // 
            this.lblMinBonusCountdown.Location = new System.Drawing.Point(194, 10);
            this.lblMinBonusCountdown.Name = "lblMinBonusCountdown";
            this.lblMinBonusCountdown.Size = new System.Drawing.Size(23, 18);
            this.lblMinBonusCountdown.TabIndex = 13;
            this.lblMinBonusCountdown.Text = "5";
            this.lblMinBonusCountdown.Visible = false;
            // 
            // lblMinQuestionController
            // 
            this.lblMinQuestionController.AutoSize = true;
            this.lblMinQuestionController.Location = new System.Drawing.Point(4, 10);
            this.lblMinQuestionController.Name = "lblMinQuestionController";
            this.lblMinQuestionController.Size = new System.Drawing.Size(41, 17);
            this.lblMinQuestionController.TabIndex = 2;
            this.lblMinQuestionController.Text = "Clear";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Location = new System.Drawing.Point(4, 48);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(74, 17);
            this.lblQuestionNumber.TabIndex = 30;
            this.lblQuestionNumber.Text = "Question 1";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(4, 73);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(74, 17);
            this.lblAnswer.TabIndex = 31;
            this.lblAnswer.Text = "ANSWER:";
            // 
            // imgMinIncorrect
            // 
            this.imgMinIncorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinIncorrect.Image = global::PACEBuzz.Properties.Resources.if_dialog_close_29299;
            this.imgMinIncorrect.Location = new System.Drawing.Point(223, 48);
            this.imgMinIncorrect.Name = "imgMinIncorrect";
            this.imgMinIncorrect.Size = new System.Drawing.Size(19, 17);
            this.imgMinIncorrect.TabIndex = 33;
            this.imgMinIncorrect.TabStop = false;
            // 
            // imgMinCorrect
            // 
            this.imgMinCorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinCorrect.Image = global::PACEBuzz.Properties.Resources.if_accept_35637;
            this.imgMinCorrect.Location = new System.Drawing.Point(197, 48);
            this.imgMinCorrect.Name = "imgMinCorrect";
            this.imgMinCorrect.Size = new System.Drawing.Size(19, 17);
            this.imgMinCorrect.TabIndex = 32;
            this.imgMinCorrect.TabStop = false;
            // 
            // imgScore
            // 
            this.imgScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgScore.Image = global::PACEBuzz.Properties.Resources.scores;
            this.imgScore.Location = new System.Drawing.Point(273, 12);
            this.imgScore.Name = "imgScore";
            this.imgScore.Size = new System.Drawing.Size(19, 17);
            this.imgScore.TabIndex = 29;
            this.imgScore.TabStop = false;
            this.imgScore.Click += new System.EventHandler(this.imgScore_Click);
            // 
            // imgPause
            // 
            this.imgPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPause.Image = global::PACEBuzz.Properties.Resources.Pause;
            this.imgPause.Location = new System.Drawing.Point(109, 48);
            this.imgPause.Name = "imgPause";
            this.imgPause.Size = new System.Drawing.Size(19, 17);
            this.imgPause.TabIndex = 28;
            this.imgPause.TabStop = false;
            this.imgPause.Click += new System.EventHandler(this.imgPause_Click);
            // 
            // imgPlay
            // 
            this.imgPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPlay.Image = global::PACEBuzz.Properties.Resources.Play;
            this.imgPlay.Location = new System.Drawing.Point(84, 48);
            this.imgPlay.Name = "imgPlay";
            this.imgPlay.Size = new System.Drawing.Size(19, 17);
            this.imgPlay.TabIndex = 27;
            this.imgPlay.TabStop = false;
            this.imgPlay.Click += new System.EventHandler(this.imgPlay_Click);
            // 
            // imgMinExit
            // 
            this.imgMinExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinExit.Image = global::PACEBuzz.Properties.Resources.Actions_window_close_icon;
            this.imgMinExit.Location = new System.Drawing.Point(400, 10);
            this.imgMinExit.Name = "imgMinExit";
            this.imgMinExit.Size = new System.Drawing.Size(19, 17);
            this.imgMinExit.TabIndex = 23;
            this.imgMinExit.TabStop = false;
            this.imgMinExit.Click += new System.EventHandler(this.imgMinExit_Click);
            // 
            // imgMinForceLastLight
            // 
            this.imgMinForceLastLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinForceLastLight.Image = global::PACEBuzz.Properties.Resources.lighthouse_shine;
            this.imgMinForceLastLight.Location = new System.Drawing.Point(248, 10);
            this.imgMinForceLastLight.Name = "imgMinForceLastLight";
            this.imgMinForceLastLight.Size = new System.Drawing.Size(19, 17);
            this.imgMinForceLastLight.TabIndex = 26;
            this.imgMinForceLastLight.TabStop = false;
            this.imgMinForceLastLight.Click += new System.EventHandler(this.imgMinForceLastLight_Click);
            // 
            // imgMinHelp
            // 
            this.imgMinHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinHelp.Image = global::PACEBuzz.Properties.Resources.Button_Help_icon;
            this.imgMinHelp.Location = new System.Drawing.Point(375, 10);
            this.imgMinHelp.Name = "imgMinHelp";
            this.imgMinHelp.Size = new System.Drawing.Size(19, 17);
            this.imgMinHelp.TabIndex = 20;
            this.imgMinHelp.TabStop = false;
            this.imgMinHelp.Click += new System.EventHandler(this.imgMinHelp_Click);
            // 
            // imgMinSettings
            // 
            this.imgMinSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinSettings.Image = global::PACEBuzz.Properties.Resources.gear_16;
            this.imgMinSettings.Location = new System.Drawing.Point(350, 10);
            this.imgMinSettings.Name = "imgMinSettings";
            this.imgMinSettings.Size = new System.Drawing.Size(19, 17);
            this.imgMinSettings.TabIndex = 21;
            this.imgMinSettings.TabStop = false;
            this.imgMinSettings.Click += new System.EventHandler(this.imgMinSettings_Click);
            // 
            // imgMinRefresh
            // 
            this.imgMinRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinRefresh.Image = global::PACEBuzz.Properties.Resources.arrow_refresh;
            this.imgMinRefresh.Location = new System.Drawing.Point(74, 10);
            this.imgMinRefresh.Name = "imgMinRefresh";
            this.imgMinRefresh.Size = new System.Drawing.Size(19, 17);
            this.imgMinRefresh.TabIndex = 25;
            this.imgMinRefresh.TabStop = false;
            this.imgMinRefresh.Click += new System.EventHandler(this.imgMinRefresh_Click);
            // 
            // imgMinLightCheck
            // 
            this.imgMinLightCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinLightCheck.Image = global::PACEBuzz.Properties.Resources.lightbulb;
            this.imgMinLightCheck.Location = new System.Drawing.Point(223, 10);
            this.imgMinLightCheck.Name = "imgMinLightCheck";
            this.imgMinLightCheck.Size = new System.Drawing.Size(19, 17);
            this.imgMinLightCheck.TabIndex = 22;
            this.imgMinLightCheck.TabStop = false;
            this.imgMinLightCheck.Click += new System.EventHandler(this.imgMinLightCheck_Click);
            // 
            // imgMinReset
            // 
            this.imgMinReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinReset.Image = global::PACEBuzz.Properties.Resources.lightbulb_off;
            this.imgMinReset.Location = new System.Drawing.Point(109, 10);
            this.imgMinReset.Name = "imgMinReset";
            this.imgMinReset.Size = new System.Drawing.Size(19, 17);
            this.imgMinReset.TabIndex = 17;
            this.imgMinReset.TabStop = false;
            this.imgMinReset.Click += new System.EventHandler(this.imgMinReset_Click);
            // 
            // imgMinNextBuzz
            // 
            this.imgMinNextBuzz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinNextBuzz.Image = global::PACEBuzz.Properties.Resources.arrow_right;
            this.imgMinNextBuzz.Location = new System.Drawing.Point(134, 10);
            this.imgMinNextBuzz.Name = "imgMinNextBuzz";
            this.imgMinNextBuzz.Size = new System.Drawing.Size(19, 17);
            this.imgMinNextBuzz.TabIndex = 18;
            this.imgMinNextBuzz.TabStop = false;
            this.imgMinNextBuzz.Click += new System.EventHandler(this.imgMinNextBuzz_Click);
            // 
            // imgMinBonusCountdown
            // 
            this.imgMinBonusCountdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinBonusCountdown.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgMinBonusCountdown.ErrorImage")));
            this.imgMinBonusCountdown.Image = global::PACEBuzz.Properties.Resources.clock_16;
            this.imgMinBonusCountdown.Location = new System.Drawing.Point(171, 10);
            this.imgMinBonusCountdown.Name = "imgMinBonusCountdown";
            this.imgMinBonusCountdown.Size = new System.Drawing.Size(19, 17);
            this.imgMinBonusCountdown.TabIndex = 11;
            this.imgMinBonusCountdown.TabStop = false;
            this.imgMinBonusCountdown.Click += new System.EventHandler(this.imgMinBonusCountdown_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 99);
            this.Controls.Add(this.imgMinIncorrect);
            this.Controls.Add(this.imgMinCorrect);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.imgScore);
            this.Controls.Add(this.imgPause);
            this.Controls.Add(this.imgPlay);
            this.Controls.Add(this.imgMinExit);
            this.Controls.Add(this.imgMinForceLastLight);
            this.Controls.Add(this.imgMinHelp);
            this.Controls.Add(this.imgMinSettings);
            this.Controls.Add(this.imgMinRefresh);
            this.Controls.Add(this.imgMinLightCheck);
            this.Controls.Add(this.lblMinQuestionController);
            this.Controls.Add(this.lblBuzzersDetected);
            this.Controls.Add(this.imgMinReset);
            this.Controls.Add(this.lblMinBonusCountdown);
            this.Controls.Add(this.imgMinNextBuzz);
            this.Controls.Add(this.imgMinBonusCountdown);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 0);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PACEBuzz";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgMinIncorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinForceLastLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinLightCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinNextBuzz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinBonusCountdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgMinNextBuzz;
        private System.Windows.Forms.PictureBox imgMinReset;
        private System.Windows.Forms.Label lblMinBonusCountdown;
        private System.Windows.Forms.PictureBox imgMinBonusCountdown;
        private System.Windows.Forms.Label lblMinQuestionController;
        private System.Windows.Forms.PictureBox imgMinHelp;
        private System.Windows.Forms.PictureBox imgMinSettings;
        private System.Windows.Forms.PictureBox imgMinLightCheck;
        private System.Windows.Forms.PictureBox imgMinExit;
        private System.Windows.Forms.Label lblBuzzersDetected;
        private System.Windows.Forms.PictureBox imgMinRefresh;
        private System.Windows.Forms.PictureBox imgMinForceLastLight;
        private System.Windows.Forms.PictureBox imgPlay;
        private System.Windows.Forms.PictureBox imgPause;
        private System.Windows.Forms.PictureBox imgScore;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.PictureBox imgMinCorrect;
        private System.Windows.Forms.PictureBox imgMinIncorrect;
    }
}

