using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Car[] Cars = new Car[0] { };

        public Gallery(int id, string name)
        {
            Id = id;
            Name = name;
            Cars =  new Car[0];
        }
        public void AddCar(Car car) 
        {
            Array.Resize( ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = car;
        }
        public void ShowAllCars()
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine($"Id:{car.Id}, Name:{car.Name}, Speed: {car.Speed}, CarCode:{car.CarCode}");

            }
        }

        public Car[] GetAllCars()
       
            {
                return Cars;
            }


        public Car FindCarById(int id)
        {
            return Cars.FirstOrDefault(car => car.Id == id);
        }

        public Car FindCarByCarCode(string carCode)
        {
            return Cars.FirstOrDefault(car => car.CarCode == carCode);
        }

        public Car[] FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            return Cars.Where(car => car.Speed >= minSpeed && car.Speed <= maxSpeed).ToArray();
        }
    }
}


