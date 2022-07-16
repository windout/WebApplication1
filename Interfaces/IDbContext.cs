namespace WebApplication1.Interfaces
{
    public interface IDbContext
    {
        public List<T> ReadAll<T>();
    }
}
