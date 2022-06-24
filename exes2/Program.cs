// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreatAndFillArr(int large, int min, int max)
{
    int[] array = new int[large];
    for (int ifill = 0; ifill < array.Length; ifill++)
    {
        array[ifill] = new Random().Next(min, max + 1);
    }
    return array;
}
void printarr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}
int SumOddPosiyions(int[] arr)
{
    int SumOdd = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        SumOdd += arr[i];
    }
    System.Console.WriteLine($"Сумма элементов на нечетных позициях  = {SumOdd}");
    return SumOdd;
}
int[] myArray = CreatAndFillArr(10, 0, 10);
printarr(myArray);
SumOddPosiyions(myArray);
