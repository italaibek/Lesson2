// using System;
// public class Answer
// {

//     static int SumArray(int[] numbers)
//     {
//         int sum = 0;
//         foreach (int num in numbers)
//         {
//             sum += num;
//         }
//         return sum;
//     }

//     static public void Main(string[] args)
//     {
//         int[] numbers = { 1, 5, 32, 3, 4, 5, 6 }; 
                                                  
//         int result = SumArray(numbers);
//         Console.WriteLine(result);
//     }
// }


// using System;
// public class Answer
// {
//     static int MaxValue(int[] numbers)
//     {
//         int maximum = numbers[0];
//         foreach (int num in numbers)
//         {
//             if (num > maximum)
//             {
//                 maximum = num;
//             }
//         }
//         return maximum;
//     }
//     static public void Main(string[] args)
//     {
//         int[] numbers = { 7, 1, 8, 3, 4, 48 }; // Массив можно поменять для проверки
//                                                // Не удаляйте строки ниже
//         int result = MaxValue(numbers);
//         Console.WriteLine(result);
//     }
// }

// using System;
// public class Answer
// {
//     static int ProductOfArray(int[] numbers)
//     {
//         int product = 1;
//         foreach (int num in numbers)
//         {
//             product *= num;
//         }
//         return product;

//     }
//     static public void Main(string[] args)
//     {
//         int[] numbers = { 2, 3, 4 }; // Массив можно поменять для проверки
//                                      // Не удаляйте строки ниже
//         int result = ProductOfArray(numbers);
//         Console.WriteLine(result);
//     }
// }

// using System;
// using System.Linq;
// public class Answer
// {
//     static int[] RemoveEvenNumbers(int[] numbers)
//     {
//         return numbers.Where(n => n % 2 != 0).ToArray();
//     }
//     static public void Main(string[] args) {
//         int[] numbers = { 1, 2, 3, 4, 5 }; // Массив можно поменять для проверки
//     // Не удаляйте строки ниже
// int[] result = RemoveEvenNumbers(numbers);
//         Console.WriteLine("[" + string.Join(", ", result) + "]");
//     }
// }


using System;
public class Answer
{
    static double AverageInRange(int[] numbers, int start, int end)
    {
        if (start < 0 || end >= numbers.Length || start > end)
        {
            throw new ArgumentException("Неверные индексы диапазона.");
        }
        double sum = 0;
        int count = end - start + 1;
        for (int i = start; i <= end; i++)
        {
            sum += numbers[i];
        }
        return sum / count;
    }
    static public void Main(string[] args) {
        int[] numbers = { 1, 4, 6, 8, 10 }; // Массив можно поменять для проверки
        int start = 1; // Начальный индекс диапазона
        int end = 3; // Конечный индекс диапазона
                     // Не удаляйте строки ниже
        double result = AverageInRange(numbers, start, end);
        Console.WriteLine(result);
    }
}