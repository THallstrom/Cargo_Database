using System.Diagnostics;

namespace Cargo_Database.Services
{
    internal class MenuService
    {
        private readonly VesselService _vesselService;
        private readonly CisternService _cisternService;

        public MenuService(VesselService vesselService, CisternService cisternService)
        {
            _vesselService = vesselService;
            _cisternService = cisternService;
        }


        public async Task MenuServiceMenu()
        {
            var running = true;
            do
            {

            

            var userOption = "";
            Console.WriteLine("Välkommen till Lastprogrammet");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Fartyg");
            Console.WriteLine("2. Lägg till last");
            Console.WriteLine("3. Lägg till cistern");
            Console.WriteLine("4. Lägg till cisterndata");
            try
            {
                userOption = Console.ReadLine();
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }


            switch (userOption)
            {
                case "1":
                        Console.WriteLine("1. Lägg in ett fartyg");
                        Console.WriteLine("2. Lista alla fartyg");
                        userOption = Console.ReadLine();
                        switch (userOption)
                        {
                            case "1":
                    await _vesselService.CreateVesselAsync();
                                break;
                                case "2":
                                await _vesselService.GetAllVesselAsync();
                                break;
                        }
                        break; 
                    case "2":
                    Console.WriteLine();
                    break;
                    case "3":
                    await _cisternService.CreateCisternAsync();
                    break;
                    case "4":
                    Console.WriteLine();
                    break;
                    case "5":
                    running = false;
                    break;
            }
            } while (running);
        }

    }
}
