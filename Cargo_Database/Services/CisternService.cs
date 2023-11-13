using Cargo_Database.Entitys;
using Cargo_Database.Repositorys;

namespace Cargo_Database.Services
{
    internal class CisternService
    {
        private readonly CisternRepo _repo;

        public CisternService(CisternRepo repo)
        {
            _repo = repo;
        }

        public async Task CreateCisternAsync()
        {
            var cistern = new CisternEntity();
            Console.Write("Skriv in nummer på cistern: ");
            cistern.CisternName = Console.ReadLine()!;
            Console.Write("Vilken produkt finns i cistern: ");
            cistern.ProductDescription = Console.ReadLine()!;
            Console.Write("Vilken hamn befinner vi oss i: ");
            cistern.CisternLocation = Console.ReadLine()!;
            Console.Write("Vad är maximala volymen i cistern: ");
            cistern.MaxVolym = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vilken är maximala ullaget: ");
            cistern.MaxUllage = Convert.ToInt32(Console.ReadLine());

            var entity = await _repo.CreateAsync(cistern);
        }
    }
}
