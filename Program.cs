


using ConsoleApp17;
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Gallery gallery = new Gallery(1, "gallery");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. Masin elave et");
            Console.WriteLine("2. butun masinlari goster");
            Console.WriteLine("3. ID ile masini tap");
            Console.WriteLine("4. CarCode ile masini tap");
            Console.WriteLine("5. Suret intervallari ile masinlari tap");
            Console.WriteLine("6. Proqrami bitir");
            Console.Write("seciminizi daxil edin: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Masin ID daxil et: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Masinin adini daxil et: ");
                        string name = Console.ReadLine();
                        Console.Write("Masinin suretini daxil et: ");
                        int speed = int.Parse(Console.ReadLine());
                        gallery.AddCar(new Car(id, name, speed));
                        Console.WriteLine("Masin elave olundu.");
                        break;

                    case 2:
                        gallery.ShowAllCars();
                        break;

                    case 3:
                        Console.Write("axtarmaq ucun masin İD daxil edin: ");
                        int searchId = int.Parse(Console.ReadLine());
                        Car foundCarById = gallery.FindCarById(searchId);
                        if (foundCarById != null)
                        {
                            Console.WriteLine($" ID {searchId}: {foundCarById.Name} olan masin tapildi");
                        }
                        else
                        {
                            Console.WriteLine($" ID {searchId} masin tapilmadi");
                        }
                        break;

                    case 4:
                        Console.Write("axtarmaq ucun masinin CarCode daxil edin : ");
                        string searchCarCode = Console.ReadLine().ToUpper();
                        Car foundCarByCarCode = gallery.FindCarByCarCode(searchCarCode);
                        if (foundCarByCarCode != null)
                        {
                            Console.WriteLine($" CarCode {searchCarCode}: {foundCarByCarCode.Name} masin tapildi");
                        }
                        else
                        {
                            Console.WriteLine($" CarCode {searchCarCode} masin tapilmadi");
                        }
                        break;

                    case 5:
                        Console.Write("minimum sureti daxil edin: ");
                        int minSpeed = int.Parse(Console.ReadLine());
                        Console.Write("maximum sureti daxil edin: ");
                        int maxSpeed = int.Parse(Console.ReadLine());
                        Car[] carsInSpeedInterval = gallery.FindCarsBySpeedInterval(minSpeed, maxSpeed);
                        Console.WriteLine($"masiniin {minSpeed} ve {maxSpeed}sureti:");
                        foreach (var car in carsInSpeedInterval)
                        {
                            Console.WriteLine($"{car.Name} - Suret: {car.Speed}");
                        }
                        break;

                    case 6:
                        exit = true;
                        Console.WriteLine("proqram bitir...");
                        break;

                    default:
                        Console.WriteLine("Yanlış seçim. Zəhmət olmasa 1 ilə 6 arasında bir rəqəm daxil edin.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Yalnış daxiletmə. Duzgun nömrə daxil edin.");
            }
        }
    }
}
