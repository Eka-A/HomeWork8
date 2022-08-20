Random random = new Random();
int rows = random.Next(4,4);
int columns = random.Next(4,4);
int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();
MinSumArray(array);


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

void MinSumArray(int[,] array)
{
    int columns = array.GetLength(1);
    int rows = array.GetLength(0);
    int sum = 0; 
    int sum1 = 0; 
    int sum2 = 0;
    int row = 0;
    
     for(int i = 0; i < rows; i++) 
    {
        sum2 = 0;
        for(int j = 0; j < columns; j++) 
        {
            sum2 += array[i, j];  
        }
        if(sum2 < sum1 && sum2!=sum1)
        {   
            sum = sum2; 
            row = i;    
        }
        
        sum1 = sum2;
    }

Console.WriteLine($"Наименьшаяя сумма = {sum}");                                                                        
Console.WriteLine($"Номер строки = {row+1}");
}
