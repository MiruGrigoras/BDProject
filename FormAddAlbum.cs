using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDProject.Tables;

namespace BDProject
{
    public partial class FormAddAlbum : Form
    {
        public FormAddAlbum()
        {
            InitializeComponent();
        }

        private void AlbumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.albumBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseDataSet);

        }

        private void FormAddAlbum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseDataSet.Album' table. You can move, or remove it, as needed.
            this.albumTableAdapter.Fill(this.myDatabaseDataSet.Album);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            MyDatabaseEntities rep = new MyDatabaseEntities();
            Album newAlbum = new Album();
            try
            {

                newAlbum.AlbumKey = Convert.ToInt16(AlbumKeyTextBox.Text);
                newAlbum.SingerKey = Convert.ToInt16(SingerKeyTextBox.Text);
                newAlbum.AlbumName = AlbumNameTextBox.Text;
                newAlbum.ReleaseDate = ReleaseDatePicker.Value;
                newAlbum.NoSongs = Convert.ToInt16(NoSongsTextBox.Text);
                rep.Albums.Add(newAlbum);
                rep.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong!");
            }
            MessageBox.Show("The adding was successful!");
            this.Close();
        }
    }
}
