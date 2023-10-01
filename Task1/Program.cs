// Вывести на экран матрицу 8x5, элементами которой являются целые случайные числа из интервала [20,40]. Определить номер строки, содержащей не более 3-х чѐтных чисел
Random r = new Random();
int[,] A = new int[8,5];
int[] B = new int[8];
 
    for (int i = 0; i < 8; i++)
{
        for (int j = 0; j < 5; j++)
    {
         A[i, j] = r.Next(20, 40);
         Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
 
Console.WriteLine("\n\n");
 
    for (int i = 0; i < 8; i++)
{
        for (int j = 0; j < 5; j++)
    {
        if (A[i, j]%2==0)
        {
        B[i] = B[i] + 1;
        }
                    
    }
    Console.Write(B[i] + " ");
}
 
Console.WriteLine("\n\n");
 
    for (int a = 0; a < 8; a++)
{
        if (B[a]<=3)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(A[a, j] + " ");
            }
                Console.WriteLine();
        }
}