using System.Threading.Tasks;
using YoutubeDownloader.Application.Models;

namespace YoutubeDownloader.Application.Interfaces
{
    public interface IDownloaderService
    {
        Task<VideoInfoModel> GetVideoInfoAsync(string url);
        Task DonloadVideoAsync(string url, string path);
        Task DonloadAudioAsync(string url, string path);
    }
}
