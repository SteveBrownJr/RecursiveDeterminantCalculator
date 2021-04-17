public class determinantCalculatorRecursive
    {
        public double InfiniteDetrminantCalculator(double[,] matrix)
        {
            if (matrix.GetLength(0)==2)
            {
                return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            }
            else
            {
                double output = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (i%2==0)
                    {
                        output += matrix[0, i] * InfiniteDetrminantCalculator(Matrixgenerator(matrix,i));
                    }
                    else
                    {
                        output += (-1)*matrix[0, i] * InfiniteDetrminantCalculator(Matrixgenerator(matrix, i));
                    }
                }
                return output;
            }
        }
        private  double[,] Matrixgenerator(double[,] matrix, int dontneed)
        {
            double[,] output = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
            if (dontneed == 0)
            {
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    for (int j = 1; j < matrix.GetLength(1); j++)
                    {
                        output[i - 1, j - 1] = matrix[i, j];
                    }
                }
            }
            else
            {
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < dontneed; j++)
                    {
                        output[i - 1, j] = matrix[i, j];
                    }
                }
                if (dontneed != matrix.GetLength(1))
                {
                    for (int i = 1; i < matrix.GetLength(0); i++)
                    {
                        for (int j = dontneed+1; j < matrix.GetLength(1); j++)
                        {
                            output[i - 1, j - 1] = matrix[i, j];
                        }
                    }
                }
            }
            return output;

        }
    }