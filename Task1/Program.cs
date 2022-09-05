// напишите цикл,который принимает на входдва числа(А и В) и возводит число А в натуральную степень В.
Console.Clear(); 


/*Console.WriteLine("Введите число a");
 int a = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите число b");
 int b = int.Parse(Console.ReadLine());
 
 int i =1;
 for(int n=0; n<b; n++)
 {
    i*=a; 
    
 }
 Console.WriteLine("{0}^{1}={2}",a,b,i);
 
 Console.WriteLine(a+"^"+b+"="+i);*/


 //  программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
 Console.WriteLine("число");
 
int num =int.Parse(Console.ReadLine());
int sum = 0;
string i = "Катя";
string P =" ";
while (num>0){
    sum= sum+num%10;
    num= num/10;
}
Console.WriteLine(sum);*/


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] Array = new int[8];
Random G = new Random(); //подключаем случайные числа
for (int i = 0; i < 8; i++)
{
  Array[i] = G.Next(0, 100);
}
int count = Array.Length;
int index = 0;
Console.Write("[");
while (index < count)
{
  Console.Write(Array[index]);
  index++;

  if (index < count)
  {
    Console.Write(", ");
  }
}

Console.Write("]");



//Найти максимальное и минимальное число в массиве из 10 случайных чисел от -10до 10

int[] array = new int[10];
Random g = new Random();
int min;
int max;
for(int i = 0; i !=10; i++)
{
   array[i] = g.Next(-10,10);
   Console.Write( array[i]+","+" ");
}
max=array[0];
min= array[0];
for(int i=1; i!=10; i++)
{
   if(array[i]>max){
      max= array[i];
   }
   if(array[i]<min)
   {
      min=array[i];
   }
}
Console.WriteLine();
Console.WriteLine("максимальное число в массиве:{0}",max);
Console.WriteLine("Минимальное число в массиве: {0}",min);

