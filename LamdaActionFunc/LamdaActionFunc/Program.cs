using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class LinqExercise8
{
    static void Main(string[] args)
    {
        string chst, chen;
        string ch;
        string[] cities =  
        {  
            "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"  
        };

        Console.Write("\nLINQ : Find the string which starts and ends with a specific character : ");
        Console.Write("\n-----------------------------------------------------------------------\n");
        Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");

        Console.Write("\nInput starting character for the string : ");
        
        chst = Console.ReadLine();
        Console.Write("\nInput ending character for the string : ");
        chen = Console.ReadLine();


        var _result = from x in cities
            where x.StartsWith(chst)
            where x.EndsWith(chen)
            select x;
        Console.Write("\n\n");
        foreach (var city in _result)
        {
            Console.Write("The city starting with {0} and ending with {1} is : {2} \n", chst, chen, city);
        }

        Console.ReadLine();
    }
}