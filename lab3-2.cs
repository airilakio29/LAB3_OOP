using System;
using System.Collections.Generic;
public class MatrixRepository
{
    private List<Matrix> matrices = new List<Matrix>();

    public void addMatrix(Matrix m)
    {
        matrices.Add(m);
    }

    public Matrix getMatrix(int index)
    {
        return matrices[index];
    }
}

public class VectorRepository
{
    private List<Vector> vectors = new List<Vector>();

    public void addVector(Vector v)
    {
        vectors.Add(v);
    }

    public Vector getVector(int index)
    {
        return vectors[index];
    }
}

public class InputHandler
{
    public Matrix inputMatrix()
    {
        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter columns: ");
        int cols = int.Parse(Console.ReadLine());

        Matrix matrix = new Matrix(rows, cols);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Value [{i},{j}]: ");
                matrix.setValue(i, j,
                    double.Parse(Console.ReadLine()));
            }
        }

        return matrix;
    }

    public Vector inputVector()
    {
        Console.Write("Enter vector size: ");
        int size = int.Parse(Console.ReadLine());

        Vector vector = new Vector(size);

        for (int i = 0; i < size; i++)
        {
            Console.Write("Value "+i+":");
            vector.setValue(i,
                double.Parse(Console.ReadLine()));
        }

        return vector;
    }
}