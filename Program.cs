// int totalExercises = 1;

// for (int number = 8; number >= totalExercises; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }

// Console.WriteLine("Домашнее задание готово");
// Console.WriteLine();

// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }


// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     Console.WriteLine("^_^");
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
// }

// Console.WriteLine();

// int counts = 0;

// for (int ticket = 4; ticket <= 30; ticket++)
// {

//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         counts++;
//         continue;
//     }
//     Console.WriteLine($"Первый доступный билет: {ticket}");
//     Console.WriteLine($"Сколько билетов было пропущено: {counts}");
//     break;
// }

// for (; ; )
// {
//     Console.Write("Введите код группы (для выхода - 'exit'): ");
//     string groupCode = Console.ReadLine()!;

//     if (groupCode == "exit")
//     {
//         break;
//     }

//     Console.WriteLine($"Записан код группы: {groupCode}");
// }

// Console.WriteLine("Работа с журналом завершена");






// Задача Б
Console.WriteLine();

for (int numbers = 100; numbers >= 0; numbers -= 10)
{
    Console.WriteLine($"Числа: {numbers}");
}

// Задача В
Console.WriteLine();

int counts = 1;

for (int nambers = 1; nambers <= 9; nambers++)
{
    Console.WriteLine($"Умножения на {counts}:");
    counts++;
    for (int nombers = 1; nombers <= 9; nombers++)
    {
        Console.WriteLine(nambers * nombers);

    }
}
