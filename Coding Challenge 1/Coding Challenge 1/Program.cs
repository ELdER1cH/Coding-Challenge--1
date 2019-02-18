using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 3, 4, 5, 6 };
            int[] input2 = { 2, 3, 6, 4, 8 };
            int[] tempInput1 = input1;
            int[] tempInput2 = input2;
            int counter = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int[] outputUnion = new int[input1.Length + input2.Length];
            int[] outputIntersection = new int[input1.Length];
            //---------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < input1.Length; i++)
            {
                if (input2.Contains(input1[i]))
                {
                    outputIntersection[counter] = input1[i];
                    counter++;
                }
            }
            //---------------------------------------------------------------------------------------------------------------
            for (int n = 0; n < input1.Length; n++)
            {
                if (input2.Contains(input1[n]))
                {
                    for (int i = 0; i < input1.Length; i++)
                    {
                        if (input1[n] == tempInput2[i])
                            tempInput2[i] = 0;                            
                    }
                }
                
            }
            //-------------------------------------------------------
            for (int m = 0; m < tempInput2.Length; m++)
            {
                outputUnion[m] = input1[m];
            }
            //-------------------------------------------------------
            for (int j = 0; j < tempInput2.Length; j++)
            {
                outputUnion[j + input1.Length]= tempInput2[j];
            }

            Array.Sort(outputUnion);
            Array.Sort(outputUnion);
            //---------------------------------------------------------------------------------------------------------------
            //Output
            Console.WriteLine("Output Intersection");
            foreach (var item in outputIntersection)
            {
                Console.Write(outputIntersection[counter1]);
                counter1++;
            }
            Console.WriteLine();
            Console.WriteLine("Output Union");
            foreach (var item in outputUnion)
            {
                Console.Write(outputUnion[counter3]);
                counter3++;
            }
            Console.ReadLine();
        }
    }
}
