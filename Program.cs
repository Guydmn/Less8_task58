// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.Write("Введите высоту матриц: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длинну матриц: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] doubleArray1 = new int [m, n];
// int [,] doubleArray2 = new int [m, n];
// int [,] newArray = new int [m, n];



// Random rnd = new Random();

// for (int i = 0; i < doubleArray1.GetLength(0); i++)
// {
//     for (int j = 0; j < doubleArray1.GetLength(1); j++)
//     {
//         doubleArray1[i, j] = rnd.Next(0, 10);
//         Console.Write($"{doubleArray1[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// for (int k = 0; k < doubleArray2.GetLength(0); k++)
// {
//     for (int l = 0; l < doubleArray2.GetLength(1); l++)
//     {
//         doubleArray2[k, l] = rnd.Next(0, 10);
//         Console.Write($"{doubleArray2[k, l]} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine($"Произведение двух матриц равно: ");


// for (int i = 0; i < doubleArray1.GetLength(0); i++)
// {
//     for (int j = 0; j < doubleArray1.GetLength(1); j++)
//     {
//         for (int k = 0; k < doubleArray2.GetLength(0); k++)
//         {
                
//             for (int l = 0; l < doubleArray2.GetLength(1); l++)
//             {
//                 if (i == k && j == l)
//                 {
//                     newArray[i, j] = doubleArray1[i, j] * doubleArray2 [k, l];
//                     Console.Write($"{newArray[i, j]} ");
//                 }
                   
//             }
//         }   
//     }
//     Console.WriteLine();
// }
       
    // Размерность матриц
Console.Write("Введите высоту матриц: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну матриц: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrixA = new int [n, n];
int [,] matrixB = new int [n, n];
int [,] matrixC = new int [n, n];

Random rnd = new Random();

for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixA.GetLength(1); j++)
    {
        matrixA[i, j] = rnd.Next(0, 10);
        Console.Write($"{matrixA[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int k = 0; k < matrixB.GetLength(0); k++)
{
    for (int l = 0; l < matrixB.GetLength(1); l++)
    {
        matrixB[k, l] = rnd.Next(0, 10);
        Console.Write($"{matrixB[k, l]} ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Произведение двух матриц равно: ");

for (int i = 0; i < n; i++) {
    for (int j = 0; j < n; j++) {
        for (int k = 0; k < n; k++) {
            matrixC[i,j] = matrixC[i,j] + (matrixA[i,k] * matrixB[k,j]);
        }
    }
}

for (int i = 0; i < n; i++) {
    for (int j = 0; j < n; j++) {
        Console.Write("{0} ", matrixC[i,j]);
    }
    Console.WriteLine();
}
