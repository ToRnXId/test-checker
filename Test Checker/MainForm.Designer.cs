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
            lblScore = new Label();
            btnCheck = new Button();
            lblInfo = new Label();
            lblQuestionsQty = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AccessibleRole = AccessibleRole.None;
            resources.ApplyResources(lblQuestion, "lblQuestion");
            lblQuestion.BackColor = SystemColors.InfoText;
            lblQuestion.BorderStyle = BorderStyle.Fixed3D;
            lblQuestion.CausesValidation = false;
            lblQuestion.ForeColor = SystemColors.ControlLightLight;
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
            rbChoice1.FlatAppearance.CheckedBackColor = Color.White;
            rbChoice1.FlatAppearance.MouseDownBackColor = Color.White;
            rbChoice1.FlatAppearance.MouseOverBackColor = Color.White;
            rbChoice1.ForeColor = SystemColors.ControlLightLight;
            rbChoice1.Name = "rbChoice1";
            rbChoice1.UseCompatibleTextRendering = true;
            rbChoice1.UseMnemonic = false;
            rbChoice1.UseVisualStyleBackColor = true;
            // 
            // rbChoice2
            // 
            rbChoice2.FlatAppearance.BorderColor = Color.White;
            rbChoice2.FlatAppearance.BorderSize = 3;
            rbChoice2.FlatAppearance.CheckedBackColor = Color.White;
            rbChoice2.FlatAppearance.MouseDownBackColor = Color.White;
            rbChoice2.FlatAppearance.MouseOverBackColor = Color.White;
            resources.ApplyResources(rbChoice2, "rbChoice2");
            rbChoice2.ForeColor = SystemColors.ControlLightLight;
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
            rbChoice3.ForeColor = SystemColors.ControlLightLight;
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
            rbChoice4.ForeColor = SystemColors.ControlLightLight;
            rbChoice4.Name = "rbChoice4";
            rbChoice4.UseCompatibleTextRendering = true;
            rbChoice4.UseMnemonic = false;
            rbChoice4.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderColor = Color.White;
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.ForeColor = SystemColors.ActiveCaption;
            btnNext.Name = "btnNext";
            btnNext.Tag = "";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblTimer
            // 
            lblTimer.ForeColor = SystemColors.ActiveCaption;
            resources.ApplyResources(lblTimer, "lblTimer");
            lblTimer.Name = "lblTimer";
            // 
            // lblScore
            // 
            lblScore.ForeColor = SystemColors.ActiveCaption;
            resources.ApplyResources(lblScore, "lblScore");
            lblScore.Name = "lblScore";
            // 
            // btnCheck
            // 
            btnCheck.DialogResult = DialogResult.Cancel;
            btnCheck.FlatAppearance.BorderColor = Color.White;
            resources.ApplyResources(btnCheck, "btnCheck");
            btnCheck.ForeColor = SystemColors.ActiveCaption;
            btnCheck.Name = "btnCheck";
            btnCheck.Tag = "";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblInfo
            // 
            lblInfo.BorderStyle = BorderStyle.Fixed3D;
            lblInfo.FlatStyle = FlatStyle.Popup;
            lblInfo.ForeColor = SystemColors.ActiveCaption;
            resources.ApplyResources(lblInfo, "lblInfo");
            lblInfo.Name = "lblInfo";
            lblInfo.UseCompatibleTextRendering = true;
            // 
            // lblQuestionsQty
            // 
            lblQuestionsQty.ForeColor = SystemColors.ActiveCaption;
            resources.ApplyResources(lblQuestionsQty, "lblQuestionsQty");
            lblQuestionsQty.Name = "lblQuestionsQty";
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.White;
            resources.ApplyResources(btnBack, "btnBack");
            btnBack.ForeColor = SystemColors.ActiveCaption;
            btnBack.Name = "btnBack";
            btnBack.Tag = "";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // MainForm
            // 
            AcceptButton = btnNext;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            CausesValidation = false;
            Controls.Add(btnBack);
            Controls.Add(lblQuestionsQty);
            Controls.Add(lblInfo);
            Controls.Add(btnCheck);
            Controls.Add(lblScore);
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
        private Button btnNext;
        private Label lblTimer;
        private Label lblScore;
        private Button btnCheck;
        private Label lblInfo;
        private Label lblQuestionsQty;
        private Button btnBack;
        public RadioButton rbChoice1;
        public RadioButton rbChoice2;
        public RadioButton rbChoice3;
        public RadioButton rbChoice4;
    }
}