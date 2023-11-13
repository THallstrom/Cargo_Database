using Cargo_Database.Contexts;
using Cargo_Database.Entitys;

namespace Cargo_Database.Repositorys
{
    internal class CargoRepo : Repo<CargoEntity>
    {
        private readonly DataContext _context;
        public CargoRepo(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
