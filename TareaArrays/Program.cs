using System;
using System.Collections.Generic;


namespace TareaArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = new int[] {1, 2, 3, 4, 5};

            numArr[1] = 6;
            //numArr[4] = 7;
            numArr[numArr.Length - 1] = 7;

            //numArr[0] = 0;

            // 0, 6, 3, 4, 7
            //6, 3, 4, 7, 8
            //numArr[0] = 6;
            //numArr[1] = 3;
            //numArr[2] = 4;
            //numArr[3] = 7;

            for (int i = 0; i < numArr.length; i++)
            {
                numArr[i] = numArr [i + 1];
            }


            numArr[4] = 8;

            for (int i = 0; i < numArr.length; i++)
            {
                Console.WriteLine(numArr[i]);
            }

            Console.WriteLine("\n------------\n");

            List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);
            numList.Add(4);
            numList.Add(5);

            numList[1] = 6;
            numList[numList.Count - 1] = 7;

            //numList.Remove(1); //borrar el 1
            numList.RemoveAt(0); //borrar el primer elemento

            numList.Add(8);
            numList.Add(9);

            //multiplicar por 3
            // 18, 9, 12, 21, 24, 27
            for (int i = 0; i < numList.Count; i++)
            {
                numList[i] = numList[i] * 3;
            }

            //[18], 9, 12, 21, 24 , 27
            //18, [9], 12, 21, 24 , 27
            //18, 9, [12], 21, 24 , 27
            //18, 9, 12, [21], 24 , 27
            //            i=3
            //18, 9, 12, 24 , [27]
            //                i=4
            //18, 9, 12, 21, 24 

            //para poder borrar elemntos se puede utilizar un for invertido

            for (int i = numList.Count - 1; i >= 0; 1--)
            {
                if (numList[i] > 20)
                {
                    numList.Remove(numList[i]);
                }
            }

            // Alternativa guardar elementos que se debian borrar y borrarlos despues del for
            //lista elementosaborrar = [21, 24, 27]

            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }

            Console.WriteLine("\n------------\n");


            List<int> numList = new List<int>();

            numList2.Add(2);
            numList2.Add(6);
            numList2.Add(19);
            numList2.Add(34;
            numList2.Add(65);
            numList2.Add(12;
            numList2.Add(42);
            numList2.Add(33);
            numList2.Add(40);
            numList2.Add(15);

            int mayor = numList2[0];

            for (int i = 0; i < numList.Count;; i++)
            {
              if (numList2[i] > mayor)
              {
                  mayor = numList2[i];
              }  
            }

            Console.WriteLine("Numero mayor encontrado: " + mayor );
            for (int i = 0; i < numList2.Count; i++)
            {
                Console.WriteLine(numList2[i]);
            }


        }
    }
}
