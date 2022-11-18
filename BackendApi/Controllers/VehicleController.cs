using BackendApi.Interface;
using BackendApi.Model;
using BackendApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController: Controller
    {
        private readonly IVehicle _vehicleRepository;
        public VehicleController(IVehicle vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Vehicle>))]
        public IActionResult GetAllVehicle()
        {
            var vehicles = _vehicleRepository.GetAllVehicles();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(vehicles);

        }



    }
}
