using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Door
{
    class SecuredDoor : IDoor
    {
        private IDoor mDoor;

        public SecuredDoor(IDoor door)
        {
            mDoor = door ?? throw new ArgumentNullException("door", "door can not be null");
        }

        public void Open(string password)
        {
            if (Authenticate(password))
            {
                mDoor.Open(password);
            }
            else
            {
                Console.WriteLine("Big no! It ain't possible.");
            }
        }

        private bool Authenticate(string password)
        {
            return password == "$ecr@t";
        }

        public void Close()
        {
            mDoor.Close();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }
    }
}
