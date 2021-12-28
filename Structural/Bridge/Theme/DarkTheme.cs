using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Theme
{
    public class DarkTheme : ITheme
    {
        public string GetColor()
        {
            return "Dark Black";
        }
    }
}
