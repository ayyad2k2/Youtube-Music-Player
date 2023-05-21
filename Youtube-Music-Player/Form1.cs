namespace CheapSpotify
{
    public partial class Form1 : Form
    {

        BindingSource albumBindingSource = new BindingSource();
        BindingSource trackBindingSource = new BindingSource();


        public Form1()
        {
            InitializeComponent();
        }

        private void loadAlbumsBtn_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albumBindingSource.DataSource = albumsDAO.getAllAlbums();

            albumDataGridView.DataSource = albumBindingSource;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albumBindingSource.DataSource = albumsDAO.searchTitles(searchTextBox.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int row = dataGridView.CurrentRow.Index;

            if (dataGridView.Rows[row].Cells[4].Value != null)
            {
                String imageURL = dataGridView.Rows[row].Cells[4].Value.ToString();
                try
                {
                    pictureBox1.Load(imageURL);
                }
                catch { }
            }
            AlbumsDAO albumsDAO = new AlbumsDAO();

            trackBindingSource.DataSource = albumsDAO.getTracksForAlbum((int)dataGridView.Rows[row].Cells[0].Value);

            songsDataGridView.DataSource = trackBindingSource;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albumBindingSource.DataSource = albumsDAO.getAllAlbums();

            albumDataGridView.DataSource = albumBindingSource;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Album album = new Album
            {
                AlbumName = albumNameTextBox.Text,
                ArtistName = artistTextBox.Text,
                Year = Int32.Parse(yearTextBox.Text),
                ImageURL = imageURLTextBox.Text,
                Description = descriptionTextBox.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();

            int result = albumsDAO.addOneAlbum(album);
            MessageBox.Show("The result is : " + result);


        }
    }
}