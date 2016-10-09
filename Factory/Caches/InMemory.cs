namespace Factory.Caches
{
    public class InMemory : ICache
    {
        public void Put(string data) { }
        public string Get(string key) { return "InMemory Cache"; }
    }
}
