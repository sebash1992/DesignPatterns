namespace Composite.Employee
{
    public class Designer : IEmployee
    {
        private string mName;
        private float mSalary;

        public Designer(string name, float salary)
        {
            this.mName = name;
            this.mSalary = salary;
        }

        public float GetSalary()
        {
            return this.mSalary;
        }

        public string GetRole()
        {
            return "Designer";
        }

        public string GetName()
        {
            return this.mName;
        }
    }
}
