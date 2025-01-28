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
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string backgroundImagePath = Path.Combine(Application.StartupPath, "Фоны", "Fon_StartGame.jpg");
                if (!File.Exists(backgroundImagePath))
                {
                    MessageBox.Show("Фоновое изображение не найдено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
            videoPath = Path.Combine(Application.StartupPath, "Сцены", "Scene_DayOne.mp4");
            Video_Start(); // Добавлен вызов метода Video_Start для начала воспроизведения видео
        }

        private void Video_Start()
        {
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Location = new Point(0, 0);
            axWindowsMediaPlayer1.Size = new Size(1920, 1080);
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Day_one()
        {
            videoPath = Path.Combine(Application.StartupPath, "Сцены", "One.MOV");
            Video_Start(); // Добавлен вызов метода Video_Start для начала воспроизведения видео
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                // Видео завершено, переходим к Дню 1
                axWindowsMediaPlayer1.Visible = false;
            }
            Day_one();
        }
    }
}