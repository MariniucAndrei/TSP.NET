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
    public partial class Form3 : Form
    {
        APIClient proxy = new APIClient();

        public Form3()
        {
            InitializeComponent();
        }

        private void btnCreate_Event_Click(object sender, EventArgs e)
        {
            proxy.CreateNew("Events", numeEvent.Text.ToString(), IdMedia_Event.Text.ToString());
            MessageBox.Show("Done!");
        }

        private void btnRead_Event_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.Read("Events").ToString());
        }

        private void btnSearch_Event_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.Search("Events", numeEvent.Text.ToString()));
        }

        private void btnDelete_Event_Click(object sender, EventArgs e)
        {
            proxy.Delete("Events", numeEvent.Text.ToString());
            MessageBox.Show("Done!");
        }

        private void btnSave_Event_Click(object sender, EventArgs e)
        {
            proxy.Save();
            MessageBox.Show("Save!");
        }
    }
}
