namespace enumExample;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(Days.Sunday);
        Console.WriteLine((int)Days.Saturday);
        Console.WriteLine((int)Days.Sunday); // we use cast (int) operation.

        int tempature = 32;
        if (tempature <= (int)WheatherTempature.Cold)
            Console.WriteLine("It's too cold to go out");
        else if (tempature >= (int)WheatherTempature.Normal)
            Console.WriteLine("It's too hot to go out");
        else if (tempature >= (int)WheatherTempature.Normal && tempature < (int)WheatherTempature.VeryHot)
            Console.WriteLine("Let's go outside!");

    }

    enum Days
    {
        Monday, //monday members index = 0
        Tuesday, // index = 1
        Wednesday, //index = 2
        Thursday, // index = 3
        Friday = 23,
        Saturday, // now this index will be = 24
        Sunday // index will be = 25
    }
}

enum WheatherTempature
{
    Cold = 5,
    Normal = 20,
    Hot = 25,
    VeryHot = 30
}
