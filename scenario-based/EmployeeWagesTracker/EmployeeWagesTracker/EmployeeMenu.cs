using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWagesTracker{
    sealed class EmployeeMenu{

        private IEmployee IEmp;

        public void EmployeeChoices() {
           
            IEmp = new EmployeeUtilityImpl();
            IEmp.AddEmployee(); 
            IEmp.MarkAttendence();
            IEmp.ShowAttendence();
        }
    }
}
