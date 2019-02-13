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
            while (_response != 5)
            {
                PrintMenu();
                switch (_response)
                {
                    case 1:
                        PrintCars();
                        Console.Clear();
                        break;
                    case 2:
                        var car = GetUserInputForCar();
                        _carRepo.AddCarToList(car);
                        break;
                    case 3:
                        var removeCar = SelectACar("remove");
                        _carRepo.RemoveCarFromList(removeCar);
                        break;
                    case 4:
                        var updateCar = SelectACar("update");
                        UpdateCar(updateCar);
                        break;
                    case 5:
                        Console.WriteLine("Have a nice day!");
                        break;
                    default:
                        Console.WriteLine("Please enter a correct value.");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
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
            var brand = _carRepo.GetBrandByInt(brandResponse);

            Console.WriteLine("Please Select A Type Of Car:\n\t" +
                "1. Truck\n\t" +
                "2. Van\n\t" +
                "3. Sedan\n\t" +
                "4. Hybrid\n\t" +
                "5. Other");
            var typeResponse = int.Parse(Console.ReadLine());
            var type = _carRepo.GetCarTypeByInt(typeResponse);

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

        private void UpdateCar(Car car)
        {
            Console.WriteLine("Which property would you like to update?\n\t" +
                "1.  Brand\n\t" +
                "2.  Car Type\n\t" +
                "3.  Year\n\t" +
                "4.  Mileage\n\t" +
                "5.  Color\n\t" +
                "6.  Number of doors\n\t" +
                "7.  Safety Rating\n\t" +
                "8.  Four-wheel drive status\n\t" +
                "9.  Accident Status\n\t" +
                "10. Heated Seat Status\n\t" +
                "11. No change");
            int propertyChoice = int.Parse(Console.ReadLine());
            switch (propertyChoice)
            {
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                default:
                    break;
            }
            Console.WriteLine("Coming Soon!");
        }

        private Car SelectACar(string action)
        {
            Console.WriteLine($"Which car would you like to {action}?");
            int i = 1;
            foreach (var c in _carList)
            {
                Console.WriteLine($"{i}. {c.Color} {c.Year} {c.BrandOfCar}");
                i++;
            }
            var carInt = int.Parse(Console.ReadLine());
            return _carList[carInt - 1];
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