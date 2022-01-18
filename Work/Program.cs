
/*Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами*/

Console.WriteLine("Введите пожалуйста своё имя");
 stringname = "unnamed";
name = Console.ReadLine();
Console.WriteLine($"Здравствуйте, {name}, вы запустили программу, которая из имеющегося массива чисел формирует массив из чётных чисел");
Console.WriteLine("Для того чтобы ввести массив самостоятельно, введите 1");
Console.WriteLine("Чтобы массив был сгенерирован из случайных чисел, введите 2");
 intchoise = 0;
choise = Convert.ToInt32(Console.ReadLine());
if (choise == 1)
{
    Console.WriteLine("Введите количество элементов для массива, который вы хотите задать");
    int i = 0;
    i = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[i];
      intcount= ;
    Console.WriteLine("Построчно, через Enter, введите пожалуйста каждый элемент массива");
    while (count <i)
    {
        arr[count] = Convert.ToInt32(Console.ReadLine());
        count++;
    }
     intcount2 = 0;
    for (count = 0; count <i; count++)
    {
        if (arr[count]%2 == 0)
        {
            count22++;
        }
    }
    int []arr2 = new int[count22];
     intcount3 = 0;
    for (count = 0; count <i; count++)
    {
        if (arr[count]%2 == 0)
        {
            arr2[count33] = arr[count];
            count33++;
        }
    }
    count = 0;
    if (count2 2== 0)
    {
        Console.WriteLine("В данном массиве нет ни одного чётного числа");
    }
    else
    {
        Console.WriteLine("Конечный результат:");
        while (count <count2)
        {
            Console.WriteLine($"{arr2[count]}");
            count++;
        }
    }
}
if (choise == 2)
{
    Console.WriteLine("Введите количество элементов для массива, который вы хотите задать");
    int k = 0;
    k = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[k];
    int ccount = 0;
    Console.WriteLine("Будет сформирован массив из случайных чисел в диапазоне от -100 до 100 ");
    Random r = new Random();
    while (ccount <k)
    {
        array[ccount] = r.Next(-100,100);
        ccount++;
    }
    ccount = 0;
    int ccount2 = 0;
    for (ccount = 0; ccount <k; ccount++)
    {
        if (array[ccount]%2 == 0)
        {
            ccount2++;
        }
    }
    int []array2 = new int[ccount2];
    int ccount3 = 0;
    for (ccount = 0; ccount <k; ccount++)
    {
        if (array[ccount]%2 == 0)
        {
            array2[ccount3] = array[ccount];
            ccount3++;
        }
    }
    Console.WriteLine("Если вы хотите увидеть весь сформированный массив, введите 1, если хотите просто продолжить, введите любое число кроме единицы");
    int choise2 = 0;
    choise2 = Convert.ToInt32(Console.ReadLine());
    ccount = 0;
    if (choise2 == 1)
    {
        while (ccount <ccount2)
        {
            Console.WriteLine($"{array2[ccount]}");
            ccount++;
        }
    }
    ccount = 0;
    if (ccount2 == 0)
    {
        Console.WriteLine("В данном массиве нет ни одного чётного числа");
    }
    else 
    {
        Console.WriteLine("Конечный результат:");
        while (ccount <ccount2)
        {
            Console.WriteLine($"{array2[ccount]}");
            ccount++;
        }
    }
}
