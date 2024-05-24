﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class PartTimeEmployee : IEmployee
    {

        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;
        public PartTimeEmployee(string Fname, string Lname, string Dept, string JTitle) {

            this.FirstName = Fname;
            this.LastName = Lname;
            this.Department = Dept;
            this.JobTitle = JTitle;

        }
        public string FirstName
        {
            get
            {
                return first_name;
            }
            set
            {
                first_name = value;
            }

        }

        public string LastName
        {
            get
            {
                return last_name;
            }
            set
            {
                last_name = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        public string JobTitle
        {
            get
            {
                return job_title;
            }
            set
            {
                job_title = value;
            }
        }

        public double BasicSalary
        {
            get
            {
                return basic_salary;
            }
            set
            {
                basic_salary = value;
            }
        }

        public void computeSalary(double ratePerHour, int hoursWorked)
        {
            BasicSalary = hoursWorked * ratePerHour;

        }
            public double getSalary()
        { 
                return BasicSalary;
            }
        }


}
