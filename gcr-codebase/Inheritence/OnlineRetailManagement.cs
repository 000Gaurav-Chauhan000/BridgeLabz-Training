using System;

class Order{
    public int OrderId;
    public string OrderDate;

    public Order(int orderId, string orderDate){
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus(){
        return "Order Placed";
    }
}

class ShippedOrder : Order{
    public string TrackingNumber;

    public ShippedOrder(int orderId, string orderDate, string trackingNumber): base(orderId, orderDate){
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus(){
        return "Product has been Shipped";
    }
}

class DeliveredOrder : ShippedOrder{
    public string DeliveryDate;

    public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate): base(orderId, orderDate, trackingNumber){
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus(){
        return "Product Delivered";
    }
}

class Program{
    static void Main(){
        Order o1 = new Order(101, "1-12-1998");
        ShippedOrder o2 = new ShippedOrder(102, "2-1-2003", "ABC123");
        DeliveredOrder o3 = new DeliveredOrder(103, "3-1-2007", "CDE234", "5-1-1999");

        Console.WriteLine(o1.GetOrderStatus());
        Console.WriteLine(o2.GetOrderStatus());
        Console.WriteLine(o3.GetOrderStatus());
    }
}
