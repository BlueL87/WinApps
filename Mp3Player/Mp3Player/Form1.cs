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
        private ArrayList list;
        private int mode; //0-autoRewind 1-loop 2-showFrame 3-shuffle
        private int nextSong, currentSong;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitPlayer();
        }

        private void InitPlayer()
        {
            player = new WMPLib.WindowsMediaPlayer();
            list = new ArrayList();
            timer = new Timer();
            player.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(playStateChange);
            setVolume(70);
            setMode(0);
            resetCurrentAndNext();
            timer.Interval = 10;
            timer.Stop();
            timer.Tick += new EventHandler(playNext);
        }

        private void playStateChange(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                timer.Start();
            }
        }

        private void playNext(object sender, EventArgs e)
        {
            timer.Stop();
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
            mode = i;
            switch (i)
            {
                case 0:
                    lbMode.Text = "Standard Play";
                    break;
                case 1:
                    lbMode.Text = "Loop Single";
                    break;
                case 2:
                    lbMode.Text = "Loop All";
                    break;
                case 3:
                    lbMode.Text = "Shuffle";
                    break;
                default:
                    lbMode.Text = "Standard Play";
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
            player.controls.stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
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
                            foreach (var x in oDlg.FileNames)
                            {
                                list.Add(x);
                                lbTitles.Items.Add(x);
                            }
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
            lbVolume.Text = player.settings.volume.ToString();
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            nextSong = lbTitles.SelectedIndex;
            if (currentSong != nextSong)
                play();
        }

        private void play()
        {
            if (currentSong == nextSong)
                player.controls.play();
            else if (list.Count > 0 && nextSong > 0 && nextSong < list.Count)
            {
                player.controls.stop();
                player.URL = (string)list[nextSong];
                currentSong = nextSong;
                player.controls.play();
            }
            else if (list.Count > 0)
            {
                currentSong = 0;
                nextSong = 0;
                player.URL = (string)list[nextSong];
                player.controls.play();
            }
        }

        private void cleanList()
        {
            lbTitles.Items.Clear();
            list.Clear();
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
            ++mode;
            if (mode > 3) mode = 0;
            setMode(mode);
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
            if (mode == 0 || mode == 2)
            {
                nextSong = currentSong + 1;
                if (nextSong >= list.Count) nextSong = 0;
                if (nextSong < lbTitles.Items.Count) lbTitles.SelectedIndex = nextSong;
            }
            else if (mode == 1)
            {
                nextSong = currentSong;
            }
            else
            {
                Random rnd = new Random();
                nextSong = rnd.Next(0, list.Count);
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
                                list.Add(currentLine);
                                lbTitles.Items.Add(currentLine);
                            }
                            sr.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not play the file. Original error: " + ex.Message);
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

        private void saveListDlg()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "yourList.lst";
            save.Filter = "ListFile| *.lst";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine(_LIST_HEADER);
                for (int i = 0; i < list.Count; ++i)
                    writer.WriteLine(list[i]);
                writer.Dispose();
                writer.Close();
            }
        }
    }
}
