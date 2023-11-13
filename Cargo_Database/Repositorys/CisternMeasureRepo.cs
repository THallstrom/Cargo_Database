using Cargo_Database.Contexts;
using Cargo_Database.Entitys;

namespace Cargo_Database.Repositorys
{
    internal class CisternMeasureRepo : Repo<CisternMeasureEntity>
    {
        private readonly DataContext _context;
        public CisternMeasureRepo(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
