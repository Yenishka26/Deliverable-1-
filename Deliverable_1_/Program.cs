namespace Deliverable_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Input = 0;
            string series = "";

            while (true)
            {
                try
                {
                    Console.Write("Enter interger between 1 to 100: ");
                    Input = int.Parse(Console.ReadLine());

                    if (Input >= 1 && Input <= 100)
                    {
                        break;
                    }
                }catch
                {
                    Console.WriteLine("Only interger numbers are allowed");
                }
            }
            while (true)
            {
                Console.Write("Specify the series type: Even or Odd: ");
                series = Console.ReadLine();

                if (series == "Even" || series == "Odd")
                {
                    break;
                }
            }

            if (series == "Odd")
            {
                Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + Input + " are:");
                for (int i = 1; i <= Input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            if (series == "Even")
            {
                Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + Input + " are:");
                for (int i = 0; i <= Input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
        

    }
}