using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3Player
{
    public partial class Form1 : Form
    {
        private WMPLib.WindowsMediaPlayer wplayer;

        public Form1()
        {
            InitializeComponent();
            InitPlayer();
        }

        private void InitPlayer()
        {
            wplayer = new WMPLib.WindowsMediaPlayer();
            setVolume(70);
        }

        private void aUTHORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "It is a free mp3 player made by Steve";
            string caption = "Author";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
        }

        private void vERSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Version  Luna-1.0.0";
            string caption = "Version";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitMusicSelectionDlg();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (wplayer != null)
                wplayer.controls.stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (wplayer != null)
                wplayer.controls.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (wplayer.URL == null || wplayer.URL == "")
                InitMusicSelectionDlg();
            else
                wplayer.controls.play();

        }

        private void InitMusicSelectionDlg()
        {
            System.IO.Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            wplayer.URL = openFileDialog1.FileName;
                            wplayer.controls.play();
                            setTitle("");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not play the file. Original error: " + ex.Message);
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (wplayer != null && wplayer.settings.volume < 100)
                setVolume(wplayer.settings.volume+5);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (wplayer != null && wplayer.settings.volume > 1)
                setVolume(wplayer.settings.volume-5);
        }

        private void setVolume(int value)
        {
            wplayer.settings.volume = value;
            lbVolume.Text = wplayer.settings.volume.ToString();
        }

        private void setTitle(string title)
        {
            lbTitle.Text = title;
        }
    }
}
