// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 //Напишите программу, которая покажет количество чётных чисел в массиве.


/*Console.Clear();
int[] Array = new int[4];
Random G = new Random();
int count=0;
Console.Write("[");

for(int i =0; i!=4; i++)
{
    Array[i]=G.Next(100,1000); 
    Console.Write(" "+Array[i]+"," );
    
    if(Array[i]%2==0){
       count++;
    }
} 
Console.WriteLine("]"); 
Console.WriteLine("количество четных чисел  "+count);*/



//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

/*Console.Clear();
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[]numbers = new int [size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;
for (int b = 1; b< numbers.Length; b+=2)
    sum = sum + numbers[b];
    Console.WriteLine($" Cумма элементов на нечетных позициях = {sum}");

void FillArrayRandomNumbers(int[]numbers){
    for(int i = 0; i< numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,10);
    }
}
void PrintArray (int[]numbers){
    Console.Write("[");
    for(int i = 0; i < numbers.Length;i++){
        Console.Write(" "+numbers[i]+ ",");
    }
    Console.Write("]");
    Console.WriteLine();
}*/



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

 /*Console.Clear();
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[]numbers = new double [size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++){
    if (numbers[z] >max){
        max = numbers [z];
    }
    if(numbers[z]< min){
        min = numbers[z];
    }
}
Console.WriteLine($"Max = {max}, Min = {min}" );
Console.WriteLine($"Результат Max-Min={max-min}");

void FillArrayRandomNumbers(double[]numbers){
    for(int i = 0; i< numbers.Length; i++){
        numbers[i] = Convert.ToDouble(new Random().Next(-100,100))/10;
    }
}
void PrintArray (double[]numbers){
    Console.Write("[");
    for(int i = 0; i < numbers.Length;i++){
        Console.Write(" "+numbers[i]+ ".");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine();*/



//(задача со звёздочкой):Задайте одномерный массив, заполненный случайными числами. Из входного массива сформируйте
 //массив с чётными и массив с нечётными значениями элементов входного массива. Найдите ср. арифметическое из 
 //полученных значений элементов массивов и выведите результат сравнения средних арифметических.
//[1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами


Console.Clear();

Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] array = GetArray(size,0,20);

Console.WriteLine(String.Join(" ", array));

int sumEvenNumber = 0;
int sumUnevenNumber = 0;

foreach(int element in array){
sumEvenNumber += element %2==0 ? element : 0;
sumUnevenNumber += element %2 !=0 ? element : 0;
}
if (sumEvenNumber<sumUnevenNumber){
    Console.WriteLine($"sum even: {sumEvenNumber} < sum uneven {sumUnevenNumber}"); 
    if(sumEvenNumber>sumUnevenNumber)
    Console.WriteLine($"sum even: {sumEvenNumber} > sum uneven {sumUnevenNumber}");
    }
int [] GetArray(int size, int min, int max){
int[] result = new int[size];

for(int i = 0; i < size; i++){
result[i] = new Random().Next(min, max + 1);
}
return result;
}

