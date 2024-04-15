
float first_number;
float second_number;
string what_do ="well thats allright then!";
float answer;
string calculation;

string boomer = "per";



string boomer_do = "Work on Antwar";

while (boomer != boomer_do)
{

    Console.WriteLine("What is the first number you would like to use in the Calculation");


    Console.Write("number:\t");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    first_number = (float)Convert.ToDouble(Console.ReadLine());
    

    Console.WriteLine("what is the second number you would like to use");
    Console.Write("number:\t");
    second_number = (float)Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("You can use either: +,-,*,/");
    Console.Write("Choice:\t");
    calculation = Console.ReadLine();

    if (calculation == "+")
    {
        answer = first_number + second_number;
        Console.WriteLine($"The resault is {answer}");
    }
    else if (calculation == "-")
    {
        answer = first_number - second_number;
        Console.WriteLine($"The resault is {answer}");
    }
    else if (calculation == "*")
    {
        answer = first_number * second_number;
        Console.WriteLine($"The resault is {answer}");
    }
    else if (calculation == "/")
    {
        answer = first_number / second_number;
        Console.WriteLine($"The resault is {answer}");
    }
    else
    {
        Console.WriteLine("This aint it chief");
    }

    Console.WriteLine("wanna do more? Yes or no");
    string Word_awnser = Console.ReadLine();
    if (Word_awnser == "yes" || Word_awnser == "y")
    {

    }
    else
    {
        Console.WriteLine(what_do);
        boomer = boomer_do;
        Console.WriteLine("\n" +
            "░░░░░▐▀█▀▌░░░░▀█▄░░░\r\n" +
            "░░░░░▐█▄█▌░░░░░░▀█▄░\r\n" +
            "░░░░░░▀▄▀░░░▄▄▄▄▄▀▀░\r\n" +
            "░░░░▄▄▄██▀▀▀▀░░░░░░░\r\n" +
            "░░░█▀▄▄▄█░▀▀░░░░░░░░\r\n" +
            "░░░▌░▄▄▄▐▌▀▀▀░░░░░░░ THIS IS BOB\r\n" +
            "▄░▐░░░▄▄░█░▀▀ ░░░░░░\r\n" +
            "▀█▌░░░▄░▀█▀░▀ ░░░░░░ HE IS STARTING AN UPRISING AND REQUESTS YOU JOIN HIM\r\n" +
            "░░░░░░░▄▄▐▌▄▄░░░░░░░ COPY AND PASTE HIM TO MAKE EVERYONE ELSE AWARE\r\n" +
            "░░░░░░░▀███▀█░▄░░░░░\r\n" +
            "░░░░░░▐▌▀▄▀▄▀▐▄░░░░░\r\n" +
            "░░░░░░▐▀░░░░░░▐▌░░░░\r\n" +
            "░░░░░░█░░░░░░░░█░░░░\r\n" +
            "░░░░░▐▌░░░░░░░░░█░░░\r\n");
    }
#pragma warning restore CS8600
}