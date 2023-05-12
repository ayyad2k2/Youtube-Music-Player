namespace CheapSpotify
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadAlbumsBtn = new Button();
            dataGridView1 = new DataGridView();
            searchButton = new Button();
            searchTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loadAlbumsBtn
            // 
            loadAlbumsBtn.BackColor = Color.Gray;
            loadAlbumsBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            loadAlbumsBtn.FlatAppearance.BorderSize = 0;
            loadAlbumsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            loadAlbumsBtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            loadAlbumsBtn.FlatStyle = FlatStyle.Flat;
            loadAlbumsBtn.ForeColor = SystemColors.ControlText;
            loadAlbumsBtn.Location = new Point(283, 436);
            loadAlbumsBtn.Name = "loadAlbumsBtn";
            loadAlbumsBtn.Size = new Size(100, 26);
            loadAlbumsBtn.TabIndex = 0;
            loadAlbumsBtn.Text = "Load Albums";
            loadAlbumsBtn.UseVisualStyleBackColor = false;
            loadAlbumsBtn.Click += loadAlbumsBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(283, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(637, 175);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Gray;
            searchButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            searchButton.FlatAppearance.MouseOverBackColor = Color.Cyan;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.ForeColor = SystemColors.ControlText;
            searchButton.Location = new Point(709, 385);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(100, 26);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(283, 385);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(407, 23);
            searchTextBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(48, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 608);
            Controls.Add(pictureBox1);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(dataGridView1);
            Controls.Add(loadAlbumsBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadAlbumsBtn;
        private DataGridView dataGridView1;
        private Button searchButton;
        private TextBox searchTextBox;
        private PictureBox pictureBox1;
    }
}