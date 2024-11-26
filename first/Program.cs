static void SortAscending(ref int[] arr)
{
    Array.Sort(arr);
}

static void SortDescending(ref int[] arr)
{
    Array.Sort(arr);
    Array.Reverse(arr);
}

static int[] MergeArrays(int[] arr1, int[] arr2)
{
    int[] arr = new int[arr1.Length + arr2.Length];
    arr1.CopyTo(arr, 0);
    arr2.CopyTo(arr, arr1.Length);
    return arr;
}

int[] array1 = { 5, 3, 8, 1 };
int[] array2 = { 7, 2, 9 };
SortAscending(ref array1);
Console.WriteLine("Сортировка по возрастанию: " + string.Join(", ", array1));
SortDescending(ref array2);
Console.WriteLine("Сортировка по убыванию: " + string.Join(", ", array2));
int[] mergedArray = MergeArrays(array1, array2);
Console.WriteLine("Объединение: " + string.Join(", ", mergedArray));