using AxWMPLib;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private string videoPath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            video.Size = new Size(1920, 1080);
            video.Location = new Point(0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string backgroundImagePath = Path.Combine(Application.StartupPath, "Фоны", "Fon_StartGame.jpg");
                Fon.Size = new Size(1920, 1080);
                Fon.Location = new Point(0, 0);
                Fon.BackgroundImage = Image.FromFile(backgroundImagePath);
                Fon.BackgroundImageLayout = ImageLayout.Stretch;
                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки фона: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Exit.Location = new Point(1720, 0);
            Play.Visible = false;
            video.Visible = true;
            videoPath = Path.Combine(Application.StartupPath, "Сцены", "Scene_one.mp4");
            video.URL = videoPath; // Указать путь к видео
            video.Ctlcontrols.play(); //
            Text_Schujet.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Text_Schujet_Click(object sender, EventArgs e)
        {
            videoPath = Path.Combine(Application.StartupPath, "Сцены", "Scene_two.mp4");
            video.URL = videoPath; // Указать путь к видео
            video.Ctlcontrols.play(); // Запустить 
        }
    }
}