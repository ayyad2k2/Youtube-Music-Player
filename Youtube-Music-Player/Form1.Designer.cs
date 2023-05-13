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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loadAlbumsBtn = new Button();
            albumDataGridView = new DataGridView();
            searchButton = new Button();
            searchTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            addAlbumGroupBox1 = new GroupBox();
            descriptionTextBox = new TextBox();
            imageURLTextBox = new TextBox();
            yearTextBox = new TextBox();
            artistTextBox = new TextBox();
            albumNameTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            addButton = new Button();
            songsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)albumDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            addAlbumGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)songsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // loadAlbumsBtn
            // 
            loadAlbumsBtn.BackColor = Color.LightGray;
            loadAlbumsBtn.BackgroundImage = (Image)resources.GetObject("loadAlbumsBtn.BackgroundImage");
            loadAlbumsBtn.BackgroundImageLayout = ImageLayout.Zoom;
            loadAlbumsBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            loadAlbumsBtn.FlatAppearance.BorderSize = 0;
            loadAlbumsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            loadAlbumsBtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            loadAlbumsBtn.FlatStyle = FlatStyle.Flat;
            loadAlbumsBtn.ForeColor = SystemColors.ControlText;
            loadAlbumsBtn.Location = new Point(404, 272);
            loadAlbumsBtn.Name = "loadAlbumsBtn";
            loadAlbumsBtn.Size = new Size(31, 31);
            loadAlbumsBtn.TabIndex = 0;
            loadAlbumsBtn.UseVisualStyleBackColor = false;
            loadAlbumsBtn.Click += loadAlbumsBtn_Click;
            // 
            // albumDataGridView
            // 
            albumDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            albumDataGridView.Location = new Point(407, 76);
            albumDataGridView.Name = "albumDataGridView";
            albumDataGridView.RowTemplate.Height = 25;
            albumDataGridView.Size = new Size(637, 175);
            albumDataGridView.TabIndex = 1;
            albumDataGridView.CellClick += dataGridView1_CellClick;
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
            searchButton.Location = new Point(867, 280);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(100, 26);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(441, 280);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(407, 23);
            searchTextBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(127, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // addAlbumGroupBox1
            // 
            addAlbumGroupBox1.Controls.Add(descriptionTextBox);
            addAlbumGroupBox1.Controls.Add(imageURLTextBox);
            addAlbumGroupBox1.Controls.Add(yearTextBox);
            addAlbumGroupBox1.Controls.Add(artistTextBox);
            addAlbumGroupBox1.Controls.Add(albumNameTextBox);
            addAlbumGroupBox1.Controls.Add(label5);
            addAlbumGroupBox1.Controls.Add(label4);
            addAlbumGroupBox1.Controls.Add(label3);
            addAlbumGroupBox1.Controls.Add(label2);
            addAlbumGroupBox1.Controls.Add(label1);
            addAlbumGroupBox1.Location = new Point(75, 76);
            addAlbumGroupBox1.Name = "addAlbumGroupBox1";
            addAlbumGroupBox1.Size = new Size(299, 214);
            addAlbumGroupBox1.TabIndex = 5;
            addAlbumGroupBox1.TabStop = false;
            addAlbumGroupBox1.Text = "Add Album";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(136, 174);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(144, 23);
            descriptionTextBox.TabIndex = 9;
            // 
            // imageURLTextBox
            // 
            imageURLTextBox.Location = new Point(136, 136);
            imageURLTextBox.Name = "imageURLTextBox";
            imageURLTextBox.Size = new Size(144, 23);
            imageURLTextBox.TabIndex = 8;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(136, 98);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(144, 23);
            yearTextBox.TabIndex = 7;
            // 
            // artistTextBox
            // 
            artistTextBox.Location = new Point(136, 60);
            artistTextBox.Name = "artistTextBox";
            artistTextBox.Size = new Size(144, 23);
            artistTextBox.TabIndex = 6;
            // 
            // albumNameTextBox
            // 
            albumNameTextBox.Location = new Point(136, 22);
            albumNameTextBox.Name = "albumNameTextBox";
            albumNameTextBox.Size = new Size(144, 23);
            albumNameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 177);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 144);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Image URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 106);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 68);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            // 
            // addButton
            // 
            addButton.BackColor = Color.Gray;
            addButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            addButton.FlatAppearance.MouseOverBackColor = Color.Cyan;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.ForeColor = SystemColors.ControlText;
            addButton.Location = new Point(176, 311);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 33);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // songsDataGridView
            // 
            songsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            songsDataGridView.Location = new Point(404, 326);
            songsDataGridView.Name = "songsDataGridView";
            songsDataGridView.RowTemplate.Height = 25;
            songsDataGridView.Size = new Size(637, 175);
            songsDataGridView.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 608);
            Controls.Add(songsDataGridView);
            Controls.Add(addButton);
            Controls.Add(addAlbumGroupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(albumDataGridView);
            Controls.Add(loadAlbumsBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)albumDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            addAlbumGroupBox1.ResumeLayout(false);
            addAlbumGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)songsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadAlbumsBtn;
        private DataGridView albumDataGridView;
        private Button searchButton;
        private TextBox searchTextBox;
        private PictureBox pictureBox1;
        private GroupBox addAlbumGroupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox albumNameTextBox;
        private TextBox descriptionTextBox;
        private TextBox imageURLTextBox;
        private TextBox yearTextBox;
        private TextBox artistTextBox;
        private Button addButton;
        private DataGridView songsDataGridView;
    }
}