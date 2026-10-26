namespace _08._10._26_homework_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* #region Task1
            int[] A = new int[5];
            double[,] B = new double[3,4];

            Random random = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                A[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0;i <B.GetLength(0);i++)
            {
                for(int j = 0;j < B.GetLength(1);j++)
                {
                    B[i, j] = random.Next(-100, 101) / 10.0;
                }
            }

            Console.WriteLine("Array 1");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array 2");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for(int j = 0; j < B.GetLength(1);j++)
                {
                    Console.Write(B[i,j] + "\t" );
                }
                Console.WriteLine();
            }

            double max = A[0];
            double min = A[0];
            double sum = 0;
            double product = 1;
            int evenSum = 0;
            double oddSum = 0;

            for(int i = 0;i < A.Length;i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }

                if (A[i] < min)
                {
                    min = A[i];
                }

                sum = sum + A[i];
                product = product * A[i];

                if (A[i] % 2 == 0)
                {
                    evenSum = evenSum + A[i];
                }
            }


            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                    }

                    if (B[i, j] < min)
                    {
                        min = B[i, j];
                    }

                    sum = sum + B[i, j];
                    product = product * B[i, j];

                    if (j % 2 == 0)
                    {
                        oddSum = oddSum + B[i, j];
                    }
                }
            }
            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
            Console.WriteLine("Total sum: " + sum);
            Console.WriteLine("Total product: " + product);
            Console.WriteLine("Sum of even elements in A: " + evenSum);
            Console.WriteLine("Sum of odd columns in B: " + oddSum);
            #endregion */


            #region Task2
            int[,] array = new int[5, 5];
            Random random2 = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random2.Next(-100, 101);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }

                Console.WriteLine();
            }

            int minimum = array[0, 0];
            int maximum = array[0, 0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minimum)
                    {
                        minimum = array[i, j];
                        minIndex = i * 5 + j;
                    }

                    if (array[i, j] > maximum)
                    {
                        maximum = array[i, j];
                        maxIndex = i * 5 + j;
                    }
                }
            }

            int sum2 = 0;

            int start = minIndex;
            int end = maxIndex;

            if (start > end)
            {
                start = maxIndex;
                end = minIndex;
            }

            for (int i = start + 1; i < end; i++)
            {
                sum2 = sum2 + array[i / 5, i % 5];
            }

            Console.WriteLine("Minimum: " + minimum);
            Console.WriteLine("Maximum: " + maximum);
            Console.WriteLine("Sum between min and max: " + sum2);
            #endregion

        }
    }
}
