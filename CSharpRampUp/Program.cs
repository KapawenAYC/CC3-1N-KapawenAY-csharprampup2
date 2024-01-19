namespace C__first_project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PART 1");
            Console.WriteLine(" ");

            Console.WriteLine("Weight in pound (lbs)");
            int username = Convert.ToInt32(Console.ReadLine());
            double userName = username;
            double sum = userName * 0.45359237;
            Console.WriteLine("Weight converted to kilograms (kg): " + sum);
            Console.WriteLine("======================================================");

            Console.WriteLine("Length in Miles (mi): ");
            int milesInput = Convert.ToInt32(Console.ReadLine());
            double miles2 = milesInput;
            double kilometer = miles2 * 1.6;
            Console.WriteLine("Length in Kilometer (km): " + kilometer);
            Console.WriteLine("======================================================");

            Console.WriteLine("Temperature in Fahrenheiht (F): ");
            int fahren = Convert.ToInt32(Console.ReadLine());
            double fahrenCon = fahren;
            double cel = fahrenCon - 32 * 5 / 9;
            Console.WriteLine("Temperature in Celsius (C): " + cel);
            Console.WriteLine("======================================================");

            Console.WriteLine("Age of Student 1: ");
            int student1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 2: ");
            int student2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 3: ");
            int student3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 4: ");
            int student4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 5: ");
            int student5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 6: ");
            int student6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 7: ");
            int student7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 8: ");
            int student8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 9: ");
            int student9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 10: ");
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
            string amulet = "Pink Pendant";
            string potion = "Elixir";
            string artifact = "Booger Bomb";

            Console.WriteLine($"In Baguio, {hero} and {friend1} wielded {weapon} and {weapon2},");
            Console.WriteLine($"guided by {friend2} and assisted by {friend3} with a {potion}.");
            Console.WriteLine($"Their quest is to retrieve the {artifact} to defeat {kalaban}.");
            Console.WriteLine($"Baguio's fate hinged on their courage and resilience.");
            Console.WriteLine("======================================================");

            Console.WriteLine("PART 2");

            // Input validation for number pattern
            int patternInput = 0;

            while (patternInput <= 0)
            {
                Console.Write("\nEnter a number for pattern: ");
                patternInput = int.Parse(Console.ReadLine());

                if (patternInput <= 0)
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            Console.WriteLine("\nNumber Pattern (Task 1):");
            int i = 1;

            while (i <= patternInput)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write(j + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }

            // Input validation for sum calculation
            int sumInput = 0;

            while (sumInput <= 0)
            {
                Console.Write("\nEnter a number for sum calculation: ");
                sumInput = int.Parse(Console.ReadLine());

                if (sumInput <= 0)
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            int sums = 0;
            i = 1;

            while (i <= sumInput)
            {
                sums += i;
                i++;
            }
            Console.WriteLine("\nSum Calculation (Task 2): Formula: 1 + 2 + 3 + ... + " + sumInput);
            Console.WriteLine("Result: " + sums);

            // Input validation for decreasing pattern
            int decreasingPatternInput = 0;

            while (decreasingPatternInput <= 0)
            {
                Console.Write("\nEnter a number for decreasing pattern: ");
                decreasingPatternInput = int.Parse(Console.ReadLine());

                if (decreasingPatternInput <= 0)
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            Console.WriteLine("\nDecreasing Number Pattern:");
            i = decreasingPatternInput;

            while (i >= 1)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write(j + " ");
                    j++;
                }
                Console.WriteLine();
                i--;
            }

        }
    }
}

