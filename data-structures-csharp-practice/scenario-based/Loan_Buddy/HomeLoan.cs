using System;
using System.Collections.Generic;
using System.Text;

namespace Loan_Buddy
{
    public class HomeLoan : LoanApplication
    {
        public HomeLoan(Applicant applicant, int term)   : base(applicant, term, 8.5) { }

        public override bool ApproveLoan()
        {
            bool status =
                Applicant.GetCreditScore() >= 700 && Applicant.Income >= 50000;

            SetApprovalStatus(status);
            return status;
        }

        public override double CalculateEMI()
        {
            return CalculateStandardEMI() * 0.95; 
        }
    }


}
