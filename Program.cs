using static System.Console;
namespace oopTest
{
    internal class Program
    {
        class Car
        {
            public string Colour { get; } = "red";
            /*makes a class called Car with a variable 
             */
        }
        static void Main(string[] args)
        {
            Car myObj = new Car();
            WriteLine(myObj.Colour);
        }
    }
}
