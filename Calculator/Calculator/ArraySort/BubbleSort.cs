﻿namespace Calculator.ArraySort
{
    public class BubbleSort : ISorter
    {
        /// <summary>
        /// Bubble sort method
        /// </summary>
        /// <param name="A">
        /// Input array,sorting array by Bubble method
        /// </param>
        /// <returns>
        /// Output array
        /// </returns>
        public double[] Sort(double[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[i])
                    {
                        var temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
            return A;
        }
    }
}
