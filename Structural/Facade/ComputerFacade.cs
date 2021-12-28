namespace Facade
{
    public class ComputerFacade
    {
        private readonly Computer mComputer;

        public ComputerFacade(Computer computer)
        {
            this.mComputer = computer ?? throw new ArgumentNullException("computer", "computer cannot be null");
        }

        public void TurnOn()
        {
            mComputer.GetElectricShock();
            mComputer.MakeSound();
            mComputer.ShowLoadingScreen();
            mComputer.Bam();
        }

        public void TurnOff()
        {
            mComputer.CloseEverything();
            mComputer.PullCurrent();
            mComputer.Sooth();
        }
    }
}
