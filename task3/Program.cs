// Вывести на экран матрицу 3x6, элементами которой являются целые случайные числа из интервала [10,90]. Определить номер минимального элемента в каждой строке.
Random r = new Random();
int[,] A = new int[3, 6];
int[] B = new int[3];
 
    for (int i = 0; i < 3; i++)
{
        for (int j = 0; j < 6; j++)
    {
            A[i, j] = r.Next(10, 90);
            Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
 
Console.WriteLine("\n\n");
 
 
int W = 90;
    for (int i = 0; i < 3; i++)
{
        for (int j = 0; j < 6; j++)
    {
            if (A[i,j] < W)
            {
                W = A[i, j];
            }
    }
    Console.WriteLine(W + "");
    W = 90;
}