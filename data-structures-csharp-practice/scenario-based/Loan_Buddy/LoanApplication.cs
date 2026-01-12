using System;
using System.Collections.Generic;
using System.Text;

namespace Loan_Buddy
{
    public abstract class LoanApplication : IApprovable
    {
        protected Applicant Applicant;
        protected int Term; 
        protected double InterestRate; 

        private bool isApproved;

        protected LoanApplication(Applicant applicant, int term, double interestRate)
        {
            Applicant = applicant;
            Term = term;
            InterestRate = interestRate;
        }
        protected double CalculateStandardEMI()
        {
            double P = Applicant.LoanAmount;
            double R = (InterestRate / 12) / 100;
            int N = Term;

            return (P * R * Math.Pow(1 + R, N)) /(Math.Pow(1 + R, N) - 1);
        }

        protected void SetApprovalStatus(bool status)
        {
            isApproved = status;
        }

        public bool IsApproved => isApproved;

        public abstract bool ApproveLoan();
        public abstract double CalculateEMI();
    }

}
