using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DataTypes
{
    static void Main()
    {
        ushort first = 52130;
        sbyte second = -115;
        int third = 4825932;
        byte forth = 97;
        short fifth = -10000;

        Console.WriteLine(second);
        Console.WriteLine("The five numbers are: {0}, {1}, {2}, {3} and {4}.", first, second, third, forth, fifth);

        if (second < 0)
        {
            Console.WriteLine("I am no fool");
        }

    }
}

