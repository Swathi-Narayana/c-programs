
using System;
using System.Collections.Generic;
class GFG
{
    static public void Main()
    {
        Dictionary<int, string> My_dict =
                    new Dictionary<int, string>();
        
        My_dict.Add(1123, "Welcome");
        My_dict.Add(1124, "to");
        My_dict.Add(1125, "solvencia");
        foreach (KeyValuePair<int, string> ele in My_dict)
        {
            Console.WriteLine("{0} and {1}",
                        ele.Key, ele.Value);
        }
        Console.WriteLine();
        My_dict.Remove(1124);
        foreach (KeyValuePair<int, string> ele in My_dict)
        {
            Console.WriteLine("{0} and {1}",
                        ele.Key, ele.Value);
        }
        Console.WriteLine();
        My_dict.Clear();
        Console.WriteLine("Total number of key/value " +
        "pairs present in My_dict:{0}", My_dict.Count);

    }
}
