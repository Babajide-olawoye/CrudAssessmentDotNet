using BackendApi.Interface;
using BackendApi.Model;
using BackendApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController: Controller
    {
        private readonly IClaim repository;
        public ClaimController(IClaim repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Claim>))]
        public IActionResult GetClaims()
        {
            var allClaims = repository.GetAllClaims();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(allClaims);
        }

        [HttpGet("{claimId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Claim>))]
        public IActionResult GetClaimById(int claimId)
        {
            var claim = repository.GetClaim(claimId);
            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(claim);
        }


        [HttpGet("/claim/vehicle")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Claim>))]
        public IActionResult GetClaimByVehicle(Vehicle vehicle)
        {
            var claim = repository.GetClaimByVehicleId(vehicle);
            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(claim);
        }

    }
}
