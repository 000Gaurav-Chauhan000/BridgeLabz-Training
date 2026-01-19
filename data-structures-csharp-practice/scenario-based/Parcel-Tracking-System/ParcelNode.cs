class ParcelNode
{
    public string ParcelStatus;
    public ParcelNode Next;
    public ParcelNode(string parcelStatus)
    {
        ParcelStatus = parcelStatus;
        Next = null;
    }  
}