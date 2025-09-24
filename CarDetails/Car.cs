using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetails
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Model} made by {Make} is starting!");
        }
        public void Stop()
        {
            Console.WriteLine($"{Model} made by {Make} is stopping!");
        }
        public void Accelerate()
        {
            Console.WriteLine($"{Model} made by {Make} is accelerating!");
        }
        public void GetInfo()
        {
            Console.WriteLine($"This is a {Color} colored {Model} made by {Make} company in {Year} AD.");
        }
    }
}
