using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new CacheFactory();
            var cache = factory.CreateCache(CacheType.InMemory);
            Console.WriteLine(cache.Get("key"));
            Console.ReadLine();
        }
    }
}
