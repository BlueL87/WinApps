using System;
using System.Collections;
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
        private WMPLib.WindowsMediaPlayer player;
        private ArrayList list;
        private int mode; //0-autoRewind 1-loop 2-showFrame 3-shuffle
        private int currentIndex;
        private bool isPlaying, isChanged;

        public Form1()
        {
            InitializeComponent();
            InitPlayer();
        }

        private void InitPlayer()
        {
            player = new WMPLib.WindowsMediaPlayer();
            list = new ArrayList();
            setVolume(70);
            setMode(0);
            isPlaying = false;
            isChanged = false;
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
            isPlaying = false;
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
            player.URL = (string)lbTitles.SelectedItem;
            if (currentIndex != lbTitles.SelectedIndex)
            {
                isChanged = true;
                currentIndex = lbTitles.SelectedIndex;
            }
            play();
        }

        private void play()
        {
            if (isPlaying && currentIndex != -1 && !isChanged)
                player.controls.play();
            else if(isChanged)
            {
                player.controls.stop();
                player.URL = (string)list[currentIndex];
                player.controls.play();
            }
            else if (list.Count > 0)
            {
                currentIndex = 0;
                player.URL = (string)list[currentIndex];
                player.controls.play();
            }
            isChanged = false;
        }

        private void cleanList()
        {
            lbTitles.Items.Clear();
            list.Clear();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            isPlaying = false;
            currentIndex = -1;
            player.controls.stop();
            cleanList();
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
            ++currentIndex;
            player.controls.stop();
            findNext();
            isChanged = true;
            play();
        }

        private void findNext()
        {
            if (mode != 3)
            {
                ++currentIndex;
                if (currentIndex >= list.Count) currentIndex = 0;
                lbTitles.SelectedIndex = currentIndex;
            }
            else
            {
                Random rnd = new Random();
                currentIndex = rnd.Next(0, list.Count);
                lbTitles.SelectedIndex = currentIndex;
            }
        }
    }
}
