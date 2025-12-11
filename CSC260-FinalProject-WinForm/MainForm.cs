namespace CSC260_FinalProject_WinForm
{
    public partial class MainForm : Form
    {
        StartScreen start;
        SetupScreen setup;
        GameScreen game;
        public MainForm()
        {
            InitializeComponent();

            start = new StartScreen();
            setup = new SetupScreen();
            game = new GameScreen();

            LoadScreen(start);
        }

        public void LoadScreen(UserControl screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        public void ShowStartScreen()
        {
            LoadScreen(start);
        }

        public void ShowSetupScreen()
        {

            LoadScreen(setup);
        }
        public void ShowGameScreen()
        {

            LoadScreen(game);
        }
    }
}
