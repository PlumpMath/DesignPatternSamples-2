using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory
{
    class FooBar
    {
    }

    public interface IBody
    {
        string BodyParts { get; }
    }

    public class CarBody : IBody
    {
        public virtual string BodyParts
        {
            get { return "Body shell parts for a car"; }
        }
    }

    public class VanBody: IBody
    {
        public virtual string BodyParts
        {
            get { return "Body shell parts for a van"; }
        }
    }

    public interface IChassis
    {
        string ChassisParts { get; }
    }

    public class CarChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get { return "Chassis parts for a Car"; }
        }
    }

    public class VanChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get { return "Chassis parts for a Van"; }
        }
    }

    public interface IGlassware
    {
        string GlasswareParts { get; }
    }

    public class CarGlassware : IGlassware
    {
        public virtual string GlasswareParts
        {
            get { return "Window glassware for a car"; }
        }
    }

    public class VanGlassware : IGlassware
    {
        public virtual string GlasswareParts
        {
            get { return "Window glassware for a van"; }
        }
    }

    ///// pattern involves a abstract factory class and two concrete factory classes 
    public abstract class AbstractVehicleFactory
    {
        public abstract IBody CreateBody();
        public abstract IChassis CreateChassis();
        public abstract IGlassware CreateGlassware();
    }

    public class CarFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new CarBody();
        }

        public override IChassis CreateChassis()
        {
            return new CarChassis();
        }

        public override IGlassware CreateGlassware()
        {
            return new CarGlassware();
        }
    }

    public class VanFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new VanBody();
        }

        public override IChassis CreateChassis()
        {
            return new VanChassis();
        }

        public override IGlassware CreateGlassware()
        {
            return new VanGlassware();
        }
    }
}
