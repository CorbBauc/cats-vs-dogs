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
    public partial class BoardSlot : UserControl
    {
        private Card _card;
        private bool _isEmpty = true;
        public event Action<BoardSlot> SlotClicked;
        public BoardSlot()
        {
            InitializeComponent();
            this.Click += BoardSlot_Click;
            pictureBoxCardArt.Click += BoardSlot_Click;
            labelHealth.Click += BoardSlot_Click;
            labelMana.Click += BoardSlot_Click;
            labelDamage.Click += BoardSlot_Click;

        }

        public bool IsEmpty
        {
            get { return _isEmpty; }
        }

        public void LoadCardInSlot(Card card)
        {
            _card = card;

            if(card == null)
            {
                ClearSlot();
                return;
            }

            _isEmpty = false;
            pictureBoxCardArt.Image = card.Art;
            labelHealth.Text = card.Health.ToString();
            labelMana.Text = card.Mana.ToString();
            labelDamage.Text = card.Damage.ToString();
        }

        public void ClearSlot()
        {
            _card = null;
            _isEmpty = true;

            pictureBoxCardArt.Image = null;
            labelHealth.Text = "";
            labelMana.Text = "";
            labelDamage.Text = "";
        }

        public void BoardSlot_Click(object sender, EventArgs e)
        {
            SlotClicked?.Invoke(this);
        }
    }
}
