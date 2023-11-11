//генерация рандомных чисел в массив
Random rnd = new Random();//Random это тип данных как int

int size = 1000; //задали размер массива
int[] arr_int = new int[size]; //описали массив
int i = 0;
while (i < size)
{
    arr_int[i] = rnd.Next(1, 10); //заполняем массив случайными данными от 1 до 9
    i++;
}

i = 0;
while (i < size)
{
    Console.Write($"{arr_int[i]} "); //вывод массива на печать
    i++;
}
