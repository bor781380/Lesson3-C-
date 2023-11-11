



using System.Diagnostics.CodeAnalysis;

int n = 3;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.WriteLine(sum);
Console.WriteLine(product);

void FillArray(int[] arr)
{
    int i = 0;
    while (i < n)
    {
        arr[i] = i + 1;
        i++;
    }
}
void PrintArray(int[] arr)
{
    int i = 0;
    while (i < n)
    {
        Console.WriteLine($"{arr[i]} ");
        i++;
    }
}
int GetSumOfElements(int[] arr)
{
    int sum = 0;
    int i = 0;
    while (i < n)
    {
        sum = sum + arr[i];
        i++;
    }
    return (sum);
}
int GetProductOfElements(int[] arr)
{
    int product = 1;
    int i = 0;
    while (i < n)
    {
        product = product * arr[i];
        i++;
    }
    return (product);
}