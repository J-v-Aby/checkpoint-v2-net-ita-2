using checkGiovanni.DbContext;
using checkGiovanni.DTO;
using checkGiovanni.Entity;

namespace checkGiovanni.Service
{
    public class PlateService : IPlateService
    {
        private readonly IDbContext _db;

        public PlateService(IDbContext db)
        {
            _db = db;
        }

        public void AddPlate(PlateDTO plate)
        {
            var y = new Plate { Name = plate.Name,Type =plate.Type, Price=plate.Price };
            _db.platesList.Add(y);
        }

        public async Task<List<GetPlateDTOcs>> GetAllPlateAsync()
        {
            var y = _db.platesList.Select(a => new GetPlateDTOcs{ PlateId = a.PlateId, Name = a.Name, Type = a.Type, Price = a.Price }).ToList();
            return  y;
        }

        public Task<List<GetPlateDTOcs>> GetAllTipeAsync(string type)
        {
            var y = _db.platesList.Where(a => a.Type == type);
            return (Task<List<GetPlateDTOcs>>)y;
        }

        public Task<List<PlateDTO>> GetPricePlateAsync(decimal price)
        {
            var y = _db.platesList.Where(a => a.Price <10);
            return (Task<List<PlateDTO>>)y;
        }
    }
}
