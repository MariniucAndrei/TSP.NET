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
    public partial class Form1 : Form
    {
        APIClient proxy = new APIClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            proxy.Create("Medias", nume.Text.ToString(), data.Text.ToString(), calea.Text.ToString(), esteStearsa.Text.ToString(), Int32.Parse(idZona.Text), Int32.Parse(idGrup.Text), Int32.Parse(idEveniment.Text));
            MessageBox.Show("Done!");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.Read("Medias").ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            proxy.Update(nume.Text.ToString(), numenou.Text.ToString());
            MessageBox.Show("Done!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            proxy.Delete("Medias", nume.Text.ToString());
            MessageBox.Show("Done!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.Search("Medias", nume.Text.ToString()));
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.Filter(nume.Text.ToString(), data.Text.ToString(), calea.Text.ToString(), esteStearsa.Text.ToString(), Int32.Parse(idZona.Text), Int32.Parse(idGrup.Text), Int32.Parse(idEveniment.Text)));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            proxy.Save();
            MessageBox.Show("Save!");
        }
    }
}
