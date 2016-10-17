using System;

namespace Adapter
{
    public class Phone : ILightningPort
    {        
        public void PushData(AudioData data)
        {
            Console.WriteLine($"Data type: {data.Type} First value: {data.Data[0]}");
        }
    }
}
