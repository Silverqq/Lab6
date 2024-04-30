using System;

abstract class Transport
{
    public abstract double Speed { get; }
    public abstract double LoadCapacity { get; }
    public abstract double Range { get; }

    public abstract string GetTransportInfo();
}

abstract class Car : Transport
{
    public override string GetTransportInfo()
    {
        return $"A car with a load capacity of {LoadCapacity} can travel a distance of {Range}";
    }
}

abstract class Airplane : Transport
{
    public override string GetTransportInfo()
    {
        return $"An airplane with a load capacity of {LoadCapacity} can fly a distance of {Range}";
    }
}

abstract class Ship : Transport
{
    public override string GetTransportInfo()
    {
        return $"A ship with a load capacity of {LoadCapacity} can sail a distance of {Range}";
    }
}

class Sedan : Car
{
    public override double Speed => 120;
    public override double LoadCapacity => 500;
    public override double Range => 800;

    public Sedan()
    {
        Console.WriteLine(GetTransportInfo());
    }
}

class PassengerPlane : Airplane
{
    public override double Speed => 900;
    public override double LoadCapacity => 20000;
    public override double Range => 6000;

    public PassengerPlane()
    {
        Console.WriteLine(GetTransportInfo());
    }
}

class CargoShip : Ship
{
    public override double Speed => 25;
    public override double LoadCapacity => 500000;
    public override double Range => 10000;

    public CargoShip()
    {
        Console.WriteLine(GetTransportInfo());
    }
}

class Program
{
    static void Main()
    {
        Sedan sedan = new Sedan();
        PassengerPlane plane = new PassengerPlane();
        CargoShip ship = new CargoShip();
    }
}
