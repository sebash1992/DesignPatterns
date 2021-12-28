using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class LowerCase : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToLower());
        }
    }
}
