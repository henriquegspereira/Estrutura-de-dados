using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CombSort
{
    public class CombSort
    {
        public static void Sort(int[] array)
        {
            int tamanho = array.Length;
            int gap = tamanho; // distancia entre os valores
            bool trocado = true;
            double fator = 1.3;

            while (gap > 1 || trocado)
            {
                gap = (int)(gap / fator); // 7 | 5 | quando chegar a 1 será o comportamento de um BubbleSort
                if (gap < 1)
                {
                    gap = 1;
                }
                trocado = false;
                for (int i = 0; i + gap < tamanho; i++)
                {
                    if (array[i] > array[i + gap]) // 8 > -6 | 4 > 28 | 1 > 0
                    {
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                        trocado = true;
                    }
                }
            }
        }
    }
}
