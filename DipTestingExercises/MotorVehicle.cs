using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipTestingExercises
{
    public abstract class MotorVehicle: IVehicle
    {
        IPerson driver;
        public int maxFuel { get; set; }
        public int currentFuel { get; set; }
        public int litresPerKM { get; set; }


        public MotorVehicle(IPerson pDriver, int pMax, int pCurrent, int pLitresPerKM)
        {
            driver = pDriver;
            maxFuel = pMax;
            currentFuel = pCurrent;
            litresPerKM = pLitresPerKM;
        }


        public void refuel()
        {
            currentFuel = maxFuel;
        }

        public int getFuelRemaining()
        {
            return currentFuel;
        }

        public void travel(int pKMTavelled)
        {
            currentFuel -= litresPerKM * pKMTavelled;
        }

    }
}
