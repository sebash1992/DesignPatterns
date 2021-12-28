namespace Observer
{
    public class JobSeeker : IObserver<JobPost>
    {
        public string Name { get; private set; }

        public JobSeeker(string name)
        {
            Name = name;
        }

        //Method is not being called by JobPostings class currently
        public void OnCompleted()
        {
            //No Implementation
        }

        //Method is not being called by JobPostings class currently
        public void OnError(Exception error)
        {
            //No Implementation
        }

        public void OnNext(JobPost value)
        {
            Console.WriteLine($"Hi {Name} ! New job posted: {value.Title}");
        }
    }
}
