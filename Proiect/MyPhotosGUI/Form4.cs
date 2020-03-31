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
    public partial class Form4 : Form
    {
        DataBaseAPI objectuse = new DataBaseAPI();
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCreate_Zone_Click(object sender, EventArgs e)
        {
            objectuse.CreateNew("Zones", numeZona.Text.ToString(), IdMedia_Zone.Text.ToString());
            MessageBox.Show("Done!");
        }

        private void btnRead_Zone_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objectuse.Read("Zones").ToString());
        }

        private void btnSearch_Zone_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objectuse.Search("Zones", numeZona.Text.ToString()));
        }

        private void btnDelete_Zone_Click(object sender, EventArgs e)
        {
            objectuse.Delete("Zones", numeZona.Text.ToString());
            MessageBox.Show("Done!");
        }

        private void btnSave_Zones_Click(object sender, EventArgs e)
        {
            objectuse.Save();
            MessageBox.Show("Save!");
        }
    }
}
