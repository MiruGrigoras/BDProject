using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDProject
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void SingerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.singerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseDataSet1);

        }

        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseDataSet1.Singer' table. You can move, or remove it, as needed.
            this.singerTableAdapter.Fill(this.myDatabaseDataSet1.Singer);

        }
    }
}
