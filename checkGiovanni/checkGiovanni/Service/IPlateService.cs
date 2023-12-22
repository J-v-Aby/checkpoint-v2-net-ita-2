using checkGiovanni.DTO;
using checkGiovanni.Entity;

namespace checkGiovanni.Service
{
    public interface IPlateService
    {
        public void AddPlate(PlateDTO plate);
        public Task<List<GetPlateDTOcs>> GetAllPlateAsync();
        public Task<List<GetPlateDTOcs>> GetAllTipeAsync(string type);
        public Task<List<PlateDTO>> GetPricePlateAsync(Decimal price);
        
    }
}
