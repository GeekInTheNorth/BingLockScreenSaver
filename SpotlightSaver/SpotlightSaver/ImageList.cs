using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SpotlightSaver.Domain;

namespace SpotlightSaver
{
    public partial class ImageList : Form
    {
        private const int MaximumImageWidth = 384;
        private const int MaximumImageHeight = 216;
        private const int ImageSpacing = 10;

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

            DrawImageList(spotlightImages);
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

        private void DrawImageList(IEnumerable<SpotlightImage> spotlightImages)
        {
            var imageNumber = 0;

            foreach (var spotlightImage in spotlightImages)
            {
                var imageBox = new PictureBox();
                imageBox.Width = MaximumImageWidth;
                imageBox.Height = MaximumImageHeight;
                imageBox.Load(spotlightImage.FullPath);
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                imageBox.Parent = pnImageContainer;
                imageBox.Top = 8;
                imageBox.Left = 8 + ((MaximumImageWidth + ImageSpacing)  * imageNumber);
                imageBox.DoubleClick += ImageBox_DoubleClick;

                imageNumber++;
            }
        }

        private void ImageBox_DoubleClick(object sender, EventArgs e)
        {
            var imageBox = (PictureBox)sender;
            var imagePreview = new ImagePreview(imageBox.ImageLocation);
            imagePreview.ShowDialog();
        }
    }
}
