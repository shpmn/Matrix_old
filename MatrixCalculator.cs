// Class MatrixCalculator implements a range of functionalities 
// and operations which can be conducted on matrices.


public static class MatrixCalculator
{
    private static void CheckAdditionAndSubtractionCompatibility(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
        {
            throw new Exception("In order to calculate both matrices have to be of the same length and width!");
        }
    }

    private static void CheckMultiplicationCompatibility(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.columns != matrix2.rows)
        {
            throw new Exception(@"In order to multiply matrices, the number of columns of the 1st matrix must be equal to the number of rows of the 2nd matrix!");
        }
    }

    public static Matrix AddMatrices(Matrix matrix1, Matrix matrix2)
    { 
        MatrixCalculator.CheckAdditionAndSubtractionCompatibility(matrix1, matrix2);
        
        Matrix result = new Matrix(matrix1.rows, matrix2.columns); 

        for (int row = 0; row < matrix1.rows; row++) // dlaczego nie pokazuje bledu mimo ze nie wie co to matrix
        {
            for (int column = 0; column < matrix2.columns; column++)
            {
                result.matrix[row, column] = matrix1.matrix[row, column] + matrix2.matrix[row, column];
            }
        }
        return result;
    }

    public static Matrix SubtractMatrices(Matrix matrix1, Matrix matrix2)
    {
        MatrixCalculator.CheckAdditionAndSubtractionCompatibility(matrix1, matrix2);
        
        Matrix result = new Matrix(matrix1.rows, matrix2.columns); 
        
        for (int row = 0; row < matrix1.rows; row++)
        {
            for (int column = 0; column < matrix2.columns; column++)
            {
                result.matrix[row, column] = matrix1.matrix[row, column] - matrix2.matrix[row, column];
            }
        }
        return result;
    }

    public static Matrix MultiplyMatrixByScalar(Matrix matrix, int scalar)
    {
        Matrix result = new Matrix(matrix.rows, matrix.columns); 
        
        for (int row = 0; row < matrix.rows; row++)
        {
            for (int column = 0; column < matrix.columns; column++)
            {
                result.matrix[row, column] = matrix.matrix[row, column] * scalar;
            }
        }
        return result;
    }
    
    public static Matrix MultiplyMatrices(Matrix matrix1, Matrix matrix2)
    {
        MatrixCalculator.CheckMultiplicationCompatibility(matrix1, matrix2);

        Matrix result = new Matrix(matrix1.rows, matrix2.columns);

        for (int row = 0; row < result.rows; row++)
            {
                for (int column = 0; column < result.columns; column++)
                {
                    int tempSum = 0;

                    for (int step = 0; step < result.columns; step++)
                    {
                        tempSum += matrix1.matrix[row, step] * matrix2.matrix[step, column];
                    }
                    result.matrix[row, column] = tempSum;
                }
            }
        return result;
    }

    public static Matrix TransposeMatrix(Matrix matrix)
    {
        int resultRows = matrix.columns;
        int resultColumns = matrix.rows;
        
        Matrix result = new Matrix(resultRows, resultColumns);
        
        for (int row = 0; row < result.rows; row++)
        {
            for (int column = 0; column < result.columns; column++)
            {
                result.matrix[row, column] = matrix.matrix[column, row];
            }
        }
        return result;
    }

}
