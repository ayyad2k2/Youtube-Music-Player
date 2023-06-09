namespace CheapSpotify
{
    partial class NavigationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            FramePanel = new Panel();
            buttonExit = new Button();
            buttonMinimize = new Button();
            FramePanel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 39, 42);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(232, 160);
            button1.Name = "button1";
            button1.Size = new Size(304, 120);
            button1.TabIndex = 0;
            button1.Text = "Fake Spotify";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FramePanel
            // 
            FramePanel.BackColor = Color.FromArgb(35, 39, 42);
            FramePanel.Controls.Add(buttonExit);
            FramePanel.Controls.Add(buttonMinimize);
            FramePanel.Location = new Point(0, 0);
            FramePanel.Name = "FramePanel";
            FramePanel.Size = new Size(800, 50);
            FramePanel.TabIndex = 3;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(35, 39, 42);
            buttonExit.BackgroundImage = Properties.Resources.close;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Location = new Point(747, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(50, 49);
            buttonExit.TabIndex = 5;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click_1;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.FromArgb(35, 39, 42);
            buttonMinimize.BackgroundImage = Properties.Resources.minimize;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Location = new Point(700, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(50, 49);
            buttonMinimize.TabIndex = 6;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(800, 450);
            Controls.Add(FramePanel);
            Controls.Add(button1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "NavigationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NavigationForm";
            FramePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel FramePanel;
        private Button buttonExit;
        private Button buttonMinimize;
    }
}