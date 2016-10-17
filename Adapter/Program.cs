namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new Phone();
            var adapter = new AudioJackToLightningAdapter();
            var audioJack = new AudioJack();
            AudioData lightningData = adapter.GetLightningDataFormat(audioJack);
            phone.PushData(lightningData);
        }
    }
}
