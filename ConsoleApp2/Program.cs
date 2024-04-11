
int first_number;
int second_number;
string what_do;



string boomer = "per";



string boomer_do = "Work on Antwar";

while (boomer != boomer_do) {

    Console.WriteLine("What is the first number you would like to use in the Calculation");
    



    Console.WriteLine("what is the second number you would like to use");
    second_number = Convert.ToInt32(Console.Read());



    string calculation = Console.ReadLine();
    if (calculation == "+")
    {
       int answer = first_number + second_number;
    }
    else if (calculation == "-")
    {
        int answer = first_number - second_number;
    }
    else if (calculation == "*") 
    {
        int answer = first_number * second_number;
    }
    else  if (calculation == "/")
    {
        int answer = first_number / second_number;
    }
    else
    {
        Console.WriteLine("This aint it chief");
    }
}
