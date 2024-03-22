using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeVideoDownloader
{
    public partial class YoutubeVideoConverterToMp3 : Form
    {
        public YoutubeVideoConverterToMp3()
        {
            InitializeComponent();
        }

        public async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        async Task Search()
        {
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(linkBox.Text);
            var streamInfoSet = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var videoStreamInfo = streamInfoSet.GetMuxedStreams().GetWithHighestVideoQuality();
            downloadedMusicLabel.Text = "";
            videoLabel.Text = video.Title;
            musicDownloadBtn.Visible = true;
            videoDownloadBtn.Visible = true;
            await initizated();
            webView21.CoreWebView2.Navigate(videoStreamInfo.Url);
        }
        async Task DownloadAudioAsync()
        {

            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(linkBox.Text);

            var streamInfoSet = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var audioStreamInfo = streamInfoSet.GetAudioOnlyStreams().GetWithHighestBitrate();

            string UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string DownloadFolder = Path.Combine(UserProfile, "Downloads");
            downloadedMusicLabel.Text = video.Title + " installing..";
            string outputPath = $"{DownloadFolder}\\" + video.Title.Split('|', '/', '\\', '~', '`')[0] + Guid.NewGuid() + ".mp3";

            await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, outputPath);
            downloadedMusicLabel.Text = video.Title + " installed.";
            MessageBox.Show("Music successfully downloaded.");


        }

        async Task DownloadVideoAsync()
        {

            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(linkBox.Text);

            var streamInfoSet = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var videoStreamInfo = streamInfoSet.GetMuxedStreams().GetWithHighestVideoQuality();
            
            string UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string DownloadFolder = Path.Combine(UserProfile, "Downloads");
            downloadedMusicLabel.Text = video.Title + " installing..";
            string outputPath = $"{DownloadFolder}\\" + video.Title.Split('|', '/', '\\', '~', '`')[0] + Guid.NewGuid() + ".mp4";

            await youtube.Videos.Streams.DownloadAsync(videoStreamInfo, outputPath);
            downloadedMusicLabel.Text = video.Title + " installed.";
            MessageBox.Show("Video successfully downloaded.");


        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void musicDownloadBtn_Click(object sender, EventArgs e)
        {
            DownloadAudioAsync();
        }

        private void videoDownloadBtn_Click(object sender, EventArgs e)
        {
            DownloadVideoAsync();
        }

        private void YoutubeVideoConverterToMp3_Load(object sender, EventArgs e)
        {
            musicDownloadBtn.Visible = false;
            videoDownloadBtn.Visible = false;
        }
    }
}
