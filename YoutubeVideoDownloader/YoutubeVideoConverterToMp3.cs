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

            downloadComboBox.Items.Add("Mp3");
            downloadComboBox.Items.Add("Mp4");
            downloadComboBox.SelectedIndex = 0;
            downloadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            await Search(linkBox.Text);
        }

        private async void downloadBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                var title = downloadComboBox.SelectedIndex == 0 ? "music" : "video";

                folderDialog.Description = $"Select a folder to save the {title}";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    var selectedPath = folderDialog.SelectedPath;
                    switch (downloadComboBox.SelectedIndex)
                    {
                        case 0:
                            await DownloadAudioAsync(linkBox.Text, selectedPath);
                            break;
                        case 1:
                            await DownloadVideoAsync(linkBox.Text, selectedPath);
                            break;
                    }
                }
            }
        }

        private void YoutubeVideoConverterToMp3_Load(object sender, EventArgs e)
        {
            downloadComboBox.Visible = false;
            downloadBtn.Visible = false;
        }

        #region private logic

        private async Task Search(string url)
        {
            try
            {
                var videoInfo = await _downloaderService.GetVideoInfoAsync(url);

                downloadedMusicLabel.Text = "";
                videoLabel.Text = videoInfo.Title;
                downloadComboBox.Visible = true;
                downloadBtn.Visible = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task DownloadAudioAsync(string url, string path)
        {
            try
            {
                downloadedMusicLabel.Text = videoLabel.Text + " audio installing..";

                await _downloaderService.DonloadAudioAsync(url, path);

                downloadedMusicLabel.Text = videoLabel.Text + " audio installed.";

                MessageBox.Show("Music successfully downloaded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task DownloadVideoAsync(string url, string path)
        {
            try
            {
                downloadedMusicLabel.Text = videoLabel.Text + " video installing..";

                await _downloaderService.DonloadVideoAsync(url, path);

                downloadedMusicLabel.Text = videoLabel.Text + " video installed.";

                MessageBox.Show("Video successfully downloaded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private async void linkBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await Search(linkBox.Text);
            }
        }
    }
}
