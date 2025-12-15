namespace CSC260_FinalProject_WinForm
{
    partial class SetupScreen
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
            button1 = new Button();
            buttonDiceRollLeft = new Button();
            labelDiceRollOutcomeLeft = new Label();
            nameInputLeft = new TextBox();
            nameInputRight = new TextBox();
            labelEnterNameLeft = new Label();
            labelEnterNameRight = new Label();
            buttonConfirmNames = new Button();
            buttonDiceRollRight = new Button();
            labelDiceRollOutcomeRight = new Label();
            labelNameLeft = new Label();
            labelNameRight = new Label();
            panelEnterNames = new Panel();
            panelTeamSelect = new Panel();
            buttonCats = new Button();
            buttonDogs = new Button();
            labelTeamSelect = new Label();
            panelRollDice = new Panel();
            panelEnterNames.SuspendLayout();
            panelTeamSelect.SuspendLayout();
            panelRollDice.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(304, 357);
            button1.Name = "button1";
            button1.Size = new Size(202, 126);
            button1.TabIndex = 0;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonDiceRollLeft
            // 
            buttonDiceRollLeft.Location = new Point(74, 274);
            buttonDiceRollLeft.Name = "buttonDiceRollLeft";
            buttonDiceRollLeft.Size = new Size(329, 153);
            buttonDiceRollLeft.TabIndex = 1;
            buttonDiceRollLeft.Text = "Roll Die";
            buttonDiceRollLeft.UseVisualStyleBackColor = true;
            buttonDiceRollLeft.Click += buttonDiceRollLeft_Click;
            // 
            // labelDiceRollOutcomeLeft
            // 
            labelDiceRollOutcomeLeft.BorderStyle = BorderStyle.FixedSingle;
            labelDiceRollOutcomeLeft.Font = new Font("Segoe UI", 16F);
            labelDiceRollOutcomeLeft.Location = new Point(206, 159);
            labelDiceRollOutcomeLeft.Name = "labelDiceRollOutcomeLeft";
            labelDiceRollOutcomeLeft.Size = new Size(65, 65);
            labelDiceRollOutcomeLeft.TabIndex = 2;
            labelDiceRollOutcomeLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameInputLeft
            // 
            nameInputLeft.Location = new Point(162, 119);
            nameInputLeft.Name = "nameInputLeft";
            nameInputLeft.Size = new Size(160, 23);
            nameInputLeft.TabIndex = 3;
            // 
            // nameInputRight
            // 
            nameInputRight.Location = new Point(607, 119);
            nameInputRight.Name = "nameInputRight";
            nameInputRight.Size = new Size(160, 23);
            nameInputRight.TabIndex = 4;
            // 
            // labelEnterNameLeft
            // 
            labelEnterNameLeft.Font = new Font("Segoe UI", 16F);
            labelEnterNameLeft.Location = new Point(162, 72);
            labelEnterNameLeft.Name = "labelEnterNameLeft";
            labelEnterNameLeft.Size = new Size(160, 34);
            labelEnterNameLeft.TabIndex = 5;
            labelEnterNameLeft.Text = "Enter Name";
            labelEnterNameLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEnterNameRight
            // 
            labelEnterNameRight.AutoSize = true;
            labelEnterNameRight.Font = new Font("Segoe UI", 16F);
            labelEnterNameRight.Location = new Point(626, 72);
            labelEnterNameRight.Name = "labelEnterNameRight";
            labelEnterNameRight.Size = new Size(127, 30);
            labelEnterNameRight.TabIndex = 6;
            labelEnterNameRight.Text = "Enter Name";
            labelEnterNameRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonConfirmNames
            // 
            buttonConfirmNames.Location = new Point(340, 216);
            buttonConfirmNames.Name = "buttonConfirmNames";
            buttonConfirmNames.Size = new Size(236, 77);
            buttonConfirmNames.TabIndex = 7;
            buttonConfirmNames.Text = "Confirm Names";
            buttonConfirmNames.UseVisualStyleBackColor = true;
            buttonConfirmNames.Click += buttonConfirmNames_Click;
            // 
            // buttonDiceRollRight
            // 
            buttonDiceRollRight.Location = new Point(543, 274);
            buttonDiceRollRight.Name = "buttonDiceRollRight";
            buttonDiceRollRight.Size = new Size(329, 153);
            buttonDiceRollRight.TabIndex = 8;
            buttonDiceRollRight.Text = "button2";
            buttonDiceRollRight.UseVisualStyleBackColor = true;
            buttonDiceRollRight.Click += buttonDiceRollRight_Click;
            // 
            // labelDiceRollOutcomeRight
            // 
            labelDiceRollOutcomeRight.BorderStyle = BorderStyle.FixedSingle;
            labelDiceRollOutcomeRight.Font = new Font("Segoe UI", 16F);
            labelDiceRollOutcomeRight.Location = new Point(673, 159);
            labelDiceRollOutcomeRight.Name = "labelDiceRollOutcomeRight";
            labelDiceRollOutcomeRight.Size = new Size(65, 65);
            labelDiceRollOutcomeRight.TabIndex = 9;
            labelDiceRollOutcomeRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNameLeft
            // 
            labelNameLeft.Font = new Font("Segoe UI", 16F);
            labelNameLeft.Location = new Point(193, 77);
            labelNameLeft.Name = "labelNameLeft";
            labelNameLeft.Size = new Size(100, 38);
            labelNameLeft.TabIndex = 10;
            labelNameLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNameRight
            // 
            labelNameRight.Font = new Font("Segoe UI", 16F);
            labelNameRight.Location = new Point(651, 77);
            labelNameRight.Name = "labelNameRight";
            labelNameRight.Size = new Size(100, 38);
            labelNameRight.TabIndex = 11;
            labelNameRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelEnterNames
            // 
            panelEnterNames.Controls.Add(buttonConfirmNames);
            panelEnterNames.Controls.Add(nameInputLeft);
            panelEnterNames.Controls.Add(nameInputRight);
            panelEnterNames.Controls.Add(labelEnterNameLeft);
            panelEnterNames.Controls.Add(labelEnterNameRight);
            panelEnterNames.Location = new Point(24, 9);
            panelEnterNames.Name = "panelEnterNames";
            panelEnterNames.Size = new Size(965, 631);
            panelEnterNames.TabIndex = 12;
            // 
            // panelTeamSelect
            // 
            panelTeamSelect.Controls.Add(buttonCats);
            panelTeamSelect.Controls.Add(buttonDogs);
            panelTeamSelect.Controls.Add(button1);
            panelTeamSelect.Controls.Add(labelTeamSelect);
            panelTeamSelect.Location = new Point(1020, 134);
            panelTeamSelect.Name = "panelTeamSelect";
            panelTeamSelect.Size = new Size(785, 506);
            panelTeamSelect.TabIndex = 14;
            // 
            // buttonCats
            // 
            buttonCats.Font = new Font("Segoe UI", 16F);
            buttonCats.Location = new Point(445, 252);
            buttonCats.Name = "buttonCats";
            buttonCats.Size = new Size(176, 82);
            buttonCats.TabIndex = 2;
            buttonCats.Text = "CATS";
            buttonCats.UseVisualStyleBackColor = true;
            buttonCats.Click += buttonCats_Click;
            // 
            // buttonDogs
            // 
            buttonDogs.Font = new Font("Segoe UI", 16F);
            buttonDogs.Location = new Point(187, 252);
            buttonDogs.Name = "buttonDogs";
            buttonDogs.Size = new Size(176, 82);
            buttonDogs.TabIndex = 1;
            buttonDogs.Text = "DOGS";
            buttonDogs.UseVisualStyleBackColor = true;
            buttonDogs.Click += buttonDogs_Click;
            // 
            // labelTeamSelect
            // 
            labelTeamSelect.BorderStyle = BorderStyle.FixedSingle;
            labelTeamSelect.Font = new Font("Segoe UI", 16F);
            labelTeamSelect.Location = new Point(187, 127);
            labelTeamSelect.Name = "labelTeamSelect";
            labelTeamSelect.Size = new Size(434, 37);
            labelTeamSelect.TabIndex = 0;
            // 
            // panelRollDice
            // 
            panelRollDice.Controls.Add(buttonDiceRollLeft);
            panelRollDice.Controls.Add(labelDiceRollOutcomeLeft);
            panelRollDice.Controls.Add(labelNameRight);
            panelRollDice.Controls.Add(buttonDiceRollRight);
            panelRollDice.Controls.Add(labelDiceRollOutcomeRight);
            panelRollDice.Controls.Add(labelNameLeft);
            panelRollDice.Location = new Point(30, 309);
            panelRollDice.Name = "panelRollDice";
            panelRollDice.Size = new Size(959, 496);
            panelRollDice.TabIndex = 13;
            // 
            // SetupScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTeamSelect);
            Controls.Add(panelRollDice);
            Controls.Add(panelEnterNames);
            Name = "SetupScreen";
            Size = new Size(1920, 1080);
            panelEnterNames.ResumeLayout(false);
            panelEnterNames.PerformLayout();
            panelTeamSelect.ResumeLayout(false);
            panelRollDice.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button buttonDiceRollLeft;
        private Label labelDiceRollOutcomeLeft;
        private TextBox nameInputLeft;
        private TextBox nameInputRight;
        private Label labelEnterNameLeft;
        private Label labelEnterNameRight;
        private Button buttonConfirmNames;
        private Button buttonDiceRollRight;
        private Label labelDiceRollOutcomeRight;
        private Label labelNameLeft;
        private Label labelNameRight;
        private Panel panelEnterNames;
        private Panel panelRollDice;
        private Panel panelTeamSelect;
        private Label labelTeamSelect;
        private Button buttonCats;
        private Button buttonDogs;
    }
}
