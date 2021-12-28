using AbstractFactory.Interfaces;

namespace AbstractFactory.DoorMakers
{
    public class Welder : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit iron doors");
        }
    }
}
