using checkGiovanni.Entity;

namespace checkGiovanni.DbContext
{
    public interface IDbContext
    {
        public List<Plate> platesList {  get; set; }
    }
}
