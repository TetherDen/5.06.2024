using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05._06
{
    internal class Teapot : Device, ISound
    {
        public Teapot(string name, string description) : base(name, description)
        {

        }
        public override void Show()
        {
            Console.WriteLine($"Teapot Name: {Name}");
        }

        public override void Desc()
        {
            Console.WriteLine($"Teapot Description: {Description}");
        }
        public void Sound()
        {
            Console.WriteLine("Teapot Sound()...");
        }
    }
}
