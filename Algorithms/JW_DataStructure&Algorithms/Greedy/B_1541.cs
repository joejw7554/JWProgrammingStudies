using System;
using System.Collections.Generic;
using System.Text;

//https://www.acmicpc.net/problem/1541
class B_1541
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] separated = input.Split('-');


        int sum = Sum(separated[0]);


        for (int i = 1; i < separated.Length; i++)
        {
            sum -= Sum(separated[i]);
        }

        Console.WriteLine(sum);

    }

    static int Sum(string group)
    {
        int sum = 0;
        var numbers = group.Split('+');

        foreach (var number in numbers)
        {
            sum += int.Parse(number);
        }
        return sum;
    }
}

