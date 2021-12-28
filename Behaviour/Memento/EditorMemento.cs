using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class EditorMemento
    {
        private string mContent;

        public EditorMemento(string content)
        {
            mContent = content;
        }

        public string Content
        {
            get
            {
                return mContent;
            }
        }
    }
}
