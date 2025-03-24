using System.IO;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO.Compression;

namespace YoutubeDownloader.Application.Utils
{
    public static class RequiredAppsManager
    {
        private static HttpClient _client = new HttpClient();

        public static async Task DownloadYtDlp(string directoryPath = "")
        {
            string ytDlpDownloadUrl = GetYtDlpDownloaderUrl();
            if (string.IsNullOrEmpty(directoryPath))
            {
                directoryPath = Directory.GetCurrentDirectory();
            }

            string downloadLocation = Path.Combine(directoryPath, Path.GetFileName(ytDlpDownloadUrl));
            File.WriteAllBytes(downloadLocation, await DownloadFileBytesAsync(ytDlpDownloadUrl));
        }

        public static async Task DownloadFFmpeg(string directoryPath = "")
        {
            await FFDownloader(directoryPath);
        }

        #region privates

        private static string FFDownloaderUrl()
        {
            return "https://github.com/ffbinaries/ffbinaries-prebuilt/releases/download/v6.1/ffmpeg-6.1-win-64.zip";
        }

        private static async Task FFDownloader(string directoryPath = "")
        {
            if (string.IsNullOrEmpty(directoryPath))
            {
                directoryPath = Directory.GetCurrentDirectory();
            }

            using MemoryStream stream = new MemoryStream(await DownloadFileBytesAsync(FFDownloaderUrl()));
            using ZipArchive zipArchive = new ZipArchive(stream, ZipArchiveMode.Read);
            if (zipArchive.Entries.Count > 0)
            {
                zipArchive.Entries[0].ExtractToFile(Path.Combine(directoryPath, zipArchive.Entries[0].FullName), overwrite: true);
            }
        }

        private static string GetYtDlpDownloaderUrl()
        {
            return "https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe";
        }

        private static async Task<byte[]> DownloadFileBytesAsync(string uri)
        {
            if (!Uri.TryCreate(uri, UriKind.Absolute, out Uri _))
            {
                throw new InvalidOperationException("URI is invalid.");
            }

            return await _client.GetByteArrayAsync(uri);
        }

        #endregion
    }
}
