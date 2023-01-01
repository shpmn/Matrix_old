// Testing Examples of Matrix Calculations

public class Test {
    public Test()
    {
        this.FullTest();
    }

    public void FullTest() {
        //TODO
        //TU TESTY!!!
        //TU TESTY!!!
        //TU TESTY!!!
        
        Matrix matrix1 = new Matrix(rows: 5, columns: 6);
        Console.WriteLine("Matrix 1");
        matrix1.DisplayMatrix();
        
        Matrix matrix2 = new Matrix(rows: 6, columns: 5);
        Console.WriteLine("Matrix 2");
        matrix2.DisplayMatrix();
        
        AddTest(matrix1, matrix2);
        SubtractTest(matrix1, matrix2);
        MultiplyTest(matrix1, matrix2);
        ScalarMultiplyTest(matrix1, 5);
        TransposeTest(matrix2);

    }

    private void AddTest(Matrix matrix1, Matrix matrix2) 
    {
        Matrix result = MatrixCalculator.AddMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix addition");
        result.DisplayMatrix();
        Console.WriteLine();
    }

    private void SubtractTest(Matrix matrix1, Matrix matrix2) 
    {
        Matrix result = MatrixCalculator.SubtractMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix subtraction");
        result.DisplayMatrix();
        Console.WriteLine();
    }

    private void MultiplyTest(Matrix matrix1, Matrix matrix2) 
    {
        Matrix result = MatrixCalculator.MultiplyMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix multiplication");
        result.DisplayMatrix();
        Console.WriteLine();
    }

    private void ScalarMultiplyTest(Matrix matrix1, int scalar) 
    {
        Matrix result = MatrixCalculator.MultiplyMatrixByScalar(matrix1, scalar);
        Console.WriteLine("Matrix 1 multiplication by scalar");
        result.DisplayMatrix();
        Console.WriteLine();
    }

    private void TransposeTest(Matrix matrix1) 
    {
        Matrix result = MatrixCalculator.TransposeMatrix(matrix1);
        Console.WriteLine("Matrix 2 transposition");
        result.DisplayMatrix();
        Console.WriteLine();
    }
    
    
}
