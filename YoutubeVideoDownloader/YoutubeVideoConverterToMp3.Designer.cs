﻿using System.Windows.Forms;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoutubeVideoConverterToMp3));
            linkBox = new TextBox();
            searchBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            downloadedMusicLabel = new Label();
            videoLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            contextMenuStrip4 = new ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            downloadBtn = new Button();
            downloadComboBox = new ComboBox();
            onlinePictureBox = new PictureBox();
            onlineLable = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)onlinePictureBox).BeginInit();
            SuspendLayout();
            // 
            // linkBox
            // 
            linkBox.BackColor = SystemColors.Control;
            linkBox.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkBox.Location = new Point(160, 269);
            linkBox.Name = "linkBox";
            linkBox.RightToLeft = RightToLeft.No;
            linkBox.Size = new Size(514, 27);
            linkBox.TabIndex = 0;
            linkBox.KeyDown += linkBox_KeyDown;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Transparent;
            searchBtn.BackgroundImageLayout = ImageLayout.None;
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.Location = new Point(639, 271);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(32, 21);
            searchBtn.TabIndex = 1;
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(139, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(347, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(97, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(488, 109);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(127, 77);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(159, 250);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 6;
            label1.Text = "Paste Link: ";
            // 
            // downloadedMusicLabel
            // 
            downloadedMusicLabel.AutoSize = true;
            downloadedMusicLabel.Location = new Point(13, 535);
            downloadedMusicLabel.Name = "downloadedMusicLabel";
            downloadedMusicLabel.Size = new Size(0, 14);
            downloadedMusicLabel.TabIndex = 7;
            // 
            // videoLabel
            // 
            videoLabel.Cursor = Cursors.IBeam;
            videoLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            videoLabel.Location = new Point(160, 310);
            videoLabel.Name = "videoLabel";
            videoLabel.RightToLeft = RightToLeft.No;
            videoLabel.Size = new Size(334, 20);
            videoLabel.TabIndex = 8;
            videoLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new Size(61, 4);
            // 
            // downloadBtn
            // 
            downloadBtn.BackColor = Color.Transparent;
            downloadBtn.Cursor = Cursors.Hand;
            downloadBtn.FlatAppearance.BorderColor = Color.Silver;
            downloadBtn.FlatStyle = FlatStyle.Flat;
            downloadBtn.Image = (Image)resources.GetObject("downloadBtn.Image");
            downloadBtn.Location = new Point(280, 388);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(172, 33);
            downloadBtn.TabIndex = 18;
            downloadBtn.UseVisualStyleBackColor = false;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // downloadComboBox
            // 
            downloadComboBox.BackColor = Color.White;
            downloadComboBox.Cursor = Cursors.Hand;
            downloadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            downloadComboBox.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            downloadComboBox.FormattingEnabled = true;
            downloadComboBox.ImeMode = ImeMode.NoControl;
            downloadComboBox.Location = new Point(458, 388);
            downloadComboBox.Name = "downloadComboBox";
            downloadComboBox.Size = new Size(73, 33);
            downloadComboBox.TabIndex = 13;
            // 
            // onlinePictureBox
            // 
            onlinePictureBox.Location = new Point(707, 12);
            onlinePictureBox.Name = "onlinePictureBox";
            onlinePictureBox.Size = new Size(14, 16);
            onlinePictureBox.TabIndex = 19;
            onlinePictureBox.TabStop = false;
            // 
            // onlineLable
            // 
            onlineLable.AutoSize = true;
            onlineLable.Location = new Point(722, 11);
            onlineLable.Name = "onlineLable";
            onlineLable.Size = new Size(0, 14);
            onlineLable.TabIndex = 20;
            // 
            // YoutubeVideoConverterToMp3
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(onlineLable);
            Controls.Add(onlinePictureBox);
            Controls.Add(downloadComboBox);
            Controls.Add(downloadBtn);
            Controls.Add(videoLabel);
            Controls.Add(downloadedMusicLabel);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(searchBtn);
            Controls.Add(linkBox);
            Font = new Font("Verdana", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "YoutubeVideoConverterToMp3";
            RightToLeft = RightToLeft.No;
            Text = "YoutubeVideoConverterToMp3";
            Load += YoutubeVideoConverterToMp3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)onlinePictureBox).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button downloadBtn;
        private ComboBox downloadComboBox;
        private PictureBox onlinePictureBox;
        private Label onlineLable;
    }
}
