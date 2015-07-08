using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Library
{
    public class JaggedSort
    {
        static public int[][] SortArrayMax(int[][] jagged, int key = 0)
        {
            int temp;
            int[] tempor;
            int[][] tempJagged = CopyMass(jagged);
            int[] arrForSort = SortMaxMin(jagged, key);
            foreach (int[] array in tempJagged)
            {
                tempor = new int[arrForSort.Length];
                for (int k = 0, j = k + 1; j < arrForSort.Length; j++, k++)
                {
                    if (arrForSort[k] > arrForSort[j])
                    {
                        temp = arrForSort[k];
                        arrForSort[k] = arrForSort[j];
                        arrForSort[j] = temp;

                        tempor = tempJagged[k];
                        tempJagged[k] = tempJagged[j];
                        tempJagged[j] = tempor;
                    }
                }
            }
            ShowArrow(tempJagged);
            return tempJagged;
        }
        static public int[][] SortArrayMin(int[][] jagged)
        {
            return SortArrayMax(jagged, 1);
        }
        static public int[][] SortSumElem(int[][] jagged)
        {
            return SortArrayMax(jagged, 2);
        }
        static private int[] SortMaxMin(int[][] jagged, int key)
        {
            int temp;
            int count = 0;
            int sumOfElem = 0;
            int[] maxmin = new int[jagged.Length];
            foreach (int[] array in jagged)
            {
                for (int i = 0; i < array.Length; i++)
                {  
                    for (int j = i + 1; j < array.Length; j++)
                    {
                       
                        if (jagged[count][i] > jagged[count][j])
                        {
                            temp = jagged[count][i];
                            jagged[count][i] = jagged[count][j];
                            jagged[count][j] = temp;
                        }        
                    }
                    sumOfElem += array[i];
                }
                if (key == 0) maxmin[count] = jagged[count][array.Length - 1];
                else if (key == 1) maxmin[count] = jagged[count][0];
                else maxmin[count] = sumOfElem;
                count++;
                sumOfElem = 0;
            }
            return maxmin;
        }  
        static private void ShowArrow(int[][] jagged)
        {
            int count = 0;
            foreach (int[] array in jagged)
            {
                Console.WriteLine("Mass {0}",count+1);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(" elements {0}", jagged[count][i]);
                }
                count++;
            }
             
        }   
        static private int[][] CopyMass(int[][] jagged)
         {
             int count = 0;
             int[][] copyJagged = new int[jagged.Length][];
             foreach (int[] array in jagged)
             {
                 copyJagged[count] = new int[array.Length];
                 for (int i = 0; i < array.Length; i++)
                 {
                     int n = jagged[count][i];
                     copyJagged[count][i] = n;
                 }
                 count++;
             }
            return copyJagged;
         }
    }

}
