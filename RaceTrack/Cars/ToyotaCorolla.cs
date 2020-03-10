using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class ToyotaCorolla : RaceCar
    {
        public ToyotaCorolla()
        {
            Name = "Toyota Corolla";
            TopSpeed = 110; // It's the Model S!
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} fires up immediately, with its engine purring like a kitten.");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} comes to an exceedingly quick stop, almost as if on a dime!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name}'s engine is commanded to halt, and halt it does.");
        }
    }
}
