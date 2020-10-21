using System;

namespace IndexesRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] intArray = new int[]{0,1,2,3,4,5,6,7,8,9};

            int[] parcial = intArray[2..6];

            foreach(var i in parcial){
                Console.WriteLine(i);
            }

            for (int i =1; i <= parcial.Length; i++){
                Console.WriteLine(parcial[^i]);
            }

        }
    }
    
}
