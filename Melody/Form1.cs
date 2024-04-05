using Melody;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melody
{
    
    public partial class Form1 : Form
    {
        BindingSource userBindingSource = new BindingSource();
        BindingSource artistBindingSource = new BindingSource();
        BindingSource allartistBindingSource = new BindingSource();
        BindingSource albumBindingSource = new BindingSource();
        BindingSource allalbumBindingSource = new BindingSource();
        BindingSource songBindingSource = new BindingSource();
        BindingSource allsongBindingSource = new BindingSource();
        BindingSource numUserBindingSource = new BindingSource();
        BindingSource numArtistBindingSource = new BindingSource();
        BindingSource numAlbumBindingSource = new BindingSource();
        BindingSource numSongBindingSource = new BindingSource();
        BindingSource allsongASCBindingSource = new BindingSource();
        BindingSource allsongDESCBindingSource = new BindingSource();
        BindingSource allalbumASCBindingSource = new BindingSource();
        BindingSource allalbumDESCBindingSource = new BindingSource();
        BindingSource allartistASCBindingSource = new BindingSource();
        BindingSource allartistDESCBindingSource = new BindingSource();

        public Form1()  
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewSong.Visible = false;
            dataGridViewAlbum.Visible = false;

            AlbumASC.Visible = false;
            AlbumDSC.Visible = false;
            SongASC.Visible = false;
            SongDSC.Visible = false;



            ArtistDAO artistDAO = new ArtistDAO();
            //connect the list to the grid view control
            artistBindingSource.DataSource = artistDAO.getAllArtists();
            dataGridView1.DataSource = artistBindingSource;
            
            pictureBox1.Load("https://static.wikia.nocookie.net/objectmayhem/images/0/0e/OMIITune.png/revision/latest?cb=20200328001814");

            NumHolderDAO numHolderDAO = new NumHolderDAO();
            //connect the list to the grid view control
            numUserBindingSource.DataSource = numHolderDAO.getUserNum();
            dataGridViewNum.DataSource = numUserBindingSource;

            //connect the list to the grid view control
            numArtistBindingSource.DataSource = numHolderDAO.getArtistNum();
            dataGridViewArtistNum.DataSource = numArtistBindingSource;

            //connect the list to the grid view control
            numAlbumBindingSource.DataSource = numHolderDAO.getAlbumNum();
            dataGridViewAlbumNum.DataSource = numAlbumBindingSource;

            //connect the list to the grid view control
            numSongBindingSource.DataSource = numHolderDAO.getSongNum();
            dataGridViewSongNum.DataSource = numSongBindingSource;


        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //get the row clicked

            int rowClicked = dataGridView.CurrentRow.Index;

            String imageURL = dataGridView.Rows[rowClicked].Cells[2].Value.ToString();
            pictureBox1.Load(imageURL);
        }



        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridViewAlbum.Visible = true;

            AlbumASC.Visible = false;
            AlbumDSC.Visible = false;
            SongASC.Visible = false;
            SongDSC.Visible = false;
            ArtistASC.Visible = false;
            ArtistDSC.Visible = false;


            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;


            ArtistDAO artistDAO = new ArtistDAO();

            albumBindingSource.DataSource = artistDAO.getAlbums((int)dataGridView.Rows[rowClicked].Cells[0].Value);
            dataGridViewAlbum.DataSource = albumBindingSource;
            
            

        }

        private void dataGridViewAlbum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //get the row clicked

            int rowClicked = dataGridView.CurrentRow.Index;

            String imageURL = dataGridView.Rows[rowClicked].Cells[2].Value.ToString();
            pictureBox1.Load(imageURL);

        }

        private void dataGridViewAlbum_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewAlbum.Visible = false;
            dataGridViewSong.Visible = true;

            AlbumASC.Visible = false;
            AlbumDSC.Visible = false;
            SongASC.Visible = false;
            SongDSC.Visible = false;
            ArtistASC.Visible = false;
            ArtistDSC.Visible = false;




            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;


            ArtistDAO artistDAO = new ArtistDAO();

            songBindingSource.DataSource = artistDAO.getSongs((int)dataGridView.Rows[rowClicked].Cells[0].Value);
            dataGridViewSong.DataSource = songBindingSource;
        }

        private void dataGridViewSong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSong_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumASC.Visible = false;
            AlbumDSC.Visible = false;
            SongASC.Visible = false;
            SongDSC.Visible = false;
            ArtistASC.Visible = true;
            ArtistDSC.Visible = true;

            dataGridViewAlbum.Visible = false;
            dataGridViewSong.Visible = false;
            dataGridView1.Visible = true;
            ArtistDAO artistDAO = new ArtistDAO();
            //connect the list to the grid view control
            artistBindingSource.DataSource = artistDAO.getAllArtists();
            dataGridView1.DataSource = artistBindingSource;
            pictureBox1.Load("https://static.wikia.nocookie.net/objectmayhem/images/0/0e/OMIITune.png/revision/latest?cb=20200328001814");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumASC.Visible = true;
            AlbumDSC.Visible = true;
            SongASC.Visible = false;
            SongDSC.Visible = false;
            ArtistASC.Visible = false;
            ArtistDSC.Visible = false;

            dataGridViewAlbum.Visible = true;
            dataGridViewSong.Visible = false;
            dataGridView1.Visible = false;
            ArtistDAO artistDAO = new ArtistDAO();
            //connect the list to the grid view control
            allalbumBindingSource.DataSource = artistDAO.getAllAlbums();
            dataGridViewAlbum.DataSource = allalbumBindingSource;
            pictureBox1.Load("https://static.wikia.nocookie.net/objectmayhem/images/0/0e/OMIITune.png/revision/latest?cb=20200328001814");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlbumASC.Visible = false;
            AlbumDSC.Visible = false;
            SongASC.Visible = true;
            SongDSC.Visible = true;
            ArtistASC.Visible = false;
            ArtistDSC.Visible = false; 


            dataGridViewAlbum.Visible = false;
            dataGridViewSong.Visible = true;
            dataGridView1.Visible = false;
            ArtistDAO artistDAO = new ArtistDAO();
            //connect the list to the grid view control
            allsongBindingSource.DataSource = artistDAO.getAllSongs();
            dataGridViewSong.DataSource = allsongBindingSource;
            pictureBox1.Load("https://static.wikia.nocookie.net/objectmayhem/images/0/0e/OMIITune.png/revision/latest?cb=20200328001814");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            ArtistDAO artistDAO = new ArtistDAO();
            allsongASCBindingSource.DataSource = artistDAO.getAllSongsASC();
            dataGridViewSong.DataSource = allsongASCBindingSource;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ArtistDAO artistDAO = new ArtistDAO();
            allsongDESCBindingSource.DataSource = artistDAO.getAllSongsDSC();
            dataGridViewSong.DataSource = allsongDESCBindingSource;
        }

        private void AlbumASC_Click(object sender, EventArgs e)
        {
            ArtistDAO artistDAO = new ArtistDAO();
            allalbumASCBindingSource.DataSource = artistDAO.getAllAlbumsASC();
            dataGridViewAlbum.DataSource = allalbumASCBindingSource;
        }

        private void AlbumDSC_Click(object sender, EventArgs e)
        {
            ArtistDAO artistDAO = new ArtistDAO();
            allalbumDESCBindingSource.DataSource = artistDAO.getAllAlbumsDESC();
            dataGridViewAlbum.DataSource = allalbumDESCBindingSource;
        }

        private void ArtistASC_Click(object sender, EventArgs e)
        {
            ArtistDAO artistDAO = new ArtistDAO();
            allartistASCBindingSource.DataSource = artistDAO.getAllArtistsASC();
            dataGridView1.DataSource = allartistASCBindingSource;
        }

        private void ArtistDSC_Click(object sender, EventArgs e)
        {
            ArtistDAO artistDAO = new ArtistDAO();
            allartistDESCBindingSource.DataSource = artistDAO.getAllArtistsDESC();
            dataGridView1.DataSource = allartistDESCBindingSource;
        }

        private void dataGridViewSong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewAlbum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}







