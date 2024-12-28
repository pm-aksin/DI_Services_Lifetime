namespace DI_Services_Lifetime.Services
{
    public class TransientGUIDService : ITransientGUIDService
    {
         private readonly Guid _guid;
        public TransientGUIDService()
        {
            _guid = System.Guid.NewGuid();
        }
        public string GetGUID()
        {
            return _guid.ToString();
        }
    }
}
