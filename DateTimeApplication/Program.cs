using System;

namespace DateTimeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //zjistí jaký den bylo datum 6. července 1415
            DateTime year = DateTime.Now;
            int yearInt = year.Year;
            DateTime d1 = new DateTime(1415, 7, 6);
            Console.WriteLine("Part 1");
            Console.WriteLine("6.7.1415 byl " + d1.DayOfWeek);
            Console.WriteLine("");
            Console.WriteLine("Part 2 ");

            //vypočte a vypíše nejblížších 5 let v budoucnosti, kdy 6. červenec připadne na stejný den v týdnu a výpočet dní do dané situace
            int yearCount = 0;
            while (yearCount < 5)
            {
                year = new DateTime(yearInt, 7, 6);
                if (year.DayOfWeek == d1.DayOfWeek)
                {
                    Console.WriteLine("Další rok, kdy 6. července připadne na stejný den bude: " + year.Year);
                    if(yearCount==0)
                    {
                        double diff = (year - DateTime.Now).TotalDays;
                        Console.WriteLine("Do tohoto dne zbývá: " +(int)diff + " dní");
                    }
                    yearCount += 1;
                }
                yearInt += 1;
            }

            //vypište jak dlouho trval výpočet
        }
    }
}
