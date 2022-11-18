using BackendApi.Data;
using BackendApi.Interface;
using BackendApi.Model;

namespace BackendApi.Repository
{
    public class OwnerRepository : IOwner
    {
        private readonly DataContext _context;
        public OwnerRepository(DataContext context)
        {
            _context = context;
        }

        public Owner GetOwner(int id)
        {
            return _context.owner.Where(p => p.Id == id).FirstOrDefault();
        }
        public Owner GetOwner(String driverLicense)
        {
            return _context.owner.Where(p => p.DriverLicense == driverLicense).FirstOrDefault();
        }

        public Owner GetOwner(Owner owner)
        {
            return _context.owner.Where(p => p == owner).FirstOrDefault();
        }

        public ICollection<Owner> GetOwners()
        {
            return _context.owner.OrderBy(p => p.Id).ToList();
        }

        public bool IsOwner(string driverLicense)
        {
            return _context.owner.Any(p => p.DriverLicense == driverLicense);
        }
    }
}
