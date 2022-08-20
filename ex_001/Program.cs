//Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

Random random = new Random();
int rows = random.Next(4,4);
int columns = random.Next(4,4);
int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);

int temp;
for (int k = 0; k < array.GetLength(1); k++)
{
    for (int l = k + 1; l < array.GetLength(1); l++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
        if (array[i,k] < array[i,l])
        {
            temp = array[i, l];
            array[i, l] = array[i, k];
            array[i, k] = temp;
        }
        }
    }
}           

Console.WriteLine();
PrintArray(array);
            




static void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j<columns; j++)
        {
            array[i,j]= random.Next(startNumber,finishNumber);

        }
    }
}


static void PrintArray(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j<columns; j++)
        {
            Console.Write(array[i,j] + "\t");
        }

        Console.WriteLine();
    }
}

