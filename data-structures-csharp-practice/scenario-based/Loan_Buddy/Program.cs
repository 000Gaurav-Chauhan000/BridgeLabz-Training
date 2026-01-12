using System;
namespace Loan_Buddy{

    class Program
    {
        static void Main()
        {
            Applicant applicant = new Applicant("Chun-Li" ,720 ,60000 ,500000);

            LoanApplication loan = new HomeLoan(applicant, 240);

            if (loan.ApproveLoan()){
                Console.WriteLine("Loan Approved");
                Console.WriteLine($"Monthly EMI: {loan.CalculateEMI():F2}");
            }
            else{
                Console.WriteLine("Loan Rejected");
            }
        }
    }
}