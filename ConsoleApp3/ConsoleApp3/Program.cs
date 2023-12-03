using System;
using System.Threading;

// Клас Дорога
public class Road
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int Lanes { get; set; }
    public int TrafficLevel { get; set; }
    // Інші властивості та методи для відстеження трафіку і т.д.
}

// Клас Транспортний засіб
public class Vehicle : IDriveable
{
    public double Speed { get; set; }
    public double Size { get; set; }
    public string? Type { get; set; }

    public void Move()
    {
        // Логіка руху транспортного засобу
        Console.WriteLine($"Vehicle of type '{Type}' is moving at speed {Speed}.");
    }

    public void Stop()
    {
        // Логіка зупинки транспортного засобу
        Console.WriteLine($"Vehicle of type '{Type}' has stopped.");
    }
}

// Інтерфейс IDriveable
public interface IDriveable
{
    void Move();
    void Stop();
}

// Клас, що імітує рух та зміну руху різних транспортних засобів залежно від дороги
public class TrafficSimulation
{
    public void SimulateTraffic(Road road, Vehicle vehicle)
    {
        // Логіка для імітації руху транспортного засобу в залежності від дороги
        Console.WriteLine($"Simulating traffic on road with {road.Lanes} lane(s) and length {road.Length} km...");

        // Можна використовувати характеристики дороги та транспортного засобу для прийняття рішень
        if (vehicle.Speed < 40 && road.TrafficLevel > 70)
        {
            vehicle.Stop();
            Thread.Sleep(2000); // Затримка для імітації зупинки на переповненій дорозі
        }
        else
        {
            vehicle.Move();
            Thread.Sleep(1000); // Затримка для імітації руху транспорту
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання для імітації руху транспортного засобу на дорозі
        Road road = new Road { Length = 10, Width = 5, Lanes = 2, TrafficLevel = 80 };
        Vehicle car = new Vehicle { Type = "Car", Speed = 30, Size = 2 };

        TrafficSimulation simulation = new TrafficSimulation();
        simulation.SimulateTraffic(road, car);
    }
}
