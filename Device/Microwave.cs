using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05._06
{
    internal class Microwave : Device, ISound
    {
        public Microwave(string name, string description) : base(name, description) { }
        public override void Show()
        {
            Console.WriteLine($"Microwave name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Microwave Description: {Description}");
        }
        public void Sound()
        {
            Console.WriteLine("Microwave Sound()...");
        }

    }
}
