using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Speak : IAnimalOperation
    {
        public void VisitDolphin(Dolphin dolphin)
        {
            dolphin.Speak();
        }

        public void VisitLion(Lion lion)
        {
            lion.Roar();
        }

        public void VisitMonkey(Monkey monkey)
        {
            monkey.Shout();
        }
    }
}
