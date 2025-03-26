using System;
using System.IO;
using System.Threading.Tasks;
using YoutubeDLSharp;
using YoutubeDLSharp.Options;
using YoutubeDownloader.Application.Interfaces;
using YoutubeDownloader.Application.Models;
using YoutubeExplode;

namespace YoutubeDownloader.Application.Implementations
{
    public class DownloaderService : IDownloaderService
    {
        private readonly YoutubeClient _youtubeClient;

        private YoutubeDL _youtubeDL;
        public DownloaderService()
        {
            _youtubeClient = new YoutubeClient();

            var importantFilesPath = Path.Combine(Environment.CurrentDirectory, "Importants");
            _youtubeDL = new YoutubeDL
            {
                YoutubeDLPath = Path.Combine(importantFilesPath, "yt-dlp.exe"),
                FFmpegPath = Path.Combine(importantFilesPath, "ffmpeg.exe")
            };
        }

        public async Task<VideoInfoModel> GetVideoInfoAsync(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new Exception("You mast paste any youtube video url.");

            var video = await _youtubeClient.Videos.GetAsync(url);

            var infoModel = new VideoInfoModel
            {
                Title = video.Title,
                Description = video.Description,
                Duration = video.Duration,
                Url = video.Url
            };

            return infoModel;
        }

        public async Task DonloadVideoAsync(string url, string path)
        {
            _youtubeDL.OutputFolder = path;
            _youtubeDL.OutputFileTemplate = "%(title)s_video.%(ext)s";
            await _youtubeDL.RunVideoDownload(url);
        }

        public async Task DonloadAudioAsync(string url, string path)
        {
            _youtubeDL.OutputFolder = path;
            _youtubeDL.OutputFileTemplate = "%(title)s_audio.%(ext)s";
            await _youtubeDL.RunAudioDownload(url, AudioConversionFormat.Mp3);
        }
    }
}
