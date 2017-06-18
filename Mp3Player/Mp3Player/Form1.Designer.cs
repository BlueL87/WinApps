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
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERSIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUTHORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.lbVolume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMode = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.aBOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.openFileToolStripMenuItem.Text = "OPEN";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vERSIONToolStripMenuItem,
            this.aUTHORToolStripMenuItem});
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            // 
            // vERSIONToolStripMenuItem
            // 
            this.vERSIONToolStripMenuItem.Name = "vERSIONToolStripMenuItem";
            this.vERSIONToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.vERSIONToolStripMenuItem.Text = "VERSION";
            this.vERSIONToolStripMenuItem.Click += new System.EventHandler(this.vERSIONToolStripMenuItem_Click);
            // 
            // aUTHORToolStripMenuItem
            // 
            this.aUTHORToolStripMenuItem.Name = "aUTHORToolStripMenuItem";
            this.aUTHORToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.aUTHORToolStripMenuItem.Text = "AUTHOR";
            this.aUTHORToolStripMenuItem.Click += new System.EventHandler(this.aUTHORToolStripMenuItem_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Aqua;
            this.btnStop.Location = new System.Drawing.Point(255, 73);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 33);
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
            this.btnPlay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Crimson;
            this.btnPlay.Location = new System.Drawing.Point(642, 73);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(88, 33);
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
            this.btnPause.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Aqua;
            this.btnPause.Location = new System.Drawing.Point(349, 190);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(107, 33);
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
            this.btnUp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.Aqua;
            this.btnUp.Location = new System.Drawing.Point(349, 336);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(88, 33);
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
            this.btnDown.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.Aqua;
            this.btnDown.Location = new System.Drawing.Point(349, 379);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(88, 33);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lbVolume
            // 
            this.lbVolume.BackColor = System.Drawing.Color.Transparent;
            this.lbVolume.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolume.ForeColor = System.Drawing.Color.Aqua;
            this.lbVolume.Location = new System.Drawing.Point(251, 379);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(92, 33);
            this.lbVolume.TabIndex = 6;
            this.lbVolume.Text = "70";
            this.lbVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(251, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Volume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitles
            // 
            this.lbTitles.BackColor = System.Drawing.Color.Black;
            this.lbTitles.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitles.ForeColor = System.Drawing.Color.Gold;
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ItemHeight = 15;
            this.lbTitles.Location = new System.Drawing.Point(349, 73);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(287, 109);
            this.lbTitles.TabIndex = 12;
            this.lbTitles.SelectedIndexChanged += new System.EventHandler(this.lbTitles_SelectedIndexChanged);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Transparent;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.Aqua;
            this.btnClean.Location = new System.Drawing.Point(349, 229);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(107, 33);
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
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Crimson;
            this.btnAdd.Location = new System.Drawing.Point(642, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 33);
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
            this.btnMode.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.ForeColor = System.Drawing.Color.Crimson;
            this.btnMode.Location = new System.Drawing.Point(529, 190);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(107, 33);
            this.btnMode.TabIndex = 15;
            this.btnMode.Text = "MODE";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(525, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMode
            // 
            this.lbMode.BackColor = System.Drawing.Color.Transparent;
            this.lbMode.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.ForeColor = System.Drawing.Color.Crimson;
            this.lbMode.Location = new System.Drawing.Point(525, 379);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(236, 33);
            this.lbMode.TabIndex = 16;
            this.lbMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Crimson;
            this.btnNext.Location = new System.Drawing.Point(642, 112);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 33);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mp3Player.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 505);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbVolume);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(978, 552);
            this.MinimumSize = new System.Drawing.Size(978, 552);
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Button btnNext;
    }
}

