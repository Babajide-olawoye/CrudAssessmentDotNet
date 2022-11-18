using BackendApi.Model;

namespace BackendApi.Interface
{
    public interface IClaim
    {
        ICollection<Claim> GetAllClaims();

        Claim GetClaim(int id);
        Claim GetClaimByVehicleId(Vehicle vehicle);
    }
}
