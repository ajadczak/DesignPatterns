namespace Adapter
{
    public class AudioJack : IAudioJack
    {
        public byte[] GetAudioStream()
        {
            return new byte[1] {0xFF};
        }
    }
}
