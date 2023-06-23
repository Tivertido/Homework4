// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

//         Console.WriteLine("Массив: ");
//         for (int i = 0; i < arr.Length; i++) {
//             Console.WriteLine(arr[i]);
//         }


Console.Write("Введите элементы массива через запятую: ");
        string input = Console.ReadLine();
        string[] tokens = input.Split(','); // отделяем элементы введенного массива
        int[] arr = new int[tokens.Length]; // создаем массив нужной длины

        for (int i = 0; i < tokens.Length; i++) {
            arr[i] = int.Parse(tokens[i]); // конвертируем элементы в число
        }

        Console.WriteLine("Массив:");
        Console.WriteLine("[" + string.Join(", ", arr) + "]"); // выводим массив на экран
