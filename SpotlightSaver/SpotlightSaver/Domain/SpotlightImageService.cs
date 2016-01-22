using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace SpotlightSaver.Domain
{
    public class SpotlightImageService
    {
        public string GetSpotlightFolderPath()
        {
            var userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var driveInfo = new DirectoryInfo(userFolder);
            driveInfo = SearchFor(driveInfo, "AppData");
            driveInfo = SearchFor(driveInfo, "Local");
            driveInfo = SearchFor(driveInfo, "Packages");
            driveInfo = SearchFor(driveInfo, "Microsoft.Windows.ContentDeliveryManager");
            driveInfo = SearchFor(driveInfo, "LocalState");
            driveInfo = SearchFor(driveInfo, "Assets");

            return driveInfo.FullName;
        }

        public List<SpotlightImage> GetSpotlightImages()
        {
            var folder = new DirectoryInfo(GetSpotlightFolderPath());
            var fileList = new List<SpotlightImage>();

            foreach (var fileInfo in folder.GetFiles())
            {
                var spotlightFile = GetSpotlightImage(fileInfo);

                if (spotlightFile != null)
                    fileList.Add(spotlightFile);
            }

            return fileList;
        }

        private SpotlightImage GetSpotlightImage(FileInfo fileInfo)
        {
            var spotlightImage = new SpotlightImage();
            spotlightImage.Name = fileInfo.Name;
            spotlightImage.FullPath = fileInfo.FullName;
            spotlightImage.Size = (int)fileInfo.Length;
            spotlightImage.Created = fileInfo.CreationTime;

            try
            {
                var image = new Bitmap(fileInfo.FullName);
                spotlightImage.Width = image.Width;
                spotlightImage.Height = image.Height;
            }
            catch (Exception ex)
            {
                return null;
            }

            return spotlightImage;
        }

        private DirectoryInfo SearchFor(DirectoryInfo directoryInfo, string partialFolderName)
        {
            foreach (var folder in directoryInfo.GetDirectories())
            {
                if (string.Equals(folder.Name, partialFolderName, StringComparison.CurrentCultureIgnoreCase))
                {
                    return new DirectoryInfo(folder.FullName);
                }
            }

            foreach (var folder in directoryInfo.GetDirectories())
            {
                if (folder.Name.ToLower().Contains(partialFolderName.ToLower()))
                {
                    return new DirectoryInfo(folder.FullName);
                }
            }

            return directoryInfo;
        }
    }
}