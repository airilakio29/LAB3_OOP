
using system;

public class DimensionValidator
{
    public bool validateMatrixAddition(Matrix A, Matrix B)
    {
        return A.getRows() == B.getRows() && A.getCols() == B.getCols();
    }

    public bool validateVectorAddition(Vector A, Vector B)
    {
        return A.getSize() == B.getSize();
    }
}
public class MatrixCalculator
{
    private DimensionValidator validator;

    public MatrixCalculator()
    {
        validator = new DimensionValidator();
    }

    public Matrix add(Matrix A, Matrix B)
    {
        if (!validator.validateMatrixAddition(A, B))
            throw new Exception("Matrix dimension are not compatible");

        Matrix result = new Matrix(A.getRows(), A.getCols());

        for (int i = 0; i < A.getRows(); i++)
        {
            for (int j = 0; j < A.getCols(); j++)
            {
                result.setValue(i, j,A.getValue(i, j) + B.getValue(i, j));
            }
        }

        return result;
    }
}
public class VectorCalculator
{
    private DimensionValidator validator;

    public VectorCalculator()
    {
        validator = new DimensionValidator();
    }

    public Vector add(Vector A, Vector B)
    {
        if (!validator.validateVectorAddition(A, B))
            throw new Exception("Vector dimension are not compatible");

        Vector result = new Vector(A.getSize());

        for (int i = 0; i < A.getSize(); i++)
        {
            result.setValue(i,
                A.getValue(i) + B.getValue(i));
        }

        return result;
    }
}
