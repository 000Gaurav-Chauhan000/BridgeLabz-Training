namespace TrafficManager
{
    internal class VehicleNode
    {
        public string VehicleNo;
        public VehicleNode Next;

        public VehicleNode(string number)
        {
            VehicleNo = number;
            Next = null;
        }
    }
}
