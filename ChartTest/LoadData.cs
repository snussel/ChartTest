using ChartTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ChartTest
{
    public class LoadData
    {

        public static List<StatsModel> GetStats(string QueryType)
        {
            var FullList = GetList();

            switch (QueryType)
            {
                case "M":
                    return FullList.Where(m => m.Manufacturer != null).GroupBy(m => m.Manufacturer).Select(s => new StatsModel { xValue = s.Key, yValue = s.Count() }).ToList();
                case "C":
                    return FullList.Where(m => m.vClass != null).GroupBy(m => m.vClass).Select(s => new StatsModel { xValue = s.Key, yValue = s.Count() }).ToList();
                case "T":
                    return FullList.Where(m => m.vType != null).GroupBy(m => m.vType).Select(s => new StatsModel { xValue = s.Key, yValue = s.Count() }).ToList();
                case "L":
                    return FullList.Where(m => m.LocationName != null).GroupBy(m => m.LocationName).Select(s => new StatsModel { xValue = s.Key, yValue = s.Count() }).ToList();

                default:
                    return null;
            }
        }

        public static List<VehicleModel> GetList(string QueryType, string QueryValue)
        {
            var FullList = GetList();

            switch(QueryType)
            {
                case "M":
                    return FullList.Where(m => m.Manufacturer == QueryValue).ToList();
                case "C":
                    return FullList.Where(m => m.vClass == QueryValue).ToList();
                case "T":
                    return FullList.Where(m => m.vType == QueryValue).ToList();
                case "L":
                    return FullList.Where(m => m.LocationName == QueryValue).ToList();
                default:
                    return null;
            }

            //return FullList.Where(l => l.LocationName).ToList();
        }

        public static List<VehicleModel> GetList()
        {
            List<VehicleModel> ReturnList = new List<VehicleModel>();

            ReturnList.Add(new VehicleModel { VID = 0, Name = "Bodhi", Manufacturer = "Canis", LocationName = "1337 Exceptionalists Way", vType = "Ground - Truck", vClass = "Off Road" });
            ReturnList.Add(new VehicleModel { VID = 1, Name = "Virgo Classic", Manufacturer = "Dundreary", LocationName = "1337 Exceptionalists Way", vType = "Ground - Classic Coupe", vClass = "Muscle" });
            ReturnList.Add(new VehicleModel { VID = 2, Name = "Faction", Manufacturer = "Willard", LocationName = "1337 Exceptionalists Way", vType = "Ground - Classic Coupe", vClass = "Muscle" });
            ReturnList.Add(new VehicleModel { VID = 3, Name = "Dukes", Manufacturer = "Imponte", LocationName = "1337 Exceptionalists Way", vType = "Ground - Classic Coupe", vClass = "Muscle" });
            ReturnList.Add(new VehicleModel { VID = 4, Name = "Stallion", Manufacturer = "Declasse", LocationName = "1337 Exceptionalists Way", vType = "Ground - Classic Coupe", vClass = "Muscle" });
            ReturnList.Add(new VehicleModel { VID = 5, Name = "Tornado", Manufacturer = "Declasse", LocationName = "1337 Exceptionalists Way", vType = "Ground - Classic Coupe", vClass = "Sport Classic", isInsured = false });
            ReturnList.Add(new VehicleModel { VID = 6, Name = "Huntley S", Manufacturer = "Enus", LocationName = "1337 Exceptionalists Way", vType = "Ground - CrossOver", vClass = "SUV" });
            ReturnList.Add(new VehicleModel { VID = 7, Name = "Bifta", Manufacturer = "BF", LocationName = "1337 Exceptionalists Way", vType = "Ground - Dirt Sport", vClass = "Off Road" });
            ReturnList.Add(new VehicleModel { VID = 8, Name = "FQ 2", Manufacturer = "Fathom", LocationName = "1337 Exceptionalists Way", vType = "Ground - CrossOver", vClass = "SUV", isInsured = false });
            ReturnList.Add(new VehicleModel { VID = 9, Name = "Issi", Manufacturer = "Weeny", LocationName = "1337 Exceptionalists Way", vType = "Ground - Convertible Coupe", vClass = "Compact", isInsured = false });

            ReturnList.Add(new VehicleModel { VID = 10, Name = "Sadler", Manufacturer = "Vapid", LocationName = "Eclipse Towers Penthouse Suite 3", vType = "Ground - Truck", vClass = "Utility" });
            ReturnList.Add(new VehicleModel { VID = 11, Name = "Granger", Manufacturer = "Declasse", LocationName = "Eclipse Towers Penthouse Suite 3", vType = "Ground - Truck", vClass = "SUV", isInsured = false });
            ReturnList.Add(new VehicleModel { VID = 12, Name = "Cavalcade", Manufacturer = "Albany", LocationName = "Eclipse Towers Penthouse Suite 3", vType = "Ground - Truck", vClass = "SUV" });
            ReturnList.Add(new VehicleModel { VID = 13, Name = "Jackal", Manufacturer = "Ocelot", LocationName = "Eclipse Towers Penthouse Suite 3", vType = "Ground - Sedan", vClass = "Coupes", isInsured = false });
            ReturnList.Add(new VehicleModel { VID = 14, Name = "F620", Manufacturer = "Ocelot", LocationName = "Eclipse Towers Penthouse Suite 3", vType = "Ground - Coupe", vClass = "Coupes" });
            ReturnList.Add(new VehicleModel { VID = 15, Name = "Exemplar", Manufacturer = "Dewbauchee", LocationName = "Eclipse Towers Penthouse Suite 3", vType = "Ground - Sedan", vClass = "Coupes" });
            ReturnList.Add(new VehicleModel { VID = 16, Name = "Super Diamond", Manufacturer = "Enus", LocationName = "Eclipse Towers Penthouse Suite 3", vType = "Ground - Sedan", vClass = "Sedan" });
            ReturnList.Add(new VehicleModel { VID = 17, Name = "Oracle", Manufacturer = "Ubermacht", LocationName = "Eclipse Towers Penthouse Suite 3", vType = "Ground - Sedan", vClass = "Coupes" });
            ReturnList.Add(new VehicleModel { VID = 18, Name = "Regina", Manufacturer = "Dundreary", LocationName = "Eclipse Towers Penthouse Suite 3", vType = "Ground - Station Wagon", vClass = "Sedan", isInsured = false });
            ReturnList.Add(new VehicleModel { VID = 19, Name = "Kuruma (Armored)", Manufacturer = "Karin", LocationName = "Eclipse Towers Penthouse Suite 3", vType = "Ground - APC", vClass = "Sports" });
            ReturnList.Add(new VehicleModel { VID = 20, Name = "Scorcher", LocationName = "Eclipse Towers Penthouse Suite 3", vType = "Ground - Bicycle", vClass = "Cycle", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/scorcher" });

            ReturnList.Add(new VehicleModel { VID = 21, Name = "Moonbeam Custom", Manufacturer = "Declasse", LocationName = "Master Penthouse The Diamond", vType = "Ground - Van", vClass = "Muscle", isMod = true, CLURL = "https://www.gtabase.com/grand-theft-auto-v/guides/property-types/master-penthouse-the-diamond" });
            ReturnList.Add(new VehicleModel { VID = 22, Name = "Schlagen GT", Manufacturer = "Benefactor", LocationName = "Master Penthouse The Diamond", vType = "Ground - Coupe", vClass = "Sports", CLURL = "https://www.gtabase.com/grand-theft-auto-v/guides/property-types/master-penthouse-the-diamond", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/schlagen-gt" });
            ReturnList.Add(new VehicleModel { VID = 23, Name = "Ruston", Manufacturer = "Hijak", LocationName = "Master Penthouse The Diamond", vType = "Ground - Track Toy", vClass = "Sports", CLURL = "https://www.gtabase.com/grand-theft-auto-v/guides/property-types/master-penthouse-the-diamond" });
            ReturnList.Add(new VehicleModel { VID = 24, Name = "Gauntlet Classic", Manufacturer = "Bravado", LocationName = "Master Penthouse The Diamond", vType = "Ground - Classic Coupe", CLURL = "https://www.gtabase.com/grand-theft-auto-v/guides/property-types/master-penthouse-the-diamond", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/gauntlet-classic" });

            ReturnList.Add(new VehicleModel { VID = 25, Name = "Novak", Manufacturer = "Lampadati", LocationName = "Maze Bank West Garage", vType = "Ground - Crossover", vClass = "SUV", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/novak" });
            ReturnList.Add(new VehicleModel { VID = 26, Name = "Thrax", Manufacturer = "Truffade", LocationName = "Maze Bank West Garage", vType = "Ground - Exotic", vClass = "Super" });
            ReturnList.Add(new VehicleModel { VID = 27, Name = "Zentorno", Manufacturer = "Pegassi", LocationName = "Maze Bank West Garage", vType = "Ground - Exotic", vClass = "Super" });
            ReturnList.Add(new VehicleModel { VID = 28, Name = "GP1", Manufacturer = "Progen", LocationName = "Maze Bank West Garage", vType = "Ground - Exotic", vClass = "Super" });
            ReturnList.Add(new VehicleModel { VID = 29, Name = "Deveste Eight", Manufacturer = "Principe", LocationName = "Maze Bank West Garage", vType = "Ground - Exotic", vClass = "Super", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/deveste-eight" });
            ReturnList.Add(new VehicleModel { VID = 30, Name = "Banshee 900R", Manufacturer = "Bravado", LocationName = "Maze Bank West Garage", vType = "Ground - Exotic", vClass = "Super", isMod = true });
            ReturnList.Add(new VehicleModel { VID = 31, Name = "Swinger", Manufacturer = "Ocelot", LocationName = "Maze Bank West Garage", vType = "Ground - Classic Coupe", vClass = "Sport Classic", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/swinger" });
            ReturnList.Add(new VehicleModel { VID = 32, Name = "Vagner", Manufacturer = "Dewbauchee", LocationName = "Maze Bank West Garage", vType = "Ground - Exotic", vClass = "Super", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/vagner" });
            ReturnList.Add(new VehicleModel { VID = 33, Name = "Taipan", Manufacturer = "Cheval", LocationName = "Maze Bank West Garage", vType = "Ground - Exotic", vClass = "Super" });
            ReturnList.Add(new VehicleModel { VID = 34, Name = "Tropos Rallye", Manufacturer = "Lampadati", LocationName = "Maze Bank West Garage", vType = "Ground - Classic Rallye", vClass = "Sports" });

            ReturnList.Add(new VehicleModel { VID = 35, Name = "Caracara", Manufacturer = "Vapid", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Truck", vClass = "Off Road" });
            ReturnList.Add(new VehicleModel { VID = 36, Name = "Speedo Custom", Manufacturer = "Vapid", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Commercial", vClass = "Vans", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/speedo-custom", isMod = true });
            ReturnList.Add(new VehicleModel { VID = 37, Name = "Mule Custom", Manufacturer = "Maibatsu", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Commercial", vClass = "Commercial", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/mule-custom", isMod = true });
            ReturnList.Add(new VehicleModel { VID = 38, Name = "Pounder Custom", Manufacturer = "MTL", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Commercial", vClass = "Commercial", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/pounder-custom", isMod = true });
            ReturnList.Add(new VehicleModel { VID = 39, Name = "Jester", Manufacturer = "Dinka", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Exotic", vClass = "Sports" });
            ReturnList.Add(new VehicleModel { VID = 40, Name = "Sultan RS", Manufacturer = "Karin", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Tuner", vClass = "Super", isMod = true });
            ReturnList.Add(new VehicleModel { VID = 41, Name = "Dominator GTX", Manufacturer = "Vapid", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Coupe", vClass = "Muscle" });
            ReturnList.Add(new VehicleModel { VID = 42, Name = "Dominator", Manufacturer = "Vapid", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Coupe", vClass = "Muscle" });
            ReturnList.Add(new VehicleModel { VID = 43, Name = "Ellie", Manufacturer = "Vapid", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Classic Coupe", vClass = "Muscle" });
            ReturnList.Add(new VehicleModel { VID = 44, Name = "Coquette Topless", Manufacturer = "Invetero", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Coupe", vClass = "Sports" });
            ReturnList.Add(new VehicleModel { VID = 45, Name = "Comet SR", Manufacturer = "Pfister", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Coupe", vClass = "Sports" });
            ReturnList.Add(new VehicleModel { VID = 46, Name = "Dominator Pisswasser", Manufacturer = "Vapid", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Race Coupe", vClass = "Muscle" });
            ReturnList.Add(new VehicleModel { VID = 47, Name = "Elegy RH8", Manufacturer = "Annis", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Coupe", vClass = "Sports" });
            ReturnList.Add(new VehicleModel { VID = 48, Name = "Duke O'Death", Manufacturer = "Imponte", LocationName = "Vespucci Canals Nightclub", vType = "Ground - APC", vClass = "Muscle" });
            ReturnList.Add(new VehicleModel { VID = 49, Name = "Caracara 4x4", Manufacturer = "Vapid", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Truck", vClass = "Off Road", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/caracara-4x4" });
            ReturnList.Add(new VehicleModel { VID = 50, Name = "Paragon R (Armored)", Manufacturer = "Enus", LocationName = "Vespucci Canals Nightclub", vType = "Ground - APC", vClass = "Sports", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/paragon-r-armored" });
            ReturnList.Add(new VehicleModel { VID = 51, Name = "Dubsta", Manufacturer = "Benefactor", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Truck", vClass = "SUV", isInsured = false });
            ReturnList.Add(new VehicleModel { VID = 52, Name = "Zion Cabrio", Manufacturer = "Ubermacht", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Convertible Coupe", vClass = "Coupe" });
            ReturnList.Add(new VehicleModel { VID = 53, Name = "Vigero", Manufacturer = "Declasse", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Classic Coupe", vClass = "Muscle" });
            ReturnList.Add(new VehicleModel { VID = 54, Name = "Gauntlet", Manufacturer = "Bravado", LocationName = "Vespucci Canals Nightclub", vType = "Ground - Coupe", vClass = "Muscle" });

            ReturnList.Add(new VehicleModel { VID = 55, Name = "Bati 801", Manufacturer = "Pegassi", LocationName = "Vespucci Beach Clubhouse", vType = "Motorcycle - Rocket", vClass = "Motorcycle" });
            ReturnList.Add(new VehicleModel { VID = 56, Name = "Ruffian", Manufacturer = "Pegassi", LocationName = "Vespucci Beach Clubhouse", vType = "Motorcycle - Offroad", vClass = "Motorcycle" });
            ReturnList.Add(new VehicleModel { VID = 57, Name = "Hakuchou Drag Bike", Manufacturer = "Shitzu", LocationName = "Vespucci Beach Clubhouse", vType = "Motorcycle - Rocket", vClass = "Motorcycle" });
            ReturnList.Add(new VehicleModel { VID = 58, Name = "Enduro", Manufacturer = "Dinka", LocationName = "Vespucci Beach Clubhouse", vType = "Motorcycle - Sport", vClass = "Motorcycle" });
            ReturnList.Add(new VehicleModel { VID = 59, Name = "Akuma", Manufacturer = "Dinka", LocationName = "Vespucci Beach Clubhouse", vType = "Motorcycle - Sport", vClass = "Motorcycle" });
            ReturnList.Add(new VehicleModel { VID = 60, Name = "Bagger", Manufacturer = "Western", LocationName = "Vespucci Beach Clubhouse", vType = "Motorcycle - Cruser", vClass = "Motorcycle" });
            ReturnList.Add(new VehicleModel { VID = 61, Name = "Vader", Manufacturer = "Shitzu", LocationName = "Vespucci Beach Clubhouse", vType = "Motorcycle - Sport", vClass = "Motorcycle" });
            ReturnList.Add(new VehicleModel { VID = 62, Name = "Daemon", Manufacturer = "Western", LocationName = "Vespucci Beach Clubhouse", vType = "Motorcycle - Sport", vClass = "Motorcycle" });
            ReturnList.Add(new VehicleModel { VID = 63, Name = "Blazer", Manufacturer = "Nagasaki", LocationName = "Vespucci Beach Clubhouse", vType = "Ground - Quad", vClass = "Off Road" });
            ReturnList.Add(new VehicleModel { VID = 64, Name = "Blazer Lifeguard", Manufacturer = "Nagasaki", LocationName = "Vespucci Beach Clubhouse", vType = "Ground - Quad", vClass = "Off Road" });

            ReturnList.Add(new VehicleModel { VID = 65, Name = "Luxor", Manufacturer = "Buckingham", LocationName = "LSIA Hangar A17", vType = "Jet", vClass = "Aircraft" });
            ReturnList.Add(new VehicleModel { VID = 66, Name = "Cuban 800", Manufacturer = "Western Company", LocationName = "LSIA Hangar A17", vType = "Personel Aircraft", vClass = "Aircraft" });
            ReturnList.Add(new VehicleModel { VID = 67, Name = "Buzzard Attack Chopper", Manufacturer = "Nagasaki", LocationName = "LSIA Hangar A17", vType = "Attack", vClass = "Helicopter" });
            ReturnList.Add(new VehicleModel { VID = 68, Name = "Dodo", Manufacturer = "Mammoth", LocationName = "LSIA Hangar A17", vType = "Sea-Plane", vClass = "Planes" });
            ReturnList.Add(new VehicleModel { VID = 69, Name = "Annihilator", Manufacturer = "Western Company", LocationName = "LSIA Hangar A17", vType = "Armed Transport", vClass = "Helicopter" });

            ReturnList.Add(new VehicleModel { VID = 70, Name = "Rhino", LocationName = "Pegasus", vType = "Tank", vClass = "Military", CLURL = "https://gta.fandom.com/wiki/Pegasus", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/rhino-tank" });
            ReturnList.Add(new VehicleModel { VID = 71, Name = "Jetmax", Manufacturer = "Shitzu", LocationName = "Pegasus", vType = "Boat", vClass = "Boats", CLURL = "https://gta.fandom.com/wiki/Pegasus" });
            ReturnList.Add(new VehicleModel { VID = 72, Name = "Seashark", Manufacturer = "Speedophile", LocationName = "Pegasus", vType = "Boat", vClass = "Boats", CLURL = "https://gta.fandom.com/wiki/Pegasus" });
            ReturnList.Add(new VehicleModel { VID = 73, Name = "Suntrap", Manufacturer = "Shitzu", LocationName = "Pegasus", vType = "Boat", vClass = "Boats", CLURL = "https://gta.fandom.com/wiki/Pegasus" });
            ReturnList.Add(new VehicleModel { VID = 74, Name = "Speeder", Manufacturer = "Pegassi", LocationName = "Pegasus", vType = "Boat", vClass = "Boats", CLURL = "https://gta.fandom.com/wiki/Pegasus" });
            ReturnList.Add(new VehicleModel { VID = 75, Name = "Marshall", Manufacturer = "Cheval", LocationName = "Pegasus", vType = "Monster Truck", vClass = "Off Road", CLURL = "https://gta.fandom.com/wiki/Pegasus" });

            ReturnList.Add(new VehicleModel { VID = 76, Name = "Mobile Operations Center", LocationName = "Chumash Bunker", vType = "MOC", vClass = "Military, Utility", CVURL = "https://www.gtabase.com/grand-theft-auto-v/vehicles/mobile-operations-center-trailer" });

            return ReturnList;
        }


    }
}
