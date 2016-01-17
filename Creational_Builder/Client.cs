using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorCompany;

namespace Creational_Builder
{
    class Client
    {
        static void Main(string[] args)
        {
            // example usage of builder pattern
            // to build a van
            AbstractVan van = new BoxVan(new StandardEngine(2000), VehicleColour.Red);
            VehiclBuilder vanBuilder = new VanBuilder(van);
            VehicleDirector director = new VanDirector();
            IVehicle v = director.Build(vanBuilder);
            Console.WriteLine(v);
            Console.Read();
        }
    }
}
