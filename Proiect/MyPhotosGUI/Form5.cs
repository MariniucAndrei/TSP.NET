using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotos;

namespace MyPhotosGUI
{
    public partial class Form5 : Form
    {
        DataBaseAPI objectuse = new DataBaseAPI();
        public Form5()
        {
            InitializeComponent();
        }

        private void btnCreate_Grup_Click(object sender, EventArgs e)
        {
            objectuse.CreateNew("PeopleGroups", numeGrup.Text.ToString(), IdMedia_Grup.Text.ToString());
            MessageBox.Show("Done!");
        }

        private void btnRead_Grup_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objectuse.Read("PeopleGroups").ToString());
        }

        private void btnSearch_Grup_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objectuse.Search("PeopleGroups", numeGrup.Text.ToString()));
        }

        private void btnDelete_Grup_Click(object sender, EventArgs e)
        {
            objectuse.Delete("PeopleGroups", numeGrup.Text.ToString());
            MessageBox.Show("Done!");
        }

        private void btnSave_Grup_Click(object sender, EventArgs e)
        {
            objectuse.Save();
            MessageBox.Show("Save!");
        }
    }
}
