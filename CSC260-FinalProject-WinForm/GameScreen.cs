using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC260_FinalProject_WinForm
{
    public partial class GameScreen : UserControl
    {
        private Game _game;
        private CardSlot[] playerOneHandSlots = new CardSlot[5];
        private CardSlot[] playerTwoHandSlots = new CardSlot[5];
        private BoardSlot[] playerOneActiveSlots = new BoardSlot[3];
        private BoardSlot[] playerTwoActiveSlots = new BoardSlot[3];
        private Card _selectedCard;
        private CardSlot _selectedCardSlot;
        private BoardSlot _selectedAttackerSlot;
        private int _remainingTime;
        private bool _isAttackPhase = false;

        public GameScreen()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                playerOneHandSlots[i] = new CardSlot();
                playerOneHandSlots[i].CardClicked += OnCardSelected;

                playerTwoHandSlots[i] = new CardSlot();
                playerTwoHandSlots[i].CardClicked += OnCardSelected;
            }

            panelP1HandSlot1.Controls.Add(playerOneHandSlots[0]);
            panelP1HandSlot2.Controls.Add(playerOneHandSlots[1]);
            panelP1HandSlot3.Controls.Add(playerOneHandSlots[2]);
            panelP1HandSlot4.Controls.Add(playerOneHandSlots[3]);
            panelP1HandSlot5.Controls.Add(playerOneHandSlots[4]);

            panelP2HandSlot1.Controls.Add(playerTwoHandSlots[0]);
            panelP2HandSlot2.Controls.Add(playerTwoHandSlots[1]);
            panelP2HandSlot3.Controls.Add(playerTwoHandSlots[2]);
            panelP2HandSlot4.Controls.Add(playerTwoHandSlots[3]);
            panelP2HandSlot5.Controls.Add(playerTwoHandSlots[4]);

            for (int i = 0; i < 3; i++)
            {
                playerOneActiveSlots[i] = new BoardSlot();
                playerTwoActiveSlots[i] = new BoardSlot();
            }

            panelP1ActiveSlot1.Controls.Add(playerOneActiveSlots[0]);
            panelP1ActiveSlot2.Controls.Add(playerOneActiveSlots[1]);
            panelP1ActiveSlot3.Controls.Add(playerOneActiveSlots[2]);

            panelP2ActiveSlot1.Controls.Add(playerTwoActiveSlots[0]);
            panelP2ActiveSlot2.Controls.Add(playerTwoActiveSlots[1]);
            panelP2ActiveSlot3.Controls.Add(playerTwoActiveSlots[2]);

            foreach (var slot in playerOneActiveSlots)
            {
                slot.SlotClicked += OnBoardSlotClicked;
            }

            foreach (var slot in playerTwoActiveSlots)
            {
                slot.SlotClicked += OnBoardSlotClicked;
            }

            buttonP2EndTurn.Hide();
            buttonP2StartAttackPhase.Hide();
        }

        public void ResetAllAttacks()
        {
            foreach (var slot in playerOneActiveSlots)
            {
                slot.ResetAttack();
            }

            foreach (var slot in playerTwoActiveSlots)
            {
                slot.ResetAttack();
            }
        }

        public void EndGame(Player winner)
        {
            timerTurn.Stop();
            _isAttackPhase = false;

            ((MainForm)FindForm()).ShowWinnerScreen(winner);
            this.Hide();
        }

        public void CheckWinCondition()
        {
            if (_game.PlayerOne.Health <= 0)
            {
                EndGame(_game.PlayerTwo);
            }
            else if (_game.PlayerTwo.Health <= 0)
            {
                EndGame(_game.PlayerOne);
            }
        }

        public void ExitAttackPhase()
        {
            if (!_isAttackPhase) return;

            _isAttackPhase = false;

            if (_selectedAttackerSlot != null)
            {
                _selectedAttackerSlot.BackColor = Color.Transparent;
            }

            _selectedAttackerSlot = null;
        }

        public void InitiateCardCombat(BoardSlot attacker, BoardSlot defender)
        {
            attacker.Card.Health -= defender.Card.Damage;
            defender.Card.Health -= attacker.Card.Damage;

            if (attacker.Card.Health <= 0)
            {
                attacker.ClearSlot();
            }

            if (defender.Card.Health <= 0)
            {
                defender.ClearSlot();
            }

            LoadUI();
            CheckWinCondition();
        }

        public void InitiateDirectAttack()
        {
            Player player;

            if (_game.CurrentPlayer == _game.PlayerOne)
            {
                player = _game.PlayerTwo;
            }
            else
            {
                player = _game.PlayerOne;
            }

            player.Health -= _selectedAttackerSlot.Card.Damage;
            LoadUI();
            CheckWinCondition();
        }

        public void HandleAttackClick(BoardSlot slot)
        {
            bool p1Turn = (_game.CurrentPlayer == _game.PlayerOne);
            BoardSlot[] friendlySlots = p1Turn ? playerOneActiveSlots : playerTwoActiveSlots;
            BoardSlot[] enemySlots = p1Turn ? playerTwoActiveSlots : playerOneActiveSlots;

            if (!_isAttackPhase)
            {
                return;
            }

            if (_selectedAttackerSlot == null)
            {
                if (!friendlySlots.Contains(slot) || slot.IsEmpty || slot.HasAttacked)
                {
                    MessageBox.Show("Select one of your own cards.");
                    return;
                }

                _selectedAttackerSlot = slot;
                slot.BackColor = Color.Gold;
                return;
            }

            if (enemySlots.Contains(slot) && !slot.IsEmpty)
            {
                var attacker = _selectedAttackerSlot;

                InitiateCardCombat(_selectedAttackerSlot, slot);

                if (attacker != null && !attacker.IsEmpty)
                {
                    attacker.SetAttacked();
                }

                ExitAttackPhase();
                return;
            }

            if (enemySlots.Contains(slot) && slot.IsEmpty)
            {
                var attacker = _selectedAttackerSlot;

                InitiateDirectAttack();

                if (attacker != null && !attacker.IsEmpty)
                {
                    attacker.SetAttacked();
                }

                ExitAttackPhase();
                return;
            }

        }

        public void OnCardSelected(CardSlot slot)
        {
            Card card = slot.Card;

            bool p1Turn = (_game.CurrentPlayer == _game.PlayerOne);

            if (p1Turn && !_game.PlayerOne.Hand.Contains(card))
            {
                return;
            }

            if (!p1Turn && !_game.PlayerTwo.Hand.Contains(card))
            {
                return;
            }

            if (_game.CurrentPlayer.Mana < card.Mana)
            {

                return;
            }

            if (_selectedCardSlot != null)
            {
                _selectedCardSlot.ClearSelected();
            }

            _selectedCardSlot = slot;
            _selectedCardSlot.SetSelected();
            _selectedCard = card;

        }

        public void OnBoardSlotClicked(BoardSlot slot)
        {
            if (_isAttackPhase)
            {
                HandleAttackClick(slot);
                return;
            }

            if (_selectedCard == null)
            {
                return;
            }

            if (!slot.IsEmpty)
            {
                return;
            }

            bool p1Turn = (_game.CurrentPlayer == _game.PlayerOne);

            if (p1Turn && !playerOneActiveSlots.Contains(slot))
            {
                return;
            }

            if (!p1Turn && !playerTwoActiveSlots.Contains(slot))
            {
                return;
            }

            _game.CurrentPlayer.consumeMana(_selectedCard.Mana);

            slot.LoadCardInSlot(_selectedCard);

            _game.CurrentPlayer.Hand.Remove(_selectedCard);
            LoadUI();
            _selectedCardSlot.ClearSelected();
            _selectedCard = null;
            _selectedCardSlot = null;


        }

        public void LoadGame(Game game)
        {
            _game = game;
            ResetAllAttacks();
            LoadUI();
            _remainingTime = 30;
            timerTurn.Start();
            labelPlayersTurn.Text = $"{_game.PlayerOne.Name}'s Turn";
        }

        private void LoadUI()
        {
            labelP1Health.Text = _game.PlayerOne.Health.ToString();
            labelP1Mana.Text = _game.PlayerOne.Mana.ToString();
            labelPlayerOneTeam.Text = _game.PlayerOne.Team;
            labelPlayerOneName.Text = _game.PlayerOne.Name;

            labelP2Health.Text = _game.PlayerTwo.Health.ToString();
            labelP2Mana.Text = _game.PlayerTwo.Mana.ToString();
            labelPlayerTwoTeam.Text = _game.PlayerTwo.Team;
            labelPlayerTwoName.Text = _game.PlayerTwo.Name;

            for (int i = 0; i < 5; i++)
            {
                playerOneHandSlots[i].ClearSlot();
                playerTwoHandSlots[i].ClearSlot();
            }

            for (int i = 0; i < _game.PlayerOne.Hand.Count; i++)
            {
                playerOneHandSlots[i].LoadCard(_game.PlayerOne.Hand[i]);
            }

            for (int i = 0; i < _game.PlayerTwo.Hand.Count; i++)
            {
                playerTwoHandSlots[i].LoadCard(_game.PlayerTwo.Hand[i]);
            }

            for (int i = 0; i < playerOneActiveSlots.Length; i++)
            {
                if (!playerOneActiveSlots[i].IsEmpty)
                {
                    playerOneActiveSlots[i].LoadCardInSlot(playerOneActiveSlots[i].Card);
                }
            }

            for (int i = 0; i < playerTwoActiveSlots.Length; i++)
            {
                if (!playerTwoActiveSlots[i].IsEmpty)
                {
                    playerTwoActiveSlots[i].LoadCardInSlot(playerTwoActiveSlots[i].Card);
                }
            }
        }

        private void buttonP1EndTurn_Click(object sender, EventArgs e)
        {
            _game.endTurn();
            ResetAllAttacks();
            buttonP1EndTurn.Enabled = false;
            buttonP2EndTurn.Enabled = true;
            buttonP2StartAttackPhase.Enabled = true;
            buttonP1EndTurn.Hide();
            buttonP1StartAttackPhase.Hide();
            buttonP2EndTurn.Show();
            buttonP2StartAttackPhase.Show();
            LoadUI();
            labelPlayersTurn.Text = $"{_game.PlayerTwo.Name}'s Turn";
            _remainingTime = 30;
            labelTurnTimer.Text = _remainingTime.ToString();
            timerTurn.Start();
        }

        private void buttonP2EndTurn_Click(object sender, EventArgs e)
        {
            _game.endTurn();
            ResetAllAttacks();
            buttonP2EndTurn.Enabled = false;
            buttonP1EndTurn.Enabled = true;
            buttonP1StartAttackPhase.Enabled = true;
            buttonP2EndTurn.Hide();
            buttonP2StartAttackPhase.Hide();
            buttonP1EndTurn.Show();
            buttonP1StartAttackPhase.Show();
            LoadUI();
            labelPlayersTurn.Text = $"{_game.PlayerOne.Name}'s Turn";
            _remainingTime = 30;
            labelTurnTimer.Text = _remainingTime.ToString();
            timerTurn.Start();
        }

        private void buttonP1StartAttackPhase_Click(object sender, EventArgs e)
        {
            timerTurn.Stop();
            buttonP1StartAttackPhase.Enabled = false;
            _isAttackPhase = true;
            _selectedAttackerSlot = null;
            _selectedCard = null;

            if (_selectedCardSlot != null)
            {
                _selectedCardSlot.ClearSelected();
            }

            MessageBox.Show("Select one of your active cards to attack with!");
        }

        private void buttonP2StartAttackPhase_Click(object sender, EventArgs e)
        {
            if (_isAttackPhase)
            {
                return;
            }

            timerTurn.Stop();
            buttonP2StartAttackPhase.Enabled = false;
            _isAttackPhase = true;
            _selectedAttackerSlot = null;
            _selectedCard = null;

            if (_selectedCardSlot != null)
            {
                _selectedCardSlot.ClearSelected();
            }

            MessageBox.Show("Select one of your active cards to attack with!");
        }

        private void timerTurn_Tick(object sender, EventArgs e)
        {
            if (_isAttackPhase)
            {
                return;
            }

            _remainingTime--;
            labelTurnTimer.Text = _remainingTime.ToString();
            if (_remainingTime == 0)
            {
                timerTurn.Stop();
                _game.endTurn();
                ResetAllAttacks();
                _remainingTime = 30;
                labelTurnTimer.Text = _remainingTime.ToString();

                timerTurn.Start();

                if (_game.CurrentPlayer == _game.PlayerOne)
                {

                    LoadUI();
                    buttonP1EndTurn.Enabled = true;
                    buttonP2EndTurn.Enabled = false;
                    labelPlayersTurn.Text = $"{_game.PlayerOne.Name}'s Turn";
                }
                else
                {

                    LoadUI();
                    buttonP2EndTurn.Enabled = true;
                    buttonP1EndTurn.Enabled = false;
                    labelPlayersTurn.Text = $"{_game.PlayerTwo.Name}'s Turn";
                }
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void labelPlayerOneName_Click(object sender, EventArgs e)
        {

        }
    }
}
