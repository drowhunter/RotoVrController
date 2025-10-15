using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotoVRController
{
    public class SoundPlayer
    {
        private WaveOutEvent _outputDevice;
        private AudioFileReader _audioFileReader;
        private string _currentFilePath;

        // Delegate to output audio amplitude in dBm
        public delegate void AmplitudeChangedHandler(double amplitudeDbm);
        public event AmplitudeChangedHandler OnAmplitudeChanged;

        private System.Timers.Timer _amplitudeTimer;

        private const int MIN_DBM = -30;
        private const int MAX_DBM = 0;

        public void PlaySound(string audioFilePath)
        {

            StopSound(); // Always stop previous sound before starting new one

            _currentFilePath = audioFilePath;
            _audioFileReader = new AudioFileReader(audioFilePath);
            _outputDevice = new WaveOutEvent();
            _outputDevice.Init(_audioFileReader);
            // Add the callback here
            _outputDevice.PlaybackStopped += OnPlaybackStopped;
            _outputDevice.Play();

            //int sampleCount = _audioFileReader.WaveFormat.SampleRate / 10;  
            //Console.WriteLine("Sample count is " + sampleCount);

            // Start monitoring amplitude
            _amplitudeTimer = new System.Timers.Timer(100); // Every 100ms
            _amplitudeTimer.Elapsed += (s, e) =>
            {
                // take an audio buffer to estimate the sound volume
                float[] buffer = new float[1024];
                int readSamples = _audioFileReader.Read(buffer, 0, buffer.Length);

                if (readSamples > 0)
                {
                    double rms = 0;
                    for (int i = 0; i < readSamples; i++)
                        rms += buffer[i] * buffer[i];

                    rms = Math.Sqrt(rms / readSamples);
                    double amplitudeDbm = 20 * Math.Log10(rms);


                    // normalize dBM
                    amplitudeDbm = Math.Min(Math.Max(amplitudeDbm, MIN_DBM), MAX_DBM);
                    amplitudeDbm = ((amplitudeDbm - MIN_DBM) / (MAX_DBM - MIN_DBM)) * 100;

                    OnAmplitudeChanged?.Invoke(amplitudeDbm);
                }
            };
            _amplitudeTimer.Start();
        }


        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {


            OnAmplitudeChanged?.Invoke(0.0f);
        }

        public void StopSound()
        {
            _amplitudeTimer?.Stop();
            _amplitudeTimer?.Dispose();
            _amplitudeTimer = null;

            _outputDevice?.Stop();
            _outputDevice?.Dispose();
            _outputDevice = null;

            _audioFileReader?.Dispose();
            _audioFileReader = null;
        }
    }

}
