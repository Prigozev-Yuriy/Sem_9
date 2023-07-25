// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int AskermanFunction(int firstNum, int secondNum)
{
    if (firstNum == 0) return secondNum + 1;
    if (firstNum != 0 && secondNum == 0) return AskermanFunction(firstNum - 1, 1);
    if (firstNum > 0 && secondNum > 0) return AskermanFunction(firstNum - 1, AskermanFunction(firstNum, secondNum - 1));
    return AskermanFunction(firstNum, secondNum);

}

Console.WriteLine($"Функция Аскермана для аргументов: {firstNum} и {secondNum} равна: {AskermanFunction(firstNum, secondNum)}");