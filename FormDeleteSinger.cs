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
    public partial class FormDeleteSinger : Form
    {
        public FormDeleteSinger()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MyDatabaseEntities rep = new MyDatabaseEntities();
            try
            {
                short x = Convert.ToInt16(SingerKeyTextBox.Text);
                rep.Albums.RemoveRange(rep.Albums.Where(aux => aux.SingerKey == x));
                Singer delSinger = rep.Singers.First(aux => aux.SingerKey == x);
                rep.Singers.Remove(delSinger);
                rep.SaveChanges();
                MessageBox.Show("The deleting was successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong here!");
            }
            this.Close();
        }
    }
}
