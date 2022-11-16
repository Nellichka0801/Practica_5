//  Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
System.Console.WriteLine();
Console.WriteLine("Введите длину массива");
int lenght = int.Parse(Console.ReadLine()!);

//Создаем массив
int[] CreateArrayWithRandomNamber(int length)
{
    var result = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++){
        result[i] = random.Next(0,1000);//интервал выдуманный,
                // в рандоме выдавал слишком большие числа
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
//Сумма элементов, стоящие на нечетной позиции
int SumfОddPositions(int[] array)
{
 int result = 0;
for (int i = 1; i < lenght; i=i+2)
 {
    result += array[i];
 }
 return result;
}
var array = CreateArrayWithRandomNamber(lenght);
var SumNumber = SumfОddPositions(array);
Console.WriteLine("Созданный массив чисел: ");
Print(array);
Console.WriteLine("");

Console.WriteLine("Сумма нечетных позиций: "
                + SumNumber);
Console.WriteLine("");

