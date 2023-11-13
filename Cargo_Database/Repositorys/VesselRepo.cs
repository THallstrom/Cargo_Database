using Cargo_Database.Contexts;
using Cargo_Database.Entitys;

namespace Cargo_Database.Repositorys
{
    internal class VesselRepo : Repo<VesselEntity>
    {
        private readonly DataContext _context;
        public VesselRepo(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
