using checkGiovanni.DTO;
using checkGiovanni.Service;
using Microsoft.AspNetCore.Mvc;

namespace checkGiovanni.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlateController : ControllerBase
    {
        private IPlateService _plateService;

        public PlateController(IPlateService plateService)
        {
            _plateService = plateService;
        }

        [HttpPost]
        public IActionResult Post([FromBody]PlateDTO plate)
        {
            _plateService.AddPlate(plate);
            return Ok(" bla bla ");
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _plateService.GetAllPlateAsync());
        }
        [HttpGet]
        public async Task<IActionResult> GetBYTiPe(string type)
        {
            return Ok(await _plateService.GetAllTipeAsync(type));
        }
    }
}
