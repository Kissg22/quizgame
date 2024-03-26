namespace QuizGame
{
    partial class startLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startLabel));
            retryButton = new Button();
            scoreLabel = new Label();
            questionLabel = new Label();
            nextButton = new Button();
            questionNumberLabel = new Label();
            timerLabel = new Label();
            timeLabel = new Label();
            startButton = new Button();
            labels = new Label();
            RadioButton1 = new RadioButton();
            RadioButton2 = new RadioButton();
            RadioButton3 = new RadioButton();
            RadioButton4 = new RadioButton();
            vGroupBox = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            vGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // retryButton
            // 
            retryButton.BackColor = Color.Salmon;
            retryButton.FlatStyle = FlatStyle.Flat;
            retryButton.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            retryButton.Location = new Point(595, 373);
            retryButton.Margin = new Padding(0);
            retryButton.Name = "retryButton";
            retryButton.Size = new Size(113, 37);
            retryButton.TabIndex = 1;
            retryButton.Text = "Újra";
            retryButton.UseVisualStyleBackColor = false;
            retryButton.Click += retryButton_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.Font = new Font("Kristen ITC", 14.25F);
            scoreLabel.Location = new Point(77, 350);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(78, 27);
            scoreLabel.TabIndex = 2;
            scoreLabel.Text = "pontok";
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.BackColor = Color.Transparent;
            questionLabel.Font = new Font("Javanese Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionLabel.Location = new Point(77, 101);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(59, 54);
            questionLabel.TabIndex = 3;
            questionLabel.Text = "???";
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.Salmon;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            nextButton.ForeColor = SystemColors.ActiveCaptionText;
            nextButton.Location = new Point(77, 344);
            nextButton.Margin = new Padding(0);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(113, 37);
            nextButton.TabIndex = 4;
            nextButton.Text = "Következő";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.BackColor = Color.Transparent;
            questionNumberLabel.Font = new Font("Kristen ITC", 14.25F);
            questionNumberLabel.Location = new Point(577, 22);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(142, 27);
            questionNumberLabel.TabIndex = 5;
            questionNumberLabel.Text = "Kérdések: 0/0";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.Transparent;
            timerLabel.Font = new Font("Kristen ITC", 14.25F);
            timerLabel.Location = new Point(77, 22);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(147, 27);
            timerLabel.TabIndex = 6;
            timerLabel.Text = "Hátlralévő idő:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.BackColor = Color.Transparent;
            timeLabel.Font = new Font("Kristen ITC", 14.25F);
            timeLabel.Location = new Point(77, 400);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(55, 27);
            timeLabel.TabIndex = 7;
            timeLabel.Text = "Idő: ";
            // 
            // startButton
            // 
            startButton.BackColor = Color.Salmon;
            startButton.BackgroundImageLayout = ImageLayout.None;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Ink Free", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startButton.ForeColor = Color.Black;
            startButton.Location = new Point(294, 350);
            startButton.Margin = new Padding(0);
            startButton.Name = "startButton";
            startButton.Size = new Size(189, 44);
            startButton.TabIndex = 8;
            startButton.Text = "Játék indítása";
            startButton.UseVisualStyleBackColor = false;
            // 
            // labels
            // 
            labels.AutoSize = true;
            labels.BackColor = Color.Transparent;
            labels.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labels.Location = new Point(197, 24);
            labels.Name = "labels";
            labels.Size = new Size(403, 36);
            labels.TabIndex = 9;
            labels.Text = "TÖRTÉNELMI KVÍZ JÁTÉK";
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Font = new Font("Segoe UI Semibold", 15.25F, FontStyle.Bold);
            RadioButton1.Location = new Point(17, 16);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(96, 34);
            RadioButton1.TabIndex = 0;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "Válasz1";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Font = new Font("Segoe UI Semibold", 15.25F, FontStyle.Bold);
            RadioButton2.Location = new Point(17, 80);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(100, 34);
            RadioButton2.TabIndex = 1;
            RadioButton2.TabStop = true;
            RadioButton2.Text = "Válasz2";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            RadioButton3.AutoSize = true;
            RadioButton3.Font = new Font("Segoe UI Semibold", 15.25F, FontStyle.Bold);
            RadioButton3.Location = new Point(365, 16);
            RadioButton3.Name = "RadioButton3";
            RadioButton3.Size = new Size(100, 34);
            RadioButton3.TabIndex = 2;
            RadioButton3.TabStop = true;
            RadioButton3.Text = "Válasz3";
            RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton4
            // 
            RadioButton4.AutoSize = true;
            RadioButton4.Font = new Font("Segoe UI Semibold", 15.25F, FontStyle.Bold);
            RadioButton4.Location = new Point(365, 80);
            RadioButton4.Name = "RadioButton4";
            RadioButton4.Size = new Size(100, 34);
            RadioButton4.TabIndex = 3;
            RadioButton4.TabStop = true;
            RadioButton4.Text = "Válasz4";
            RadioButton4.UseVisualStyleBackColor = true;
            // 
            // vGroupBox
            // 
            vGroupBox.BackColor = Color.PapayaWhip;
            vGroupBox.Controls.Add(RadioButton4);
            vGroupBox.Controls.Add(RadioButton1);
            vGroupBox.Controls.Add(RadioButton3);
            vGroupBox.Controls.Add(RadioButton2);
            vGroupBox.Location = new Point(77, 164);
            vGroupBox.Margin = new Padding(0);
            vGroupBox.Name = "vGroupBox";
            vGroupBox.Size = new Size(631, 138);
            vGroupBox.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(labels);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 68);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(252, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // startLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(pictureBox1);
            Controls.Add(questionNumberLabel);
            Controls.Add(vGroupBox);
            Controls.Add(startButton);
            Controls.Add(timeLabel);
            Controls.Add(timerLabel);
            Controls.Add(nextButton);
            Controls.Add(questionLabel);
            Controls.Add(scoreLabel);
            Controls.Add(retryButton);
            Controls.Add(panel1);
            Name = "startLabel";
            Text = "Történelmi kvíz";
            vGroupBox.ResumeLayout(false);
            vGroupBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button retryButton;
        private Label scoreLabel;
        private Label questionLabel;
        private Button nextButton;
        private Label questionNumberLabel;
        private Label timerLabel;
        private Label timeLabel;
        private Button startButton;
        private Label labels;
        private RadioButton RadioButton1;
        private RadioButton RadioButton2;
        private RadioButton RadioButton3;
        private RadioButton RadioButton4;
        private Panel vGroupBox;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
