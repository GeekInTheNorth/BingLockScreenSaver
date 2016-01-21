using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<string> GetFileNames()
        {
            var folder = new DirectoryInfo(GetSpotlightFolderPath());
            var fileList = new List<string>();

            foreach (var fileName in folder.GetFiles())
            {
                fileList.Add(fileName.Name);
            }

            return fileList;
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