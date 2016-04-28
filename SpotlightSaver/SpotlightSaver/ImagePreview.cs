using System;
using System.IO;
using System.Windows.Forms;
using SpotlightSaver.Domain;

namespace SpotlightSaver
{
    public partial class ImagePreview : Form
    {
        private string InitialDirectory
        {
            get
            {
                if (GlobalVariables.UseLastFolderPath)
                    return GlobalVariables.LastFolderPath;

                return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            }
        }

        public ImagePreview(SpotlightImage spotlightImage)
        {
            InitializeComponent();

            pbPreview.Load(spotlightImage.FullPath);
        }

        public ImagePreview(string imagePath)
        {
            InitializeComponent();

            pbPreview.Load(imagePath);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileInfo = new FileInfo(pbPreview.ImageLocation);
            if (!fileInfo.Exists) return;

            var saver = new FileSaver();
            saver.Save(pbPreview.ImageLocation, InitialDirectory);
        }
    }
}
