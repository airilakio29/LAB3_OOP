This project implements matrix and vector addition using Object-Oriented Programming principles based on the given UML diagram. The system allows users to input matrices and vectors, validates their dimensions, performs addition, and displays the results.

OOP Concepts Applied

Encapsulation:
All attributes are private and accessed through public methods only.

Composition:
A Matrix is composed of multiple Row objects.

Aggregation:
MatrixRepository and VectorRepository store multiple matrix and vector objects.

Dependency:
MatrixCalculator and VectorCalculator depend on DimensionValidator to check dimension compatibility before performing addition.

Program Flow

1.User inputs matrices and vectors.
2.Dimensions are validated.
3.Addition is performed using calculator classes.
4.Results are displayed.
