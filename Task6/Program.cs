int size = 5;
int[] arr_int = new int[size];
int i=0;
while(i<size)
{
    Console.WriteLine("Введите элемент массива " + (i+1) +"-е целое число: ");
    string input = Console.ReadLine();
    arr_int[i] = Convert.ToInt32(input);
    i++;
}
PrintArray(arr_int);

void PrintArray(int[] arr_int)
{
    int i = 0;
    while (i < size)
    {
        Console.Write($"{arr_int[i]} ");
        i++;
    }
}