namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Proado", 25000, 4);
            car1.ShowAllInfo();
            Car car2 = new Car("Lexus", "LX-570", 38000, 4);
            car2.ShowAllInfo();
            Car car3 = new Car("Mercedes-Benz", "Maybach S-600 Guard", 5000000, 4);
            car3.ShowAllInfo();

            Motorcycle moto1 = new Motorcycle("Ducati", "Multistrada", 3000, 2);
            moto1.ShowAllInfo();
            Motorcycle moto2 = new Motorcycle("Ducati", "Scrambler", 4000, 2);
            moto2.ShowAllInfo();
            Motorcycle moto3 = new Motorcycle("Ducati", "Panigale", 2000, 2);
            moto3.ShowAllInfo();
        }
        class Vehicle
        {
            public string Brand;
            public string Model;
            public double Mile;
            public Vehicle(string brand, string model, double mile)
            {
                Brand = brand;
                Model = model;
                Mile = mile;
            }
            public void ShowAllInfo()
            {
                Console.WriteLine($"Brand:{Brand},Model:{Model},Mile:{Mile}");
            }
        }
        class Car : Vehicle
        {
            public int DoorsNum;
            public Car(string brand, string model, int mile, int doorsNum) : base(brand, model, mile)
            {
                DoorsNum = doorsNum;
            }

            public void ShowAllInfo()
            {
                base.ShowAllInfo();
                Console.WriteLine($"Qapi sayi: {DoorsNum}");
            }
        }
        class Motorcycle : Vehicle
        {
            public int WheelNum;

            public Motorcycle(string brand, string model, int mile, int wheelNum) : base(brand, model, mile)
            {
                WheelNum = wheelNum;
            }

            public void ShowAllInfo()
            {
                base.ShowAllInfo();
                Console.WriteLine($"Teker sayi: {WheelNum}");
            }
        }

    }
}