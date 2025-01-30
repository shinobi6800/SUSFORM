using System;
using System.Drawing;
using System.Windows.Forms;

namespace FunnyQuestionsApp
{
    public partial class Form1 : Form
    {
        private int questionIndex = 0;
        private string[] questions = new string[]
        {
            "Are you having a good day?",
            "Do you like pizza?",
            "Have you ever traveled to space?",
            "Are you a cat person?",
            "Do you enjoy programming?",
            "Are you afraid of heights?",
            "Do you believe in aliens?",
            "Do you like coffee?",
            "Is chocolate your favorite food?",
            "Are you gay?" // The special question
        };

        public Form1()
        {
            InitializeComponent();
            DisplayNextQuestion();
            questionTimer.Start(); // Start the timer to change questions
        }

        private void DisplayNextQuestion()
        {
            if (questionIndex < questions.Length)
            {
                questionLabel.Text = questions[questionIndex];
                questionIndex++;
            }
            else
            {
                questionIndex = 0; // Reset when questions end
                DisplayNextQuestion();
            }
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for answering!", "Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayNextQuestion();
        }

        private void NoButton_MouseEnter(object sender, EventArgs e)
        {
            if (questions[questionIndex - 1] == "Are you gay?") // Special question
            {
                Random rand = new Random();
                int x = rand.Next(50, this.ClientSize.Width - noButton.Width);
                int y = rand.Next(50, this.ClientSize.Height - noButton.Height);
                noButton.Location = new Point(x, y);
            }
        }

        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            DisplayNextQuestion();
        }
    }
}
