using BackendApi.Data;
using BackendApi.Interface;
using BackendApi.Model;

namespace BackendApi.Repository
{
    public class VehicleRepository : IVehicle
    {
        private readonly DataContext context;
        public VehicleRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<Vehicle> GetAllVehicles()
        {
            return this.context.vehicles.OrderBy(p => p.Owner).ToList();
        }

        public Vehicle GetVehicle(int id)
        {
            return this.context.vehicles.Where(p => p.Id == id).FirstOrDefault();
        }

        public Vehicle GetVehicle(Owner owner)
        {
            return this.context.vehicles.Where(p => p.Owner.Id == owner.Id).FirstOrDefault();
        }
    }
}
