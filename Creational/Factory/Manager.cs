using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interfaces;
using Factory.Interviewers;

namespace Factory
{
   public abstract class HiringManager
    {
        // Factory method
        abstract protected IInterviewer MakeInterviewer();
        public void TakeInterview()
        {
            var interviewer = this.MakeInterviewer();
            interviewer.AskQuestions();
        }
    }

    public class DevelopmentManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new Developer();
        }
    }

    public class MarketingManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}
