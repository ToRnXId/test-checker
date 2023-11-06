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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbChoice1 = new System.Windows.Forms.RadioButton();
            this.rbChoice2 = new System.Windows.Forms.RadioButton();
            this.rbChoice3 = new System.Windows.Forms.RadioButton();
            this.rbChoice4 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.Location = new System.Drawing.Point(12, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(776, 152);
            this.lblQuestion.TabIndex = 0;
            // 
            // rbChoice1
            // 
            this.rbChoice1.Location = new System.Drawing.Point(12, 176);
            this.rbChoice1.Name = "rbChoice1";
            this.rbChoice1.Size = new System.Drawing.Size(350, 50);
            this.rbChoice1.TabIndex = 1;
            this.rbChoice1.Text = "rbChoice1";
            this.rbChoice1.UseVisualStyleBackColor = true;
            this.rbChoice1.CheckedChanged += new System.EventHandler(this.rbChoice1_CheckedChanged);
            // 
            // rbChoice2
            // 
            this.rbChoice2.Location = new System.Drawing.Point(12, 275);
            this.rbChoice2.Name = "rbChoice2";
            this.rbChoice2.Size = new System.Drawing.Size(350, 50);
            this.rbChoice2.TabIndex = 2;
            this.rbChoice2.Text = "rbChoice2";
            this.rbChoice2.UseVisualStyleBackColor = true;
            // 
            // rbChoice3
            // 
            this.rbChoice3.Location = new System.Drawing.Point(368, 176);
            this.rbChoice3.Name = "rbChoice3";
            this.rbChoice3.Size = new System.Drawing.Size(350, 50);
            this.rbChoice3.TabIndex = 3;
            this.rbChoice3.Text = "rbChoice3";
            this.rbChoice3.UseVisualStyleBackColor = true;
            // 
            // rbChoice4
            // 
            this.rbChoice4.Location = new System.Drawing.Point(368, 275);
            this.rbChoice4.Name = "rbChoice4";
            this.rbChoice4.Size = new System.Drawing.Size(350, 50);
            this.rbChoice4.TabIndex = 4;
            this.rbChoice4.Text = "rbChoice4";
            this.rbChoice4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(409, 358);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.Location = new System.Drawing.Point(243, 358);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 23);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "Timer: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbChoice4);
            this.Controls.Add(this.rbChoice3);
            this.Controls.Add(this.rbChoice2);
            this.Controls.Add(this.rbChoice1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "MainForm";
            this.Text = "Test Checker";
            this.ResumeLayout(false);

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