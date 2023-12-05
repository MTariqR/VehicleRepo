using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vehicles
{
    internal class Car
    {
        public int numOfWheels;
        public int numOfDoors;
        public double speed;
        public bool hasGps;
        public bool hasRegistrationLicense;
        double fuelLevel;
        public string vinNumber;
        public Driver currentDriver;





        public Car(int NumOfWheels, int NumOfDoors, bool HasGps, bool HasRegistratrionLicense, string VinNumber,Driver driver)
        {
            numOfWheels = NumOfWheels;
            numOfDoors = NumOfDoors;
            hasGps = HasGps;
            hasRegistrationLicense = HasRegistratrionLicense;
            vinNumber = VinNumber;
            currentDriver = driver;
        }
        public void StartEngine()
        {
            speed = 1;
        }

        public void StopEngine()
        {
            speed = 0;
        }

        public void Accelerate(double speedUp)
        {
            speed += speedUp;
        }

        public void Decelerate(double slowDown)
        {
            speed -= slowDown;
            if (speed < 0) 
            {
                speed = 0;
            }
        }

        public double GetCurrentSpeed()
        {
            return speed;
        }
    }
}
