using AbstractFactory.Interfaces;

namespace AbstractFactory.Doors
{
    class IronDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a iron door");
        }
    }
}
