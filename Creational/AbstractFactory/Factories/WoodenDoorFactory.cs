using AbstractFactory.DoorMakers;
using AbstractFactory.Doors;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class WoodenDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new WoodenDoor();
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Carpenter();
        }
    }
}
