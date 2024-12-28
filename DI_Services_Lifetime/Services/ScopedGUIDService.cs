namespace DI_Services_Lifetime.Services
{
    public class ScopedGUIDService: IScopedGUIDService
    {
        private readonly Guid _guid;
        public ScopedGUIDService()
        {
            _guid = System.Guid.NewGuid();
        }
        public string GetGUID()
        {
            return _guid.ToString();
        }
    }
}
