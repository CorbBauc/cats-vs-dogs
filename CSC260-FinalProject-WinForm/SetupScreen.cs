using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSC260_FinalProject_WinForm
{
    public partial class SetupScreen : UserControl
    {
        private int _rollResult1;
        private int _rollResult2;
        private string _nameOne;
        private string _nameTwo;
        private string _chosenTeam;
        public Player _player1;
        public Player _player2;

        public SetupScreen()
        {
            InitializeComponent();
            this.panelRollDice.Visible = false;
            this.panelTeamSelect.Visible = false;
            this.button1.Hide();

        }

        public void createPlayerHands()
        {
            if(_player1.Team == "Dog")
            {

                //Card Name, Health, Damage, Mana Cost
                _player1.Hand = new List<Card>
                {
                    new DogCard("Tank Dog", 10, 2, 3, Properties.Resources.TankDog),
                    new DogCard("Cheap Dog", 4, 1, 1, Properties.Resources.TankDog),
                    new DogCard("Attack Dog", 5, 7, 3, Properties.Resources.TankDog),
                    new DogCard("OP Dog", 10, 10, 10, Properties.Resources.TankDog),
                    new DogCard("Average Dog", 5, 5, 5, Properties.Resources.TankDog)
                };
                _player2.Hand = new List<Card>
                {
                    //Change to CatCard after creating that class
                    new CatCard("Tank Cat", 10, 2, 3, Properties.Resources.TankCat),
                    new CatCard("Cheap Cat", 4, 1, 1, Properties.Resources.TankCat),
                    new CatCard("Attack Cat", 5, 7, 3, Properties.Resources.TankCat),
                    new CatCard("OP Cat", 10, 2, 3, Properties.Resources.TankCat),
                    new CatCard("Average Cat", 10, 2, 3, Properties.Resources.TankCat)
                };
            } else
            {
                _player1.Hand = new List<Card>
                {
                    new DogCard("Tank Cat", 10, 2, 3, Properties.Resources.TankCat),
                    new DogCard("Cheap Cat", 4, 1, 1, Properties.Resources.TankCat),
                    new DogCard("Attack Cat", 5, 7, 3, Properties.Resources.TankCat),
                    new DogCard("OP Cat", 10, 10, 10, Properties.Resources.TankCat),
                    new DogCard("Average Cat", 5, 5, 5, Properties.Resources.TankCat)
                };
                _player2.Hand = new List<Card>
                {
                    //Change to CatCard after creating that class
                    new DogCard("Tank Dog", 10, 2, 3, Properties.Resources.TankDog),
                    new DogCard("Cheap Dog", 4, 1, 1, Properties.Resources.TankDog),
                    new DogCard("Attack Dog", 5, 7, 3, Properties.Resources.TankDog),
                    new DogCard("OP Dog", 10, 10, 10, Properties.Resources.TankDog),
                    new DogCard("Average Dog", 5, 5, 5, Properties.Resources.TankDog)
                };
            }
        }

        public void setPlayers(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }


        private void buttonConfirmNames_Click(object sender, EventArgs e)
        {
            _nameOne = nameInputLeft.Text;
            _nameTwo = nameInputRight.Text;

            labelNameLeft.Text = _nameOne;
            labelNameRight.Text = _nameTwo;

            diceRollTransition();

        }

        private void buttonDiceRollLeft_Click(object sender, EventArgs e)
        {
            Random r1 = new Random();
            _rollResult1 = r1.Next(1, 12);
            labelDiceRollOutcomeLeft.Text = _rollResult1.ToString();
            buttonDiceRollLeft.Enabled = false;
            buttonDiceRollRight.Enabled = true;

        }


        //whoever wins dice roll becomes player one
        private void buttonDiceRollRight_Click(object sender, EventArgs e)
        { 
            Random r2 = new Random();
            _rollResult2 = r2.Next(1, 12);
            labelDiceRollOutcomeRight.Text = _rollResult2.ToString();
            buttonDiceRollRight.Enabled = false;

            do
            {
                _rollResult2 = r2.Next(1, 12);
            }
            while (_rollResult2 == _rollResult1);

            labelDiceRollOutcomeRight.Text = _rollResult2.ToString();
            buttonDiceRollRight.Enabled = false;

            //if nameOne wins dice roll - set name one to p1
            if (_rollResult1 > _rollResult2)
            {
                _player1.Name = _nameOne;
                _player2.Name = _nameTwo;

            }

            //if name two wins dice roll - set name two to p1
            if (_rollResult1 < _rollResult2)
            {
                _player1.Name = _nameTwo;
                _player2.Name = _nameOne;
            }

            teamSelectTransition();
        }

        public void diceRollTransition()
        {
            this.buttonDiceRollRight.Enabled = false;
            this.panelEnterNames.Visible = false;
            this.panelRollDice.Visible = true;
            this.panelRollDice.BringToFront();
        }
        public void teamSelectTransition()
        {
            this.panelRollDice.Visible = false;
            this.panelTeamSelect.Visible = true;
            this.labelTeamSelect.Text =  $"{_player1.Name}, please choose your team!";
            this.labelTeamSelect.BringToFront();
        }

        private void buttonDogs_Click(object sender, EventArgs e)
        {
            _player1.Team = "Dog";
            _player2.Team = "Cat";
            this.buttonDogs.Hide();
            this.buttonCats.Hide();
            this.button1.Show();
        }

        private void buttonCats_Click(object sender, EventArgs e)
        {
            _player1.Team = "Cat";
            _player2.Team = "Dog";
            this.buttonDogs.Hide();
            this.buttonCats.Hide();
            this.button1.Show();
        }

        //start game button

        private void button1_Click(object sender, EventArgs e)
        {
            createPlayerHands();
            ((MainForm)FindForm()).PassPlayersToGame(_player1, _player2);
            ((MainForm)FindForm()).ShowGameScreen();

        }

    }
}
