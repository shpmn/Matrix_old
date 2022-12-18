// Testing Examples of Matrix Calculations

public class Test {
    public Test()
    {
        this.FullTest();
    }

    public void FullTest() {
        //example
        Matrix matrix1 = new Matrix(rows: 3, columns: 3);
        matrix1.DisplayMatrix();
        Console.Write(matrix1.CalculateDeterminant()); 
        Console.WriteLine();
        // Matrix transposed = MatrixCalculator.TransposeMatrix(matrix1);
        // transposed.DisplayMatrix();
        Matrix matrix2 = new Matrix(rows: 4, columns: 4);
        matrix2.DisplayMatrix();
        Console.Write(matrix2.CalculateDeterminant()); 

        Console.WriteLine();
        Matrix matrix3 = new Matrix(rows: 5, columns: 5);
        matrix3.DisplayMatrix();
        Console.Write(matrix3.CalculateDeterminant()); 

        Console.ReadKey();
    }
}
