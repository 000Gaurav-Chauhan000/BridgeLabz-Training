using System;

class Course{
    public string name;
    public int duration;

    public Course(string name, int duration){
        this.name = name;
        this.duration = duration;
    }
}

class OnlineCourse : Course{
    public string platform;
    public bool recorded;

    public OnlineCourse(string name, int duration, string platform, bool recorded): base(name, duration){
        this.platform = platform;
        this.recorded = recorded;
    }
}

class PaidOnlineCourse : OnlineCourse{
    public int fee;
    public int discount;

    public PaidOnlineCourse(string name, int duration, string platform, bool recorded, int fee, int discount): base(name, duration, platform, recorded){
        this.fee = fee;
        this.discount = discount;
    }

    public void Display(){
        Console.WriteLine(name);
        Console.WriteLine(duration);
        Console.WriteLine(platform);
        Console.WriteLine(recorded);
        Console.WriteLine(fee);
        Console.WriteLine(discount);
    }
}

class Program{
    static void Main(){
        PaidOnlineCourse c1 =new PaidOnlineCourse("DIgitalMarketing", 60, "Online", true, 1400, 10);
        c1.Display();
    }

}
