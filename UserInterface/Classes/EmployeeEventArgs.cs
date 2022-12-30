using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;

namespace SystemHR.UserInterface.Classes
{
    public class EmployeeEventArgs : EventArgs 
    {
        public EmployeeModel Employee { get; set; }
        
        public EmployeeEventArgs(EmployeeModel employee)
        {
            Employee = employee;
        }
    }
}
