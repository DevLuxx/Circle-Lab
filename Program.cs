namespace Circle_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double radius;
            bool isValid;

            do
            {
                Console.Write("Enter the radius of the circle: ");
                string input = Console.ReadLine();

                isValid = double.TryParse(input, out radius);

                if (!isValid || radius <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive number.");
                }

            }
            while (!isValid || radius <= 0);

            Circle circle = new Circle(5.0);




            Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
            Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
            Console.WriteLine($"Area: {circle.CalculateArea()}");

            Console.Write("Would you like the circle to grow (yes/no)? ");
            string growInput = Console.ReadLine();

            if (growInput.ToLower() == "yes")
            {
                circle.Grow();
                Console.WriteLine($"Circle has grown. The new radius is: {circle.GetRadius()}");
            }
            else
            {
                Console.WriteLine($"Goodbye! Current radius: {circle.GetRadius()}");
            }

        }

    }
}