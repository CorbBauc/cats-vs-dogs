namespace CatsVsDogs
{
    partial class GameScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            labelPlayerOneName = new Label();
            labelPlayerOneTeam = new Label();
            labelPlayerTwoName = new Label();
            labelPlayerTwoTeam = new Label();
            labelP1Health = new Label();
            panelP1Health = new Panel();
            panelP1Mana = new Panel();
            labelP1Mana = new Label();
            gameBoardPanel = new Panel();
            labelPlayersTurn = new Label();
            labelTurnTimer = new Label();
            panel2 = new Panel();
            panelP2ActiveSlot1 = new Panel();
            panelP2ActiveSlot2 = new Panel();
            panelP2ActiveSlot3 = new Panel();
            panel1 = new Panel();
            panelP1ActiveSlot2 = new Panel();
            panelP1ActiveSlot3 = new Panel();
            panelP1ActiveSlot1 = new Panel();
            labelP2Mana = new Label();
            panelP2Mana = new Panel();
            labelP2Health = new Label();
            panelP2Health = new Panel();
            panelP1Hand = new Panel();
            panelP1HandSlot5 = new Panel();
            panelP1HandSlot4 = new Panel();
            panelP1HandSlot3 = new Panel();
            panelP1HandSlot2 = new Panel();
            panelP1HandSlot1 = new Panel();
            panelP2Hand = new Panel();
            panelP2HandSlot5 = new Panel();
            panelP2HandSlot4 = new Panel();
            panelP2HandSlot3 = new Panel();
            panelP2HandSlot2 = new Panel();
            panelP2HandSlot1 = new Panel();
            buttonP1EndTurn = new Button();
            timerTurn = new System.Windows.Forms.Timer(components);
            buttonP2EndTurn = new Button();
            buttonP1StartAttackPhase = new Button();
            buttonP2StartAttackPhase = new Button();
            panelP1Health.SuspendLayout();
            panelP1Mana.SuspendLayout();
            gameBoardPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelP2Mana.SuspendLayout();
            panelP2Health.SuspendLayout();
            panelP1Hand.SuspendLayout();
            panelP2Hand.SuspendLayout();
            SuspendLayout();
            // 
            // labelPlayerOneName
            // 
            labelPlayerOneName.BackColor = SystemColors.HighlightText;
            labelPlayerOneName.Font = new Font("Showcard Gothic", 15.75F);
            labelPlayerOneName.Location = new Point(289, 354);
            labelPlayerOneName.Name = "labelPlayerOneName";
            labelPlayerOneName.Size = new Size(127, 31);
            labelPlayerOneName.TabIndex = 2;
            labelPlayerOneName.TextAlign = ContentAlignment.MiddleCenter;
            labelPlayerOneName.Click += labelPlayerOneName_Click;
            // 
            // labelPlayerOneTeam
            // 
            labelPlayerOneTeam.BackColor = SystemColors.HighlightText;
            labelPlayerOneTeam.Font = new Font("Showcard Gothic", 15.75F);
            labelPlayerOneTeam.Location = new Point(289, 274);
            labelPlayerOneTeam.Name = "labelPlayerOneTeam";
            labelPlayerOneTeam.Size = new Size(127, 29);
            labelPlayerOneTeam.TabIndex = 3;
            labelPlayerOneTeam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPlayerTwoName
            // 
            labelPlayerTwoName.BackColor = SystemColors.HighlightText;
            labelPlayerTwoName.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            labelPlayerTwoName.Location = new Point(1535, 354);
            labelPlayerTwoName.Name = "labelPlayerTwoName";
            labelPlayerTwoName.Size = new Size(127, 31);
            labelPlayerTwoName.TabIndex = 4;
            labelPlayerTwoName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPlayerTwoTeam
            // 
            labelPlayerTwoTeam.BackColor = SystemColors.HighlightText;
            labelPlayerTwoTeam.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            labelPlayerTwoTeam.Location = new Point(1535, 274);
            labelPlayerTwoTeam.Name = "labelPlayerTwoTeam";
            labelPlayerTwoTeam.Size = new Size(127, 29);
            labelPlayerTwoTeam.TabIndex = 5;
            labelPlayerTwoTeam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelP1Health
            // 
            labelP1Health.BackColor = Color.FromArgb(210, 40, 40);
            labelP1Health.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelP1Health.Location = new Point(26, 33);
            labelP1Health.Name = "labelP1Health";
            labelP1Health.Size = new Size(49, 31);
            labelP1Health.TabIndex = 7;
            labelP1Health.Text = "10";
            labelP1Health.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelP1Health
            // 
            panelP1Health.BackgroundImage = (Image)resources.GetObject("panelP1Health.BackgroundImage");
            panelP1Health.Controls.Add(labelP1Health);
            panelP1Health.Location = new Point(372, 817);
            panelP1Health.Name = "panelP1Health";
            panelP1Health.Size = new Size(100, 100);
            panelP1Health.TabIndex = 11;
            // 
            // panelP1Mana
            // 
            panelP1Mana.BackgroundImage = (Image)resources.GetObject("panelP1Mana.BackgroundImage");
            panelP1Mana.Controls.Add(labelP1Mana);
            panelP1Mana.Location = new Point(1484, 817);
            panelP1Mana.Name = "panelP1Mana";
            panelP1Mana.Size = new Size(100, 100);
            panelP1Mana.TabIndex = 12;
            // 
            // labelP1Mana
            // 
            labelP1Mana.BackColor = Color.FromArgb(115, 223, 244);
            labelP1Mana.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelP1Mana.Location = new Point(39, 33);
            labelP1Mana.Name = "labelP1Mana";
            labelP1Mana.Size = new Size(27, 33);
            labelP1Mana.TabIndex = 0;
            labelP1Mana.Text = "5";
            // 
            // gameBoardPanel
            // 
            gameBoardPanel.Anchor = AnchorStyles.None;
            gameBoardPanel.BackColor = Color.FromArgb(255, 224, 192);
            gameBoardPanel.Controls.Add(labelPlayersTurn);
            gameBoardPanel.Controls.Add(labelTurnTimer);
            gameBoardPanel.Controls.Add(panel2);
            gameBoardPanel.Controls.Add(panel1);
            gameBoardPanel.Location = new Point(478, 212);
            gameBoardPanel.Name = "gameBoardPanel";
            gameBoardPanel.Size = new Size(1000, 549);
            gameBoardPanel.TabIndex = 1;
            // 
            // labelPlayersTurn
            // 
            labelPlayersTurn.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayersTurn.Location = new Point(243, 243);
            labelPlayersTurn.Name = "labelPlayersTurn";
            labelPlayersTurn.Size = new Size(166, 48);
            labelPlayersTurn.TabIndex = 3;
            labelPlayersTurn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTurnTimer
            // 
            labelTurnTimer.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTurnTimer.Location = new Point(452, 252);
            labelTurnTimer.Name = "labelTurnTimer";
            labelTurnTimer.Size = new Size(115, 32);
            labelTurnTimer.TabIndex = 2;
            labelTurnTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(panelP2ActiveSlot1);
            panel2.Controls.Add(panelP2ActiveSlot2);
            panel2.Controls.Add(panelP2ActiveSlot3);
            panel2.Location = new Point(18, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(964, 182);
            panel2.TabIndex = 1;
            // 
            // panelP2ActiveSlot1
            // 
            panelP2ActiveSlot1.BackColor = Color.FromArgb(224, 224, 224);
            panelP2ActiveSlot1.Location = new Point(276, 12);
            panelP2ActiveSlot1.Name = "panelP2ActiveSlot1";
            panelP2ActiveSlot1.Size = new Size(115, 150);
            panelP2ActiveSlot1.TabIndex = 4;
            // 
            // panelP2ActiveSlot2
            // 
            panelP2ActiveSlot2.BackColor = Color.FromArgb(224, 224, 224);
            panelP2ActiveSlot2.Location = new Point(434, 12);
            panelP2ActiveSlot2.Name = "panelP2ActiveSlot2";
            panelP2ActiveSlot2.Size = new Size(115, 150);
            panelP2ActiveSlot2.TabIndex = 4;
            // 
            // panelP2ActiveSlot3
            // 
            panelP2ActiveSlot3.BackColor = Color.FromArgb(224, 224, 224);
            panelP2ActiveSlot3.Location = new Point(588, 11);
            panelP2ActiveSlot3.Name = "panelP2ActiveSlot3";
            panelP2ActiveSlot3.Size = new Size(115, 150);
            panelP2ActiveSlot3.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(panelP1ActiveSlot2);
            panel1.Controls.Add(panelP1ActiveSlot3);
            panel1.Controls.Add(panelP1ActiveSlot1);
            panel1.Location = new Point(18, 341);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 187);
            panel1.TabIndex = 0;
            // 
            // panelP1ActiveSlot2
            // 
            panelP1ActiveSlot2.BackColor = Color.FromArgb(224, 224, 224);
            panelP1ActiveSlot2.Location = new Point(431, 16);
            panelP1ActiveSlot2.Name = "panelP1ActiveSlot2";
            panelP1ActiveSlot2.Size = new Size(115, 150);
            panelP1ActiveSlot2.TabIndex = 3;
            // 
            // panelP1ActiveSlot3
            // 
            panelP1ActiveSlot3.BackColor = Color.FromArgb(224, 224, 224);
            panelP1ActiveSlot3.Location = new Point(585, 16);
            panelP1ActiveSlot3.Name = "panelP1ActiveSlot3";
            panelP1ActiveSlot3.Size = new Size(115, 150);
            panelP1ActiveSlot3.TabIndex = 3;
            // 
            // panelP1ActiveSlot1
            // 
            panelP1ActiveSlot1.BackColor = Color.FromArgb(224, 224, 224);
            panelP1ActiveSlot1.Location = new Point(276, 16);
            panelP1ActiveSlot1.Name = "panelP1ActiveSlot1";
            panelP1ActiveSlot1.Size = new Size(115, 150);
            panelP1ActiveSlot1.TabIndex = 2;
            // 
            // labelP2Mana
            // 
            labelP2Mana.BackColor = Color.FromArgb(115, 223, 244);
            labelP2Mana.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelP2Mana.Location = new Point(39, 33);
            labelP2Mana.Name = "labelP2Mana";
            labelP2Mana.Size = new Size(27, 33);
            labelP2Mana.TabIndex = 0;
            labelP2Mana.Text = "5";
            // 
            // panelP2Mana
            // 
            panelP2Mana.BackgroundImage = (Image)resources.GetObject("panelP2Mana.BackgroundImage");
            panelP2Mana.Controls.Add(labelP2Mana);
            panelP2Mana.Location = new Point(1484, 53);
            panelP2Mana.Name = "panelP2Mana";
            panelP2Mana.Size = new Size(100, 100);
            panelP2Mana.TabIndex = 14;
            // 
            // labelP2Health
            // 
            labelP2Health.BackColor = Color.FromArgb(210, 40, 40);
            labelP2Health.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelP2Health.Location = new Point(26, 33);
            labelP2Health.Name = "labelP2Health";
            labelP2Health.Size = new Size(49, 31);
            labelP2Health.TabIndex = 7;
            labelP2Health.Text = "10";
            labelP2Health.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelP2Health
            // 
            panelP2Health.BackgroundImage = (Image)resources.GetObject("panelP2Health.BackgroundImage");
            panelP2Health.Controls.Add(labelP2Health);
            panelP2Health.Location = new Point(372, 53);
            panelP2Health.Name = "panelP2Health";
            panelP2Health.Size = new Size(100, 100);
            panelP2Health.TabIndex = 13;
            // 
            // panelP1Hand
            // 
            panelP1Hand.Controls.Add(panelP1HandSlot5);
            panelP1Hand.Controls.Add(panelP1HandSlot4);
            panelP1Hand.Controls.Add(panelP1HandSlot3);
            panelP1Hand.Controls.Add(panelP1HandSlot2);
            panelP1Hand.Controls.Add(panelP1HandSlot1);
            panelP1Hand.Location = new Point(478, 780);
            panelP1Hand.Name = "panelP1Hand";
            panelP1Hand.Size = new Size(1000, 177);
            panelP1Hand.TabIndex = 15;
            // 
            // panelP1HandSlot5
            // 
            panelP1HandSlot5.BackColor = Color.White;
            panelP1HandSlot5.Location = new Point(740, 13);
            panelP1HandSlot5.Name = "panelP1HandSlot5";
            panelP1HandSlot5.Size = new Size(115, 150);
            panelP1HandSlot5.TabIndex = 1;
            // 
            // panelP1HandSlot4
            // 
            panelP1HandSlot4.BackColor = Color.White;
            panelP1HandSlot4.Location = new Point(593, 13);
            panelP1HandSlot4.Name = "panelP1HandSlot4";
            panelP1HandSlot4.Size = new Size(115, 150);
            panelP1HandSlot4.TabIndex = 1;
            // 
            // panelP1HandSlot3
            // 
            panelP1HandSlot3.BackColor = Color.White;
            panelP1HandSlot3.Location = new Point(449, 13);
            panelP1HandSlot3.Name = "panelP1HandSlot3";
            panelP1HandSlot3.Size = new Size(115, 150);
            panelP1HandSlot3.TabIndex = 1;
            // 
            // panelP1HandSlot2
            // 
            panelP1HandSlot2.BackColor = Color.White;
            panelP1HandSlot2.Location = new Point(306, 13);
            panelP1HandSlot2.Name = "panelP1HandSlot2";
            panelP1HandSlot2.Size = new Size(115, 150);
            panelP1HandSlot2.TabIndex = 1;
            // 
            // panelP1HandSlot1
            // 
            panelP1HandSlot1.BackColor = Color.White;
            panelP1HandSlot1.Location = new Point(163, 13);
            panelP1HandSlot1.Name = "panelP1HandSlot1";
            panelP1HandSlot1.Size = new Size(115, 150);
            panelP1HandSlot1.TabIndex = 0;
            // 
            // panelP2Hand
            // 
            panelP2Hand.Controls.Add(panelP2HandSlot5);
            panelP2Hand.Controls.Add(panelP2HandSlot4);
            panelP2Hand.Controls.Add(panelP2HandSlot3);
            panelP2Hand.Controls.Add(panelP2HandSlot2);
            panelP2Hand.Controls.Add(panelP2HandSlot1);
            panelP2Hand.Location = new Point(478, 17);
            panelP2Hand.Name = "panelP2Hand";
            panelP2Hand.Size = new Size(1000, 177);
            panelP2Hand.TabIndex = 16;
            // 
            // panelP2HandSlot5
            // 
            panelP2HandSlot5.BackColor = Color.White;
            panelP2HandSlot5.Location = new Point(740, 13);
            panelP2HandSlot5.Name = "panelP2HandSlot5";
            panelP2HandSlot5.Size = new Size(115, 150);
            panelP2HandSlot5.TabIndex = 1;
            // 
            // panelP2HandSlot4
            // 
            panelP2HandSlot4.BackColor = Color.White;
            panelP2HandSlot4.Location = new Point(593, 13);
            panelP2HandSlot4.Name = "panelP2HandSlot4";
            panelP2HandSlot4.Size = new Size(115, 150);
            panelP2HandSlot4.TabIndex = 1;
            // 
            // panelP2HandSlot3
            // 
            panelP2HandSlot3.BackColor = Color.White;
            panelP2HandSlot3.Location = new Point(449, 13);
            panelP2HandSlot3.Name = "panelP2HandSlot3";
            panelP2HandSlot3.Size = new Size(115, 150);
            panelP2HandSlot3.TabIndex = 1;
            // 
            // panelP2HandSlot2
            // 
            panelP2HandSlot2.BackColor = Color.White;
            panelP2HandSlot2.Location = new Point(306, 13);
            panelP2HandSlot2.Name = "panelP2HandSlot2";
            panelP2HandSlot2.Size = new Size(115, 150);
            panelP2HandSlot2.TabIndex = 1;
            // 
            // panelP2HandSlot1
            // 
            panelP2HandSlot1.BackColor = Color.White;
            panelP2HandSlot1.Location = new Point(163, 13);
            panelP2HandSlot1.Name = "panelP2HandSlot1";
            panelP2HandSlot1.Size = new Size(115, 150);
            panelP2HandSlot1.TabIndex = 0;
            // 
            // buttonP1EndTurn
            // 
            buttonP1EndTurn.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonP1EndTurn.Location = new Point(287, 513);
            buttonP1EndTurn.Name = "buttonP1EndTurn";
            buttonP1EndTurn.Size = new Size(127, 68);
            buttonP1EndTurn.TabIndex = 17;
            buttonP1EndTurn.Text = "End Turn";
            buttonP1EndTurn.UseVisualStyleBackColor = true;
            buttonP1EndTurn.Click += buttonP1EndTurn_Click;
            // 
            // timerTurn
            // 
            timerTurn.Interval = 1000;
            timerTurn.Tick += timerTurn_Tick;
            // 
            // buttonP2EndTurn
            // 
            buttonP2EndTurn.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonP2EndTurn.Location = new Point(1535, 513);
            buttonP2EndTurn.Name = "buttonP2EndTurn";
            buttonP2EndTurn.Size = new Size(129, 68);
            buttonP2EndTurn.TabIndex = 18;
            buttonP2EndTurn.Text = "End Turn";
            buttonP2EndTurn.UseVisualStyleBackColor = true;
            buttonP2EndTurn.Click += buttonP2EndTurn_Click;
            // 
            // buttonP1StartAttackPhase
            // 
            buttonP1StartAttackPhase.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonP1StartAttackPhase.Location = new Point(287, 427);
            buttonP1StartAttackPhase.Name = "buttonP1StartAttackPhase";
            buttonP1StartAttackPhase.Size = new Size(129, 68);
            buttonP1StartAttackPhase.TabIndex = 19;
            buttonP1StartAttackPhase.Text = "START ATTACK PHASE";
            buttonP1StartAttackPhase.UseVisualStyleBackColor = true;
            buttonP1StartAttackPhase.Click += buttonP1StartAttackPhase_Click;
            // 
            // buttonP2StartAttackPhase
            // 
            buttonP2StartAttackPhase.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonP2StartAttackPhase.Location = new Point(1535, 427);
            buttonP2StartAttackPhase.Name = "buttonP2StartAttackPhase";
            buttonP2StartAttackPhase.Size = new Size(129, 68);
            buttonP2StartAttackPhase.TabIndex = 20;
            buttonP2StartAttackPhase.Text = "Start Attack Phase";
            buttonP2StartAttackPhase.UseVisualStyleBackColor = true;
            buttonP2StartAttackPhase.Click += buttonP2StartAttackPhase_Click;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            Controls.Add(buttonP2StartAttackPhase);
            Controls.Add(buttonP1StartAttackPhase);
            Controls.Add(buttonP2EndTurn);
            Controls.Add(panelP1Mana);
            Controls.Add(panelP1Health);
            Controls.Add(buttonP1EndTurn);
            Controls.Add(panelP2Hand);
            Controls.Add(panelP1Hand);
            Controls.Add(panelP2Mana);
            Controls.Add(panelP2Health);
            Controls.Add(labelPlayerTwoTeam);
            Controls.Add(labelPlayerTwoName);
            Controls.Add(labelPlayerOneTeam);
            Controls.Add(labelPlayerOneName);
            Controls.Add(gameBoardPanel);
            Name = "GameScreen";
            Size = new Size(1920, 1080);
            panelP1Health.ResumeLayout(false);
            panelP1Mana.ResumeLayout(false);
            gameBoardPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelP2Mana.ResumeLayout(false);
            panelP2Health.ResumeLayout(false);
            panelP1Hand.ResumeLayout(false);
            panelP2Hand.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label labelPlayerOneName;
        private Label labelPlayerOneTeam;
        private Label labelPlayerTwoName;
        private Label labelPlayerTwoTeam;
        private Label labelP1Health;
        private Panel panelP1Health;
        private Panel panelP1Mana;
        private Label labelP1Mana;
        private Panel gameBoardPanel;
        private Label labelP2Mana;
        private Panel panelP2Mana;
        private Label labelP2Health;
        private Panel panelP2Health;
        private Panel panel2;
        private Panel panel1;
        private Panel panelP2ActiveSlot1;
        private Panel panelP2ActiveSlot2;
        private Panel panelP2ActiveSlot3;
        private Panel panelP1ActiveSlot2;
        private Panel panelP1ActiveSlot3;
        private Panel panelP1ActiveSlot1;
        private Panel panelP1Hand;
        private Panel panelP1HandSlot5;
        private Panel panelP1HandSlot4;
        private Panel panelP1HandSlot3;
        private Panel panelP1HandSlot2;
        private Panel panelP1HandSlot1;
        private Panel panelP2Hand;
        private Panel panelP2HandSlot5;
        private Panel panelP2HandSlot4;
        private Panel panelP2HandSlot3;
        private Panel panelP2HandSlot2;
        private Panel panelP2HandSlot1;
        private Button buttonP1EndTurn;
        private System.Windows.Forms.Timer timerTurn;
        private Button buttonP2EndTurn;
        private Label labelTurnTimer;
        private Label labelPlayersTurn;
        private Button buttonP1StartAttackPhase;
        private Button buttonP2StartAttackPhase;
    }
}
