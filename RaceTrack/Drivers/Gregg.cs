using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Gregg : Driver
    {
        public Gregg(RaceCar car) : base(car)
        {
            Name = "Gregg";
            SkillLevel = 15;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
