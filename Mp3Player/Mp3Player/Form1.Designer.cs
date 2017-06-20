namespace Mp3Player
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOADLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIDEALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNHIDEALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERSIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUTHORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.lbVolume = new System.Windows.Forms.Label();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.lbMode = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.btnLoadList = new System.Windows.Forms.Button();
            this.lbState = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TrackBar();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSilent = new System.Windows.Forms.Button();
            this.btnLoud = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnSingleRepeat = new System.Windows.Forms.Button();
            this.btnRepeatAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.hIDEALLToolStripMenuItem,
            this.uNHIDEALLToolStripMenuItem,
            this.aBOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.sAVEToolStripMenuItem,
            this.lOADLISTToolStripMenuItem});
            this.fILEToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openFileToolStripMenuItem.Text = "OPEN";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.sAVEToolStripMenuItem.Text = "SAVE LIST";
            this.sAVEToolStripMenuItem.Click += new System.EventHandler(this.sAVEToolStripMenuItem_Click);
            // 
            // lOADLISTToolStripMenuItem
            // 
            this.lOADLISTToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOADLISTToolStripMenuItem.Name = "lOADLISTToolStripMenuItem";
            this.lOADLISTToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.lOADLISTToolStripMenuItem.Text = "LOAD LIST";
            this.lOADLISTToolStripMenuItem.Click += new System.EventHandler(this.lOADLISTToolStripMenuItem_Click);
            // 
            // hIDEALLToolStripMenuItem
            // 
            this.hIDEALLToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hIDEALLToolStripMenuItem.Name = "hIDEALLToolStripMenuItem";
            this.hIDEALLToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.hIDEALLToolStripMenuItem.Text = "HIDE";
            this.hIDEALLToolStripMenuItem.Click += new System.EventHandler(this.hIDEALLToolStripMenuItem_Click);
            // 
            // uNHIDEALLToolStripMenuItem
            // 
            this.uNHIDEALLToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNHIDEALLToolStripMenuItem.Name = "uNHIDEALLToolStripMenuItem";
            this.uNHIDEALLToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.uNHIDEALLToolStripMenuItem.Text = "UNHIDE";
            this.uNHIDEALLToolStripMenuItem.Click += new System.EventHandler(this.uNHIDEALLToolStripMenuItem_Click);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vERSIONToolStripMenuItem,
            this.aUTHORToolStripMenuItem});
            this.aBOUTToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            // 
            // vERSIONToolStripMenuItem
            // 
            this.vERSIONToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vERSIONToolStripMenuItem.Name = "vERSIONToolStripMenuItem";
            this.vERSIONToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.vERSIONToolStripMenuItem.Text = "VERSION";
            this.vERSIONToolStripMenuItem.Click += new System.EventHandler(this.vERSIONToolStripMenuItem_Click);
            // 
            // aUTHORToolStripMenuItem
            // 
            this.aUTHORToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aUTHORToolStripMenuItem.Name = "aUTHORToolStripMenuItem";
            this.aUTHORToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aUTHORToolStripMenuItem.Text = "AUTHOR";
            this.aUTHORToolStripMenuItem.Click += new System.EventHandler(this.aUTHORToolStripMenuItem_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::Mp3Player.Properties.Resources.Danieledesantis_Audio_Video_Outline_Stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Teal;
            this.btnStop.Location = new System.Drawing.Point(196, 106);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(36, 33);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Mp3Player.Properties.Resources.Danieledesantis_Audio_Video_Outline_Play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Teal;
            this.btnPlay.Location = new System.Drawing.Point(100, 106);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(36, 33);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = global::Mp3Player.Properties.Resources.Danieledesantis_Audio_Video_Outline_Pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Teal;
            this.btnPause.Location = new System.Drawing.Point(149, 106);
            this.btnPause.Margin = new System.Windows.Forms.Padding(0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(34, 33);
            this.btnPause.TabIndex = 3;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImage = global::Mp3Player.Properties.Resources.Icons8_Ios7_Arrows_Up;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.Teal;
            this.btnUp.Location = new System.Drawing.Point(893, 100);
            this.btnUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(31, 33);
            this.btnUp.TabIndex = 4;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.BackgroundImage = global::Mp3Player.Properties.Resources.Icons8_Ios7_Arrows_Down;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.Teal;
            this.btnDown.Location = new System.Drawing.Point(936, 100);
            this.btnDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(33, 33);
            this.btnDown.TabIndex = 5;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lbVolume
            // 
            this.lbVolume.BackColor = System.Drawing.Color.Transparent;
            this.lbVolume.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolume.ForeColor = System.Drawing.Color.Black;
            this.lbVolume.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbVolume.Location = new System.Drawing.Point(832, 25);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(192, 33);
            this.lbVolume.TabIndex = 6;
            this.lbVolume.Text = "Volume 70";
            this.lbVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitles
            // 
            this.lbTitles.BackColor = System.Drawing.Color.White;
            this.lbTitles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTitles.Font = new System.Drawing.Font("Lucida Handwriting", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitles.ForeColor = System.Drawing.Color.Black;
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.HorizontalScrollbar = true;
            this.lbTitles.ItemHeight = 16;
            this.lbTitles.Location = new System.Drawing.Point(15, 463);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(268, 224);
            this.lbTitles.TabIndex = 12;
            this.lbTitles.SelectedIndexChanged += new System.EventHandler(this.lbTitles_SelectedIndexChanged);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Transparent;
            this.btnClean.BackgroundImage = global::Mp3Player.Properties.Resources.Icons8_Ios7_Files_Delete_File;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.Teal;
            this.btnClean.Location = new System.Drawing.Point(329, 668);
            this.btnClean.Margin = new System.Windows.Forms.Padding(0);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(31, 33);
            this.btnClean.TabIndex = 13;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::Mp3Player.Properties.Resources.Iconsmind_Outline_Add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Teal;
            this.btnAdd.Location = new System.Drawing.Point(15, 131);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 33);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.Transparent;
            this.btnMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMode.FlatAppearance.BorderSize = 0;
            this.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.ForeColor = System.Drawing.Color.Black;
            this.btnMode.Location = new System.Drawing.Point(631, 309);
            this.btnMode.Margin = new System.Windows.Forms.Padding(0);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(72, 33);
            this.btnMode.TabIndex = 15;
            this.btnMode.Text = "MODE";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // lbMode
            // 
            this.lbMode.BackColor = System.Drawing.Color.Transparent;
            this.lbMode.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.ForeColor = System.Drawing.Color.Black;
            this.lbMode.Location = new System.Drawing.Point(637, 342);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(140, 33);
            this.lbMode.TabIndex = 16;
            this.lbMode.Text = "Standard";
            this.lbMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::Mp3Player.Properties.Resources.Danieledesantis_Audio_Video_Outline_Last_track;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Teal;
            this.btnNext.Location = new System.Drawing.Point(243, 106);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 33);
            this.btnNext.TabIndex = 18;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSaveList
            // 
            this.btnSaveList.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveList.BackgroundImage = global::Mp3Player.Properties.Resources.Iconsmind_Outline_Save;
            this.btnSaveList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveList.FlatAppearance.BorderSize = 0;
            this.btnSaveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveList.ForeColor = System.Drawing.Color.Teal;
            this.btnSaveList.Location = new System.Drawing.Point(15, 40);
            this.btnSaveList.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(44, 33);
            this.btnSaveList.TabIndex = 19;
            this.btnSaveList.UseVisualStyleBackColor = false;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // btnLoadList
            // 
            this.btnLoadList.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadList.BackgroundImage = global::Mp3Player.Properties.Resources.Icons8_Ios7_Programming_Show_Property;
            this.btnLoadList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoadList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadList.FlatAppearance.BorderSize = 0;
            this.btnLoadList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadList.ForeColor = System.Drawing.Color.Teal;
            this.btnLoadList.Location = new System.Drawing.Point(15, 86);
            this.btnLoadList.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadList.Name = "btnLoadList";
            this.btnLoadList.Size = new System.Drawing.Size(44, 33);
            this.btnLoadList.TabIndex = 20;
            this.btnLoadList.UseVisualStyleBackColor = false;
            this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click);
            // 
            // lbState
            // 
            this.lbState.BackColor = System.Drawing.Color.Transparent;
            this.lbState.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.ForeColor = System.Drawing.Color.Black;
            this.lbState.Location = new System.Drawing.Point(412, 40);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(88, 33);
            this.lbState.TabIndex = 21;
            this.lbState.Text = "Waiting";
            this.lbState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPosition
            // 
            this.tbPosition.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbPosition.BackColor = System.Drawing.Color.White;
            this.tbPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPosition.Location = new System.Drawing.Point(71, 47);
            this.tbPosition.Maximum = 100;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(335, 56);
            this.tbPosition.TabIndex = 22;
            this.tbPosition.Scroll += new System.EventHandler(this.tbPosition_Scroll);
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Black;
            this.lbTime.Location = new System.Drawing.Point(85, 70);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(307, 33);
            this.lbTime.TabIndex = 23;
            this.lbTime.Text = "00:00:00 / 00:00:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::Mp3Player.Properties.Resources.Iconsmind_Outline_Remove;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Teal;
            this.btnDelete.Location = new System.Drawing.Point(286, 668);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(31, 33);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSilent
            // 
            this.btnSilent.BackColor = System.Drawing.Color.Transparent;
            this.btnSilent.BackgroundImage = global::Mp3Player.Properties.Resources.Danieledesantis_Audio_Video_Outline_Audio_off;
            this.btnSilent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSilent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSilent.FlatAppearance.BorderSize = 0;
            this.btnSilent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSilent.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSilent.ForeColor = System.Drawing.Color.Teal;
            this.btnSilent.Location = new System.Drawing.Point(936, 58);
            this.btnSilent.Margin = new System.Windows.Forms.Padding(0);
            this.btnSilent.Name = "btnSilent";
            this.btnSilent.Size = new System.Drawing.Size(31, 33);
            this.btnSilent.TabIndex = 25;
            this.btnSilent.UseVisualStyleBackColor = false;
            this.btnSilent.Click += new System.EventHandler(this.btnSilent_Click);
            // 
            // btnLoud
            // 
            this.btnLoud.BackColor = System.Drawing.Color.Transparent;
            this.btnLoud.BackgroundImage = global::Mp3Player.Properties.Resources.Danieledesantis_Audio_Video_Outline_Audio;
            this.btnLoud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoud.FlatAppearance.BorderSize = 0;
            this.btnLoud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoud.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoud.ForeColor = System.Drawing.Color.Teal;
            this.btnLoud.Location = new System.Drawing.Point(893, 58);
            this.btnLoud.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoud.Name = "btnLoud";
            this.btnLoud.Size = new System.Drawing.Size(31, 33);
            this.btnLoud.TabIndex = 26;
            this.btnLoud.UseVisualStyleBackColor = false;
            this.btnLoud.Click += new System.EventHandler(this.btnLoud_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffle.BackgroundImage = global::Mp3Player.Properties.Resources.Danieledesantis_Audio_Video_Outline_Shuffle;
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.Black;
            this.btnShuffle.Location = new System.Drawing.Point(243, 151);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(0);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(40, 33);
            this.btnShuffle.TabIndex = 27;
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnSingleRepeat
            // 
            this.btnSingleRepeat.BackColor = System.Drawing.Color.Transparent;
            this.btnSingleRepeat.BackgroundImage = global::Mp3Player.Properties.Resources.Danieledesantis_Audio_Video_Outline_Replay;
            this.btnSingleRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSingleRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSingleRepeat.FlatAppearance.BorderSize = 0;
            this.btnSingleRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleRepeat.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleRepeat.ForeColor = System.Drawing.Color.Black;
            this.btnSingleRepeat.Location = new System.Drawing.Point(149, 151);
            this.btnSingleRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.btnSingleRepeat.Name = "btnSingleRepeat";
            this.btnSingleRepeat.Size = new System.Drawing.Size(40, 33);
            this.btnSingleRepeat.TabIndex = 28;
            this.btnSingleRepeat.UseVisualStyleBackColor = false;
            this.btnSingleRepeat.Click += new System.EventHandler(this.btnSingleRepeat_Click);
            // 
            // btnRepeatAll
            // 
            this.btnRepeatAll.BackColor = System.Drawing.Color.Transparent;
            this.btnRepeatAll.BackgroundImage = global::Mp3Player.Properties.Resources.Iconsmind_Outline_Repeat_3_2;
            this.btnRepeatAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRepeatAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepeatAll.FlatAppearance.BorderSize = 0;
            this.btnRepeatAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeatAll.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepeatAll.ForeColor = System.Drawing.Color.Black;
            this.btnRepeatAll.Location = new System.Drawing.Point(196, 151);
            this.btnRepeatAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnRepeatAll.Name = "btnRepeatAll";
            this.btnRepeatAll.Size = new System.Drawing.Size(40, 33);
            this.btnRepeatAll.TabIndex = 29;
            this.btnRepeatAll.UseVisualStyleBackColor = false;
            this.btnRepeatAll.Click += new System.EventHandler(this.btnRepeatAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mp3Player.Properties.Resources._529320;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnRepeatAll);
            this.Controls.Add(this.btnSingleRepeat);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnLoud);
            this.Controls.Add(this.btnSilent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.btnLoadList);
            this.Controls.Add(this.btnSaveList);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.lbVolume);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Blue\'s Musicplayer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vERSIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aUTHORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.Button btnLoadList;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOADLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hIDEALLToolStripMenuItem;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.ToolStripMenuItem uNHIDEALLToolStripMenuItem;
        private System.Windows.Forms.TrackBar tbPosition;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSilent;
        private System.Windows.Forms.Button btnLoud;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnSingleRepeat;
        private System.Windows.Forms.Button btnRepeatAll;
    }
}

