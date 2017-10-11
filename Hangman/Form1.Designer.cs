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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 12);
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
            this.PlayButton.Location = new System.Drawing.Point(68, 12);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(70, 23);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 68);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuessButton
            // 
            this.GuessButton.Location = new System.Drawing.Point(510, 251);
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
            this.GuessCountLabel.Location = new System.Drawing.Point(636, 9);
            this.GuessCountLabel.Name = "GuessCountLabel";
            this.GuessCountLabel.Size = new System.Drawing.Size(0, 13);
            this.GuessCountLabel.TabIndex = 6;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(26, 186);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(0, 13);
            this.test.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 344);
            this.Controls.Add(this.test);
            this.Controls.Add(this.GuessCountLabel);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
    }
}

