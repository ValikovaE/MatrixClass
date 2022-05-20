using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3] {
            { 1, 3, 5},
            { 2, 3, 5},
            {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
            { 1, 3, 5, 6},
            { 2, 3, 5, 78},
           {100, 56 , -54, 6} };

            //int[,] matrix3 = new int[4, 4] {
            //{ 1, 3, 5, 6},
            //{ 2, 3, 5, 78},
            //{100, 56 , -54, 6},
            //{ 2, 3, 5, 78} }; 


            CustomMatrix customMatrix = new CustomMatrix(matrix);
            customMatrix.GetSummElements();
            customMatrix.setMatrix(matrix2);
            customMatrix.GetSummElements();
            //customMatrix.setMatrix(matrix3);
            //customMatrix.GetSummElements();
        }



    }
}   