namespace Hangman
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.PlayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GuessCountLabel = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.WinningGif = new System.Windows.Forms.PictureBox();
            this.possible = new System.Windows.Forms.Label();
            this.possiblewordcount = new System.Windows.Forms.Label();
            this.HowManyText = new System.Windows.Forms.Label();
            this.PossibleText = new System.Windows.Forms.Label();
            this.LettersLeftText = new System.Windows.Forms.Label();
            this.BadGuessesText = new System.Windows.Forms.Label();
            this.GoodGuessesText = new System.Windows.Forms.Label();
            this.TheWordText = new System.Windows.Forms.Label();
            this.GuessesLeftText = new System.Windows.Forms.Label();
            this.WrongButton = new System.Windows.Forms.PictureBox();
            this.RightButton = new System.Windows.Forms.PictureBox();
            this.GuessText = new System.Windows.Forms.Label();
            this.IndexInfo = new System.Windows.Forms.TextBox();
            this.IndexButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TipText = new System.Windows.Forms.Label();
            this.guessRightLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinningGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WrongButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.StartButton.Location = new System.Drawing.Point(197, 98);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(281, 148);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Play Hangman";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 31);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(12, 57);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(70, 23);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Start";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 46);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuessCountLabel
            // 
            this.GuessCountLabel.AutoSize = true;
            this.GuessCountLabel.Location = new System.Drawing.Point(633, 31);
            this.GuessCountLabel.Name = "GuessCountLabel";
            this.GuessCountLabel.Size = new System.Drawing.Size(0, 13);
            this.GuessCountLabel.TabIndex = 6;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(58, 217);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(0, 13);
            this.test.TabIndex = 8;
            // 
            // WinningGif
            // 
            this.WinningGif.Image = global::Hangman.Properties.Resources.hanging;
            this.WinningGif.Location = new System.Drawing.Point(222, 78);
            this.WinningGif.Name = "WinningGif";
            this.WinningGif.Size = new System.Drawing.Size(240, 214);
            this.WinningGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WinningGif.TabIndex = 9;
            this.WinningGif.TabStop = false;
            // 
            // possible
            // 
            this.possible.AutoSize = true;
            this.possible.Location = new System.Drawing.Point(16, 305);
            this.possible.Name = "possible";
            this.possible.Size = new System.Drawing.Size(0, 13);
            this.possible.TabIndex = 10;
            // 
            // possiblewordcount
            // 
            this.possiblewordcount.AutoSize = true;
            this.possiblewordcount.Location = new System.Drawing.Point(62, 264);
            this.possiblewordcount.Name = "possiblewordcount";
            this.possiblewordcount.Size = new System.Drawing.Size(0, 13);
            this.possiblewordcount.TabIndex = 11;
            // 
            // HowManyText
            // 
            this.HowManyText.AutoSize = true;
            this.HowManyText.Location = new System.Drawing.Point(13, 12);
            this.HowManyText.Name = "HowManyText";
            this.HowManyText.Size = new System.Drawing.Size(0, 13);
            this.HowManyText.TabIndex = 12;
            // 
            // PossibleText
            // 
            this.PossibleText.AutoSize = true;
            this.PossibleText.Location = new System.Drawing.Point(12, 245);
            this.PossibleText.Name = "PossibleText";
            this.PossibleText.Size = new System.Drawing.Size(0, 13);
            this.PossibleText.TabIndex = 13;
            // 
            // LettersLeftText
            // 
            this.LettersLeftText.AutoSize = true;
            this.LettersLeftText.Location = new System.Drawing.Point(9, 284);
            this.LettersLeftText.Name = "LettersLeftText";
            this.LettersLeftText.Size = new System.Drawing.Size(0, 13);
            this.LettersLeftText.TabIndex = 14;
            // 
            // BadGuessesText
            // 
            this.BadGuessesText.AutoSize = true;
            this.BadGuessesText.Location = new System.Drawing.Point(179, 295);
            this.BadGuessesText.Name = "BadGuessesText";
            this.BadGuessesText.Size = new System.Drawing.Size(0, 13);
            this.BadGuessesText.TabIndex = 15;
            // 
            // GoodGuessesText
            // 
            this.GoodGuessesText.AutoSize = true;
            this.GoodGuessesText.Location = new System.Drawing.Point(295, 12);
            this.GoodGuessesText.Name = "GoodGuessesText";
            this.GoodGuessesText.Size = new System.Drawing.Size(0, 13);
            this.GoodGuessesText.TabIndex = 16;
            // 
            // TheWordText
            // 
            this.TheWordText.AutoSize = true;
            this.TheWordText.Location = new System.Drawing.Point(9, 198);
            this.TheWordText.Name = "TheWordText";
            this.TheWordText.Size = new System.Drawing.Size(0, 13);
            this.TheWordText.TabIndex = 17;
            // 
            // GuessesLeftText
            // 
            this.GuessesLeftText.AutoSize = true;
            this.GuessesLeftText.Location = new System.Drawing.Point(596, 12);
            this.GuessesLeftText.Name = "GuessesLeftText";
            this.GuessesLeftText.Size = new System.Drawing.Size(0, 13);
            this.GuessesLeftText.TabIndex = 18;
            // 
            // WrongButton
            // 
            this.WrongButton.Image = ((System.Drawing.Image)(resources.GetObject("WrongButton.Image")));
            this.WrongButton.Location = new System.Drawing.Point(552, 178);
            this.WrongButton.Name = "WrongButton";
            this.WrongButton.Size = new System.Drawing.Size(105, 109);
            this.WrongButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WrongButton.TabIndex = 19;
            this.WrongButton.TabStop = false;
            this.WrongButton.Click += new System.EventHandler(this.WrongButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Image = ((System.Drawing.Image)(resources.GetObject("RightButton.Image")));
            this.RightButton.Location = new System.Drawing.Point(552, 63);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(105, 109);
            this.RightButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightButton.TabIndex = 20;
            this.RightButton.TabStop = false;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // GuessText
            // 
            this.GuessText.AutoSize = true;
            this.GuessText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessText.Location = new System.Drawing.Point(309, 51);
            this.GuessText.Name = "GuessText";
            this.GuessText.Size = new System.Drawing.Size(64, 24);
            this.GuessText.TabIndex = 21;
            this.GuessText.Text = "Guess";
            // 
            // IndexInfo
            // 
            this.IndexInfo.Location = new System.Drawing.Point(552, 135);
            this.IndexInfo.Name = "IndexInfo";
            this.IndexInfo.Size = new System.Drawing.Size(100, 20);
            this.IndexInfo.TabIndex = 22;
            // 
            // IndexButton
            // 
            this.IndexButton.Location = new System.Drawing.Point(567, 161);
            this.IndexButton.Name = "IndexButton";
            this.IndexButton.Size = new System.Drawing.Size(75, 23);
            this.IndexButton.TabIndex = 23;
            this.IndexButton.Text = "Index";
            this.IndexButton.UseVisualStyleBackColor = true;
            this.IndexButton.Click += new System.EventHandler(this.IndexButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TipText
            // 
            this.TipText.Location = new System.Drawing.Point(545, 83);
            this.TipText.Name = "TipText";
            this.TipText.Size = new System.Drawing.Size(123, 49);
            this.TipText.TabIndex = 24;
            this.TipText.Text = "Zero-based index. Seperate multiples by \',\' ie. \"2,4,6\"";
            // 
            // guessRightLabel
            // 
            this.guessRightLabel.Location = new System.Drawing.Point(287, 172);
            this.guessRightLabel.Name = "guessRightLabel";
            this.guessRightLabel.Size = new System.Drawing.Size(100, 20);
            this.guessRightLabel.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 344);
            this.Controls.Add(this.guessRightLabel);
            this.Controls.Add(this.WinningGif);
            this.Controls.Add(this.TipText);
            this.Controls.Add(this.IndexButton);
            this.Controls.Add(this.IndexInfo);
            this.Controls.Add(this.GuessText);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.GuessesLeftText);
            this.Controls.Add(this.TheWordText);
            this.Controls.Add(this.GoodGuessesText);
            this.Controls.Add(this.BadGuessesText);
            this.Controls.Add(this.LettersLeftText);
            this.Controls.Add(this.PossibleText);
            this.Controls.Add(this.HowManyText);
            this.Controls.Add(this.possiblewordcount);
            this.Controls.Add(this.possible);
            this.Controls.Add(this.test);
            this.Controls.Add(this.GuessCountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.WrongButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinningGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WrongButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GuessCountLabel;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.PictureBox WinningGif;
        private System.Windows.Forms.Label possible;
        private System.Windows.Forms.Label possiblewordcount;
        private System.Windows.Forms.Label HowManyText;
        private System.Windows.Forms.Label PossibleText;
        private System.Windows.Forms.Label LettersLeftText;
        private System.Windows.Forms.Label BadGuessesText;
        private System.Windows.Forms.Label GoodGuessesText;
        private System.Windows.Forms.Label TheWordText;
        private System.Windows.Forms.Label GuessesLeftText;
        private System.Windows.Forms.PictureBox WrongButton;
        private System.Windows.Forms.PictureBox RightButton;
        private System.Windows.Forms.Label GuessText;
        private System.Windows.Forms.TextBox IndexInfo;
        private System.Windows.Forms.Button IndexButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label TipText;
        private System.Windows.Forms.TextBox guessRightLabel;
    }
}
