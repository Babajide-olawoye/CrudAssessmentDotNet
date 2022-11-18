using BackendApi.Data;
using BackendApi.Interface;
using BackendApi.Model;

namespace BackendApi.Repository
{
    public class ClaimRepository : IClaim
    {
        private readonly DataContext context;
        public ClaimRepository(DataContext Context)
        {
            this.context = Context; 
        }
        public ICollection<Claim> GetAllClaims()
        {
            return context.claims.OrderBy(p => p.Id).ToList();
        }

        public Claim GetClaim(int id)
        {
            return context.claims.Where(p => p.Id == id).FirstOrDefault();
        }

        public Claim GetClaimByVehicleId(Vehicle vehicle)
        {
            return context.claims.Where(p => p.Vehicle.Id == vehicle.Id).FirstOrDefault();
        }
    }
}
