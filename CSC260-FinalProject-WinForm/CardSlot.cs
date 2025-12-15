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
    public partial class CardSlot : UserControl
    {
        private Card _card;
        private bool _isSelected = false;
        public event Action<CardSlot> CardClicked;

        public CardSlot()
        {
            InitializeComponent();

            this.Click += CardSlot_Click;
            pictureBoxCardArt.Click += CardSlot_Click;
            labelHealth.Click += CardSlot_Click;
            labelMana.Click += CardSlot_Click;
            labelDamage.Click += CardSlot_Click;

        }

        public Card Card
        {
            get {  return _card; }
        }

        private void CardSlot_Click(object? sender, EventArgs e)
        {
            if (_card != null)
            {
                CardClicked?.Invoke(this);
            }
        }

        public void LoadCard(Card card)
        {
            _card = card;

            if (card == null)
            {
                ClearSlot();
                return;
            }

            pictureBoxCardArt.Image = card.Art;
            labelHealth.Text = card.Health.ToString();
            labelMana.Text = card.Mana.ToString();
            labelDamage.Text = card.Damage.ToString();

        }

        public void ClearSlot()
        {
            _card = null;

            pictureBoxCardArt.Image = null;
            labelHealth.Text = "";
            labelMana.Text = "";
            labelDamage.Text = "";
        }

        public void SetSelected()
        {
            _isSelected = true;
            this.BackColor = Color.Gold;
        }

        public void ClearSelected()
        {
            _isSelected = false;    
            this.BackColor = Color.Transparent;

        }
    }
}
