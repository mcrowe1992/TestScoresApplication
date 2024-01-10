using static System.Formats.Asn1.AsnWriter;

namespace Test_Scores_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> scores = new List<int>();
        private void addButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(scoreTextBox.Text, out int score))
            {
                if (score >= 0 && score <= 100)
                {
                    scores.Add(score);
                    UpdateStats();
                }
                else
                {
                    MessageBox.Show("Please enter a valid score between 0 and 100.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer score.");
            }
        }

        private void UpdateStats()
        {
            int total = scores.Sum();
            int count = scores.Count;
            double average = count > 0 ? (double)total / count : 0.0;

            totalTextBox.Text = total.ToString();
            countTextBox.Text = count.ToString();
            averageTextBox.Text = average.ToString("F2");
        }

        private void displayScoresButton_Click(object sender, EventArgs e)
        {
            List<int> sortedScores = new List<int>(scores);
            sortedScores.Sort();
            string sortedScoresText = string.Join(", ", sortedScores);
            MessageBox.Show("Sorted Scores: " + sortedScoresText);
        }

        private void clearScoresButton_Click(object sender, EventArgs e)
        {
            scores.Clear();
            totalTextBox.Text = "0";
            countTextBox.Text = "0";
            averageTextBox.Text = "0.00";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}