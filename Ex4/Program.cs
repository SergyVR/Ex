// сравниваем три числа

      Console.WriteLine("Введите первое число"); 
      string firstNumber = Console.ReadLine();
      Console.WriteLine("Введите второе число"); 
      string secondNumber = Console.ReadLine();
      Console.WriteLine("Введите третье число"); 
      string thirdNumber = Console.ReadLine();

    int firstNum = int.Parse(firstNumber); 
    int secondNum = int.Parse(secondNumber); 
    int thirdNum = int.Parse(thirdNumber); 

    int Max = firstNum;

     if (Max < secondNum)
     Max = secondNum;
     if (Max < thirdNum)
     Max = thirdNum;

     Console.WriteLine($"max {Max}");
