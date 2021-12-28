/*Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами*/

Console.WriteLine("Введите пожалуйста своё имя");
string name = "unnamed";
Console.ReadLine(name);
Console.WriteLine($"Здравствуйте, {name}, вы запустили программу, которая из имеющегося массива чисел формирует массив из чётных чисел");
Console.WriteLine("Для того чтобы ввести массив самостоятельно, введите 1");
Console.WriteLine("Чтобы массив был сгенерирован из случайных чисел, введите 2");
int choise = 0;
Console.ReadLine(choise);
if (choise == 1)
{
    Console.WriteLine("Введите количество элементов для массива, который вы хотите задать");
    int i = 0;
    Console.ReadLine(i);
    int[] arr = new int[i];
    int count = 0;
    Console.WriteLine("Построчно, через Enter, введите пожалуйста каждый элемент массива");
    while (count <i)
    {
        arr[count] = Convert.ToInt32(Console.ReadLine());
        count++;
    }
    for (count = 0; count <i; count++)
    {
        if (arr[count]%2 == 0)
        {
            fin[count] = arr[i];
        }
        int size = sizeof(fin);
    }
    count = 0;
    Console.WriteLine($"Конечный результат:");
    while (count <size)
    {
        Console.WriteLine($"{fin[count]}");
        count++;
    }
}
if (choise == 2)
{

}