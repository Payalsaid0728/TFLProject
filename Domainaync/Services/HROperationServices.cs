using HR.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HR.Services
{
    public class HROperationService
    {
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            // Simulate database/API delay
            await Task.Delay(2000);

            return new List<Employee>
            {
                new Employee { Id=101, Name="Amit", Department="IT", Salary=50000 },
                new Employee { Id=102, Name="Neha", Department="HR", Salary=40000 },
                new Employee { Id=103, Name="Ravi", Department="Finance", Salary=60000 }
            };
        }

        public async Task<double> CalculateBonusAsync(Employee emp)
        {
            await Task.Delay(1000); // simulate calculation
            return emp.Salary * 0.10;
        }

        public async Task SaveEmployeeAsync(Employee emp)
        {
            await Task.Delay(1500); // simulate DB save
            Console.WriteLine($"Employee saved asynchronously: {emp.Name}");
        }
    }
}