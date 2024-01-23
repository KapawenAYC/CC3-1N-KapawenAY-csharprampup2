namespace C__first_project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PART 1");
            Console.WriteLine();

            Console.Write("Weight in pound (lbs): ");
            int pound = Convert.ToInt32(Console.ReadLine());
            double userName = pound;
            double sum = pound * 0.45359237;
            Console.WriteLine("Weight converted to kilograms (kg): " + sum);
            Console.WriteLine("======================================================");

            Console.Write("Length in Miles (mi): ");
            int milesInput = Convert.ToInt32(Console.ReadLine());
            double miles2 = milesInput;
            double kilometer = miles2 * 1.6;
            Console.WriteLine("Length in Kilometer (km): " + kilometer);
            Console.WriteLine("======================================================");

            Console.Write("Temperature in Fahrenheiht (F): ");
            int fahren = Convert.ToInt32(Console.ReadLine());
            double fahrenCon = fahren;
            double cel = fahrenCon - 32 * 5 / 9;
            Console.WriteLine("Temperature in Celsius (C): " + cel);
            Console.WriteLine("======================================================");

            Console.Write("Age of Student 1: ");
            int student1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 2: ");
            int student2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 3: ");
            int student3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 4: ");
            int student4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 5: ");
            int student5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 6: ");
            int student6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 7: ");
            int student7 = Convert.ToInt32(Console.ReadLine());
            Console.Write   ("Age of Student 8: ");
            int student8 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 9: ");
            int student9 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 10: ");
            int student10 = Convert.ToInt32(Console.ReadLine());
            int addi = student1 + student2 + student3 + student4 + student5 + student6 + student7 + student8 + student9 + student10;
            double mean = addi / 10;
            Console.WriteLine("The average age of the students is: " + mean);
            Console.WriteLine("======================================================");

            string hero = "Aldric";
            string friend1 = "James";
            string kalaban = "Satanas";
            string friend2 = "Ninoy";
            string friend3 = "Cardo";

            string weapon = "Black Espada";
            string weapon2 = "Blue Bow";
            string potion = "Elixir";
            string artifact = "Booger Bomb";

            Console.WriteLine($"In Baguio, {hero} and {friend1} wielded {weapon} and {weapon2},");
            Console.WriteLine($"guided by {friend2} and assisted by {friend3} with a {potion}.");
            Console.WriteLine($"Their quest is to retrieve the {artifact} to defeat {kalaban}.");
            Console.WriteLine($"Baguio's fate hinged on their courage and resilience.");
            Console.WriteLine("======================================================");

            Console.WriteLine("PART 2");
            Console.WriteLine();
            Console.Write("Input: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input1; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                
            }
            if (input1 <= 0)
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Input: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Formula: ");
            int sumAll = 0;
            for (int i = 1;i < input2; i++)
            {
                sumAll += i;
                Console.Write(i + "+");
                if (i+1 == input2) 
                {
                    int sumAll2 = sumAll + input2;
                    Console.Write(input2);
                    Console.WriteLine();
                    Console.WriteLine("Output: " + sumAll2);
                }
            } 

            Console.WriteLine();
            Console.Write("Input: ");
            int input3 = Convert.ToInt32(Console.ReadLine());

            for (int i = input3; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

