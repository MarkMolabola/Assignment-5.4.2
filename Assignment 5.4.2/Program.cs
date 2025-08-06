namespace Assignment_5._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the size of the square matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] newMatrix = CreateSquareMatrix(n);

            Console.WriteLine("Matrix: ");
            PrintSquareMatrix(newMatrix);
            if (n == 1)
            {
                Console.WriteLine(newMatrix[0, 0]);
            }
            else
            {

                Console.WriteLine($"The Sum in the right diagonal is: {MatrixDiagonalAddition(newMatrix, n)}");
            }

        }
        static int MatrixDiagonalAddition(int[,] matrix, int n)
        {

            int result = 0;
            for (int i = 0; i < n-1; i++)
            {

                result = matrix[i, i] + matrix[i + 1, i + 1];

            }
            return result;
        }

        static int[,] CreateSquareMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            Console.WriteLine("Input the elements of the matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i}, {j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }
        static void PrintSquareMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("|");
                    Console.Write(matrix[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
