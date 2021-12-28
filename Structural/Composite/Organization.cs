using Composite.Employee;

namespace Composite
{
    public class Organization
    {
        protected List<IEmployee> employees;

        public Organization()
        {
            employees = new List<IEmployee>();
        }

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public float GetNetSalaries()
        {
            float netSalary = 0;

            foreach (var e in employees)
            {
                netSalary += e.GetSalary();
            }
            return netSalary;
        }
    }
}
