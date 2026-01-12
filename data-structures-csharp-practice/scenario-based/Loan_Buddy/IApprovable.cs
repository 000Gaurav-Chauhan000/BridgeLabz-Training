using System;
using System.Collections.Generic;
using System.Text;

namespace Loan_Buddy
{
    public interface IApprovable
    {
        bool ApproveLoan();
        double CalculateEMI();
    }

}
