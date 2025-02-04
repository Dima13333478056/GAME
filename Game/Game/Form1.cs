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
            video.URL = videoPath;
            video.Ctlcontrols.play();
            Text_Schujet.Text = "Лечь поспать еще";
            Text_2.Text = "Начать собираться на учебу";
            Text_Schujet.Visible = true;
            Text_2.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int progress = 0;
        private void Text_Schujet_Click(object sender, EventArgs e)
        {
            switch (progress)
            {
                case 0:
                    videoPath = Path.Combine(Application.StartupPath, "Сцены", "лечь спать.mp4");
                    video.URL = videoPath;
                    video.Ctlcontrols.play();
                    progress++;
                    break;
                case 1:
                    videoPath = Path.Combine(Application.StartupPath, "Сцены", "шутка.mp4");
                    video.URL = videoPath;
                    video.Ctlcontrols.play();
                    break;
                
            }

        }
        private int progress_2 = 0;
        private void Text_2_Click(object sender, EventArgs e)
        {
            switch (progress_2)
            {
                case 0:
                    videoPath = Path.Combine(Application.StartupPath, "Сцены", "label_1.mp4");
                    video.URL = videoPath;
                    video.Ctlcontrols.play();
                    Text_Schujet.Text = "Пошутить";
                    Text_2.Text = "Сказать правду";
                    progress++;
                    break;
                case 1:
                    videoPath = Path.Combine(Application.StartupPath, "Сцены", "правда.mp4");
                    video.URL = videoPath;
                    video.Ctlcontrols.play();
                    break;
            }

        }
    }
}