using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.Operations;

namespace Lab_1;
/// <summary>
/// калькулятор
/// </summary>
public class Calculator
{
    private List<IOperation> operations;

    public Calculator()
    {
        operations = new()
        {
            new Plus(),
            new Minus(),
            new Multiply(),
            new Divide()
        };
    }

    public void Run()
    {
        bool isCorrectInput = false;
        double firstNum = 0;
        double secondNum = 0;

        while (!isCorrectInput)
        {
            Console.WriteLine("Введите первое число ");
            var number1 = Console.ReadLine();
            Console.WriteLine("Введите второе число ");
            var number2 = Console.ReadLine();

            var isFirstCorrect = double.TryParse(number1, out firstNum);
            var isSecondCorrect = double.TryParse(number2, out secondNum);

            isCorrectInput = isFirstCorrect && isSecondCorrect;

            if (!isCorrectInput)
            {
                Console.WriteLine("Введите корректные числа");
            }
        }

        foreach (var operation in operations)
        {
            var result = GetOperationResult(firstNum, secondNum, operation);
            Console.WriteLine($"{operation.Name}: {result}");
        }

    }

    private double GetOperationResult(double firstNumber, double secondNumber, IOperation operation)
    {
        return operation.Calculate(firstNumber, secondNumber);
    }
}

