namespace CSC260_FinalProject_WinForm
{
    public partial class MainForm : Form
    {
        StartScreen start;
        GameScreen game;
        public MainForm()
        {
            InitializeComponent();

            start = new StartScreen();
            game = new GameScreen();

            LoadScreen(start);
        }

        public void LoadScreen(UserControl screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        public void ShowGameScreen()
        {
            LoadScreen(game);
        }

        public void ShowStartScreen()
        {
            LoadScreen(start);
        }
    }
}
