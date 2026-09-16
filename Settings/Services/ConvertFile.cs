using NAudio.Wave;
using Settings.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Settings.Services
{
    static internal class ConvertFile
    {
        internal static bool ConvertMp3ToWavSoundsFile(string sourceFile, string name)
        {
            ConvertMp3ToWav(sourceFile, PathServices.Sounds, name);
            return true;
        }

        private static void ConvertMp3ToWav(string _inPath_, DtoPathServices path, string name)
        {
            string destination = Path.Combine(
                        path.Path,
                    name);

            using var reader = new AudioFileReader(_inPath_);
            WaveFileWriter.CreateWaveFile(destination, reader);

        }
    }
}
