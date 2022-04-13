using System;

namespace LearnCSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine($"Right now Date and Time is: {dt}");

            Console.WriteLine($"Sort date is: {dt:d}");

            Console.WriteLine($"Long date is: {dt:D}");

            Console.WriteLine($"Sort time is: {dt:f}");

            Console.WriteLine($"Long time is: {dt:F}");

            Console.WriteLine($"This is show general date and time: {dt:g}");

            Console.WriteLine($"This is show general date and time (with long time): {dt:G}");

            Console.WriteLine($"Showing day of month: {dt:m}");

            Console.WriteLine($"Showing day of month (same as above): {dt:M}");

            Console.WriteLine($"Showing sort time: {dt:t}");

            Console.WriteLine($"Showing long time: {dt:T}");

            Console.WriteLine($"Showing year of month: {dt:y}");

            Console.WriteLine($"Showing year of month (same as above): {dt:Y}");

            Console.WriteLine($"Showing year: {dt:yy}");

            Console.WriteLine($"Showing full year: {dt:yyyy}");

            Console.WriteLine($"Showing full year (with five digits): {dt:yyyyy}");

            Console.WriteLine($"Showing week of the day: {dt:ddd}");
            
            Console.WriteLine($"Showing week of the day (with full name of the day): {dt:dddd}");

            Console.WriteLine($"Showing hourse in 24hrs formate: {dt:HH}");

            Console.WriteLine($"Showing minutes: {dt:mm}");

            Console.WriteLine($"Showing secondes: {dt:ss}");

            Console.WriteLine($"Showing seconds (with two digits and showing fractional part of the seconde): {dt:FF}");

            Console.WriteLine($"Showing months in digites (01 to 12): {dt:MM}");

            Console.WriteLine($"Showing month's sort name: {dt:MMM}");

            Console.WriteLine($"Custome time: {dt:hh:mm:ss tt}");

            Console.WriteLine($"Custome date: {dt:dd/MMM/yyyy}");
        }
    }
}
