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
    }
}
