//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        while (number > 0) {
            int digit = number % 10; // получаем последнюю цифру числа
            sum += digit; // добавляем цифру к сумме
            number /= 10; // уменьшаем число на порядок
        }
        Console.WriteLine("Сумма цифр числа: {0}", sum);