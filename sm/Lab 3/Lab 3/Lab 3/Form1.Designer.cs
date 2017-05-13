using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.seekBar = new System.Windows.Forms.TrackBar();
            this.volumeTrack = new System.Windows.Forms.TrackBar();
            this.playButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.durationText = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.trackBar10 = new System.Windows.Forms.TrackBar();
            this.filterList = new System.Windows.Forms.ListBox();
            this.pitch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.peakUpdater = new System.Windows.Forms.Timer(this.components);
            this.peakBar = new Lab_3.PeakBar();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrack)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).BeginInit();
            this.SuspendLayout();
            // 
            // seekBar
            // 
            this.seekBar.Location = new System.Drawing.Point(100, 65);
            this.seekBar.Maximum = 100;
            this.seekBar.Name = "seekBar";
            this.seekBar.Size = new System.Drawing.Size(281, 45);
            this.seekBar.TabIndex = 0;
            this.seekBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.seekBar.Scroll += new System.EventHandler(this.seekBar_Scroll);
            // 
            // volumeTrack
            // 
            this.volumeTrack.Location = new System.Drawing.Point(10, 116);
            this.volumeTrack.Maximum = 100;
            this.volumeTrack.Name = "volumeTrack";
            this.volumeTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeTrack.Size = new System.Drawing.Size(45, 104);
            this.volumeTrack.TabIndex = 1;
            this.volumeTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.volumeTrack.Value = 100;
            this.volumeTrack.ValueChanged += new System.EventHandler(this.volumeTrack_ValueChanged);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(10, 65);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(84, 45);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // durationText
            // 
            this.durationText.AutoSize = true;
            this.durationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationText.Location = new System.Drawing.Point(387, 76);
            this.durationText.Name = "durationText";
            this.durationText.Size = new System.Drawing.Size(39, 20);
            this.durationText.TabIndex = 8;
            this.durationText.Text = "0 / 0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.trackBar1);
            this.flowLayoutPanel1.Controls.Add(this.trackBar2);
            this.flowLayoutPanel1.Controls.Add(this.trackBar3);
            this.flowLayoutPanel1.Controls.Add(this.trackBar4);
            this.flowLayoutPanel1.Controls.Add(this.trackBar5);
            this.flowLayoutPanel1.Controls.Add(this.trackBar6);
            this.flowLayoutPanel1.Controls.Add(this.trackBar7);
            this.flowLayoutPanel1.Controls.Add(this.trackBar8);
            this.flowLayoutPanel1.Controls.Add(this.trackBar9);
            this.flowLayoutPanel1.Controls.Add(this.trackBar10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(108, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(318, 101);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(3, 3);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(25, 97);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Tag = "0";
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(34, 3);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = -100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(25, 97);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Tag = "1";
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.AutoSize = false;
            this.trackBar3.Location = new System.Drawing.Point(65, 3);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Minimum = -100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(25, 97);
            this.trackBar3.TabIndex = 3;
            this.trackBar3.Tag = "2";
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar4
            // 
            this.trackBar4.AutoSize = false;
            this.trackBar4.Location = new System.Drawing.Point(96, 3);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Minimum = -100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(25, 97);
            this.trackBar4.TabIndex = 4;
            this.trackBar4.Tag = "3";
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar4.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar5
            // 
            this.trackBar5.AutoSize = false;
            this.trackBar5.Location = new System.Drawing.Point(127, 3);
            this.trackBar5.Maximum = 100;
            this.trackBar5.Minimum = -100;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar5.Size = new System.Drawing.Size(25, 97);
            this.trackBar5.TabIndex = 5;
            this.trackBar5.Tag = "4";
            this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar5.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar6
            // 
            this.trackBar6.AutoSize = false;
            this.trackBar6.Location = new System.Drawing.Point(158, 3);
            this.trackBar6.Maximum = 100;
            this.trackBar6.Minimum = -100;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar6.Size = new System.Drawing.Size(25, 97);
            this.trackBar6.TabIndex = 6;
            this.trackBar6.Tag = "5";
            this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar6.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar7
            // 
            this.trackBar7.AutoSize = false;
            this.trackBar7.Location = new System.Drawing.Point(189, 3);
            this.trackBar7.Maximum = 100;
            this.trackBar7.Minimum = -100;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar7.Size = new System.Drawing.Size(25, 97);
            this.trackBar7.TabIndex = 7;
            this.trackBar7.Tag = "6";
            this.trackBar7.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar7.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar8
            // 
            this.trackBar8.AutoSize = false;
            this.trackBar8.Location = new System.Drawing.Point(220, 3);
            this.trackBar8.Maximum = 100;
            this.trackBar8.Minimum = -100;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar8.Size = new System.Drawing.Size(25, 97);
            this.trackBar8.TabIndex = 8;
            this.trackBar8.Tag = "7";
            this.trackBar8.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar8.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar9
            // 
            this.trackBar9.AutoSize = false;
            this.trackBar9.Location = new System.Drawing.Point(251, 3);
            this.trackBar9.Maximum = 100;
            this.trackBar9.Minimum = -100;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar9.Size = new System.Drawing.Size(25, 97);
            this.trackBar9.TabIndex = 9;
            this.trackBar9.Tag = "8";
            this.trackBar9.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar9.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar10
            // 
            this.trackBar10.AutoSize = false;
            this.trackBar10.Location = new System.Drawing.Point(282, 3);
            this.trackBar10.Maximum = 100;
            this.trackBar10.Minimum = -100;
            this.trackBar10.Name = "trackBar10";
            this.trackBar10.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar10.Size = new System.Drawing.Size(25, 97);
            this.trackBar10.TabIndex = 10;
            this.trackBar10.Tag = "9";
            this.trackBar10.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar10.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // filterList
            // 
            this.filterList.FormattingEnabled = true;
            this.filterList.Location = new System.Drawing.Point(306, 237);
            this.filterList.Name = "filterList";
            this.filterList.Size = new System.Drawing.Size(120, 95);
            this.filterList.TabIndex = 10;
            this.filterList.SelectedIndexChanged += new System.EventHandler(this.filterList_SelectedIndexChanged);
            // 
            // pitch
            // 
            this.pitch.Location = new System.Drawing.Point(53, 237);
            this.pitch.Name = "pitch";
            this.pitch.Size = new System.Drawing.Size(83, 20);
            this.pitch.TabIndex = 11;
            this.pitch.TextChanged += new System.EventHandler(this.pitch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pitch";
            // 
            // peakUpdater
            // 
            this.peakUpdater.Enabled = true;
            this.peakUpdater.Interval = 10;
            this.peakUpdater.Tick += new System.EventHandler(this.peakUpdater_Tick);
            // 
            // peakBar
            // 
            this.peakBar.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.peakBar.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.peakBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.peakBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.peakBar.Location = new System.Drawing.Point(10, 27);
            this.peakBar.Max = 100;
            this.peakBar.Min = 0;
            this.peakBar.Name = "peakBar";
            this.peakBar.Size = new System.Drawing.Size(416, 30);
            this.peakBar.TabIndex = 13;
            this.peakBar.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 383);
            this.Controls.Add(this.peakBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pitch);
            this.Controls.Add(this.filterList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.durationText);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.volumeTrack);
            this.Controls.Add(this.seekBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrack)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar seekBar;
        private TrackBar volumeTrack;
        private Button playButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Timer timer1;
        private Label durationText;
        private FlowLayoutPanel flowLayoutPanel1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private TrackBar trackBar5;
        private TrackBar trackBar6;
        private TrackBar trackBar7;
        private TrackBar trackBar8;
        private TrackBar trackBar9;
        private TrackBar trackBar10;
        private ListBox filterList;
        private TextBox pitch;
        private Label label1;
        private Timer peakUpdater;
        private PeakBar peakBar;
    }
}

