// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
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
int FindDifferBetweenMinMax(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    int difference = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else 
        if (arr[i] < min);
        {
            min = arr[i];
        }
    }
    difference = max - min;
    System.Console.WriteLine($"Разница равна {difference}");
    return difference;
}
int[] myArray = CreatAndFillArr(10, 0, 50);
printarr(myArray);
FindDifferBetweenMinMax(myArray);
