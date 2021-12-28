using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IAnimalOperation
    {
        void VisitMonkey(Monkey monkey);
        void VisitLion(Lion lion);
        void VisitDolphin(Dolphin dolphin);
    }
}
