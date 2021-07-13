using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        if (number < 0)
            number = number * -1;
        number = number % 10;
        Console.Write("{0}", number);
        return number;
    }
}