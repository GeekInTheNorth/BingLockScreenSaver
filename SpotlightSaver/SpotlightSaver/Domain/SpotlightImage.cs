using System;
using System.Drawing;

namespace SpotlightSaver.Domain
{
    public class SpotlightImage
    {
        public string Name { get; set; }

        public string FullPath { get; set; }

        public DateTime Created { get; set; }

        public int Size { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Bitmap Image
        {
            get
            {
                try
                {
                    return new Bitmap(FullPath);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
