namespace Proxy.Door
{
    public interface IDoor
    {
        void Open(string password);
        void Close();
    }
}
