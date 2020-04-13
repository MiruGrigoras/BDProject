using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using BDProject.Tables;

namespace BDProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) //NEXT button
        {
            singerBindingSource.MoveNext();
        }

        private void Previous_Click(object sender, EventArgs e) //PREVIOUS button
        {
            singerBindingSource.MovePrevious();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = GetDisplayedTable();
            this.singerTableAdapter1.Fill(this.myDatabaseDataSet1.Singer);
        }
        private DataTable GetDisplayedTable()
        {
            DataTable dt = new DataTable();

            string conString = ConfigurationManager.ConnectionStrings["BDProject.Properties.Settings.MyDatabaseConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                using(SqlCommand cmd = new SqlCommand("SELECT Singer.SingerKey, Singer.SingerName, Album.AlbumName, Album.AlbumKey, Singer.RecordLabel, Album.ReleaseDate, Album.NoSongs FROM Singer INNER JOIN Album ON Album.SingerKey=Singer.SingerKey", con))
                {
                    try {
                        con.Open();
                    } catch(System.Data.SqlClient.SqlException exception)
                    {
                        MessageBox.Show("Can`t connect to the database");
                    }
                    

                    SqlDataReader rdr = cmd.ExecuteReader();

                    dt.Load(rdr);
                }
            }

            return dt;
        }

        private void AddAlbum_Click(object sender, EventArgs e)
        {
            FormAddAlbum f = new FormAddAlbum();
            f.Show();
        }

        private void AddSinger_Click(object sender, EventArgs e)
        {
            MyDatabaseEntities rep = new MyDatabaseEntities();
            Singer newSinger = new Singer();
            try
            {
                newSinger.SingerKey = Convert.ToInt16(SingerKeyTextBox.Text);
                newSinger.SingerName = NameTextBox.Text;
                newSinger.NoAlbums = NoAlbumsTextBox.Text;
                newSinger.NoAwards = NoAwardsTextBox.Text;
                newSinger.RecordLabel = RecordLabelTextBox.Text;
                rep.Singers.Add(newSinger);
                rep.SaveChanges();
                MessageBox.Show("The adding was successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void DeleteAlbum_Click(object sender, EventArgs e)
        {
            FormDeleteAlbum f = new FormDeleteAlbum();
            f.Show();
        }

        private void DeleteSinger_Click(object sender, EventArgs e)
        {
            FormDeleteSinger f = new FormDeleteSinger();
            f.Show();
        }

        private void ShowAlbums_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = GetDisplayedTable();
        }

        private void UpdateSinger_Click(object sender, EventArgs e)
        {
            MyDatabaseEntities rep = new MyDatabaseEntities();
            try
            {
                short x = Convert.ToInt16(SingerKeyTextBox.Text);
                Singer newSinger = rep.Singers.First(aux => aux.SingerKey == x);
                if(newSinger != null)
                {
                    newSinger.SingerName = NameTextBox.Text;
                    newSinger.NoAlbums = NoAlbumsTextBox.Text;
                    newSinger.NoAwards = NoAwardsTextBox.Text;
                    newSinger.RecordLabel = RecordLabelTextBox.Text;
                    rep.SaveChanges();
                    MessageBox.Show("The modifying was successful!");
                }
                else MessageBox.Show("The key is not registered!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(GetDisplayedTable());
            dv.RowFilter = string.Format("SingerName like '%{0}%'", SearchArtistTextBox.Text);
            dataGridView.DataSource = dv;
        }
    }
}
