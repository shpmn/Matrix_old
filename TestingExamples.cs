// Testing Examples of Matrix Calculations

public class Test {
    public Test()
    {
        this.FullTest();
    }

    public void FullTest() {
        //example
        Matrix matrix1 = new Matrix(rows: 2, columns: 2);
        matrix1.DisplayMatrix();
        Console.WriteLine();
        // Matrix transposed = MatrixCalculator.TransposeMatrix(matrix1);
        // transposed.DisplayMatrix();
        Matrix matrix2 = new Matrix(rows: 2, columns: 2);
        matrix2.DisplayMatrix();

        Matrix result = MatrixCalculator.MultiplyMatrices(matrix1, matrix2);
        result.DisplayMatrix();

        Console.ReadKey();
    }
}
