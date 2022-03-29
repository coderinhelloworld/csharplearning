namespace csharpLearning.VirtualClass
{
    public static class VirtualMethod
    {
        public static void Virtual()
        {
            Employee emp = new Employee();
            Manager manager = new Manager();
            ManagerChild managerChild = new ManagerChild();
            Programmer programmer = new Programmer();
          

            Employee[] employees = new[] {emp, manager, programmer,managerChild};

            foreach (var employee in employees)
            {
                employee.Daka();
            }
        }
    }
}