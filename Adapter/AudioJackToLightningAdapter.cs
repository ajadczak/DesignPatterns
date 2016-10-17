using System;

namespace Adapter
{
    public class AudioJackToLightningAdapter
    {
        public AudioData GetLightningDataFormat(IAudioJack audio)
        {
            var stream = audio.GetAudioStream();
            Console.WriteLine("Adapting audio jack data format to ");
            return new AudioData()
            {
                Data = stream,
                Type = "ac3"
            };
        }
    }
}
