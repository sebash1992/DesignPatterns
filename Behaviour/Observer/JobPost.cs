using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class JobPost
    {
        public string Title { get; private set; }

        public JobPost(string title)
        {
            Title = title;
        }
    }
}
