using System.Net.NetworkInformation;
using YoutubeDownloader.Application.Implementations;
using YoutubeDownloader.Application.Interfaces;
using Timer = System.Windows.Forms.Timer;

namespace YoutubeVideoDownloader
{
    public partial class YoutubeVideoConverterToMp3 : Form
    {
        private readonly IDownloaderService _downloaderService;

        private bool _isInternetAvailable;
        public bool IsInternetAvailable
        {
            get => _isInternetAvailable;
            set => _isInternetAvailable = value;
        }

        public YoutubeVideoConverterToMp3()
        {
            InitializeComponent();
            _downloaderService = new DownloaderService();

            downloadComboBox.Items.Add("Mp3");
            downloadComboBox.Items.Add("Mp4");
            downloadComboBox.SelectedIndex = 0;
            downloadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            linkBox.PlaceholderText = "Search";

            // Initialize Timer
            var timer = new Timer();
            timer.Interval = 5000; // Check every 5 seconds
            timer.Tick += TimerTick;
            timer.Start();

            // Initial check
            UpdateInternetStatus();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            UpdateInternetStatus();
        }

        private void UpdateInternetStatus()
        {
            CheckInternetAvailable();

            if (IsInternetAvailable)
            {
                onlinePictureBox.Image = Image.FromFile("./Resources/user-online-icon-1024x1024-33v8udca.png");
                
                onlineLable.Text = "Online";
            }
            else
            {
                onlinePictureBox.Image = Image.FromFile("./Resources/offline-icon-512x512-ly69ez5k.png");
                onlineLable.Text = "Offline";
            }
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            if (IsInternetAvailable == false)
            {
                MessageBox.Show("Please Check your internet connection.");
                return;
            }

            await Search(linkBox.Text);
        }

        private async void downloadBtn_Click(object sender, EventArgs e)
        {
            if (IsInternetAvailable == false)
            {
                MessageBox.Show("Please Check your internet connection.");
                return;
            }

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

        private async void linkBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await Search(linkBox.Text);
            }
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

        private void CheckInternetAvailable()
        {
            try
            {
                using (var ping = new Ping())
                {
                    var reply = ping.Send("8.8.8.8", 1000); // Google DNS
                    IsInternetAvailable = reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                IsInternetAvailable = false;
            }
        }

        #endregion
    }
}
