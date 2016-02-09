namespace SpotlightSaver
{
    public static class GlobalVariables
    {
        public static string LastFolderPath { get; set; }

        public static bool UseLastFolderPath
        {
            get { return !string.IsNullOrWhiteSpace(LastFolderPath); }
        }
    }
}
