//Задайте массив заполненный случайными положительными трёхзначными
//числами. Напишите программу, которая покажет количество чётных 
//чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива");
int lenght = int.Parse(Console.ReadLine()!);
//int [] array = new int[lenght];
//Создаем массив
int[] CreateArrayWithRandomNamber(int length, 
                                  int startInterval = 100, 
                                  int endInterval =1000)
{
    var result = new int[length];
    Random random = new ();
    for (int i = 0; i < length; i++){
        result[i] = random.Next(startInterval, endInterval);
    }
    return result;
}

//Вывод массива на экран
void Print (int[]input)
{
    for (int i = 0; i < input.Length; i++)
    {
      Console.Write(input[i]);
      if (i != input.Length-1)
      Console.Write(", ");
    }
    Console.WriteLine();
}

// //Функция нахождения количества четных чисел
 int QuantityEvenNumbers(int[] input)
{
int count = 0;
for (int i = 0; i < lenght; i++)
{
    if (input[i]%2==0)
    count++;
}
return count;
}

var array = CreateArrayWithRandomNamber(lenght);
Console.WriteLine("Созданный массив чисел: ");
Print(array);
Console.WriteLine("");

Console.WriteLine("Количество четных чисел "
                + QuantityEvenNumbers(array));
Console.WriteLine("");



