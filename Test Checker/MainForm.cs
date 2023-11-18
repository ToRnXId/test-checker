using Timer = System.Windows.Forms.Timer;

namespace Test_Checker
{
    public partial class MainForm : Form
    {
        private List<Question>? questionsList;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private readonly Timer timer = new Timer();
        private int timeLeft = 61;

        public MainForm()
        {
            InitializeComponent();

            LoadQuestionsFromFile("questions.txt");

            btnBack.Enabled = false;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            DisplayQuestion();
        }

        private void LoadQuestionsFromFile(string filename)
        {
            questionsList = new List<Question>();

            try
            {
                string[] lines = File.ReadAllLines(filename);

                for (int i = 0; i < lines.Length; i += 6)
                {
                    var question = new Question
                    {
                        Text = lines[i],
                        Choices = lines.Skip(i + 1).Take(4).ToArray(),
                        CorrectAnswerIndex = int.Parse(lines[i + 5])
                    };

                    questionsList.Add(question);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading questions from file: {ex.Message}");
                Environment.Exit(1);
            }
        }

        private void UpdateQuestionsCountLabel()
        {
            lblQuestionsQty.Text = $"Question: {currentQuestionIndex + 1} / {questionsList?.Count}";
        }

        private void DisplayQuestion()
        {
            UpdateQuestionsCountLabel();

            if (questionsList != null && currentQuestionIndex < questionsList.Count)
            {
                DisplayCurrentQuestion();
                EnableAnswerButtons(true);
                timer.Start();
            }
            else
            {
                FinishTest();
            }
        }

        private void DisplayCurrentQuestion()
        {
            Question question = questionsList[currentQuestionIndex];

            lblQuestion.Text = question.Text;
            rbChoice1.Text = question.Choices[0];
            rbChoice2.Text = question.Choices[1];
            rbChoice3.Text = question.Choices[2];
            rbChoice4.Text = question.Choices[3];
        }

        private void FinishTest()
        {
            timer.Stop();
            btnCheck.Enabled = false;
            btnNext.Enabled = false;
            currentQuestionIndex--;
            UpdateQuestionsCountLabel();
            lblInfo.Text += $"Test completed! Your score: {score}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;

            if (timeLeft == 0)
            {
                timer.Stop();
                lblInfo.Text = "Time's up! Moving to the next question. ";
                EnableAnswerButtons(false);
            }
            lblTimer.Text = $"Time Left: {timeLeft}";
        }

        private void EnableAnswerButtons(bool enable)
        {
                rbChoice1.Enabled = enable;
                rbChoice2.Enabled = enable;
                rbChoice3.Enabled = enable;
                rbChoice4.Enabled = enable;
                btnCheck.Enabled = enable;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnCheck.Enabled == false)
            {
                timeLeft = 61;
                lblInfo.Text = "";
                currentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                lblInfo.Text = "Please check answer before moving next question...";
            }
        }

        private int GetSelectedAnswerIndex()
        {
            if (rbChoice1.Checked) return 0;
            if (rbChoice2.Checked) return 1;
            if (rbChoice3.Checked) return 2;
            if (rbChoice4.Checked) return 3;
            return -1;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            UpdateQuestionsCountLabel();

            int selectedAnswerIndex = GetSelectedAnswerIndex();

            if (selectedAnswerIndex != -1)
            {
                Question question = questionsList?[currentQuestionIndex];
                timer.Stop();
                EnableAnswerButtons(false);

                if (question.IsAnswerCorrect(selectedAnswerIndex))
                {
                    score++;
                    lblScore.Text = $"Score: {score}";
                    lblInfo.Text = "Correct!";
                }
                else
                {
                    lblInfo.Text = "Incorrect! The correct answer is: \n" +
                        $"{question.Choices[question.CorrectAnswerIndex]}";
                }
                timeLeft = 60;
            }
            else
            {
                lblInfo.Text = "Please select answer...";
            }
        }
    }
}