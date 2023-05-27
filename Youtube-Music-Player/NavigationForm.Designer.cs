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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationForm));
            button1 = new Button();
            FramePanel = new Panel();
            buttonExpand = new Button();
            buttonExit = new Button();
            buttonMinimize = new Button();
            button7 = new Button();
            FramePanel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 39, 42);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(261, 140);
            button1.Name = "button1";
            button1.Size = new Size(301, 123);
            button1.TabIndex = 0;
            button1.Text = "Fake Spotify";
            button1.UseVisualStyleBackColor = false;
            // 
            // FramePanel
            // 
            FramePanel.BackColor = Color.FromArgb(35, 39, 42);
            FramePanel.Controls.Add(buttonExpand);
            FramePanel.Controls.Add(buttonExit);
            FramePanel.Controls.Add(buttonMinimize);
            FramePanel.Location = new Point(0, 0);
            FramePanel.Name = "FramePanel";
            FramePanel.Size = new Size(800, 50);
            FramePanel.TabIndex = 3;
            // 
            // buttonExpand
            // 
            buttonExpand.BackColor = Color.FromArgb(35, 39, 42);
            buttonExpand.BackgroundImage = (Image)resources.GetObject("buttonExpand.BackgroundImage");
            buttonExpand.FlatStyle = FlatStyle.Flat;
            buttonExpand.Location = new Point(691, 0);
            buttonExpand.Name = "buttonExpand";
            buttonExpand.Size = new Size(50, 49);
            buttonExpand.TabIndex = 7;
            buttonExpand.UseVisualStyleBackColor = false;
            buttonExpand.Click += buttonExpand_Click;
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
            buttonMinimize.Location = new Point(635, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(50, 49);
            buttonMinimize.TabIndex = 6;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(35, 39, 42);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.Lime;
            button7.Location = new Point(137, 282);
            button7.Name = "button7";
            button7.Size = new Size(179, 72);
            button7.TabIndex = 4;
            button7.Text = "Fake Spotify";
            button7.UseVisualStyleBackColor = false;
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
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
        private Button buttonExpand;
        private Button buttonExit;
        private Button buttonMinimize;
        private Button button7;
    }
}