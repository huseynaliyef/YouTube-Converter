using System.Windows.Forms;

namespace YoutubeVideoDownloader
{
    partial class YoutubeVideoConverterToMp3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AutoSize = false;
            FormBorderStyle = FormBorderStyle.FixedSingle; 
            MaximizeBox = false;
            MinimizeBox = true;
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoutubeVideoConverterToMp3));
            linkBox = new System.Windows.Forms.TextBox();
            searchBtn = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            downloadedMusicLabel = new System.Windows.Forms.Label();
            videoLabel = new System.Windows.Forms.Label();
            musicDownloadBtn = new System.Windows.Forms.Button();
            videoDownloadBtn = new System.Windows.Forms.Button();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(components);
            contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(components);
            contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // linkBox
            // 
            linkBox.Location = new System.Drawing.Point(600, 280);
            linkBox.Name = "linkBox";
            linkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            linkBox.Size = new System.Drawing.Size(508, 22);
            linkBox.TabIndex = 0;
            // 
            // searchBtn
            // 
            searchBtn.Location = new System.Drawing.Point(760, 350);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new System.Drawing.Size(176, 32);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.youtube_logo_hd_8;
            pictureBox1.Location = new System.Drawing.Point(700, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(266, 158);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.to_png_7_png_image;
            pictureBox2.Location = new System.Drawing.Point(630, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(97, 54);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.MP3_Logo;
            pictureBox3.Location = new System.Drawing.Point(950, 120);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(127, 77);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(600, 250);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 15);
            label1.TabIndex = 6;
            label1.Text = "Paste Link: ";
            // 
            // downloadedMusicLabel
            // 
            downloadedMusicLabel.AutoSize = true;
            downloadedMusicLabel.Location = new System.Drawing.Point(600, 549);
            downloadedMusicLabel.Name = "downloadedMusicLabel";
            downloadedMusicLabel.Size = new System.Drawing.Size(0, 14);
            downloadedMusicLabel.TabIndex = 7;
            // 
            // videoLabel
            // 
            videoLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            videoLabel.Location = new System.Drawing.Point(680, 400);
            videoLabel.Name = "videoLabel";
            videoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            videoLabel.Size = new System.Drawing.Size(334, 20);
            videoLabel.TabIndex = 8;
            videoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // musicDownloadBtn
            // 
            musicDownloadBtn.Location = new System.Drawing.Point(790, 430);
            musicDownloadBtn.Name = "musicDownloadBtn";
            musicDownloadBtn.Size = new System.Drawing.Size(114, 23);
            musicDownloadBtn.TabIndex = 10;
            musicDownloadBtn.Text = "Download mp3";
            musicDownloadBtn.UseVisualStyleBackColor = true;
            musicDownloadBtn.Click += musicDownloadBtn_Click;
            // 
            // videoDownloadBtn
            // 
            videoDownloadBtn.Location = new System.Drawing.Point(790, 470);
            videoDownloadBtn.Name = "videoDownloadBtn";
            videoDownloadBtn.Size = new System.Drawing.Size(114, 23);
            videoDownloadBtn.TabIndex = 11;
            videoDownloadBtn.Text = "Dwonload mp4";
            videoDownloadBtn.UseVisualStyleBackColor = true;
            videoDownloadBtn.Click += videoDownloadBtn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // YoutubeVideoConverterToMp3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1794, 736);
            Controls.Add(videoDownloadBtn);
            Controls.Add(musicDownloadBtn);
            Controls.Add(videoLabel);
            Controls.Add(downloadedMusicLabel);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(searchBtn);
            Controls.Add(linkBox);
            Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "YoutubeVideoConverterToMp3";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            Text = "YoutubeVideoConverterToMp3";
            Load += YoutubeVideoConverterToMp3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label downloadedMusicLabel;
        private System.Windows.Forms.Label videoLabel;
        private System.Windows.Forms.Button musicDownloadBtn;
        private System.Windows.Forms.Button videoDownloadBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
