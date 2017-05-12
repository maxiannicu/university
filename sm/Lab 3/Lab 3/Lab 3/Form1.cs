using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCore;
using CSCore.Codecs;
using CSCore.CoreAudioAPI;
using CSCore.DSP;
using CSCore.SoundOut;
using CSCore.Streams;
using CSCore.Streams.Effects;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        private readonly MusicPlayer _musicPlayer = new MusicPlayer();
        private const double MaxDB = 20;
        private readonly ObservableCollection<SoundFilter> _filters = new ObservableCollection<SoundFilter>();

        public Form1()
        {
            InitializeComponent();
            UpdateButtonsStates();
            timer1.Start();

            InitFilters();
        }

        private void InitFilters()
        {
            _filters.Add(new SoundFilter
            {
                Name = "HighpassFilter @4kHz",
                Filter = source => new HighpassFilter(source.WaveFormat.SampleRate, 4000)
            });
            _filters.Add(new SoundFilter
            {
                Name = "HighShelfFilter @4kHz",
                Filter = source => new HighShelfFilter(source.WaveFormat.SampleRate, 4000, 10)
            });
            _filters.Add(new SoundFilter
            {
                Name = "LowpassFilter @1kHz",
                Filter = source => new LowpassFilter(source.WaveFormat.SampleRate, 1000)
            });
            _filters.Add(new SoundFilter
            {
                Name = "LowShelfFilter @1kHz",
                Filter = source => new LowShelfFilter(source.WaveFormat.SampleRate, 1000, 10)
            });
            _filters.Add(new SoundFilter
            {
                Name = "PeakFilter @2kHz; bandWidth = 15; gain = 10dB",
                Filter = source => new PeakFilter(source.WaveFormat.SampleRate, 2000, 15, 10)
            });
            filterList.DataSource = _filters;
            filterList.DisplayMember = "Name";
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (_musicPlayer.PlaybackState == PlaybackState.Playing)
            {
                _musicPlayer.Stop();
            }
            timer1.Stop();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = CodecFactory.SupportedFilesFilterEn;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = fileDialog.FileName;
                _musicPlayer.Open(fileName,new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Render,Role.Multimedia));
            }
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void volumeTrack_ValueChanged(object sender, EventArgs e)
        {
            _musicPlayer.Volume = volumeTrack.Value;
        }

        private void playButton_Click(object sender, EventArgs e)
        {

            if (_musicPlayer.PlaybackState != PlaybackState.Playing)
            {
                _musicPlayer.Play();
            }
            else
            {
                _musicPlayer.Pause();
            }
            UpdateButtonsStates();
        }

        private void UpdateButtonsStates()
        {
            playButton.Text = _musicPlayer.PlaybackState == PlaybackState.Playing ? "Pause" : "Play";
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_musicPlayer.Length.Ticks > 0)
            {
                UpdateSeekInfo();
            }
        }

        private void UpdateSeekInfo()
        {
            seekBar.Value = Convert.ToInt32(_musicPlayer.Position.Ticks * 100 / _musicPlayer.Length.Ticks);
            durationText.Text = String.Format("{0} / {1}", _musicPlayer.Position.ToPrettyFormat(),
                _musicPlayer.Length.ToPrettyFormat());
        }

        private void seekBar_Scroll(object sender, EventArgs e)
        {
            double perc = seekBar.Value / (double)seekBar.Maximum;
            TimeSpan position = TimeSpan.FromMilliseconds(_musicPlayer.Length.TotalMilliseconds * perc);
            _musicPlayer.Position = position;
            UpdateSeekInfo();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            var trackbar = sender as TrackBar;
            if (_musicPlayer.Equalizer != null && trackbar != null)
            {
                double perc = (trackbar.Value / (double)trackbar.Maximum);
                var value = (float)(perc * MaxDB);

                //the tag of the trackbar contains the index of the filter
                int filterIndex = Int32.Parse((string)trackbar.Tag);
                EqualizerFilter filter = _musicPlayer.Equalizer.SampleFilters[filterIndex];
                filter.AverageGainDB = value;
            }
        }

        private void filterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_musicPlayer.Ready)
            {
                var soundFilter = filterList.SelectedItem as SoundFilter;
                _musicPlayer.SetFilter(soundFilter.Filter.Invoke(_musicPlayer.Source));
            }
        }
    }
}
