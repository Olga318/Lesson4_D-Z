﻿//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
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

/*
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
    for(int i = 0; i< array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for(int j = 0; j< array.GetLength(1); j++ )
        {
            Console.Write(array[i,j] +" ");
        }
         Console.Write("]");
         Console.WriteLine("");
    }
}
Console.Clear();

Console.WriteLine("Введите размерность матриц   ");
int size = int.Parse(Console.ReadLine());
int[,] MatrixA = new int[size,size];
int[,] MatrixB = new int[size,size];
CreateTwoDimArray(MatrixA);
CreateTwoDimArray(MatrixB);
int[,] MatrixC = new int[size,size];

for(int i = 0; i< size; i++)
{
    for(int j = 0; j < size; j++)
    {
        for(int z =0; z < size; z++)
        {
            MatrixC[i,j] = MatrixC[i,j] + MatrixA[i,z] * MatrixB[z,j];
        }
    }
}
Console.WriteLine("Матрица А  ");
PrintArray(MatrixA);
Console.WriteLine();
Console.WriteLine(" Матрица В  ");
PrintArray(MatrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А и В");
PrintArray(MatrixC);*/



/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

/*
int deep1 = 2;
int deep2 = 2;
int deep3 = 2;
int countNums = 90;
int[,,] resultNums = Create3DMassive(deep1,deep2,deep3);

for(int i = 0; i< resultNums.GetLength(0); i++)
{
    for(int j = 0; j < resultNums.GetLength(1); j++)
    {
        for(int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.Write($"{resultNums[i,j,k]}-[{i},{j},{k}]   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] Create3DMassive (int size1, int size2, int size3)
{
    int[,,]array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num = 10;

    for (int i = 0; i < values.Length; i++ )
        values[i]=num++;
    for(int i = 0; i <  values.Length; i++)
    {
        int randomInd = new Random().Next(0,values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }
    int valueIndex = 0;

    for(int i = 0; i <array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2);k++)
                array[i,j,k] = values[valueIndex++];
        }
    }
    return array;
}
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}*/



/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.Clear();
Console.WriteLine("Введите размер массива:   ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size,size];
 
int num = 1;
int i = 0;
int j = 0;

while ( num <= size*size)
{
    nums[i,j] = num;
    if(i <= j + 1 && i+j < size-1)
        ++j;
    else if(i < j && i+j >= size -1)
        ++i;
    else if (i >= j && i+j > size -1)
        --j;
    else
        --i;
    num++;  
}
 PrintArray(nums);

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write( "   " + array[i,j]);
        }
        Console.WriteLine();
    }
}
Console.ReadLine();