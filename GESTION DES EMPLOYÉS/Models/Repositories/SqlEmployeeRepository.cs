﻿namespace GESTION_DES_EMPLOYÉS.Models.Repositories
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;
        public SQLEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Employee Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }
        public Employee Delete(int Id)
        {
            Employee employee = context.Employees.Find(Id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;
        }
        public Employee GetEmployee(int Id)
        {
            return context.Employees.Find(Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            throw new NotImplementedException();
        }
    }
}