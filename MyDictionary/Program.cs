using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> MyList = new Dictionary<int, string>();
            MyList.Add(1, "Yegah");
            MyList.Add(2,"Elif");
            MyList.Add(3, "Mirza");

            foreach ( KeyValuePair<int,string> person in MyList)
            {
               Console.WriteLine(" {0}. person is {1}",person.Key,person.Value);
            }

        }
    }
}
