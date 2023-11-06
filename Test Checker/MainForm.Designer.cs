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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            lblQuestion.AccessibleRole = AccessibleRole.None;
            resources.ApplyResources(lblQuestion, "lblQuestion");
            lblQuestion.BackColor = SystemColors.InfoText;
            lblQuestion.BorderStyle = BorderStyle.Fixed3D;
            lblQuestion.CausesValidation = false;
            lblQuestion.ForeColor = SystemColors.Control;
            lblQuestion.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblQuestion.Name = "lblQuestion";
            lblQuestion.UseCompatibleTextRendering = true;
            lblQuestion.UseMnemonic = false;
            // 
            // rbChoice1
            // 
            rbChoice1.BackColor = SystemColors.InfoText;
            resources.ApplyResources(rbChoice1, "rbChoice1");
            rbChoice1.FlatAppearance.BorderColor = Color.White;
            rbChoice1.FlatAppearance.BorderSize = 3;
            rbChoice1.FlatAppearance.CheckedBackColor = Color.White;
            rbChoice1.FlatAppearance.MouseDownBackColor = Color.White;
            rbChoice1.FlatAppearance.MouseOverBackColor = Color.White;
            rbChoice1.ForeColor = SystemColors.Window;
            rbChoice1.Name = "rbChoice1";
            rbChoice1.UseCompatibleTextRendering = true;
            rbChoice1.UseMnemonic = false;
            rbChoice1.UseVisualStyleBackColor = false;
            // 
            // rbChoice2
            // 
            rbChoice2.FlatAppearance.BorderColor = Color.White;
            rbChoice2.FlatAppearance.BorderSize = 3;
            rbChoice2.FlatAppearance.CheckedBackColor = Color.White;
            rbChoice2.FlatAppearance.MouseDownBackColor = Color.White;
            rbChoice2.FlatAppearance.MouseOverBackColor = Color.White;
            resources.ApplyResources(rbChoice2, "rbChoice2");
            rbChoice2.ForeColor = SystemColors.Window;
            rbChoice2.Name = "rbChoice2";
            rbChoice2.UseCompatibleTextRendering = true;
            rbChoice2.UseMnemonic = false;
            rbChoice2.UseVisualStyleBackColor = false;
            // 
            // rbChoice3
            // 
            rbChoice3.FlatAppearance.BorderColor = Color.White;
            rbChoice3.FlatAppearance.BorderSize = 3;
            rbChoice3.FlatAppearance.CheckedBackColor = Color.White;
            rbChoice3.FlatAppearance.MouseDownBackColor = Color.White;
            rbChoice3.FlatAppearance.MouseOverBackColor = Color.White;
            resources.ApplyResources(rbChoice3, "rbChoice3");
            rbChoice3.ForeColor = SystemColors.Window;
            rbChoice3.Name = "rbChoice3";
            rbChoice3.UseCompatibleTextRendering = true;
            rbChoice3.UseMnemonic = false;
            rbChoice3.UseVisualStyleBackColor = false;
            // 
            // rbChoice4
            // 
            rbChoice4.FlatAppearance.BorderColor = Color.White;
            rbChoice4.FlatAppearance.BorderSize = 3;
            rbChoice4.FlatAppearance.CheckedBackColor = Color.White;
            rbChoice4.FlatAppearance.MouseDownBackColor = Color.White;
            rbChoice4.FlatAppearance.MouseOverBackColor = Color.White;
            resources.ApplyResources(rbChoice4, "rbChoice4");
            rbChoice4.ForeColor = SystemColors.Window;
            rbChoice4.Name = "rbChoice4";
            rbChoice4.UseCompatibleTextRendering = true;
            rbChoice4.UseMnemonic = false;
            rbChoice4.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderColor = Color.White;
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.ForeColor = SystemColors.ControlLight;
            btnNext.Name = "btnNext";
            btnNext.Tag = "";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblTimer
            // 
            lblTimer.ForeColor = SystemColors.ControlLightLight;
            resources.ApplyResources(lblTimer, "lblTimer");
            lblTimer.Name = "lblTimer";
            // 
            // MainForm
            // 
            AcceptButton = btnNext;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            CausesValidation = false;
            Controls.Add(lblTimer);
            Controls.Add(btnNext);
            Controls.Add(rbChoice4);
            Controls.Add(rbChoice3);
            Controls.Add(rbChoice2);
            Controls.Add(rbChoice1);
            Controls.Add(lblQuestion);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "MainForm";
            Opacity = 0.9D;
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
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