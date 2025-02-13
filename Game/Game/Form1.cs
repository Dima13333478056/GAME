using AxWMPLib;
using System;
using System.Drawing;
using System.Drawing.Text;
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
        private string user_input = "";
        private void Play_Click(object sender, EventArgs e)
        {
            Exit.Location = new Point(1720, 0);
            Play.Visible = false;
            video.Visible = true;
            videoPath = Path.Combine(Application.StartupPath, "Сцены", "Пробуждение.mp4");
            Video_play();
            Text_Schujet.Text = "Лечь поспать еще";
            Text_2.Text = "Начать собираться на учебу";
            Text_Schujet.Visible = true;
            Text_2.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Text_Schujet_Click(object sender, EventArgs e)
        {
            user_input = Text_Schujet.Text;
            switch (user_input)
            {
                case "Лечь поспать еще":
                    videoPath = Path.Combine(Application.StartupPath, "Сцены", "лечь спать.MOV");
                    Video_play();
                    Wasted();
                    break;
                case "Пошутить":
                    videoPath = Path.Combine(Application.StartupPath, "Сцены", "шутка (2).mp4");
                    Video_play();
                    Text_Schujet.Text = "Пойти на пары";
                    Text_2.Text = "Прогулять";
                    break;
                case "Пойти на пары":
                    videoPath = Path.Combine(Application.StartupPath, "Сцены", "на пары.mp4");
                    Video_play();
                    Text_Schujet.Text = "Сказать что не знаю ответа";
                    Text_2.Text = "Инкапсуляция Наследование Полиморфизм";
                    break;
                case "Сказать что не знаю ответа":
                    videoPath = Path.Combine(Application.StartupPath, "Сцены", "не знаю.MOV");
                    Video_play();
                    Wasted();
                    break;
            }

        }
        private void Wasted()
        {
            timer1.Interval = 10000;
            timer1.Start();
        }
        private void Text_2_Click(object sender, EventArgs e)
        {
            user_input = Text_2.Text;

            switch (user_input)
            {
                case "Начать собираться на учебу":
                    videoPath = Path.Combine(Application.StartupPath, "Сцены", "label_1.mp4");
                    Video_play();
                    Text_Schujet.Text = "Пошутить";
                    Text_2.Text = "Сказать правду";
                    break;

                case "Сказать правду":
                    videoPath = Path.Combine(Application.StartupPath, "Сцены", "правда (2).mp4");
                    Video_play();
                    Text_Schujet.Text = "Пойти на пары";
                    Text_2.Text = "Прогулять";
                    break;
                case "Прогулять":
                    videoPath = Path.Combine(Application.StartupPath, "Сцены", "Прогулять.mp4");
                    Video_play();
                    Wasted();
                    break;
                case "Инкапсуляция Наследование Полиморфизм":
                    videoPath = Path.Combine(Application.StartupPath, "Сцены", "правильно.MOV");
                    Video_play();
                    break;
            }
        }
        private void Video_play()
        {
            video.Size = new Size(1920, 1080);
            video.Location = new Point(0, 0);
            video.URL = videoPath;
            video.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Вы проиграли!");
            this.Close();
        }
    }
}