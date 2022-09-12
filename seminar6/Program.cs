//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2


/*Console.Clear();

Console.WriteLine("Введите количество чисел:  ");
int n = Convert.ToInt32(Console.ReadLine());
double[]mas = new double[n];
int pol = 0 ;int otr = 0; 

for (int i = 0; i<n; i++)
{
    Console.Write("Введите число:  ");
    mas[i] = Convert.ToDouble(Console.ReadLine());
}
for(int i = 0; i<mas.GetLength(0);i++)
{
    if(mas[i]>0)
    {
        pol++;
    }
}
Console.WriteLine("Количество положительных чисел" +" "+ pol );*/







//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*Console.Clear();
Console.Write("Введите значение b1  "); 
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1  ");
double k1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2  ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2  ");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (-b2+b1)/(-k1+k2);
double y = k2*x+b2;
Console.WriteLine($" Две прямые пересекутся в точке А с координатами X:{x} и Y:{y}");*/






//(задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.

//[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево





int [] GetArray(int size, int min, int max){
int[] newArray = new int[size];

for(int i = 0; i < size; i++){
newArray[i] = new Random().Next(min, max + 1);
}
Console.WriteLine();
return newArray;
}

int[] SdvigArray(int[]array)
{
    int temp;
    
    for(int i = 0;  i<array.Length-1; i++)
    {
        temp=array[i];
        if(i<=array.Length)
        {
           array[i]= array[i+1]; 
        }
        else if(i>array.Length)   
            {
            array[i]= temp;
        }
    }
    return (array) ;
}


Console.Clear();

Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] array = GetArray(size,0,20);

Console.WriteLine(String.Join(" ", array));
int[] myArray = array;
myArray=SdvigArray(myArray);
for( int i = 0; i <myArray.Length; i++)
{
    Console.Write (myArray[i]+"  ");
}