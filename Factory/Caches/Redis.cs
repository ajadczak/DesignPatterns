namespace Factory.Caches
{
    public class RedisCache : ICache
    {
        public void Put(string data) { }
        public string Get(string key) { return "RedisCache"; }
    }
}
