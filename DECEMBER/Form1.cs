namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "WinForm";
            this.BackColor = Color.Black;
            this.Width = 400;
            this.Height = 400;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("you want to play a game?", " GAME ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Game(sender, e);
            else
                MessageBox.Show("ok!");
        }
        private void Game(object sender, EventArgs e)
        {
            int num = 1;
            DialogResult result;
            DialogResult again;
            while (true)
            {
                result = MessageBox.Show($"{new Random().Next(1, 2000)}", "It`s your number?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("it`s too easy!)");
                    MessageBox.Show($"program guessed the number from an attempt={num}");
                    again = MessageBox.Show($"You want play again?","Second try?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (again == DialogResult.Yes)
                        Game(sender, e);
                    else
                        Close();
                    return;
                }
                num++;
            }

        }
    }
}