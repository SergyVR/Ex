      // узнаём чётное или нечётное
      Console.WriteLine("Введите число"); 
      string firstNumber = Console.ReadLine();

    int firstNum = int.Parse(firstNumber); 

     if (firstNum % 2 == 0)
          Console.WriteLine("чётное");
          
     else Console.WriteLine("нечётное");
