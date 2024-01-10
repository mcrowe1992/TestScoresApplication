namespace Test_Scores_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblScore = new Label();
            lblScoreTotal = new Label();
            lblScoreCount = new Label();
            lblAverage = new Label();
            scoreTextBox = new TextBox();
            totalTextBox = new TextBox();
            countTextBox = new TextBox();
            averageTextBox = new TextBox();
            addButton = new Button();
            displayScoresButton = new Button();
            clearScoresButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(73, 59);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(39, 15);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score:";
            // 
            // lblScoreTotal
            // 
            lblScoreTotal.AutoSize = true;
            lblScoreTotal.Location = new Point(73, 117);
            lblScoreTotal.Name = "lblScoreTotal";
            lblScoreTotal.Size = new Size(66, 15);
            lblScoreTotal.TabIndex = 1;
            lblScoreTotal.Text = "Score total:";
            // 
            // lblScoreCount
            // 
            lblScoreCount.AutoSize = true;
            lblScoreCount.Location = new Point(73, 174);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(73, 15);
            lblScoreCount.TabIndex = 2;
            lblScoreCount.Text = "Score count:";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(73, 225);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(53, 15);
            lblAverage.TabIndex = 3;
            lblAverage.Text = "Average:";
            // 
            // scoreTextBox
            // 
            scoreTextBox.Location = new Point(197, 56);
            scoreTextBox.Name = "scoreTextBox";
            scoreTextBox.Size = new Size(100, 23);
            scoreTextBox.TabIndex = 4;
            // 
            // totalTextBox
            // 
            totalTextBox.Location = new Point(197, 114);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(100, 23);
            totalTextBox.TabIndex = 5;
            // 
            // countTextBox
            // 
            countTextBox.Location = new Point(197, 171);
            countTextBox.Name = "countTextBox";
            countTextBox.ReadOnly = true;
            countTextBox.Size = new Size(100, 23);
            countTextBox.TabIndex = 6;
            // 
            // averageTextBox
            // 
            averageTextBox.Location = new Point(197, 222);
            averageTextBox.Name = "averageTextBox";
            averageTextBox.ReadOnly = true;
            averageTextBox.Size = new Size(100, 23);
            averageTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Location = new Point(374, 57);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // displayScoresButton
            // 
            displayScoresButton.Location = new Point(57, 293);
            displayScoresButton.Name = "displayScoresButton";
            displayScoresButton.Size = new Size(100, 23);
            displayScoresButton.TabIndex = 9;
            displayScoresButton.Text = "Display Scores";
            displayScoresButton.UseVisualStyleBackColor = true;
            displayScoresButton.Click += displayScoresButton_Click;
            // 
            // clearScoresButton
            // 
            clearScoresButton.Location = new Point(209, 293);
            clearScoresButton.Name = "clearScoresButton";
            clearScoresButton.Size = new Size(88, 23);
            clearScoresButton.TabIndex = 10;
            clearScoresButton.Text = "Clear Scores";
            clearScoresButton.UseVisualStyleBackColor = true;
            clearScoresButton.Click += clearScoresButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(209, 373);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(clearScoresButton);
            Controls.Add(displayScoresButton);
            Controls.Add(addButton);
            Controls.Add(averageTextBox);
            Controls.Add(countTextBox);
            Controls.Add(totalTextBox);
            Controls.Add(scoreTextBox);
            Controls.Add(lblAverage);
            Controls.Add(lblScoreCount);
            Controls.Add(lblScoreTotal);
            Controls.Add(lblScore);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private Label lblScoreTotal;
        private Label lblScoreCount;
        private Label lblAverage;
        private TextBox scoreTextBox;
        private TextBox totalTextBox;
        private TextBox countTextBox;
        private TextBox averageTextBox;
        private Button addButton;
        private Button displayScoresButton;
        private Button clearScoresButton;
        private Button exitButton;
    }
}