using CarDetails;

class Program
{
    static void Main(string[] args)
    {
        var cars = new List<Car>();
        cars.Add(new Car {Make = "Toyota", Model = "Hilux", Year = 2019, Color = "Red"});
        cars.Add(new Car {Make = "Buggati", Model = "Chiron", Year = 2015, Color = "Copper"});
        cars.Add(new Car {Make = "Mercedes", Model = "S-Class", Year = 2022, Color = "Black"});
        cars.Add(new Car {Make = "Rolls Royce", Model = "Phantom", Year = 2025, Color = "White"});

        foreach (var car in cars)
        {
            car.Start();
            car.Accelerate();
            car.Stop();
            car.GetInfo();

            Console.WriteLine();
        }

        Console.ReadLine();

    }
}
