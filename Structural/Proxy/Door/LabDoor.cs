namespace Proxy.Door
{
    class LabDoor : IDoor
    {
        public void Close()
        {
            Console.WriteLine("Closing lab door");
        }

        public void Open(string password)
        {
            Console.WriteLine("Opening lab door");
        }
    }
}
