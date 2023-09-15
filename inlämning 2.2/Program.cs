using System;
    namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur långt hoppade du Elin mått i meter");
            string långtText = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade du Alma mått i meter");
            string hoppadeText = Console.ReadLine();
            double långt = double.Parse(långtText);
            double hoppade = double.Parse(hoppadeText);
            double skillnad = långt - hoppade;
            Console.WriteLine("elin hoppade" + skillnad + "längre än alma");
        }
    }
}
