using System;

namespace Data_Type_Char
{
    internal class Program
    {
        public static void Main(string[] args)
        {
             while (true)
             {
                 char symbol = char.Parse(Console.ReadLine());  // could be improved by adding a check for the console return 
                 Console.WriteLine($"The code of '{symbol}' is {(int)symbol}");  // a bit sloppy but works pretty well for the job that it must do
             }
        }
    }
}