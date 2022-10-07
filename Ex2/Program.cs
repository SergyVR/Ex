

       // сравниваем числа
      Console.WriteLine("Введите первое число"); 
      string firstNumber = Console.ReadLine();
      Console.WriteLine("Введите второе число"); 
      string secondNumber = Console.ReadLine();

    int firstNum = int.Parse(firstNumber); 
    int secondNum = int.Parse(secondNumber); 

     if (firstNum == secondNum)
          Console.WriteLine("числа равны");
          
     if (firstNum < secondNum)
          Console.WriteLine($"max {secondNum}");
     else Console.WriteLine($"max {firstNum} ");
    
