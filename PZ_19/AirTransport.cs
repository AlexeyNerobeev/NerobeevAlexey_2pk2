using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class AirTransport : Transport
    {
        public override void TransportCargo()
        {
            Console.WriteLine($"Перевозка грузов воздушным транспортом на расстояние: {Distance} км");
            Console.WriteLine($"Перевозка грузов воздушным транспортом по следующей цене: {Price}");
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() * 2.0; 
        }
    }
}
