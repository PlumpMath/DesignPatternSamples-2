using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorCompany;

namespace Creational_Builder
{
    public abstract class VehiclBuilder
    {
        // defines all possible 'build' methods for both cars and vans
        // the abstract Vehicle property getter returns the finished vehicle
        public virtual void BuildBody() { }
        public virtual void BuildBoot() { }
        public virtual void BuildChassis() { }
        public virtual void BuildPassengerArea() { }
        public virtual void BuildReinforcedStorageArea() { }
        public virtual void BuildWindows() { }

        public abstract IVehicle Vehicle { get; }
    }

    public class CarBuilder : VehiclBuilder
    {
        private AbstractCar carInProgress;

        public CarBuilder(AbstractCar car)
        {
            carInProgress = car;
        }

        public override void BuildBody()
        {
            Console.WriteLine("building car body");
        }

        public override void BuildBoot()
        {
            Console.WriteLine("building car boot");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("building car chassis");
        }

        public override void BuildPassengerArea()
        {
            Console.WriteLine("building car passenger area");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("building car windows");
        }

        public override IVehicle Vehicle
        {
            get { return carInProgress; }
        }
    }

    public class VanBuilder : VehiclBuilder
    {
        private AbstractVan vanInProgress;

        public VanBuilder(AbstractVan van)
        {
            vanInProgress = van;
        }

        public override void BuildBody()
        {
            Console.WriteLine("building van body");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("building van chassis");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("building van windows");
        }

        public override IVehicle Vehicle
        {
            get { return vanInProgress; }
        }

        // BuildBoot() & BuildPassengerArea() not overridden
    }

    public abstract class VehicleDirector
    {
        public abstract IVehicle Build(VehiclBuilder builder);
    }

    public class CarDirector : VehicleDirector
    {
        public override IVehicle Build(VehiclBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildPassengerArea();
            builder.BuildBoot();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }

    public class VanDirector : VehicleDirector
    {
        public override IVehicle Build(VehiclBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildReinforcedStorageArea();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }
}
