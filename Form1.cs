namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "WinForm";
            this.BackColor = Color.Yellow;
            this.Width = 400;
            this.Height = 400;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hello winform!");
            Button btn = new Button();
            btn.Text = "self-made button";
            btn.Width = 150;
            btn.Height = 50;
            btn.BackColor = Color.YellowGreen;   
            btn.ForeColor = Color.Blue;
            btn.Location = new Point(btn.Location.X+100, btn.Location.Y+200);
            Controls.Add(btn);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
          Button tmp = sender as Button;
            tmp.Top = 350;
            tmp.Text = "i need more  clicks!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("you really want close program?!"," warning-Exit! ", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Close();
            else
                MessageBox.Show("Thank you!");

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Text = $"X={e.X},{e.Y}";
            if (e.Button == MouseButtons.Left)
                MessageBox.Show("left btn pressed!");
            else if (e.Button == MouseButtons.Middle)
                MessageBox.Show("middle btn pressed!");
            else
                MessageBox.Show("Right btn pressed!");
        }
    }
}