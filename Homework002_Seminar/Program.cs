// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// // и на выходе показывает вторую цифру этого числа. 
// // Обязательна проверка на ввод чисел больше/меньше 3-х знаков

Console.WriteLine("Введите трехзначное число: ");
string Numbers = Console.ReadLine()!;

if(Numbers.Length != 3)
{
    Console.WriteLine("ВВЕДЕНО НЕВЕРНОЕ ЧИСЛО!");
}
else
{
    Console.WriteLine($"Вторая цифра этого числа: {Numbers[1]}");
}



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. Берем числа до 100000

Console.WriteLine("Введите число: ");
string Numbers = Console.ReadLine()!;

if(Numbers.Length < 3)
{
    Console.WriteLine("ТРЕТЬЕЙ ЦИФРЫ НЕТ!");
}
else
{
    Console.WriteLine($"Третья цифра числа: {Numbers[2]}");
}


// // Задача 15: Напишите программу, которая принимает на вход цифру,
// // обозначающую день недели, и проверяет, является ли этот день выходным.
// // Обязательна проверка на ввод числа <1 и >7


Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine()!);

switch (number)
{
    case 1:{
        Console.WriteLine("ПОНЕДЕЛЬНИК");
    break;
    }
    case 2:{
    Console.WriteLine("ВТОРНИК");
    break;
    }
    case 3:{
    Console.WriteLine("СРЕДА");
    break;
    }
    case 4:{
    Console.WriteLine("ЧЕТВЕРГ");
    break;
    }
    case 5:{
    Console.WriteLine("ПЯТНИЦА");
    break;
    }
    case 6:{
    Console.WriteLine("СУББОТА Выходной");
    break;
    }
    case 7:{
    Console.WriteLine("ВОСКРЕСЕНЬЕ Выходной");
    break;
    }
    default:{
    Console.WriteLine("Номер не соответствут количеству дней недели");
    break;
    }

}

