using System;

class Device{
    public int DeviceId;
    public string Condition;

    public Device(int deviceId, string condition){
        DeviceId = deviceId;
        Condition = condition;
    }
}

class Thermostat : Device{
    public int TemperatureSetting;

    public Thermostat(int deviceId, string condition, int temperature): base(deviceId, condition){
        TemperatureSetting = temperature;
    }

    public void Displaycondition(){
        Console.WriteLine(DeviceId);
        Console.WriteLine(Condition);
        Console.WriteLine(TemperatureSetting);
    }
}

class Program{
    static void Main(){
        Thermostat t1 = new Thermostat(45, "GOOD", 10);
        t1.Displaycondition();
    }
}