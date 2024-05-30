using System;

class Program
{
    static void Main()
    {
        // Заранее заданный массив (можно заменить на ввод с клавиатуры)
        // string[] inputArray = { "Hello", "2", "world", ":-)" };

        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите массив строк через пробел(без кавычек):");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        // Инициализация нового массива с максимальной возможной длиной
        string[] resultArray = new string[inputArray.Length];
        int index = 0;

        // Проход по всем строкам в исходном массиве
        for (int i = 0; i < inputArray.Length; i++)
        {
            // Проверка длины строки
            if (inputArray[i].Length <= 3)
            {
                // Добавление строки в новый массив
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        // Формирование окончательного массива без пустых элементов
        string[] finalArray = new string[index];
        Array.Copy(resultArray, finalArray, index);

        // Вывод результата
        Console.WriteLine("Результат:");
        Console.WriteLine("[{0}]", string.Join(", ", finalArray));
    }
}
