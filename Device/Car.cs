using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05._06
{
    internal class Car: Device, ISound
    {
        public Car(string name, string description) : base(name, description) 
        {
        }
        public override void Show()
        {
            Console.WriteLine($"Car Name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Car Description: {Description}");
        }
        public void Sound()
        {
            Console.WriteLine("Car Sound()...");
        }
    }
}
