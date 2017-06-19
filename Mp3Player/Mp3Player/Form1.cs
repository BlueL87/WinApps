using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3Player
{
    public partial class Form1 : Form
    {
        private const string _LIST_HEADER = "LIST_STEVE_PLAYER";
        private WMPLib.WindowsMediaPlayer player;
        private ArrayList playlist;
        private int playMode;
        private int nextSong, currentSong;
        private Timer songFinishedTimer, playingTimer;
        private bool standardModePlayFinished;

        public Form1()
        {
            InitializeComponent();
            InitPlayer();
        }

        private void InitPlayer()
        {
            player = new WMPLib.WindowsMediaPlayer();
            playlist = new ArrayList();
            songFinishedTimer = new Timer();
            playingTimer = new Timer();
            player.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(playStateChange);
            setVolume(70);
            setMode(0);
            resetCurrentAndNext();
            songFinishedTimer.Interval = 10;
            songFinishedTimer.Stop();
            songFinishedTimer.Tick += new EventHandler(playNext);
            standardModePlayFinished = false;
        }

        private void playStateChange(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                songFinishedTimer.Start();
            }
            if (NewState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                lbState.Text = "Playing";
            }
            if (NewState == (int)WMPLib.WMPPlayState.wmppsPaused)
            {
                lbState.Text = "Paused";
            }
            if (NewState == (int)WMPLib.WMPPlayState.wmppsWaiting)
            {
                lbState.Text = "Waiting";
            }
            if (NewState == (int)WMPLib.WMPPlayState.wmppsStopped)
            {
                lbState.Text = "Stopped";
            }
        }

        private void playNext(object sender, EventArgs e)
        {
            songFinishedTimer.Stop();
            findNext();
            play();
        }

        private void resetCurrentAndNext()
        {
            currentSong = -1;
            nextSong = -2;
        }

        private void setMode(int i)
        {
            playMode = i;
            switch (i)
            {
                case 0:
                    lbMode.Text = "Standard";
                    break;
                case 1:
                    lbMode.Text = "Single";
                    break;
                case 2:
                    lbMode.Text = "Loop All";
                    break;
                case 3:
                    lbMode.Text = "Shuffle";
                    break;
                default:
                    lbMode.Text = "Standard";
                    break;
            }
        }

        private void aUTHORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "It is a free mp3 player made by Steve Liu\nContact: s7nger@gmail.com";
            string caption = "Author";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
        }

        private void vERSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Version  Luna-1.0.1";
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
            playingTimer.Stop();
            player.controls.stop();
            lbTime.Text = "00:00:00 / 00:00:00";
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            playingTimer.Stop();
            player.controls.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0)
            {
                cleanList();
                InitMusicSelectionDlg();
            }
            play();
        }

        private void InitMusicSelectionDlg()
        {
            System.IO.Stream myStream = null;
            OpenFileDialog oDlg = new OpenFileDialog();
            oDlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            oDlg.Multiselect = true;
            currentSong = -3;

            if (oDlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = oDlg.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            foreach (string x in oDlg.FileNames)
                            {
                                if (x.Length < 5) continue;
                                else if (x.Substring(x.Length - 4) != ".mp3"
                                    && x.Substring(x.Length - 4) != ".wma"
                                    && x.Substring(x.Length - 5) != ".flac"
                                    && x.Substring(x.Length - 4) != ".mp4"
                                    && x.Substring(x.Length - 4) != ".avi"
                                    ) continue;
                                playlist.Add(x);
                                lbTitles.Items.Add(x);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to play the file! Error: " + ex.Message);
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (player.settings.volume < 100)
                setVolume(player.settings.volume + 5);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (player.settings.volume > 1)
                setVolume(player.settings.volume - 5);
        }

        private void setVolume(int value)
        {
            player.settings.volume = value;
            lbVolume.Text = "Volume " + player.settings.volume.ToString();
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            nextSong = lbTitles.SelectedIndex;
            if (currentSong != nextSong)
                play();
        }

        private void play()
        {
            if (standardModePlayFinished)
            {
                standardModePlayFinished = false;
                return;
            }
            if (currentSong == nextSong)
                player.controls.play();
            else if (playlist.Count > 0 && nextSong > 0 && nextSong < playlist.Count)
            {
                player.controls.stop();
                player.URL = (string)playlist[nextSong];
                currentSong = nextSong;
                player.controls.play();
            }
            else if (playlist.Count > 0)
            {
                currentSong = 0;
                nextSong = 0;
                player.URL = (string)playlist[nextSong];
                player.controls.play();
            }
            if (nextSong >= 0 && nextSong < playlist.Count)
            {
                lbTitles.SelectedIndex = nextSong;
                playingTimer.Start();
                playingTimer.Interval = 10;
                playingTimer.Tick += new EventHandler(playingStatus);
            }
        }

        private void playingStatus(object sender, EventArgs e)
        {
            try
            {
                double currentPos = player.controls.currentPosition;
                double length = player.currentMedia.duration;
                if (length <= 0) return;
                double currentPercentage = currentPos / length * 100;
                tbPosition.Value = (int)currentPercentage;
                TimeSpan timeFormatCurrent = TimeSpan.FromSeconds(currentPos);
                TimeSpan timeFormatLength = TimeSpan.FromSeconds(length);
                lbTime.Text = timeFormatCurrent.ToString(@"hh\:mm\:ss") + " / " + timeFormatLength.ToString(@"hh\:mm\:ss");
            }
            catch (Exception ex)
            {
                //player is null ptr
                songFinishedTimer.Stop();
            }
        }

        private void cleanList()
        {
            lbTitles.Items.Clear();
            playlist.Clear();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            currentSong = 0;
            nextSong = 0;
            player.controls.stop();
            cleanList();
            player.URL = "empty_mp3.mp3";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InitMusicSelectionDlg();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            ++playMode;
            if (playMode > 3) playMode = 0;
            setMode(playMode);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            findNext();
            play();
        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            saveListDlg();
        }

        private void btnLoadList_Click(object sender, EventArgs e)
        {
            cleanList();
            loadListDlg();
            play();
        }

        private void findNext()
        {
            if (playMode == 0)
            {
                nextSong = currentSong + 1;
                if (nextSong >= playlist.Count) standardModePlayFinished = true;
            }
            else if (playMode == 1)
            {
                nextSong = currentSong;
            }
            else if (playMode == 2)
            {
                nextSong = currentSong + 1;
                if (nextSong >= playlist.Count) nextSong = 0;
                if (nextSong < lbTitles.Items.Count) lbTitles.SelectedIndex = nextSong;
            }
            else
            {
                Random rnd = new Random();
                nextSong = rnd.Next(0, playlist.Count);
                if (nextSong < lbTitles.Items.Count) lbTitles.SelectedIndex = nextSong;
            }
        }

        private void loadListDlg()
        {
            System.IO.Stream myStream = null;
            OpenFileDialog oDlg = new OpenFileDialog();
            oDlg.Filter = "ListFile (*.lst)|*.lst";
            oDlg.Multiselect = false;
            currentSong = -3;
            if (oDlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = oDlg.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader sr = new StreamReader(oDlg.FileName);
                            string currentLine = sr.ReadLine();
                            if (currentLine != _LIST_HEADER)
                            {
                                sr.Close();
                                return;
                            }
                            while (!sr.EndOfStream)
                            {
                                currentLine = sr.ReadLine();
                                playlist.Add(currentLine);
                                lbTitles.Items.Add(currentLine);
                            }
                            sr.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load the list! Error: " + ex.Message);
                }
            }
        }

        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveListDlg();
        }

        private void lOADLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleanList();
            loadListDlg();
            play();
        }

        private void hIDEALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void saveListDlg()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "yourList.lst";
            save.Filter = "ListFile| *.lst";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine(_LIST_HEADER);
                for (int i = 0; i < playlist.Count; ++i)
                    writer.WriteLine(playlist[i]);
                writer.Dispose();
                writer.Close();
            }
        }

        private void hideAll()
        {
            btnAdd.Hide();
            btnClean.Hide();
            btnDown.Hide();
            btnLoadList.Hide();
            btnMode.Hide();
            btnNext.Hide();
            btnPause.Hide();
            btnPlay.Hide();
            btnSaveList.Hide();
            btnStop.Hide();
            btnUp.Hide();
            lbMode.Hide();
            lbState.Hide();
            lbVolume.Hide();
            lbTitles.Hide();
            tbPosition.Hide();
            lbTime.Hide();
            btnDelete.Hide();
        }

        private void tbPosition_Scroll(object sender, EventArgs e)
        {
            try
            {
                double length = player.currentMedia.duration;
                if (length <= 0) return;
                player.controls.currentPosition = tbPosition.Value * length / 100;
            }
            catch (Exception ex)
            {
                //do nothing
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0) return;
            player.controls.stop();
            playlist.RemoveAt(lbTitles.SelectedIndex);
            lbTitles.Items.RemoveAt(lbTitles.SelectedIndex);
            if (playlist.Count > 1)
            {
                findNext();
                lbTitles.SelectedIndex = nextSong;
                play();
            }
        }

        private void uNHIDEALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAll();
        }

        private void showAll()
        {
            btnAdd.Show();
            btnClean.Show();
            btnDown.Show();
            btnLoadList.Show();
            btnMode.Show();
            btnNext.Show();
            btnPause.Show();
            btnPlay.Show();
            btnSaveList.Show();
            btnStop.Show();
            btnUp.Show();
            lbMode.Show();
            lbState.Show();
            lbVolume.Show();
            lbTitles.Show();
            tbPosition.Show();
            lbTime.Show();
            btnDelete.Show();
        }

    }
}
