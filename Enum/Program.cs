using System;


namespace Enum
{
    public enum TraficLight
    {
        Red,
        Green,
        Yellow
    }

    class Program
    {
        public enum DaysInWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        [Flags]  // Represents combination of values using bitwise operations
        public enum FileName
        {
            Name = 0000,
            Age = 0100,
            Gender = 0010,
            Birthday = 0001,
            Contains = Name | Age | Gender | Birthday
        }

        

        public static void Main()
        {
            //Console.WriteLine((DaysInWeek)4); // To print the enum with the number auto assignment

            //DaysInWeek.Tuesday = (DaysInWeek)2;  // both are the same things we can also indicate the days with the index values

            //DaysInWeek Today = DaysInWeek.Sunday;

            //DaysInWeek Today = (DaysInWeek)7;

            //Console.WriteLine(Today);

            //Console.WriteLine((FileName)0001);

            //Console.WriteLine((FileName)0111);

            //FileName file = FileName.Age | FileName.Gender;

            //Console.WriteLine(file);

            //if ((FileName.Age & FileName.Gender) == FileName.Name)
            //{
            //    Console.WriteLine("Name");
            //}

            TraficLight CurrentLight = TraficLight.Green;

            switch (CurrentLight)
            {
                case TraficLight.Red:
                    Console.WriteLine("Stop");
                    break;

                case TraficLight.Green:
                    Console.WriteLine("Go");
                    break;
                case TraficLight.Yellow:
                    Console.WriteLine("Wait");
                    break;
            }

        }


    }
}