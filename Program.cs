namespace assignment1_oop
{
    using System;

    #region q1

    //public enum WeekDays
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Days of the week:");

    //        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
    //        {
    //            Console.WriteLine(day);
    //        }
    //    }
    //}

    #endregion

    #region q2

    //public struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Person[] persons = new Person[3];
    //        persons[0] = new Person("ahmed", 25);
    //        persons[1] = new Person("aya", 30);
    //        persons[2] = new Person("ali", 35);

    //        Console.WriteLine("Details of persons:");

    //        foreach (var person in persons)
    //        {
    //            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    //        }
    //    }
    //}


    #endregion

    #region q3

    //public enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
    //        string input = Console.ReadLine();

    //        if (Enum.TryParse(input, true, out Season season))
    //        {
    //            switch (season)
    //            {
    //                case Season.Spring:
    //                    Console.WriteLine("Spring: March to May");
    //                    break;
    //                case Season.Summer:
    //                    Console.WriteLine("Summer: June to August");
    //                    break;
    //                case Season.Autumn:
    //                    Console.WriteLine("Autumn: September to November");
    //                    break;
    //                case Season.Winter:
    //                    Console.WriteLine("Winter: December to February");
    //                    break;
    //                default:
    //                    Console.WriteLine("Invalid season.");
    //                    break;
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid input. Please enter one of the following: Spring, Summer, Autumn, Winter.");
    //        }
    //    }
    //}

    #endregion

    #region q4

    //// Define an enum for Permissions with Flags attribute
    //[Flags]
    //public enum Permissions
    //{
    //    None = 0,
    //    Read = 1,
    //    Write = 2,
    //    Delete = 4,
    //    Execute = 8
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Create a variable with no permissions initially
    //        Permissions userPermissions = Permissions.None;

    //        // Add permissions to the variable
    //        userPermissions |= Permissions.Read;
    //        userPermissions |= Permissions.Write;

    //        Console.WriteLine($"Current Permissions: {userPermissions}");

    //        // Check if a specific permission exists
    //        Console.WriteLine("Checking permissions:");
    //        Console.WriteLine($"Has Read: {userPermissions.HasFlag(Permissions.Read)}");
    //        Console.WriteLine($"Has Execute: {userPermissions.HasFlag(Permissions.Execute)}");

    //        // Remove a permission
    //        userPermissions &= ~Permissions.Write;
    //        Console.WriteLine($"Permissions after removing Write: {userPermissions}");

    //        // Add Execute permission
    //        userPermissions |= Permissions.Execute;
    //        Console.WriteLine($"Permissions after adding Execute: {userPermissions}");
    //    }
    //}

    #endregion

    #region q5

    //public enum Colors
    //{
    //    Red,
    //    Green,
    //    Blue
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a color name:");
    //        string input = Console.ReadLine();

    //        if (Enum.TryParse(input, true, out Colors color))
    //        {
    //            switch (color)
    //            {
    //                case Colors.Red:
    //                case Colors.Green:
    //                case Colors.Blue:
    //                    Console.WriteLine($"{color} is a primary color.");
    //                    break;
    //                default:
    //                    Console.WriteLine($"{color} is not a primary color.");
    //                    break;
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid color input. Please enter Red, Green, or Blue.");
    //        }
    //    }
    //}

    #endregion

    #region q6

    //public struct Point
    //{
    //    public double X { get; set; }
    //    public double Y { get; set; }

    //    public Point(double x, double y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public double DistanceTo(Point other)
    //    {
    //        return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter the X and Y coordinates for the first point, separated by a space:");
    //        string[] point1Input = Console.ReadLine().Split(' ');
    //        Point point1 = new Point(
    //            double.Parse(point1Input[0]),
    //            double.Parse(point1Input[1])
    //        );

    //        Console.WriteLine("Enter the X and Y coordinates for the second point, separated by a space:");
    //        string[] point2Input = Console.ReadLine().Split(' ');
    //        Point point2 = new Point(
    //            double.Parse(point2Input[0]),
    //            double.Parse(point2Input[1])
    //        );

    //        double distance = point1.DistanceTo(point2);
    //        Console.WriteLine($"The distance between the two points is: {distance:F2}");
    //    }
    //}

    #endregion

    #region q7

    //public struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Person[] persons = new Person[3];

    //        for (int i = 0; i < 3; i++)
    //        {
    //            Console.WriteLine($"Enter the name of person {i + 1}:");
    //            string name = Console.ReadLine();

    //            Console.WriteLine($"Enter the age of person {i + 1}:");
    //            int age = int.Parse(Console.ReadLine());

    //            persons[i] = new Person(name, age);
    //        }

    //        Person oldestPerson = persons[0];
    //        foreach (var person in persons)
    //        {
    //            if (person.Age > oldestPerson.Age)
    //            {
    //                oldestPerson = person;
    //            }
    //        }

    //        Console.WriteLine($"The oldest person is {oldestPerson.Name} with {oldestPerson.Age} years.");
    //    }
    //}


    #endregion
}
