using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_And_Assignment_ADV_C__Task4_Solution.part_01
{
    #region Enums
    public enum LayOffCause
    {
        ZeroVactionStock,
        SixtyAge
    }
    #endregion

    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
        public Employee Employee { get; private set; }

        public EmployeeLayOffEventArgs(Employee employee)
        {
            Employee = employee;
        }
    }

    internal class Employee
    {
        #region Properties
        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }
        public int VacationStock { get; set; }
        #endregion

        #region Events
        public event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;
        #endregion

        #region Methods
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            int daysRequest = (To - From).Days;
            if (VacationStock - daysRequest < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.ZeroVactionStock });
                return false;
            }
            VacationStock -= daysRequest;
            return true;
        }
        public void EndOfYearOperation()
        {
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.ZeroVactionStock });
            }
            else if ((DateTime.Now.Year - BirthDate.Year) > 60)
            {
                OnEmployeeLayOff((new EmployeeLayOffEventArgs { Cause = LayOffCause.SixtyAge }));
            }
        }

        #endregion

    }
}
