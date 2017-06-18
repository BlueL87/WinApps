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
        private string currentSong;

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
        }

        private void setMode(int i)
        {
            mode = i;
            switch (i)
            {
                case 0:
                    player.settings.setMode("autoRewind", true);
                    lbMode.Text = "Auto Rewind";
                    break;
                case 1:
                    player.settings.setMode("loop", true);
                    lbMode.Text = "Loop";
                    break;
                case 2:
                    player.settings.setMode("showFrame", true);
                    lbMode.Text = "Show Frame";
                    break;
                case 3:
                    player.settings.setMode("shuffle", true);
                    lbMode.Text = "Shuffle";
                    break;
                default:
                    player.settings.setMode("autoRewind", true);
                    lbMode.Text = "autoRewind";
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
            player.controls.stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (currentSong == "")
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
            currentSong = (string)lbTitles.SelectedItem;
            if (currentSong != "")
            {
                player.URL = currentSong;
                play();
            }
        }

        private void play()
        {
            if (currentSong != "")
                player.controls.play();
            else if (list.Count > 0)
            {
                currentSong = (string)list[0];
                player.URL = currentSong;
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
            player.controls.stop();
            currentSong = "";
            player.URL = currentSong;
            cleanList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InitMusicSelectionDlg();
        }

        private void timerCheckFinished_Tick(object sender, EventArgs e)
        {

        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            ++mode;
            if (mode > 3) mode = 0;
            setMode(mode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
