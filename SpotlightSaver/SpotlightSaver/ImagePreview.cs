using System;
using System.IO;
using System.Windows.Forms;
using SpotlightSaver.Domain;

namespace SpotlightSaver
{
    public partial class ImagePreview : Form
    {
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

            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JPEG File (*.jpg)|*.jpg|All files (*.*)|*.*";
            saveDialog.CheckFileExists = false;
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveDialog.DefaultExt = "jpg";
            saveDialog.AddExtension = true;
            saveDialog.Title = "Save Spotlight Image";

            if (saveDialog.ShowDialog() == DialogResult.OK) SaveFile(saveDialog.FileName);
        }

        private void SaveFile(string fileName)
        {
            var existingFile = new FileInfo(pbPreview.ImageLocation);
            var newFile = new FileInfo(fileName);

            if (newFile.Exists)
            {
                if (MessageBox.Show("An image by the same name already exists, do you want to replace it?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    newFile.Delete();
                else
                    return;
            }

            existingFile.CopyTo(fileName);
        }
    }
}
