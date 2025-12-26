using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatsVsDogs
{
    public partial class WinnerScreen : UserControl
    {
        private Player _winner;
        public WinnerScreen()
        {
            InitializeComponent();
        }

        public void SetWinner(Player winner)
        {
            _winner = winner;
            labelWinnerMessage.Text = $"Congratulations {winner.Name}! You are the winner!";
        }

        private void buttonQuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
