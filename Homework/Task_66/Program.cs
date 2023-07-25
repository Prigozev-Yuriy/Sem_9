// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int firstNum, int secondNum)
{
    if (firstNum < secondNum)
    {
        if (firstNum == secondNum) return firstNum;
        return firstNum + SumNumbers(firstNum + 1, secondNum);
    }
    else if (firstNum == secondNum) return secondNum;
    return secondNum + SumNumbers(firstNum, secondNum + 1);
}

Console.WriteLine($"Сумма натуральных элементов в промежутке от числа {firstNum} до числа {secondNum} равна: {SumNumbers(firstNum, secondNum)}");