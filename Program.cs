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






// // Задача Б
// Console.WriteLine();

// for (int numbers = 100; numbers >= 0; numbers -= 10)
// {
//     Console.WriteLine($"Числа: {numbers}");
// }

// // Задача В
// Console.WriteLine();

// int counts = 1;

// for (int nambers = 1; nambers <= 9; nambers++)
// {
//     Console.WriteLine($"Умножения на {counts}:");
//     counts++;
//     for (int nombers = 1; nombers <= 9; nombers++)
//     {
//         Console.WriteLine(nambers * nombers);

//     }
// }

// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
// Console.WriteLine("Фамилия не введена. Завершение работы."); 
// return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
// .OrderBy(_ => rnd.Next()) 
// .Take(2) 
// .OrderBy(x => x) 
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}"); 



// // Вариант 7. 
// for (int a = 1; a <= 5; a++)
// {
//     Console.WriteLine();

//     for (int b = 1; b <= 5; b++)
//     {
//         Console.WriteLine(a + b);
//     }
// }

// // Вариант 9
// Console.WriteLine();

// int num = 5;
// for (int sum = 1; sum <= 30; sum++)
// {

//     if (sum == num)
//     {
//         num += 5;
//         continue;
//     }
//     Console.WriteLine($"Сумма: {sum}");
// }


// Доп задание
int days = 0;


for (int totalTr = 1; days <= 20; totalTr++)
{
    for (int week = 1; week <= 3; week++)
    {
        Console.WriteLine("^_^");
        for (int day = 1; day <= 7; day++)
        {
            days++;
            if (day == 7)
            {
                continue;
            }

        }
    }
    Console.WriteLine($"Тренировочных дней {days}");
}
