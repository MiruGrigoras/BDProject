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
    public partial class FormDeleteAlbum : Form
    {
        public FormDeleteAlbum()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MyDatabaseEntities rep = new MyDatabaseEntities();
            try
            {
                Album newAlbum = rep.Albums.First(aux => aux.AlbumName.Equals(AlbumNameTextBox.Text));
                rep.Albums.Remove(newAlbum);
                rep.SaveChanges();
                MessageBox.Show("The deleting was successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!");
            }
            this.Close();
        }
    }
}
