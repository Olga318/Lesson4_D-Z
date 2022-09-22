/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в 
промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/

/*
Console.Clear();
Console.WriteLine(" Введите число M:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число N:   ");
int n = Convert.ToInt32(Console.ReadLine());

EvenNumbers(m,n);

int EvenNumbers(int m, int n )
{
    if(m==n && n % 2 == 0 )
    {
        Console.Write($"{n}  ");
        return n;
    }
    else{
        Console.Write($"{m}  ");
        m= m + 2;    
    }
    return EvenNumbers(m,n);
}
Console.WriteLine();*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
// от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*
Console.Clear();
Console.WriteLine(" Введите число M:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число N:   ");
int n = Convert.ToInt32(Console.ReadLine());

void SumNumbers( int n, int m, int sum)
{
    if (m>n)
    {
        Console.WriteLine($"сумма чисел = {sum}");    
        return;
    }
    sum = sum +(m++); 
    SumNumbers(n, m, sum);
}
SumNumbers(n, m, 0);*/




/*Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих 
чисел с помощью рекурсии.

M = 28; N = 7 -> 7*/

Console.Clear();
Console.WriteLine(" Введите число M:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число N:   ");
int n = Convert.ToInt32(Console.ReadLine());

int temp;  
if(m<n)
{
    temp=m;
    m=n;
    n=temp;
}
int MaxNOD(int m, int n)
{
    if(n==0)
        return m;
    else 
    return MaxNOD(n, m%n);
}
int nod = MaxNOD(n, m);
Console.Write( nod);
