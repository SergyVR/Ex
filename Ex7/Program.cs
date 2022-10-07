// выводим чётные числа до заданного

   Console.WriteLine("Введите число"); 
 
  string firstNumber = Console.ReadLine();
  int Num = int.Parse(firstNumber); 
  int nk = 2;
   while (Num > nk)      
   {
      Console.WriteLine(nk);
       nk = nk + 2; 
   }
