namespace Properties_DamienAd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates an object "car" and sets its make and model
            Car car = new Car(); 
            car.Make = "Ford"; 
            car.Model = "Mustang"; 
            //prints car make and model to console
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            //Creates an object "car2" and sets its make and model
            Car car2 = new Car(); 
            car2.Make = "Chevy"; 
            car2.Model = "Camero";
            //prints car2 make and model to console
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            Car car3 = new Car();
            //prints car3 make and model to console
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
        }
    }
    
    }
