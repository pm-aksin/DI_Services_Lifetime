namespace DI_Services_Lifetime.Services
{
    public class SingletonGUIDService : ISingletonGUIDService
    {
        private readonly Guid _guid;
        public SingletonGUIDService()
        {
            _guid = System.Guid.NewGuid();
        }
        public string GetGUID()
        {
            return _guid.ToString();
        }
    }
}
