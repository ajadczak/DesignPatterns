namespace Factory
{
    public interface ICache
    {
        void Put(string data);
        string Get(string key);
    }
}
