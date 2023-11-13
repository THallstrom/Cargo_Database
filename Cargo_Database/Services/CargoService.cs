using Cargo_Database.Entitys;
using Cargo_Database.Repositorys;

namespace Cargo_Database.Services
{
    internal class CargoService
    {
        private readonly VesselRepo _vesselRepo;
        private readonly CisternRepo _cisternRepo;

        public CargoService(CisternRepo cisternRepo, VesselRepo vesselRepo)
        {
            _cisternRepo = cisternRepo;
            _vesselRepo = vesselRepo;
        }

        public async Task CreateCargoAsync()
        {
            var cargo = new CargoEntity();
            Console.Write("Skriv in produktnamn: ");
            cargo.ProductName = Console.ReadLine()!;
            Console.Write("Skriv in produktvolym");
            cargo.ProductVolym= Convert.ToInt32(Console.ReadLine());

            var vessels = await _vesselRepo.GetAllAsync();
            var i = 0;
            foreach (var vessel in vessels)
            {
                Console.WriteLine($"{vessel.Id} {vessel}");
            }
            // Denna delen är inte klar på långa vägar men nu tänker jag inte klart
            Console.Write("Välj Fartyg från listan: ");
            Console.Write("Välj cistern från listan: ");
        }
    }
}
