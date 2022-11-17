//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов
// массива.

 
// Console.WriteLine("Введите интервал для массива"); 
// Console.WriteLine("Введите первое число интервала"); 
// int startInterval = int.Parse(Console.ReadLine()!); 
// Console.WriteLine("Введите ворое число интервала"); 
// int endInterval = int.Parse(Console.ReadLine()!); 

Console.WriteLine(); 
Console.WriteLine("Введите длину массива"); 
int lenght = int.Parse(Console.ReadLine()!); 
//Создаем массив 
double[] CreateArrayWithRandomNamber(int length)//int startInterval,int endInterval) 
{ 
    var result = new double[length]; 
    Random random = new Random(); 
    for (int i = 0; i < length; i++){ 
        result[i] = random.NextDouble() + random.Next (-100, 100);// метод + подсказали 
    } 
    return result; 
} 
 
//Вывод массива на экран 
void Print (double[] input) 
{ 
    for (int i = 0; i < lenght; i++) 
    { 
      Console.Write(input[i]); 
      if (i != input.Length-1) 
      Console.WriteLine(" "); 
    } 
    Console.WriteLine(); 
} 
// int[] array = new int[lenght];    
//  int Max = array[0]; 
// int Min = array[0]; 
double DifferenceBetweenMaxAndMin (double[] input) 
{ 
    //double result = 0.0;  
    //int[] array = new int[lenght];    
    double Max = input[0]; 
    double Min = input[0]; 
    for (int i = 0; i < input.Length; i++) 
    { 
        if (input[i]< Min) Min = input[i]; 
        if (input[i] > Max) Max = input[i]; 
                   
    } 
    //result = Max-Min; 
    //Console.WriteLine("Минимальное "+ Min + " " + "Максимальное"+ " "+ Max) ; 
    return Max-Min; 
} 
var array = CreateArrayWithRandomNamber(lenght); 
var Differen = DifferenceBetweenMaxAndMin (array); 
Console.WriteLine("Созданный массив чисел: "); 
Print(array); 
Console.WriteLine(""); 
 
Console.WriteLine("Разница между минимальным и максимальным числом равно: "+ Differen); 
Console.WriteLine("");