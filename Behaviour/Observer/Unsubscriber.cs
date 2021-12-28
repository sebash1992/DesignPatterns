namespace Observer
{
    public class Unsubscriber<JobPost> : IDisposable
    {
        private List<IObserver<JobPost>> mObservers;
        private IObserver<JobPost> mObserver;

        internal Unsubscriber(List<IObserver<JobPost>> observers, IObserver<JobPost> observer)
        {
            this.mObservers = observers;
            this.mObserver = observer;
        }

        public void Dispose()
        {
            if (mObservers.Contains(mObserver))
                mObservers.Remove(mObserver);
        }
    }
}
