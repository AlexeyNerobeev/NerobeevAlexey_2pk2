using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class RailwayTransport : Transport
    {
        public override void TransportCargo()
        {
            Console.WriteLine($"Перевозка грузов железнодорожным транспортом на расстояние: {Distance} км");
            Console.WriteLine($"Перевозка грузов железнодорожным транспортом по следующей цене: {Price}");
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() * 1.2;
        }
    }
}
