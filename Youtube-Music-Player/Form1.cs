using System.Windows.Forms;

namespace CheapSpotify
{
    public partial class Form1 : Form
    {

        BindingSource albumBindingSource = new BindingSource();
        BindingSource trackBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();


        public Form1()
        {
            InitializeComponent();
        }

        private void loadAlbumsBtn_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albums = albumsDAO.getAllAlbums();

            albumBindingSource.DataSource = albums;

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


            trackBindingSource.DataSource = albums[row].Tracks;

            songsDataGridView.DataSource = trackBindingSource;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albums = albumsDAO.getAllAlbums();

            albumBindingSource.DataSource = albums;

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
            if (result == 1)
            {
                MessageBox.Show("Album added, Please refresh Page");
            }
            else
            {
                MessageBox.Show("Somehow not working");

            }


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int row = songsDataGridView.CurrentRow.Index;
            int trackID = (int)songsDataGridView.Rows[row].Cells[0].Value;

            AlbumsDAO albumsDao = new AlbumsDAO();
            int result = albumsDao.deleteTrack(trackID);
            MessageBox.Show("Track ID: " + trackID + " was deleted");

            songsDataGridView.DataSource = null;
            albums = albumsDao.getAllAlbums();

        }
    }
}