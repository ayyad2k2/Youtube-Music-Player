namespace CheapSpotify
{
    public partial class Form1 : Form
    {

        BindingSource albumBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void loadAlbumsBtn_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            Album a1 = new Album()
            {
                ID = 1,
                AlbumName = "Smithereens",
                ArtistName = "Joji",
                Year = 2023,
                ImageURL = "https://www.youtube.com",
                Description = "WOW this is a description"

            };

            Album a2 = new Album()
            {
                ID = 1,
                AlbumName = "Nectar",
                ArtistName = "Joji",
                Year = 2023,
                ImageURL = "https://www.youtube.com",
                Description = "WOW this is a description"

            };

            albumsDAO.albums.Add(a1);
            albumsDAO.albums.Add(a2);

            // connect the lsit to the grid view control 
            albumBindingSource.DataSource = albumsDAO.albums;

            dataGridView1.DataSource = albumBindingSource; 

        }
    }
}