using System;

namespace YoutubeDownloader.Application.Models
{
    public class VideoInfoModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public string Url { get; set; }
    }
}
