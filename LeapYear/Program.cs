// See https://aka.ms/new-console-template for more information
int inputNum;

if (args.Length == 1)
{
    inputNum = Int32.Parse(args[0]);
} else
{
    string input = Console.ReadLine();
    if (!int.TryParse(input, out inputNum))
    {
        Console.WriteLine("Do not try to fuck me up");
        System.Environment.Exit(0);
    }

}

Console.WriteLine(isLeapYear(inputNum));

bool isLeapYear (int year)
{
    if (1582 < year  && year % 4 == 0)
    {
        if (year % 100 == 0)
        {    
            return year % 400 == 0;
        }
    }
    return false;
}
