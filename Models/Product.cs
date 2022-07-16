using WebApplication1.Entities;
using WebApplication1.Interfaces;

namespace WebApplication1.Models
{
    public class Product
    {
        IDbContext _db;

        public Product(IDbContext db)
        {
            _db = db;
        }
        public List<Material> GetAllList()
        {
            return _db.ReadAll<Material>();
        }
    }
}
