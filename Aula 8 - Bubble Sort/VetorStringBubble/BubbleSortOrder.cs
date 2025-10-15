using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetorStringBubble
{
    public class BubbleSortOrder
    {
       public static T[] Sort<T>(T[] array)
            where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0) 
                    //Para ordem decrescente, alterar para < 0 
                    // (inverte a logica da comparação, se for maior, troca, invertendo a ordem se for menor, troca)
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
            return array;
        }

        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        } 
    }
}