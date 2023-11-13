using Cargo_Database.Contexts;
using Cargo_Database.Entitys;

namespace Cargo_Database.Repositorys
{
    internal class CisternRepo : Repo<CisternEntity>
    {
        private readonly DataContext _context;
        public CisternRepo(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
