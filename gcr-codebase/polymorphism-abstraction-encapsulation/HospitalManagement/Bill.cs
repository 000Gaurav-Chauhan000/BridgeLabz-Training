using System;

namespace HospitalManagement{
    internal class Bill{
        int id;
        int patientId;
        DateOnly billDate;
        double amount;

        public Bill(int id, int patientId, DateOnly billDate, double amount){
            this.id = id;
            this.patientId = patientId;
            this.billDate = billDate;
            this.amount = amount;
        }
        public int Id { get => id; set => id = value; }
        public int PatientId { get => patientId; set => patientId = value; }        
        public DateOnly BillDate { get => billDate; }
        public double Amount { get => amount; }



    }
}