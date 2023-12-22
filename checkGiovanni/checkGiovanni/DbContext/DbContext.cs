using checkGiovanni.Entity;

namespace checkGiovanni.DbContext
{
    public class DbContext : IDbContext
    {
        public List<Plate> platesList { get; set; } = new();
    }
}
