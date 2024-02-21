using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class Transport
    {
        public double Distance { get; set; }
        public double Price { get; set; }

        public virtual double CalculateCost()
        {
            return Distance * Price;
        }

        public virtual void TransportCargo()
        {
            Console.WriteLine($"Перевозка грузов на расстояние: {Distance} км");
            Console.WriteLine($"Перевозка грузов по следующей цене: {Price}");
        }

        public static Transport operator +(Transport t1, Transport t2)
        {
            Transport newTransport = new Transport
            {
                Distance = t1.Distance + t2.Distance,
                Price = t1.Price + t2.Price
            };
            return newTransport;
        }

        public static Transport operator -(Transport t1, Transport t2)
        {
            Transport newTransport = new Transport
            {
                Distance = Math.Abs(t1.Distance - t2.Distance),
                Price = Math.Abs(t1.Price - t2.Price)
            };
            return newTransport;
        }
    }
}
