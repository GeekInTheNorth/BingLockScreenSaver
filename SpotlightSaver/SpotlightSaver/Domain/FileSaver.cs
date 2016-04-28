using System.IO;
using System.Windows.Forms;

namespace SpotlightSaver.Domain
{
    public class FileSaver
    {
        public void Save(string sourceFileName, string defaultLocation)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JPEG File (*.jpg)|*.jpg|All files (*.*)|*.*";
            saveDialog.CheckFileExists = false;
            saveDialog.InitialDirectory = defaultLocation;
            saveDialog.DefaultExt = "jpg";
            saveDialog.AddExtension = true;
            saveDialog.Title = "Save Spotlight Image";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(sourceFileName, saveDialog.FileName);
                GlobalVariables.LastFolderPath = Path.GetDirectoryName(saveDialog.FileName);
            }
        }

        private void SaveFile(string sourceFileName, string destinationFileName)
        {
            var existingFile = new FileInfo(sourceFileName);
            var newFile = new FileInfo(destinationFileName);

            if (newFile.Exists)
            {
                if (MessageBox.Show("An image by the same name already exists, do you want to replace it?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    newFile.Delete();
                else
                    return;
            }

            existingFile.CopyTo(destinationFileName);
        }
    }
}
