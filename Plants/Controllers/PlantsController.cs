using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plants.Models;
using Plants.Schemas;

namespace Plants.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        private IPlants _plantsFetcher;

        public PlantsController(IPlants plantsFetcher)
        {
            _plantsFetcher = plantsFetcher;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try 
            {
                var plants = _plantsFetcher.FetchAllPlants();
                return Ok(plants);
            }
            catch (Exception e)
            {
                // invoke error handler with exception
                return NotFound();
            }
        }
    }
}
