//Class Matrix implements an object of a matrix with additional functionalities.

public class Matrix
{
    public int rows;
    public int columns;
    public int[,] matrix;
    
    public int random_min_constraint = 0;
    public int random_max_constraint = 10;
    

    public Matrix(int rows, int columns)
    { 
        this.rows = rows;
        this.columns = columns;
        
        this.matrix = new int[rows, columns];
        
        this.FillWithRandomNumbers();
    }

    public void FillWithRandomNumbers()
    {
        Random random = new Random();
        
        for (int row = 0; row < this.rows; row++)
        {
            for (int column = 0; column < this.columns; column++)
            {
                this.matrix[row, column] = random.Next(this.random_min_constraint, this.random_max_constraint + 1);
            }
        }
    }

    public void FillWithZeros()
    {
        for (int row = 0; row < this.rows; row++)
        {
            for (int column = 0; column < this.columns; column++)
            {
                this.matrix[row, column] = 0;
            }
        }
    }
    
    public void DisplayMatrix()
    {
        for (int row = 0; row < this.rows; row++)
        {
            for (int column = 0; column < this.columns; column++)
                {
                    Console.Write("{0,-4}", this.matrix[row, column] + " ");
                }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public bool IsMatrixSquare()
    {
        if (this.rows == this.columns)
            {
                return true;
            }
        else return false;
    }
    
    public bool IsIdentityMatrix()
    {   
        bool isIdentity = true;
        
        if(!this.IsIdentityMatrix())
        {
            isIdentity = false;
        }

        for (int row = 0; row < this.rows; row++)
        {
            for (int column = 0; column < this.columns; column++)
            {
                if (row == column && this.matrix[row, column] != 1)
                {
                    isIdentity = false;
                }
                else if (row != column && this.matrix[row, column] != 0)
                {
                    isIdentity = false;
                }
            }
        }
        return isIdentity;
    }

    public void SetValue(int row, int column, int value)
    {
        this.matrix[row, column] = value;
    }

    public int GetValue(int row, int column)
    {
        return this.matrix[row, column];
    }

    public int CalculateDeterminant()
    {
        int determinant = 0;

        if(!this.IsMatrixSquare())
        {
            throw new Exception(@"In order to calculate determinant the matrix
                                must have equal number of rows and columns!");
        }

        int matrixSize = this.matrix.GetLength(0);
        determinant = Determinant.CalculateDeterminantRecursively(this.matrix, matrixSize);  

        return determinant;
    }
}
