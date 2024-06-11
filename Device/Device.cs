using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW_05._06
{

    interface ISound
    {
        void Sound();
    }


    internal abstract class Device
    {
        private string _name;
        private string _description;
        public Device(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public abstract void Show();
        public abstract void Desc();
    }

}
