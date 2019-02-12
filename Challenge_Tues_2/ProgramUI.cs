using System;
using System.Collections.Generic;

namespace Challenge_Tues_2
{
    internal class ProgramUI
    {
        CarRepository _carRepo = new CarRepository();
        List<Car> _carList;
        int _response;

        internal void Run()
        {
            _carList = _carRepo.GetCarList();
            SeedCarData();
            PrintMenu();
            switch (_response)
            {
                case 1:
                    PrintCars();
                    break;
                case 2:
                    Car car = GetUserInputForCar();
                    AddCarToList();
                    break;
                case 3:
                    RemoveCarFromList();
                    break;
                case 4:
                    UpdateCar();
                    break;
                case 5:
                    Console.WriteLine("Have a nice day!");
                    break;
                default:
                    Console.WriteLine("Please enter a correct value.");
                    break;
            }
        }

        private Car GetUserInputForCar()
        {
            Console.WriteLine("Please Select A Brand:\n\t" +
                "1. Toyota\n\t" +
                "2. Ford\n\t" +
                "3. Chevrolet\n\t" +
                "4. Honda\n\t" +
                "5. Tesla\n\t" +
                "6. Lambourgini\n\t" +
                "7. BMW" +
                "8. Other");
            var brandResponse = int.Parse(Console.ReadLine());
            Brand brand;
            switch (brandResponse)
            {
                case 1:
                    brand = Brand.Toyota;
                    break;
                case 2:
                    brand = Brand.Ford;
                    break;
                case 3:
                    brand = Brand.Chevrolet;
                    break;
                case 4:
                    brand = Brand.Honda;
                    break;
                case 5:
                    brand = Brand.Tesla;
                    break;
                case 6:
                    brand = Brand.Lambourgini;
                    break;
                case 7:
                    brand = Brand.BMW;
                    break;
                default:
                    brand = Brand.Other:
                    break;
            }

            Console.WriteLine("Please Select A Type Of Car:\n\t" +
                "1. Truck\n\t" +
                "2. Van\n\t" +
                "3. Sedan\n\t" +
                "4. Hybrid\n\t" +
                "5. Other");
            var typeResponse = int.Parse(Console.ReadLine());
            CarType type;
            switch (typeResponse)
            {
                case 1:
                    type = CarType.Truck;
                    break;
                case 2:
                    type = CarType.Van;
                    break;
                case 3:
                    type = CarType.Sedan;
                    break;
                case 4:
                    type = CarType.Hybrid;
                    break;
                default:
                    type = CarType.Other;
                    break;
            }

            Console.Write("Enter the car's year: ");
            var year = int.Parse(Console.ReadLine());

            Console.Write("Enter the car's mileage: ");
            var mileage = int.Parse(Console.ReadLine());

            Console.Write("Enter the car's color: ");
            var color = Console.ReadLine();

            Console.WriteLine("Enter the number of doors: ");
            var doors = int.Parse(Console.ReadLine());

            Console.WriteLine("How safe is the car? 1-5");
            var rating = int.Parse(Console.ReadLine());

            Console.WriteLine("Is the car four-wheel drive? y/n");
            var boolResponse = Console.ReadLine().ToLower();
            var isFWD = _carRepo.GetBooleanFromString(boolResponse);

            Console.WriteLine("Has the car had an accident? y/n");
            boolResponse = Console.ReadLine().ToLower();
            var hadAccident = _carRepo.GetBooleanFromString(boolResponse);

            Console.WriteLine("Does the car have heated seats?");
            boolResponse = Console.ReadLine().ToLower();
            var hasHeatSeats = _carRepo.GetBooleanFromString(boolResponse);

             return new Car(brand, type, year, mileage, color, doors, rating, isFWD, hadAccident, hasHeatSeats);
        }

        private void SeedCarData()
        {
            _carRepo.AddCarToList(new Car(Brand.BMW, CarType.Sedan, 2017, 35000, "Black", 2, 5, false, false, true));
            _carRepo.AddCarToList(new Car(Brand.Ford, CarType.Truck, 2007, 185000, "Black", 4, 3, true, true, false));
        }

        private void UpdateCar()
        {
            Console.WriteLine("Coming Soon!");
        }

        private void RemoveCarFromList()
        {
            throw new NotImplementedException();
        }

        private void AddCarToList()
        {
            throw new NotImplementedException();
        }

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?\n\t" +
                "1. See All Cars\n\t" +
                "2. Add A New Car\n\t" +
                "3. Sell A Car\n\t" +
                "4. Update A Car\n\t" +
                "5. Exit Program");
            _response = int.Parse(Console.ReadLine());
        }

        private void PrintCars()
        {
            Console.WriteLine("Brand\tCar Type\tYear\tMileage\tColor\tDoors\tSafteyRating\tFWD Status\tAccident?\tHeated Seats?");
            foreach (Car car in _carList)
                Console.WriteLine($"{car.BrandOfCar}\t{car.TypeOfCar}\t{car.Year}\t{car.Mileage}\t{car.Color}\t{car.NumOfDoors}\t{car.SafteyRating}\t{car.IsFWD}\t{car.HadAccident}\t{car.HasHeatedSeats}");
        }
    }
}