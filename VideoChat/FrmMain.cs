using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoChat
{
    public partial class FrmMain : Form
    {
        public LibVLC _libVLC;
        public MediaPlayer _mp;

        private string currentVideo = "";
        public FrmMain()
        {
            InitializeComponent();

            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            _mp.EndReached += _mp_EndReached;
            videoView1.MediaPlayer = _mp;

        }

        private void _mp_EndReached(object? sender, EventArgs e)
        {
            if (currentVideo == "default.mp4")
            {
                ThreadPool.QueueUserWorkItem(_ =>
                {
                    using (var media = new Media(_libVLC, currentVideo))
                    {
                        _mp.Play(media);
                    }
                });
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //PlayerAudioOrMedaiByFFPlay("default.mp4");
            currentVideo = "default.mp4";
            using (var media = new Media(_libVLC, currentVideo))
            {
                _mp.Play(media);
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mp.Stop();
            _mp.Dispose();
            _libVLC.Dispose();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            //TODO:Whisper语音转文字
            //TODO:文字发送到RWKV
            //TODO:RWKV给出反馈文字
            //TODO:VSTS生成语音
            //TODO:sadtalker生成视频并且播放
            //TODO:播放完毕后切换到默认视频画面
        }
    }
}
