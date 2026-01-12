using System;
using System.Collections.Generic;
using System.Text;

namespace Loan_Buddy
{
    public class Applicant
    {
        public string Name { get; }
        public double Income { get; }
        public double LoanAmount { get; }

        private int creditScore;

        public Applicant(string name, int creditScore, double income, double loanAmount)
        {
            Name = name;
            this.creditScore = creditScore;
            Income = income;
            LoanAmount = loanAmount;
        }

        protected internal int GetCreditScore()
        {
            return creditScore;
        }
    }

}
