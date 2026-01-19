internal class ParcelUtility : IParcel
{
    public ParcelNode head;
    
    public ParcelUtility()
    {
        head = new ParcelNode("Packed");
        head.Next = new ParcelNode("Shipped");
        head.Next.Next = new ParcelNode("In- Transition");
        head.Next.Next.Next = new ParcelNode("Delivered");
    }
    public void ShowStages()
    {
        ParcelNode temp = head;
        while(temp != null)
        {
            Console.Write(temp.ParcelStatus + " --> ");
            temp = temp.Next;
        }
        Console.Write("End");
    }
    public void AddCustomCheckPoint()
{
    Console.Write("Enter existing stage after which to add checkpoint: ");
    string afterStage = Console.ReadLine();

    Console.Write("Enter new checkpoint name: ");
    string newStage = Console.ReadLine();

    ParcelNode temp = head;

    while (temp != null)
    {
        if (temp.ParcelStatus.Equals(afterStage, StringComparison.OrdinalIgnoreCase))
        {
            ParcelNode newNode = new ParcelNode(newStage);
            newNode.Next = temp.Next;
            temp.Next = newNode;

            Console.WriteLine("Checkpoint added successfully.");
            return;
        }
        temp = temp.Next;
    }

    Console.WriteLine("Stage not found. Checkpoint not added.");
}

    public void ParcelMissing()
{
    Console.Write("Enter stage where parcel got lost: ");
    string lostStage = Console.ReadLine();

    ParcelNode temp = head;

    while (temp != null)
    {
        if (temp.ParcelStatus.Equals(lostStage, StringComparison.OrdinalIgnoreCase))
        {
            temp.Next = null; 
            Console.WriteLine("Parcel marked as missing. Delivery chain broken.");
            return;
        }
        temp = temp.Next;
    }

    Console.WriteLine("Stage not found. No changes made.");
}

}