//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.


/*Console.Clear();
double[,] a= new double[3,3];
Random random = new Random();
for(int i=0;i<3;i++){
    for(int j=0; j<3; j++){
        a[i,j]=random.NextDouble();
        Console.Write("  "+a[i,j]);
    }
    Console.WriteLine();
}*/


//второй вариант решения


/*int[,]CreateRandomTwoDemArray(int m, int n,  int min, int max)
{
    int[,] newMatrix = new int[m, n];
    for(int i= 0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            newMatrix[i,j] = new Random().Next(min,max+1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }    
    return newMatrix;   
}
Console.Clear();
Console.Write("Введите количество строк m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество  n:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение min:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение max:  ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomTwoDemArray(m,n,min,max);*/





// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.

//

int[,]CreateRandomTwoDemArray(int m, int n,  int min, int max)
{
    int[,] newMatrix = new int[m, n];
    for(int i= 0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            newMatrix[i,j] = new Random().Next(min,max+1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }    
    return newMatrix;   
}
Console.Clear();
Console.Write("Введите количество строк m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество  n:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение min:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение max:  ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение A:  ");
int A = Convert.ToInt32(Console.ReadLine());


int[,] array = CreateRandomTwoDemArray(m,n,min,max);

//int A  = 22;


if (int[2,3]==22)
{
    Console.WriteLine("Элемент А имеется на данной позиции");
}
else{
    Console.WriteLine("Элемента А на данной позиции нет");
}




















/*Console.Clear();
Console.Write("Введите номер строки m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца n:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число  поиска А   ");
int A = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[4,5];
RandomTwoDemArray(num);

if (n>num.GetLength(0)||m>num.GetLength(1))
{
    Console.WriteLine(" Такого элемента нет ");
}
else{
    Console.WriteLine($"Значение элемента {m} cтроки и {n} столбца равно {num[m-1,n-1]}");
}
PrintArray(num);


int[,] RandomTwoDemArray( int[,]array)
{
    //int[,] array = new int[m, n];
    for(int i= 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-100,100)/10;
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }    
    return array;   
}


void PrintArray(int[,] array )
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        Console.Write("[");
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}*/