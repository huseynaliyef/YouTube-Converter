using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDownloader.Application.Implementations;
using YoutubeDownloader.Application.Interfaces;

namespace YoutubeVideoDownloader
{
    public partial class YoutubeVideoConverterToMp3 : Form
    {
        private readonly IDownloaderService _downloaderService;
        public YoutubeVideoConverterToMp3()
        {
            InitializeComponent();
            _downloaderService = new DownloaderService();
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            await Search(linkBox.Text);
        }

        private async void musicDownloadBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder to save the music";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    await DownloadAudioAsync(linkBox.Text, selectedPath);
                }
            }
        }

        private async void videoDownloadBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder to save the video";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    await DownloadVideoAsync(linkBox.Text, selectedPath);
                }
            }
        }

        private void YoutubeVideoConverterToMp3_Load(object sender, EventArgs e)
        {
            musicDownloadBtn.Visible = false;
            videoDownloadBtn.Visible = false;
        }

        #region privates

        private async Task Search(string url)
        {
            var videoInfo = await _downloaderService.GetVideoInfoAsync(url);

            downloadedMusicLabel.Text = "";
            videoLabel.Text = videoInfo.Title;
            musicDownloadBtn.Visible = true;
            videoDownloadBtn.Visible = true;
        }
        private async Task DownloadAudioAsync(string url, string path)
        {
            downloadedMusicLabel.Text = videoLabel.Text + " audio installing..";

            await _downloaderService.DonloadAudioAsync(url, path);

            downloadedMusicLabel.Text = videoLabel.Text + " audio installed.";

            MessageBox.Show("Music successfully downloaded.");
        }

        private async Task DownloadVideoAsync(string url, string path)
        {
            downloadedMusicLabel.Text = videoLabel.Text + " video installing..";

            await _downloaderService.DonloadVideoAsync(url, path);

            downloadedMusicLabel.Text = videoLabel.Text + " video installed.";

            MessageBox.Show("Video successfully downloaded.");
        }

        #endregion
    }
}
