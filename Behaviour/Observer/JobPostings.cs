namespace Observer
{
    public class JobPostings : IObservable<JobPost>
    {
        private List<IObserver<JobPost>> mObservers;
        private List<JobPost> mJobPostings;

        public JobPostings()
        {
            mObservers = new List<IObserver<JobPost>>();
            mJobPostings = new List<JobPost>();
        }

        public IDisposable Subscribe(IObserver<JobPost> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!mObservers.Contains(observer))
            {
                mObservers.Add(observer);
            }
            return new Unsubscriber<JobPost>(mObservers, observer);
        }

        private void Notify(JobPost jobPost)
        {
            foreach (var observer in mObservers)
            {
                observer.OnNext(jobPost);
            }
        }

        public void AddJob(JobPost jobPost)
        {
            mJobPostings.Add(jobPost);
            Notify(jobPost);
        }

    }
}
