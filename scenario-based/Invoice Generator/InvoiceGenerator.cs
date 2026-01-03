class InvoiceGenerator{
    public static string[] ParseInvoice(string input){

        string[] tasks = input.Split(',');

        return tasks;
    }

    public static int GetTotalAmount(string[] tasks){
        int total = 0;

        foreach (string task in tasks){
            string[] parts = task.Split('-');

            if (parts.Length == 2){
                string amountPart = parts[1].Replace("INR", "").Trim();
                int amount = int.Parse(amountPart);
                total += amount;
            }
        }
        return total;
    }
}
