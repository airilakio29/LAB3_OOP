using System;
using System.Collections.Generic;
public class Row
{
    private double[] values;

    public Row(int size)
    {
        values = new double[size];
    }

    public double getValue(int j)
    {
        return values[j];
    }

    public void setValue(int j, double value)
    {
        values[j] = value;
    }

    public int length()
    {
        return values.Length;
    }
}
public class Matrix
{
    private int rows;
    private int cols;
    private Row[] rowData;

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        rowData = new Row[rows];

        for (int i = 0; i < rows; i++)
        {
            rowData[i] = new Row(cols);
        }
    }

    public double getValue(int i, int j)
    {
        return rowData[i].getValue(j);
    }

    public void setValue(int i, int j, double value)
    {
        rowData[i].setValue(j, value);
    }

    public int getRows()
    {
        return rows;
    }

    public int getCols()
    {
        return cols;
    }

    public void display()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(getValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }
}
public class Vector
{
    private int size;
    private double[] data;

    public Vector(int size)
    {
        this.size = size;
        data = new double[size];
    }

    public double getValue(int i)
    {
        return data[i];
    }

    public void setValue(int i, double value)
    {
        data[i] = value;
    }

    public int getSize()
    {
        return size;
    }

    public void display()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(data[i] + " ");
        }
        Console.WriteLine();
    }
}
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
