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
            this.textTitles = new System.Windows.Forms.ListBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(985, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.sAVEToolStripMenuItem,
            this.lOADLISTToolStripMenuItem});
            this.fILEToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.openFileToolStripMenuItem.Text = "OPEN";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.sAVEToolStripMenuItem.Text = "SAVE LIST";
            this.sAVEToolStripMenuItem.Click += new System.EventHandler(this.sAVEToolStripMenuItem_Click);
            // 
            // lOADLISTToolStripMenuItem
            // 
            this.lOADLISTToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOADLISTToolStripMenuItem.Name = "lOADLISTToolStripMenuItem";
            this.lOADLISTToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.lOADLISTToolStripMenuItem.Text = "LOAD LIST";
            this.lOADLISTToolStripMenuItem.Click += new System.EventHandler(this.lOADLISTToolStripMenuItem_Click);
            // 
            // hIDEALLToolStripMenuItem
            // 
            this.hIDEALLToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hIDEALLToolStripMenuItem.Name = "hIDEALLToolStripMenuItem";
            this.hIDEALLToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.hIDEALLToolStripMenuItem.Text = "HIDE";
            this.hIDEALLToolStripMenuItem.Click += new System.EventHandler(this.hIDEALLToolStripMenuItem_Click);
            // 
            // uNHIDEALLToolStripMenuItem
            // 
            this.uNHIDEALLToolStripMenuItem.Name = "uNHIDEALLToolStripMenuItem";
            this.uNHIDEALLToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.uNHIDEALLToolStripMenuItem.Text = "UNHIDE";
            this.uNHIDEALLToolStripMenuItem.Click += new System.EventHandler(this.uNHIDEALLToolStripMenuItem_Click);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vERSIONToolStripMenuItem,
            this.aUTHORToolStripMenuItem});
            this.aBOUTToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            // 
            // vERSIONToolStripMenuItem
            // 
            this.vERSIONToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vERSIONToolStripMenuItem.Name = "vERSIONToolStripMenuItem";
            this.vERSIONToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.vERSIONToolStripMenuItem.Text = "VERSION";
            this.vERSIONToolStripMenuItem.Click += new System.EventHandler(this.vERSIONToolStripMenuItem_Click);
            // 
            // aUTHORToolStripMenuItem
            // 
            this.aUTHORToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aUTHORToolStripMenuItem.Name = "aUTHORToolStripMenuItem";
            this.aUTHORToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.aUTHORToolStripMenuItem.Text = "AUTHOR";
            this.aUTHORToolStripMenuItem.Click += new System.EventHandler(this.aUTHORToolStripMenuItem_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Maroon;
            this.btnStop.Location = new System.Drawing.Point(817, 57);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(72, 33);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Maroon;
            this.btnPlay.Location = new System.Drawing.Point(659, 57);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(73, 33);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Maroon;
            this.btnPause.Location = new System.Drawing.Point(738, 57);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(73, 33);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.Maroon;
            this.btnUp.Location = new System.Drawing.Point(660, 135);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(72, 33);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDown.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.Maroon;
            this.btnDown.Location = new System.Drawing.Point(660, 174);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(72, 33);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lbVolume
            // 
            this.lbVolume.BackColor = System.Drawing.Color.Transparent;
            this.lbVolume.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolume.ForeColor = System.Drawing.Color.Maroon;
            this.lbVolume.Location = new System.Drawing.Point(410, 218);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(102, 33);
            this.lbVolume.TabIndex = 6;
            this.lbVolume.Text = "Volume 70";
            this.lbVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textTitles
            // 
            this.textTitles.BackColor = System.Drawing.Color.White;
            this.textTitles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitles.ForeColor = System.Drawing.Color.Maroon;
            this.textTitles.FormattingEnabled = true;
            this.textTitles.ItemHeight = 18;
            this.textTitles.Location = new System.Drawing.Point(12, 254);
            this.textTitles.Name = "textTitles";
            this.textTitles.Size = new System.Drawing.Size(500, 202);
            this.textTitles.TabIndex = 12;
            this.textTitles.SelectedIndexChanged += new System.EventHandler(this.lbTitles_SelectedIndexChanged);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Transparent;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.Maroon;
            this.btnClean.Location = new System.Drawing.Point(91, 96);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(73, 33);
            this.btnClean.TabIndex = 13;
            this.btnClean.Text = "CLEAN";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(12, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 33);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.Transparent;
            this.btnMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMode.FlatAppearance.BorderSize = 0;
            this.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.ForeColor = System.Drawing.Color.Maroon;
            this.btnMode.Location = new System.Drawing.Point(660, 96);
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
            this.lbMode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.ForeColor = System.Drawing.Color.Maroon;
            this.lbMode.Location = new System.Drawing.Point(738, 96);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(230, 33);
            this.lbMode.TabIndex = 16;
            this.lbMode.Text = "Standard";
            this.lbMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Maroon;
            this.btnNext.Location = new System.Drawing.Point(895, 57);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(73, 33);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSaveList
            // 
            this.btnSaveList.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveList.FlatAppearance.BorderSize = 0;
            this.btnSaveList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveList.ForeColor = System.Drawing.Color.Maroon;
            this.btnSaveList.Location = new System.Drawing.Point(12, 57);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(73, 33);
            this.btnSaveList.TabIndex = 19;
            this.btnSaveList.Text = "SAVE";
            this.btnSaveList.UseVisualStyleBackColor = false;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // btnLoadList
            // 
            this.btnLoadList.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadList.FlatAppearance.BorderSize = 0;
            this.btnLoadList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadList.ForeColor = System.Drawing.Color.Maroon;
            this.btnLoadList.Location = new System.Drawing.Point(91, 57);
            this.btnLoadList.Name = "btnLoadList";
            this.btnLoadList.Size = new System.Drawing.Size(73, 33);
            this.btnLoadList.TabIndex = 20;
            this.btnLoadList.Text = "LOAD";
            this.btnLoadList.UseVisualStyleBackColor = false;
            this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click);
            // 
            // lbState
            // 
            this.lbState.BackColor = System.Drawing.Color.Transparent;
            this.lbState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.ForeColor = System.Drawing.Color.Maroon;
            this.lbState.Location = new System.Drawing.Point(12, 218);
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
            this.tbPosition.Location = new System.Drawing.Point(12, 159);
            this.tbPosition.Maximum = 100;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(500, 56);
            this.tbPosition.TabIndex = 22;
            this.tbPosition.Scroll += new System.EventHandler(this.tbPosition_Scroll);
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Maroon;
            this.lbTime.Location = new System.Drawing.Point(106, 218);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(252, 33);
            this.lbTime.TabIndex = 23;
            this.lbTime.Text = "00:00:00 / 00:00:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mp3Player.Properties.Resources._529320;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 505);
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
            this.Controls.Add(this.textTitles);
            this.Controls.Add(this.lbVolume);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1003, 552);
            this.MinimumSize = new System.Drawing.Size(1003, 552);
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
        private System.Windows.Forms.ListBox textTitles;
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
    }
}

