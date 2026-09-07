
using System.Media;
using System.Runtime.Versioning;


namespace Audio
{
    public class SoundPlayerService
    {
        public void Play(string filePath)
        {
            filePath = Path.Combine(filePath, "test.wav");
            if (!File.Exists(filePath))
                return;

            if (OperatingSystem.IsWindows())
            {
                PlayWindows(filePath);
            }
        }

        [SupportedOSPlatform("windows")]
        private void PlayWindows(string filePath)
        {
            using var player = new SoundPlayer(filePath);
            player.Play();
        }
    }
}
