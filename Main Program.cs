using System;
class Program
{
    static void Main()
    {
        InputHandler input = new InputHandler();
        MatrixCalculator matrixCalc = new MatrixCalculator();
        VectorCalculator vectorCalc = new VectorCalculator();

        // MATRIX ADDITION
        Console.WriteLine("Matrix A:");
        Matrix A = input.inputMatrix();

        Console.WriteLine("Matrix B:");
        Matrix B = input.inputMatrix();

        Matrix resultMatrix = matrixCalc.add(A, B);

        Console.WriteLine("Matrix Addition Result:");
        resultMatrix.display();

        // VECTOR ADDITION
        Console.WriteLine("Vector A:");
        Vector vA = input.inputVector();

        Console.WriteLine("Vector B:");
        Vector vB = input.inputVector();

        Vector resultVector = vectorCalc.add(vA, vB);

        Console.WriteLine("Vector Addition Result:");
        resultVector.display();
    }public class VectorCalculator
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

}