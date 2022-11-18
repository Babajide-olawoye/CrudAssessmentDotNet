using BackendApi.Model;

namespace BackendApi.Interface
{
    public interface IOwner
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int id);
        Owner GetOwner(Owner owner);
        Owner GetOwner(String driverLicense);
        bool IsOwner(string driverLicense);
    }
}
