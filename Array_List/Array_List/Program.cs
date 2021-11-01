using System;
using System.Collections;


namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            Console.WriteLine("Add some element in ArrayList");

            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Add(9);
            arrayList.Add(15);
            arrayList.Add(45);
            arrayList.Add(798);
            arrayList.Add(654);
            arrayList.Add(654);
            arrayList.Add(654);

            Console.WriteLine(arrayList.Capacity);
            Console.WriteLine(arrayList.Count);

            foreach(int i in arrayList)
                Console.Write(i + " ");

            Console.ReadKey();
        } 
    }
}
