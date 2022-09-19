//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
/*
Console.Clear();
Console.WriteLine("Введите количество строк M:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов N:  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,]num = new int[m,n];
CreateTwoDimArray(num);
Console.WriteLine();
Console.WriteLine("Введенный массив  ");
ShowArray(num);
ChangeInLine(num);
Console.WriteLine();
Console.WriteLine("Преобразованный массив"); 
ShowArray(num);


void CreateTwoDimArray(int[,] array)
{
    for(int i=0; i<  array.GetLength(0); i++)
    {
        for(int j = 0; j<  array.GetLength(1); j++)
            array[i,j] = new Random().Next(1,10);
    }
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
            Console.Write(array[i,j] +" ");
        Console.WriteLine();
    }
}

void ChangeInLine(int[,] array)
{
   for(int i = 0; i < num.GetLength(0); i++)
   {
      for(int j = 0; j <num.GetLength(1)-1; j++)
      {
        for (int z = 0; z< num.GetLength(1)-1; z++)
        {
            if (num[i, z] < num[i, z+1])
            {
                int temp = 0;
                temp = num[i, z];
                num[i, z] = num[i, z+1];
                num[i, z+1]=  temp;
            }
        }
      }
   }  
}*/



//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
 1 строка 14*/
  

/*
Console.Clear();
Console.WriteLine("Введите размер квадратного массива:  ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int [num,num];
CreateTwoDimArray(numbers);
PrintArray( numbers);
Console.WriteLine();
MinSumRow(numbers);


void CreateTwoDimArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
            array[i,j]= new Random().Next(0,10);
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] +" ");
        Console.WriteLine();
    }
}
void MinSumRow(int[,] array)
{

    int minSum = Int32.MaxValue;
    int numberLine = 0;

    for(int i = 0; i< numbers.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j< numbers.GetLength(1); j++)
        {
            sum= sum + numbers[i,j];
        }
        if(sum < minSum)
        {
            minSum=sum;
            numberLine++;
        }
    }
    Console.WriteLine("Строка с найменьшей суммой: " + (numberLine) +" Сумма равна: "+ (minSum));
}
Console.ReadLine();*/





/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
