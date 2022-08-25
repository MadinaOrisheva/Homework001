//  3.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

/*   
// Ввод данных

       int num1;
       int num2;

       Console.Write("Введите первое число: ");
       num1 = Convert.ToInt32(Console.ReadLine());

       Console.Write("Введите второе число: ");
       num2 = Convert.ToInt32(Console.ReadLine());
       int max = num1;
// Условия вывода данных
       if (num2 > max) max = num2;


// Вывод даных
       Console.Write("Максимальное число: " + max);

*/
// Ввод данных

// 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/* 
        int num1;
        int num2;
        int num3;

        Console.Write("Введите первое число: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите третье число: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        int max = num1;

        // Условия вывода данных
        if (num2 > max) max = num2;
        if (num3 > max) max = num3;
        

        // Вывод даных
        Console.Write("Максимальное число: " + max);
    
*/

// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
 int num;

        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());

        if ((num % 2) == 0) {
            Console.Write ("четное");
        }
        else {
        Console.Write ("нечетное");
        }
       */
       //Задача 8: Напишите программу, 
       //которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
      
      
        int num;
        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        int current = 1;

        while (current<=num){
            if((current % 2)==0){
             Console.Write (current+ ",");   
            }
            current++;
        }