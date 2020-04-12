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
    public partial class Form4 : Form
    {

        APIClient proxy = new APIClient();

        public Form4()
        {
            InitializeComponent();
        }

        private void btnCreate_Zone_Click(object sender, EventArgs e)
        {
            proxy.CreateNew("Zones", numeZona.Text.ToString(), IdMedia_Zone.Text.ToString());
            MessageBox.Show("Done!");
        }

        private void btnRead_Zone_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.Read("Zones").ToString());
        }

        private void btnSearch_Zone_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.Search("Zones", numeZona.Text.ToString()));
        }

        private void btnDelete_Zone_Click(object sender, EventArgs e)
        {
            proxy.Delete("Zones", numeZona.Text.ToString());
            MessageBox.Show("Done!");
        }

        private void btnSave_Zones_Click(object sender, EventArgs e)
        {
            proxy.Save();
            MessageBox.Show("Save!");
        }
    }
}
