using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Program
    {
        struct Student
        {
            public int no;
            public string name;
            public DateTime Date;
        }
        private static void showfor(int[] forarray)
        {
            foreach (int i in forarray)
            {
                Console.WriteLine(i);
            }
        }
        private static string showfor2(int[] forarray)
        {
            foreach (int i in forarray)
            {  
                Console.WriteLine(i); 
            }
        return "0";
     }
    static void Main(string[] args)
    { 
            int[] Aarray = new int[] { 1, 2, 3, 4, 5};
            int[,] Barray = new int[5, 11];
            int[] Carray = new int[99];
            int Alength = Aarray.Length;
            int Alowbound = Aarray.GetLowerBound(0);
            int Aupbound = Aarray.GetUpperBound(0);
            int BlowBound = Barray.GetUpperBound(0);
            Carray[0] = 70;
            Carray.SetValue(70, 1);
            for (int i = 0; i < Alength; i++) 
            {
                Console.WriteLine(Aarray[i]);
            }
            showfor(Aarray);
            
            /*int index = 0:
            foreach (int i in Aarray)
            {
                Console.WriteLine(i);
                index = 1;
            }*/
            Console.WriteLine(Aarray.Reverse());
            int[] Darray = new int[] { 5, 4, 3, 2, 1 };123
            showfor(Darray);
            Array.Sort(Darray);

            Student[] Std = new Student[]
            {
                new Student(){no=1001,name="王曉明",Date=DateTime.Now},
                new Student(){no=1002,name="Mary",Date = DateTime.Parse("2025/03/04") }
            };
            Console.Read();
        }
    }
}
