using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC260_FinalProject_WinForm
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
        }


        private void startScreenButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.FindForm()).ShowStartScreen();
        }

        public void DisplayCard(Card card)
        {
            if (card == null) return;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
