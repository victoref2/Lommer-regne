﻿
int first_number;
int second_number;
string what_do;



string boomer = "per";



string boomer_do = "Work on Antwar";

while (boomer != boomer_do) {

    Console.WriteLine("What is the first number you would like to use in the Calculation");

    Console.Write("number:\t");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    first_number = Convert.ToInt32(Console.ReadLine());
      




    Console.WriteLine("what is the second number you would like to use");




    Console.WriteLine("wanna do more? Yes or no");
    string awnser = Console.ReadLine();
    if(awnser == "yes" || awnser == "y")
    {

    }else
    {
        boomer = boomer_do;
    }
#pragma warning restore CS8600
}






