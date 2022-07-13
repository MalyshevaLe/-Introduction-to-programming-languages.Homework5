/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2


int[] ArrayRandom (int n){      //Метод заполнения массива случайными трехзначными числами
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
        {
        arr[i] = new Random().Next(100, 1000);
        }
    return arr;
}

int findEven(int[] ArrayRandom){       //Поиск количества четных чисел с помощью foreach
    int count = 0;
    foreach (int item in ArrayRandom){
        if(item % 2 ==0){
            Console.Write(item + ",");
            count++;
        }
    }
    return count;
}

int[] array= ArrayRandom(9); 
Console.WriteLine(string.Join(", ", array));

Console.WriteLine($"Количество чётных чисел в массиве = {findEven(array)}");*/
   


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0


int[] ArrayRandom (int n){      //Метод заполнения массива случайными числами
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
        {
        arr[i] = new Random().Next(-100, 101);
        }
    return arr;
}

int findSum(int[] arr1){       //Метод подсчета суммы элем-ов, стоящих на нечетных позициях
    int sum = 0;

    for (int i = 1; i < arr1.Length; i+=2)        //начинаем с нечетной позиции и считаем сумму через число                  
    {
        sum = sum + arr1[i];           
    }

    // или поиск нечетных позиций с помощью остатка от деления
    //for(int i =0; i < length; i++)
    //{
    //    if(i % 2 !=0)
    //    sum = sum + arr1[i];
    //}
    return sum;
}

int[] array= ArrayRandom(9); 
Console.WriteLine(string.Join(", ", array));

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {findSum(array)}");


/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


double[] ArrayRandom (int n){      //Метод заполнения массива случайными числами
    double[] arr = new double[n];
    for (int i = 0; i < arr.Length; i++)
        {
        arr[i] = Convert.ToDouble(new Random().Next(-100, 101));
        }
    return arr;
}

Double findDiffMaxMin(double[] array){       //Поиск разницы между максимальным и минимальным элементов массива с помощью foreach
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"максимальный элемент массива = {max}");
    Console.WriteLine($"минимальный элемент массива = {min}");
    return max-min;
}

double[] arr1 = ArrayRandom(5); 

Console.WriteLine(string.Join("| ", arr1));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {findDiffMaxMin(arr1)}");