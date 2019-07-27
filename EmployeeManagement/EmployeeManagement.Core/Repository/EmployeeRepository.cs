﻿using DataAccessLayer.Data;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EmployeeManagement.Core.Models;

namespace DataAccessLayer.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeContext _context;

        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }

        public bool AddEmployee(Employee employee, Department dept)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return true;
        }
        public IList<Employee> GetEmployees()
        {
            var employees = from e in _context.Employees select e;
            return employees.ToList();
        }

        //public Employee SearchEmployee(int id)
        //{
        //    //var employee = new Employee();

        //    //employee = from e in _context.Employees.Select;
        //    //return employee;
        //}
        public bool UpdateEmployee(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
            return true;
        }
        //public int DeleteEmployee()
        //{

        //}
    }
}
