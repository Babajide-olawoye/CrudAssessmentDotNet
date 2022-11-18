using BackendApi.Model;

namespace BackendApi.Interface
{
    public interface IVehicle
    {
        public ICollection<Vehicle> GetAllVehicles();
        public Vehicle GetVehicle(int id);
        public Vehicle GetVehicle(Owner owner);

    }
}
