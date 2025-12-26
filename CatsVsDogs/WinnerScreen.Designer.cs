namespace CatsVsDogs
{
    partial class WinnerScreen
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
            labelWinnerMessage = new Label();
            buttonQuitGame = new Button();
            SuspendLayout();
            // 
            // labelWinnerMessage
            // 
            labelWinnerMessage.Location = new Point(628, 229);
            labelWinnerMessage.Name = "labelWinnerMessage";
            labelWinnerMessage.Size = new Size(613, 103);
            labelWinnerMessage.TabIndex = 0;
            labelWinnerMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonQuitGame
            // 
            buttonQuitGame.Location = new Point(828, 477);
            buttonQuitGame.Name = "buttonQuitGame";
            buttonQuitGame.Size = new Size(180, 88);
            buttonQuitGame.TabIndex = 1;
            buttonQuitGame.Text = "QUIT";
            buttonQuitGame.UseVisualStyleBackColor = true;
            buttonQuitGame.Click += buttonQuitGame_Click;
            // 
            // WinnerScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(buttonQuitGame);
            Controls.Add(labelWinnerMessage);
            Name = "WinnerScreen";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
        }

        #endregion

        private Label labelWinnerMessage;
        private Button buttonQuitGame;
    }
}
