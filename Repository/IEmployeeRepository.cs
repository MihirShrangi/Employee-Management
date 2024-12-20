﻿using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IEmployeeRepository
    {
        Task<ActionResult<Employee>?> GetEmployee(int Id);
        Task<ActionResult<IEnumerable<Employee>>> GetAllEmployee();
        Task<ActionResult<Employee>> Add(Employee employee);
        Task<Employee> Update(int id, Employee employeeChanges);
        Task<Employee> Delete(int Id);
    }

}
