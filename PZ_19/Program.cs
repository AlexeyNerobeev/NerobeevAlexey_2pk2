namespace PZ_19
{
    internal class Program
    {
        static void Main(string[] args) // Неробеев Алексей
        {
            Transport transport1 = new SeaTransport { Distance = 100, Price = 10 };
            transport1.TransportCargo();
            Console.WriteLine("");
            Transport transport2 = new RailwayTransport { Distance = 200, Price = 5 };
            transport2.TransportCargo();
            Console.WriteLine("");
            Transport transport3 = new AirTransport { Distance = 300, Price = 15 };
            transport3.TransportCargo();
            Console.WriteLine("");
            Transport transport4 = new SeaTransport { Distance = 400, Price = 20 };
            transport4.TransportCargo();
            Console.WriteLine("");
            Transport transport5 = new RailwayTransport { Distance = 500, Price = 25 };
            transport5.TransportCargo();
            Console.WriteLine("");
            Transport transport6 = new AirTransport { Distance = 600, Price = 30 };
            transport6.TransportCargo();
            Console.WriteLine("");
            Transport transport7 = new SeaTransport { Distance = 700, Price = 35 };
            transport7.TransportCargo();
            Console.WriteLine("");
            Transport transport8 = new RailwayTransport { Distance = 800, Price = 40 };
            transport8.TransportCargo();
            Console.WriteLine("");
            Transport transport9 = new AirTransport { Distance = 900, Price = 45 };
            transport9.TransportCargo();
            Console.WriteLine("");
            Transport transport10 = new SeaTransport { Distance = 1000, Price = 50 };
            transport10.TransportCargo();
            Console.WriteLine("");

            Transport totalTransport = transport1 + transport2 + transport3 + transport4 + transport5 + transport6 + transport7 + transport8 + transport9 + transport10;

            Console.WriteLine($"Общее расстояние: {totalTransport.Distance}");
            Console.WriteLine($"Итоговая цена: {totalTransport.Price}");
            Console.WriteLine($"Общая стоимость: {totalTransport.CalculateCost()}\n");

            Transport diffTransport = transport2 - transport1;

            Console.WriteLine($"Разница в расстоянии: {diffTransport.Distance}");
            Console.WriteLine($"Разница в цене: {diffTransport.Price}");
            Console.WriteLine($"Разница в стоимости: {diffTransport.CalculateCost()}");
        }
    }
}
