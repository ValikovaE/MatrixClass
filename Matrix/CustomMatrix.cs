using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class CustomMatrix
    {
        private int _rows;
        private int _columns;
        private int[,] _matrix;


        public CustomMatrix(int[,] matrix)
        {
            _rows = matrix.GetLength(0); //берет значения [3, 3] о матрице и вводит их в поля
            _columns = matrix.GetLength(1);
            _matrix = matrix;

        }

        private bool CheckingDiagonals() //сравнивает поля на наличие диагоналей и возвращает true или false
        {
            if (_rows == _columns)
            {
                Console.WriteLine("This matrix has diagonals");
                return true;
            }
            else
            {
                Console.WriteLine("This matrix doesn't have diagonals");
                return false;
            }
        }

        private int SummFirstDiag()  //складывает значения главной диагонали
        {
            int sum1 = 0;
            for (int i = 0; i < _rows; i++)
            {
                sum1 += _matrix[i, i];  //sum = sum + _matrix[i, i];
            }
            Console.WriteLine("Summ of first diagonal numbers : " + sum1);
            return sum1;
        }

        private int SummSecondDiag()  //складывает значения вторичной диагонали
        {
            int sum2 = 0;
            for (int i = 0; i < _rows; i++)
            {
                sum2 += _matrix[i, _rows - i - 1];
            }
            Console.WriteLine("Summ of second diagonal numbers : " + sum2);
            return sum2;
        }
                
        public void GetSummElements()  //если диагонали есть то выводит их сумму в консоль
        {            
            if (CheckingDiagonals())
            {
                SummFirstDiag();
                SummSecondDiag();
            }
        }

        public void setMatrix(int[,] matrix) //переключение на вторую матрицу
        {
            _rows = matrix.GetLength(0);
            _columns = matrix.GetLength(1);
            _matrix = matrix;
        }


    }
}







