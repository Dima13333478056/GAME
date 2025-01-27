namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Подписываемся на событие завершения видео
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string backgroundImagePath = "C:\\Users\\redmi\\Desktop\\Новая папка\\GAME\\Фоны\\Fon_StartGame.jpg";
                if (!File.Exists(backgroundImagePath))
                {
                    MessageBox.Show("Фоновое изображение не найдено!");
                    return;
                }

                Fon.BackgroundImage = Image.FromFile(backgroundImagePath);
                Fon.BackgroundImageLayout = ImageLayout.Stretch;
                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки фона: " + ex.Message);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            try
            {
                Exit.Location = new Point(1720, 0);
                Play.Visible = false;

                string videoPath = "C:\\Users\\redmi\\Desktop\\Новая папка\\GAME\\IMG_5204.MOV";
                if (!File.Exists(videoPath))
                {
                    MessageBox.Show("Видеофайл не найден!");
                    return;
                }

                axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.Location = new Point(0, 0);
                axWindowsMediaPlayer1.Size = new Size(1920, 1080);
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка воспроизведения видео: " + ex.Message);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Day_one()
        {
            try
            {
                string dayOneBackgroundPath = "C:\\Users\\redmi\\Desktop\\Новая папка\\GAME\\Фоны\\Fon_StartGame.jpg";
                if (!File.Exists(dayOneBackgroundPath))
                {
                    MessageBox.Show("Фон для Дня 1 не найден!");
                    return;
                }

                Fon.BackgroundImage = Image.FromFile(dayOneBackgroundPath);
                Fon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки фона для Дня 1: " + ex.Message);
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                // Видео завершено, переходим к Дню 1
                axWindowsMediaPlayer1.Visible = false;
                Day_one();
            }
        }
    }
}