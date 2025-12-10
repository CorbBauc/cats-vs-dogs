namespace CSC260_FinalProject_WinForm
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
            startScreenButton = new Button();
            SuspendLayout();
            // 
            // startScreenButton
            // 
            startScreenButton.Location = new Point(278, 211);
            startScreenButton.Name = "startScreenButton";
            startScreenButton.Size = new Size(353, 264);
            startScreenButton.TabIndex = 0;
            startScreenButton.Text = "StartScreen";
            startScreenButton.UseVisualStyleBackColor = true;
            startScreenButton.Click += startScreenButton_Click;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            Controls.Add(startScreenButton);
            Name = "GameScreen";
            Size = new Size(934, 637);
            ResumeLayout(false);
        }

        #endregion

        private Button startScreenButton;
    }
}
