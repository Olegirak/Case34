/*Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] generateArray(int length, int start,int end)
{
    int[] result = new int [length];
    for (int i = 0;i < length;i++)
    {
        result[i] = new Random().Next(start, end + 1);


    }
    return result;
}

int NumberChet(int []array)
{
int count = 0;
for (int i= 0; i < array.Length;i++)
{
    if (array[i] %2 == 0)
    {
    count = count+1;
    }
    
}
return count;
}

void printArray(int[] array)
{
    string result = "[";
    for (int i = 0; i< array.Length;i++)
    {
        result = result + array[i] + ",";
    }
    result = result[..^1]+"]";
    Console.WriteLine(result);
}   
int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
int length = getUserDate("Введите число элементов массива");
int start = getUserDate("Введите начало диапазона");
int end = getUserDate("Введите конец диапазона");
int [] array = generateArray(length,start, end);
printArray(array);
int num = NumberChet(array);
Console.Write(num);