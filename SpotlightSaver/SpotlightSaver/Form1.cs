using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotlightSaver.Domain;

namespace SpotlightSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var service = new SpotlightImageService();

            txtFilePath.Text = service.GetSpotlightFolderPath();

            var images = service.GetFileNames();
            foreach(var imageName in images)
            {
                lbImageFiles.Items.Add(imageName);
            }
        }
    }
}
