using Vehicles;
    namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver("John",true);

            Car volvo = new Car(4,5,true,true,"asdfghjkl",driver);
            volvo.StartEngine();
            volvo.Accelerate(50);
            Console.WriteLine($"The Volvo is going at {volvo.speed}km/h");
            
            driver = new Driver("Steve",false);

            Car bmw = new Car(4,5,false,false,"qwertyuiop",driver);
            bmw.StartEngine();
            bmw.Accelerate(100);
            Console.WriteLine($"The BMW is going at {bmw.speed}km/h");

            volvo.Decelerate(20);
            Console.WriteLine($"Now the Volvo is going at {volvo.speed}km/h");

            driver = new Driver("Bob",true);

            Car mazda = new Car(4,3,false,true,"zxcvbnm",driver);
            mazda.StartEngine();
            mazda.Accelerate(10);
            double mazdaSpeed = mazda.GetCurrentSpeed();

            Console.WriteLine($"The Mazda is going at {mazdaSpeed}km/h\n");

            Console.WriteLine($"Does the Volvo have GPS? {volvo.hasGps}\nDoes the BMW have GPS? {bmw.hasGps}\nDoes the Mazda have GPS? {mazda.hasGps}");
            Console.WriteLine();
            Console.WriteLine($"How many doors does the Volvo have? {volvo.numOfDoors}.\nHow many doors does the BMW have? {bmw.numOfDoors}." +
                $"\nHow many doors does the Mazda have? {mazda.numOfDoors}.");


            //volvo.Decelerate(400);
            Console.WriteLine();

            Console.WriteLine($"{volvo.currentDriver.name} is driving the Volvo at {volvo.speed}km/h.\nIt has {volvo.numOfWheels} wheels and {volvo.numOfDoors} doors.\nThe vin number is {volvo.vinNumber} and does {volvo.currentDriver.name} have a license? {volvo.currentDriver.hasLicense}");
            //Console.WriteLine("Hello, World!");
        }
    }
}
