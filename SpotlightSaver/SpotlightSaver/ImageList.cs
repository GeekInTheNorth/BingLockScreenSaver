using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SpotlightSaver.Domain;

namespace SpotlightSaver
{
    public partial class ImageList : Form
    {
        public ImageList()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int minimumWidth = 0;
            if (!int.TryParse(txtMinimumWidth.Text, out minimumWidth))
                minimumWidth = 0;
            int minimumHeight = 0;
            if (!int.TryParse(txtMinimumHeight.Text, out minimumHeight))
                minimumHeight = 0;

            var service = new SpotlightImageService();
            txtFilePath.Text = service.GetSpotlightFolderPath();

            var spotlightImages = service.GetSpotlightImages();
            spotlightImages = spotlightImages.Where(x => x.Width >= minimumWidth && x.Height >= minimumHeight).ToList();

            gvSpotlightImages.DataSource = new BindingList<SpotlightImage>(spotlightImages);
        }

        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
