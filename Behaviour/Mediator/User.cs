using Mediator.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class User
    {
        private string mName;
        private IChatRoomMediator mChatRoom;

        public User(string name, IChatRoomMediator chatroom)
        {
            mChatRoom = chatroom;
            mName = name;
        }

        public string GetName()
        {
            return mName;
        }

        public void Send(string message)
        {
            mChatRoom.ShowMessage(this, message);
        }
    }
}
