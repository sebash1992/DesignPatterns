using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Interviewers
{
    class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about design patterns!");
        }
    }
}
