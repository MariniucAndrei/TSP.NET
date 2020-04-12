using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form5 : Form
    {

        APIClient proxy = new APIClient();

        public Form5()
        {
            InitializeComponent();
        }

        private void btnCreate_Grup_Click(object sender, EventArgs e)
        {
            proxy.CreateNew("PeopleGroups", numeGrup.Text.ToString(), IdMedia_Grup.Text.ToString());
            MessageBox.Show("Done!");
        }

        private void btnRead_Grup_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.Read("PeopleGroups").ToString());
        }

        private void btnSearch_Grup_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.Search("PeopleGroups", numeGrup.Text.ToString()));
        }

        private void btnDelete_Grup_Click(object sender, EventArgs e)
        {
            proxy.Delete("PeopleGroups", numeGrup.Text.ToString());
            MessageBox.Show("Done!");
        }

        private void btnSave_Grup_Click(object sender, EventArgs e)
        {
            proxy.Save();
            MessageBox.Show("Save!");
        }
    }
}
