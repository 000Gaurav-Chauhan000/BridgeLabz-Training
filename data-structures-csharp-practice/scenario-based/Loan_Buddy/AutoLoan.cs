using System;
using System.Collections.Generic;
using System.Text;

namespace Loan_Buddy
{
    public class AutoLoan : LoanApplication
    {
        public AutoLoan(Applicant applicant)
            : base(applicant, 60, 10.0)
        {
        }

        public override bool ApproveLoan()
        {
            bool status = Applicant.GetCreditScore() >= 600;
            SetApprovalStatus(status);
            return status;
        }

        public override double CalculateEMI()
        {
            return CalculateStandardEMI();
        }
    }

}
