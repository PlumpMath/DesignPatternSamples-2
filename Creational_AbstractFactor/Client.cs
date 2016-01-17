using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory
{
    class Client
    {
        static void Main(string[] args)
        {
            // the client can instantiate the appropriate
            // 'factory' with which it can obtain the correct
            // parts, whether for car or van

            string whatToMake = "car";

            AbstractVehicleFactory factory = null;

            // create the correct factory
            if (whatToMake.Equals("car"))
            {
                factory = new CarFactory();
            }
            else if (whatToMake.Equals("van"))
            {
                factory = new VanFactory();
            }

            // create the vehicle component parts...
            IBody body = factory.CreateBody();
            IChassis chassis = factory.CreateChassis();
            IGlassware glass = factory.CreateGlassware();

            // see what we have created
            Console.WriteLine(body.BodyParts);
            Console.WriteLine(chassis.ChassisParts);
            Console.WriteLine(glass.GlasswareParts);
            Console.ReadLine();

            // disadvantage: if adding a new product ex. Lights, to include lights in family of components
            //              would need to amend AbstractVehicleFactory, CarFactory, VanFactory
            //              in addition new ILights (CarLights/Vanlights) will need to be created

        }
    }


}
