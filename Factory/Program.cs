using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var cache = CreateCache(CacheType.InMemory);
            Console.WriteLine(cache.Get("key"));
            Console.ReadLine();
        }

        private static ICache CreateCache(CacheType cacheType)
        {
            var factory = new CacheFactory();
            var cache = factory.CreateCache(cacheType);
            return cache;
        }
    }
}
