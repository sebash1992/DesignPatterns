using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Interviewers
{
    public class CommunityExecutive : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about community building!");
        }
    }
}
