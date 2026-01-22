namespace HospitalRouting
{
    class UnitNode
    {
        public string Name;
        public bool IsAvailable;
        public UnitNode Next;

        public UnitNode(string name, bool isAvailable = true)
        {
            Name = name;
            IsAvailable = isAvailable;
            Next = null;
        }
    }
}
