using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore;
using CSCore.Codecs;
using CSCore.CoreAudioAPI;
using CSCore.DSP;
using CSCore.SoundOut;
using CSCore.Streams.Effects;

namespace Lab_3
{

    public class MusicPlayer : Component
    {
        private ISoundOut _soundOut;
        private BiQuadFilterSource _sampleSource;

        private Equalizer _equalizer;

        public event EventHandler<PlaybackStoppedEventArgs> PlaybackStopped;

        public PlaybackState PlaybackState
        {
            get
            {
                if (_soundOut != null)
                    return _soundOut.PlaybackState;
                return PlaybackState.Stopped;
            }
        }

        public TimeSpan Position
        {
            get
            {
                if (_sampleSource != null)
                    return _sampleSource.GetPosition();
                return TimeSpan.Zero;
            }
            set
            {
                if (_sampleSource != null)
                    _sampleSource.SetPosition(value);
            }
        }

        public TimeSpan Length
        {
            get
            {
                if (_sampleSource != null)
                    return _sampleSource.GetLength();
                return TimeSpan.Zero;
            }
        }

        public int Volume
        {
            get
            {
                if (_soundOut != null)
                    return Math.Min(100, Math.Max((int)(_soundOut.Volume * 100), 0));
                return 100;
            }
            set
            {
                if (_soundOut != null)
                {
                    _soundOut.Volume = Math.Min(1.0f, Math.Max(value / 100f, 0f));
                }
            }
        }

        public bool Ready => _sampleSource != null;

        public ISampleSource Source => _sampleSource;

        public Equalizer Equalizer => _equalizer;

        public void Open(string filename, MMDevice device)
        {
            CleanupPlayback();
            
            _sampleSource = CodecFactory.Instance.GetCodec(filename)
                    .ToSampleSource()
                    .AppendSource(Equalizer.Create10BandEqualizer, out _equalizer)
                    .AppendSource(x => new BiQuadFilterSource(x));
            _soundOut = new WasapiOut() { Latency = 100, Device = device };
            _soundOut.Initialize(_sampleSource.ToWaveSource());
            if (PlaybackStopped != null) _soundOut.Stopped += PlaybackStopped;
        }

        public void SetFilter(BiQuad filter)
        {
            _sampleSource.Filter = filter;
        }

        public void Play()
        {
            if (_soundOut != null)
                _soundOut.Play();
        }

        public void Pause()
        {
            if (_soundOut != null)
                _soundOut.Pause();
        }

        public void Stop()
        {
            if (_soundOut != null)
                _soundOut.Stop();
        }
        
        private void CleanupPlayback()
        {
            if (_soundOut != null)
            {
                _soundOut.Dispose();
                _soundOut = null;
            }
            if (_sampleSource != null)
            {
                _sampleSource.Dispose();
                _sampleSource = null;
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            CleanupPlayback();
        }
    }
}
