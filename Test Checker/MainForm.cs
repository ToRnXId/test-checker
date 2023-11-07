using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Test_Checker
{
    public partial class MainForm : Form
    {
        private List<Question> _questions;
        private int _currentQuestionIndex = 0;
        private int _score = 0;
        private readonly Timer _timer = new Timer();
        private int _timeLeft = 20;
        private bool _answered;

        public MainForm()
        {
            InitializeComponent();

            LoadQuestionsFromFile("questions.txt");

            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;

            DisplayQuestion();
        }

        private void LoadQuestionsFromFile(string filename)
        {
            _questions = new List<Question>();

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

                    _questions.Add(question);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading questions from file: {ex.Message}");
                Environment.Exit(1);
            }
        }

        private void DisplayQuestion()
        {
            lblQuestionsQty.Text = $"Question: {_currentQuestionIndex + 1} / {_questions.Count + 1}";
            
            if (_currentQuestionIndex < _questions.Count)
            {
                Question question = _questions[_currentQuestionIndex];

                lblQuestion.Text = question.Text;
                rbChoice1.Text = question.Choices[0];
                rbChoice2.Text = question.Choices[1];
                rbChoice3.Text = question.Choices[2];
                rbChoice4.Text = question.Choices[3];

                _timer.Start();
            }
            else
            {
                _timer.Stop();
                lblInfo.Text = $"Test completed! Your score: {_score}";
                //MessageBox.Show($"Test completed! Your score: {_questions.Count}");
                Environment.Exit(0);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timeLeft--;
            if (_timeLeft == 0)
            {
                _timer.Stop();
                lblInfo.Text = "Time's up! Moving to the next question.";
                _currentQuestionIndex++;
            }
            lblTimer.Text = $"Time Left: {_timeLeft}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            lblQuestionsQty.Text = $"Question: {_currentQuestionIndex + 1} / {_questions.Count + 1}";
            int selectedAnswerIndex = GetSelectedAnswerIndex();

            if (selectedAnswerIndex != -1)
            {
                _timer.Stop();
                Question question = _questions[_currentQuestionIndex];
                question.IsAnswered = true;

                if (question.IsAnswerCorrect(selectedAnswerIndex) && question.IsAnswered)
                {
                    _score++;
                    lblScore.Text = $"Score: {_score}";
                }
                else
                {
                    lblInfo.Text = $"Incorrect! The correct answer is: \n{question.Choices[question.CorrectAnswerIndex]}";
                }

                _currentQuestionIndex++;
                _timeLeft = 60;
                DisplayQuestion();
            }
            else
            {
                //MessageBox.Show("Please select answer before moving to the next question.");
                lblInfo.Text = "Please select answer before moving to the next question.";
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
            lblQuestionsQty.Text = $"Question: {_currentQuestionIndex + 1} / {_questions.Count + 1}";

            int selectedAnswerIndex = GetSelectedAnswerIndex();

            if (selectedAnswerIndex != -1)
            {
                Question question = _questions[_currentQuestionIndex];
                _timer.Stop();

                if (question.IsAnswerCorrect(selectedAnswerIndex))
                {
                    _score++;
                    lblScore.Text = $"Score: {_score}";
                    lblInfo.Text = "Correct!";
                }
                else
                {
                    //MessageBox.Show($"Incorrect! The correct answer is: \n{question.Choices[question.CorrectAnswerIndex]}");
                    lblInfo.Text = $"Incorrect! The correct answer is: \n{question.Choices[question.CorrectAnswerIndex]}";
                }
                _timeLeft = 60;
            }
            else
            {
                //MessageBox.Show("Please select answer before moving to the next question.");
                lblInfo.Text = "Please select answer.";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_currentQuestionIndex > 0)
            {
                _currentQuestionIndex--;
            }
            //rbChoice1.Enabled = false;
            //rbChoice2.Enabled = false;
            //rbChoice3.Enabled = false;
            //rbChoice4.Enabled = false;
            lblQuestionsQty.Text = $"Question: {_currentQuestionIndex + 1} / {_questions.Count + 1}";
            DisplayQuestion();
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public string[] Choices { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public bool IsAnswered {  get; set; }

        public bool IsAnswerCorrect(int selectedAnswerIndex)
        {
            return selectedAnswerIndex == CorrectAnswerIndex;
        }
    }
}