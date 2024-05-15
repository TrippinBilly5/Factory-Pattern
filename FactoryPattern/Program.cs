namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels on the new vehicle? (2 or 4)");
            var input = Console.ReadLine();
            IVehicle newVehicle =  VehicleFactory.GetVehicle(input);
            newVehicle.Drive();
        }
    }
}
