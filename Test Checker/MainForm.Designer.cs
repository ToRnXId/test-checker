namespace Test_Checker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblQuestion = new Label();
            rbChoice1 = new RadioButton();
            rbChoice2 = new RadioButton();
            rbChoice3 = new RadioButton();
            rbChoice4 = new RadioButton();
            btnNext = new Button();
            lblTimer = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.BorderStyle = BorderStyle.FixedSingle;
            lblQuestion.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestion.Location = new Point(12, 9);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(389, 152);
            lblQuestion.TabIndex = 0;
            // 
            // rbChoice1
            // 
            rbChoice1.Location = new Point(12, 176);
            rbChoice1.Name = "rbChoice1";
            rbChoice1.Size = new Size(384, 50);
            rbChoice1.TabIndex = 1;
            rbChoice1.Text = "rbChoice1";
            rbChoice1.UseVisualStyleBackColor = true;
            rbChoice1.CheckedChanged += rbChoice1_CheckedChanged;
            // 
            // rbChoice2
            // 
            rbChoice2.Location = new Point(12, 232);
            rbChoice2.Name = "rbChoice2";
            rbChoice2.Size = new Size(384, 50);
            rbChoice2.TabIndex = 2;
            rbChoice2.Text = "rbChoice2";
            rbChoice2.UseVisualStyleBackColor = true;
            // 
            // rbChoice3
            // 
            rbChoice3.Location = new Point(12, 288);
            rbChoice3.Name = "rbChoice3";
            rbChoice3.Size = new Size(384, 50);
            rbChoice3.TabIndex = 3;
            rbChoice3.Text = "rbChoice3";
            rbChoice3.UseVisualStyleBackColor = true;
            // 
            // rbChoice4
            // 
            rbChoice4.Location = new Point(12, 344);
            rbChoice4.Name = "rbChoice4";
            rbChoice4.Size = new Size(389, 50);
            rbChoice4.TabIndex = 4;
            rbChoice4.Text = "rbChoice4";
            rbChoice4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(247, 410);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblTimer
            // 
            lblTimer.Location = new Point(78, 414);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(100, 23);
            lblTimer.TabIndex = 6;
            lblTimer.Text = "Timer: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 450);
            Controls.Add(lblTimer);
            Controls.Add(btnNext);
            Controls.Add(rbChoice4);
            Controls.Add(rbChoice3);
            Controls.Add(rbChoice2);
            Controls.Add(rbChoice1);
            Controls.Add(lblQuestion);
            Name = "MainForm";
            Text = "Test Checker";
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestion;
        private RadioButton rbChoice1;
        private RadioButton rbChoice2;
        private RadioButton rbChoice3;
        private RadioButton rbChoice4;
        private Button btnNext;
        private Label lblTimer;
    }
}