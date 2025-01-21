namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Play.Location = new Point((this.Width / 2) - (Play.Width / 2), (this.Height / 2) - (Play.Height / 2));
            Exit.Location = new Point((this.Width / 2) - (Play.Width / 2), (this.Height / 2) - (Play.Height / 2)+80);
        }

        private void Play_Click(object sender, EventArgs e)
        {

        }
    }
}
