using Cargo_Database.Entitys;
using Cargo_Database.Repositorys;

namespace Cargo_Database.Services
{
    internal class VesselService
    {
        private readonly VesselRepo _repo;

        public VesselService(VesselRepo repo)
        {
            _repo = repo;
        }

        public async Task CreateVesselAsync()
        {
            var vessel = new VesselEntity();

            Console.Write("Skriv in fartygets namn: ");
            vessel.VesselName = Console.ReadLine()!;
            Console.Write("Skriv in hamnen: ");
            vessel.HarbourName = Console.ReadLine()!;

            var vesselInMenu = await _repo.CreateAsync(vessel);
            Console.WriteLine($"Fartyg i databasen: {vesselInMenu.VesselName}");
            Console.WriteLine($"Hamn i databasen: {vesselInMenu.HarbourName}");
            Console.ReadLine();

        }
    }
}
