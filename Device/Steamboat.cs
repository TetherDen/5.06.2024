using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05._06
{
    internal class Steamboat: Device, ISound
    {
        public Steamboat(string name, string description) :base(name, description) { }
        public override void Show()
        {
            Console.WriteLine($"Steamboat Name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Steamboat Description: {Description}");
        }
        public void Sound()
        {
            Console.WriteLine("Steamboat Sound()...");
        }
    }
}
