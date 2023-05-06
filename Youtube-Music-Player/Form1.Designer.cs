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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            loadAlbumsBtn.Location = new Point(311, 37);
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
            dataGridView1.Location = new Point(417, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(637, 175);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 608);
            Controls.Add(dataGridView1);
            Controls.Add(loadAlbumsBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button loadAlbumsBtn;
        private DataGridView dataGridView1;
    }
}