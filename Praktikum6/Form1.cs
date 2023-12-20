namespace Praktikum6
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int computerChoice;
        int computerScore;
        int playerScore;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        public void Play(int playerChoice)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();

            computerChoice = rnd.Next(1, 4);
            if(computerChoice == 1)
            {
                pictureBox1.Show();
            } else if (computerChoice == 2)
            {
                pictureBox2.Show();
            } else if (computerChoice == 3)
            {
                pictureBox3.Show();
            }

            if (computerChoice != playerChoice) {
                if(playerChoice == 1)
                {
                    if (computerChoice == 2) computerScore++;
                    if (computerChoice == 3) playerScore++;
                } else if (playerChoice == 2)
                {
                    if (computerChoice == 1) playerScore++;
                    if (computerChoice == 3) computerScore++;
                } else if (playerChoice == 3)
                {
                    if (computerChoice == 1) computerScore++;
                    if (computerChoice == 2) playerScore++;
                }
            }

            label3.Text = "You " + playerScore.ToString() + " : " + computerScore.ToString() + " CPU";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Play(1);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Play(2);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Play(3);
        }
    }
}
