namespace CatsVsDogs
{
    public partial class MainForm : Form
    {
        StartScreen startScreen;
        SetupScreen setupScreen;
        GameScreen gameScreen;
        WinnerScreen winnerScreen;
        Game game;
        Player player1;
        Player player2;
        public MainForm()
        {
            InitializeComponent();

            startScreen = new StartScreen();
            setupScreen = new SetupScreen();
            gameScreen = new GameScreen();
            winnerScreen = new WinnerScreen();

            player1 = new Player();
            player2 = new Player();

            setupScreen.setPlayers(player1, player2);

            LoadScreen(startScreen);
        }

        public void PassPlayersToGame(Player p1, Player p2)
        {
            game = new Game(p1, p2);
        }

        public void LoadScreen(UserControl screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        public void ShowStartScreen()
        {
            LoadScreen(startScreen);
        }

        public void ShowSetupScreen()
        {

            LoadScreen(setupScreen);
        }
        public void ShowGameScreen()
        {
            LoadScreen(gameScreen);
            gameScreen.LoadGame(this.game);
        }

        public void ShowWinnerScreen(Player winner)
        {
            winnerScreen.SetWinner(winner);
            LoadScreen(winnerScreen);
        }
    }
}
