using Factory.Caches;

namespace Factory
{
    public class CacheFactory
    {
        public ICache CreateCache(CacheType cacheType)
        {
            switch (cacheType)
            {
                case CacheType.InMemory:
                    return new InMemory();
                case CacheType.Redis:
                    return new RedisCache();
                default:
                    return null;
            }
        }
    }
}