using System;

class MatrixProgram
{
    
    static double[,] InputMatrix(int rows, int cols)
    {
        double[,] matrix = new double[rows, cols];
        Console.WriteLine($"Nhap ma tran {rows}x{cols}:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Phan tu [{i},{j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    
    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        Console.WriteLine("Ma tran:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

   
    static double[,] AddMatrices(double[,] A, double[,] B)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] C = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                C[i, j] = A[i, j] + B[i, j];
        return C;
    }

    
    static double[,] MultiplyMatrices(double[,] A, double[,] B)
    {
        int rowsA = A.GetLength(0);
        int colsA = A.GetLength(1);
        int rowsB = B.GetLength(0);
        int colsB = B.GetLength(1);

        if (colsA != rowsB)
        {
            Console.WriteLine("khong the nhan hai ma tran nay!");
            return null;
        }

        double[,] C = new double[rowsA, colsB];
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < colsA; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        return C;
    }

    
    static double[,] TransposeMatrix(double[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] T = new double[cols, rows];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                T[j, i] = A[i, j];
        return T;
    }

    
    static void FindMinMax(double[,] A)
    {
        double min = A[0, 0], max = A[0, 0];
        foreach (double val in A)
        {
            if (val < min) min = val;
            if (val > max) max = val;
        }
        Console.WriteLine($"Gia tri nho nhat: {min}, lon nhat: {max}");
    }

    
    static double Determinant(double[,] A)
    {
        int n = A.GetLength(0);
        if (n != A.GetLength(1))
        {
            throw new Exception("Ma tran khong vuong,, khong the tinh dịnh thuc!");
        }

        if (n == 1)
            return A[0, 0];

        if (n == 2)
            return A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];

        double det = 0;
        for (int p = 0; p < n; p++)
        {
            double[,] subMatrix = new double[n - 1, n - 1];
            for (int i = 1; i < n; i++)
            {
                int colIndex = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == p) continue;
                    subMatrix[i - 1, colIndex] = A[i, j];
                    colIndex++;
                }
            }
            det += A[0, p] * Math.Pow(-1, p) * Determinant(subMatrix);
        }
        return det;
    }

    
    static bool IsSymmetric(double[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != cols) return false;
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                if (A[i, j] != A[j, i]) return false;
        return true;
    }

    static void Main()
    {
        Console.Write("Nhap so dong: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot: ");
        int cols = int.Parse(Console.ReadLine());

        double[,] A = InputMatrix(rows, cols);
        PrintMatrix(A);

        
        Console.WriteLine("\nNhap ma tran B de cong voi ma tran A:");
        double[,] B = InputMatrix(rows, cols);
        double[,] C = AddMatrices(A, B);
        Console.WriteLine("Ket qua A + B:");
        PrintMatrix(C);

       
        Console.WriteLine("\nNhap ma tran B de nhan voi A:");
        int rowsB = int.Parse(Console.ReadLine());
        int colsB = int.Parse(Console.ReadLine());
        double[,] B2 = InputMatrix(rowsB, colsB);
        double[,] D = MultiplyMatrices(A, B2);
        if (D != null)
        {
            Console.WriteLine("Ket qua A × B:");
            PrintMatrix(D);
        }

        Console.WriteLine("\nMa tran chuyen vi cua A:");
        double[,] AT = TransposeMatrix(A);
        PrintMatrix(AT);

        
        FindMinMax(A);

        
        if (rows == cols)
        {
            Console.WriteLine($"Dinh thuc cua A: {Determinant(A)}");
        }

        
        Console.WriteLine(IsSymmetric(A) ? "Ma tran A doi xung" : "Ma tran A khong doi xung");
    }
}


