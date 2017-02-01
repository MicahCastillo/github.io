using System;


namespace ch2_formatting
{
    /// <summary>
    /// Class:      program
    /// Developer:  Micah Castillo
    /// Date:       1/25/2017
    /// Purpose:    use C# formatting
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double price = 1089.30;
            Console.WriteLine("the price is {0:C}", price);
            Console.WriteLine("negative two as currency {0:C}", -2);
            Console.WriteLine("the price as fixed {0:F0}" ,price);
            Console.Read();
        }
    }
}
