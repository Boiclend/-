// Вывести на экран матрицу 4x6. Найти сумму элементов каждой строки. Вывести результат в виде одномерного массива и найти его максимальный элемент
Random r = new Random();
int[,] A = new int[4,6];
int[] B = new int[4];
 
    for (int i = 0; i < 4; i++)
{
        for (int j = 0; j < 6; j++)
    {
            A[i, j] = r.Next(20, 40);
            Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
 
Console.WriteLine("\n\n");
 
    for (int i = 0; i < 4; i++)
{
        for (int j = 0; j < 6; j++)
    {
        B[i] = B[i] + A[i, j];
    }
    Console.Write(B[i] + " ");
}
 
Console.WriteLine("\n\n");
 
int W = B[0];
    for (int a = 0; a < 4; a++)
{
        if (B[a]>W)
        {
            W = B[a];
        }
}
Console.WriteLine(W);