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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.PlayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GuessButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinningGif)).BeginInit();
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
            this.PlayButton.Text = "New Word";
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
            this.label2.Location = new System.Drawing.Point(196, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 46);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuessButton
            // 
            this.GuessButton.Location = new System.Drawing.Point(562, 273);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(106, 58);
            this.GuessButton.TabIndex = 5;
            this.GuessButton.Text = "Take a Guess";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
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
            this.WinningGif.Location = new System.Drawing.Point(218, 57);
            this.WinningGif.Name = "WinningGif";
            this.WinningGif.Size = new System.Drawing.Size(240, 214);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 344);
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
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.WinningGif);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinningGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GuessButton;
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
    }
}

