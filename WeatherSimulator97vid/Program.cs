namespace WeatherSimulator97vid
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate");
            int days = int.Parse(Console.ReadLine());
            int[] temperature = new int[days];
            string[] conditions = { "Sunny,", "Rainy", "cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                Console.WriteLine(temperature[i]);

                weatherConditions[i] = conditions[random.Next(conditions.Length)];
                Console.WriteLine(weatherConditions[i]);
            }


            Console.WriteLine("Hello, World!");
        }
    }
}
