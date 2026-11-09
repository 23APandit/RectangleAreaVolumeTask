namespace RectangleAreaVolumeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a partially writen program in C#
            // to calculate the area of a rectangle or the volume of a box
            // from the user inputs
            // Complete the code in both the main program and in the function
            // so the program will take 3 user inputs and output either the area or volume
            // test your program with the following inputs
            
            // | width   | length    | height |
            // |   5     |    6      |   -1   |
            // |   10    |    4      |    0   |
            // |   3     |    5      |    10  |
            
            // Show your test evidence in the Readme

            int width, length, height;
            
            //prompt for width
            Console.Write("Enter width: ");
            width = Convert.ToInt32(Console.ReadLine());

            //prompt for length
            Console.Write("Enter length: ");
            length = Convert.ToInt32(Console.ReadLine());

            //prompt for height
            Console.Write("Enter height (enter -1 to ignore): ");
            height = Convert.ToInt32(Console.ReadLine());

            //call func
            int answer = RectangleCalculator(width, length, height);
        }
        static int RectangleCalculator(int width, int length,int height) { 
             
            if (height == -1) //for area
            {
                int area = length * width;
                Console.WriteLine($"Area is : {area}");
            }
            else //for volume
            {
                int vol = length * width * height;
                Console.WriteLine($"Volume is : {vol}");
            }
            return 0; // should never happen
        }
    }
}
