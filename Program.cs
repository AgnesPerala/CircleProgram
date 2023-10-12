namespace CircleProgram;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("skriv in radien i cm på en cirkel");

        bool wrongInput = false; 

        while (!wrongInput) // loop until the bool is false 
        {
            bool success = int.TryParse(Console.ReadLine(), out int inputRadius); // bool for the inuput so you only can whrite in numbers 
            if (success)
            {
                Console.WriteLine($"ditt nummer du valt är {inputRadius}\n");

                // objekt for the class Circle to access the methods in Circle class 
                Circle circle1 = new Circle(inputRadius); 

                Console.WriteLine($"för att räkna ut arean blir det {inputRadius} * {inputRadius} * 3,141");
                Console.WriteLine($"arean på cirklen är då: {circle1.GetCircleArea()}\n"); 

                Console.WriteLine($"för att räkna ut omkretsen blir det {inputRadius} * 2 * 3,141");
                Console.WriteLine($"omkretsen på cirklen är då: {circle1.GetCircleCircumference()}");
                break; // ends the loop when success if true 
            }
            else // continues the loop until the user white in a number 
            {
                Console.WriteLine("du måste skirva in en ett tal för att komma vidare");
            }
        }
    }
}

