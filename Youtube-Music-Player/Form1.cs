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

            albumBindingSource.DataSource = albumsDAO.getAllAlbums();

            dataGridView1.DataSource = albumBindingSource;




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

            if (row != null)
            {
                String imageURL = dataGridView.Rows[row].Cells[4].Value.ToString();
                pictureBox1.Load(imageURL);

            }


        }
    }
}