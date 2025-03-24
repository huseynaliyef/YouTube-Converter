using System;
using System.IO;
using System.Windows.Forms;
using YoutubeDownloader.Application.Utils;

namespace YoutubeVideoDownloader
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string appEviromentDirectory = Environment.CurrentDirectory;

            var importantFilesPath = Path.Combine(appEviromentDirectory, "Importants");

            var youtubeDLPath = Path.Combine(importantFilesPath, "yt-dlp.exe");

            var ffmpegPath = Path.Combine(importantFilesPath, "ffmpeg.exe");

            if (Directory.Exists(importantFilesPath) == false)
                Directory.CreateDirectory(importantFilesPath);

            if(File.Exists(youtubeDLPath) == false)
                RequiredAppsManager.DownloadYtDlp(importantFilesPath).Wait();

            if(File.Exists(ffmpegPath) == false)
                RequiredAppsManager.DownloadFFmpeg(importantFilesPath).Wait();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new YoutubeVideoConverterToMp3());
        }
    }
}
