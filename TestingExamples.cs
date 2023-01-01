// Testing Examples of Matrix Calculations

public class Test {
    public Test()
    {
        this.FullTest();
    }

    public void FullTest() 
    {      
        Matrix matrix1 = new Matrix(rows: 3, columns: 3);
        Console.WriteLine("Matrix 1");
        matrix1.DisplayMatrix();
        
        Matrix matrix2 = new Matrix(rows: 3, columns: 3);
        Console.WriteLine("Matrix 2");
        matrix2.DisplayMatrix();
        
        AddTest(matrix1, matrix2);
        SubtractTest(matrix1, matrix2);
        MultiplyTest(matrix1, matrix2);
        ScalarMultiplyTest(matrix1, scalar: 5);
        TransposeTest(matrix2);
        CalculateDeterminantTest(matrix2, "matrix2");
        IdentityTest(matrix1, "matrix1");
        IdentityTest(matrix2, "matrix2");
        
        Matrix matrix3 = new Matrix(rows: 4, columns: 4);
        matrix3.MakeIdentity();        
        
        MakeIdentityTest(matrix3, "matrix3");
        
    }

    private void AddTest(Matrix matrix1, Matrix matrix2) 
    {
        Matrix result = MatrixCalculator.AddMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix addition");
        result.DisplayMatrix();
    }

    private void SubtractTest(Matrix matrix1, Matrix matrix2) 
    {
        Matrix result = MatrixCalculator.SubtractMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix subtraction");
        result.DisplayMatrix();
    }

    private void MultiplyTest(Matrix matrix1, Matrix matrix2) 
    {
        Matrix result = MatrixCalculator.MultiplyMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix multiplication");
        result.DisplayMatrix();
    }

    private void ScalarMultiplyTest(Matrix matrix1, int scalar) 
    {
        Matrix result = MatrixCalculator.MultiplyMatrixByScalar(matrix1, scalar);
        Console.WriteLine("Matrix 1 multiplication by scalar");
        result.DisplayMatrix();
    }

    private void TransposeTest(Matrix matrix) 
    {
        Matrix result = MatrixCalculator.TransposeMatrix(matrix);
        Console.WriteLine("Matrix 2 transposition");
        result.DisplayMatrix();
    }
    
    private void IdentityTest(Matrix matrix, string matrix_name)
    {
        string result;

        if (matrix.IsIdentityMatrix())
        {
            result = "true";
        }
        else
        {
            result = "false";
        }
        Console.WriteLine($"Identity test of {matrix_name}: {result}");
    }

    private void MakeIdentityTest(Matrix matrix, string matrixName)
    {
        Console.WriteLine("");
        
        if (matrix.IsIdentityMatrix())
        {
            Console.WriteLine($"{matrixName} is an identity matrix.");
        }
        else 
        {
            Console.WriteLine($"{matrixName} is not an identity matrix.");
        }
        matrix.DisplayMatrix();        
    }

    private void CalculateDeterminantTest(Matrix matrix, string matrix_name)
    {
        Console.WriteLine($"Determinant of {matrix_name}: {matrix.CalculateDeterminant()}");
    }
}
