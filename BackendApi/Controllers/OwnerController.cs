using BackendApi.Interface;
using BackendApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : Controller
    {
        private readonly IOwner ownerRepo;
        public OwnerController(IOwner ownerRepo)
        {
            this.ownerRepo = ownerRepo;
        }

        [HttpGet]
        [ProducesResponseType(200, Type =typeof(IEnumerable<Owner>))]
        public IActionResult GetOwners()
        {
            var owner = ownerRepo.GetOwners();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
                return Ok(owner);
        }

        [HttpGet("{driverLicense}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Owner>))]  
        public IActionResult GetOwner(String driverLicense)
        {
            if(!ownerRepo.IsOwner(driverLicense))
                return NotFound();
            var owner = ownerRepo.GetOwner(driverLicense);

            return Ok(owner);
            
        }
    }
}