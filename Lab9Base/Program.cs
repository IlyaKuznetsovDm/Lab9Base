// See https://aka.ms/new-console-template for more information

//List<long> longs = new List<long> { 2, 3, 0, 1, 5, 4, 6, 7, 9, 8, 11, 10, 14, 13, 12, 15 };

//long max = longs.AsQueryable().Max();
//double min = longs.AsQueryable().Min();

//Console.WriteLine("Минимальное значение: {0}.", min);

//Console.WriteLine("Максимальное значение: {0}.", max);

//-----------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------

int[] numbers = { 0, 2, 1, 5, 4, 3, 6, 7, 10, 9, 8, 11, 12, 14, 15, 13 };

int min = numbers.Min();
int max = numbers.Max();


Console.WriteLine($"Минимальное значение: {min}.");
Console.WriteLine($"Максимальное значение: {max}.");

//-----------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------

//class Program1
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
//        Random rand = new Random();
//        int mini = 0;
//        int maxi = 0;
//        Console.WriteLine("Введены 16 элементов массива: ");
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = rand.Next(16);
//            Console.WriteLine(numbers[i] + " ");
//        }
//        double min = numbers[0];
//        double max = numbers[0];

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            if (max < numbers[i])
//            {
//                max = numbers[i]; maxi = i;
//            }
//            if (min > numbers[i])
//            {
//                min = numbers[i]; mini = i;
//            }
//        }
//        Console.WriteLine("Результат:");
//        Console.WriteLine("Максимальный элемент и его местоположение = {0} ; {1} ", max, maxi);
//        Console.WriteLine("Минимальный элемент и его местоположение  = {0} ; {1} ", min, mini);

//    }
//}
