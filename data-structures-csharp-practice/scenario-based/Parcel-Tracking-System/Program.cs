class Program{
    static void Main()
    {
        IParcel parcelutilize = new ParcelUtility();
        parcelutilize.ShowStages();
        parcelutilize.AddCustomCheckPoint();
        parcelutilize.ParcelMissing();
    }
}