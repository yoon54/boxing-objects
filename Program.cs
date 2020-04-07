using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> newObject = new List<object>();
            newObject.Add(7);
            newObject.Add(28);
            newObject.Add(-1);
            newObject.Add(true);
            newObject.Add("chair");
            int sum = 0;
            for (var idx = 0; idx < newObject.Count; idx++)
                {
                    Console.WriteLine(newObject[idx]);
                }
            foreach(object thing in newObject)
            {
                if(thing is int)
                {
                    sum = sum + (int)thing;
                }
            
        }
        Console.WriteLine(sum);
    }
    }
}
