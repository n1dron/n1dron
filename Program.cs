class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите программу и введите подходящее число");
        Console.WriteLine("1.Угадай число");
        Console.WriteLine("2.Таблица умножения");
        Console.WriteLine("3.Вывод делителей числа");
        Console.WriteLine("4.Выйти из программы");
        int Menu = Convert.ToInt32(Console.ReadLine());

        if (Menu == 1)
        {
            Угадайчисло();
        }
        else if (Menu == 2)
        {
            Таблицаумножения();
        }
        else if (Menu == 3)
        {
            Делителичисла();   
        }
        else if (Menu == 4)
        {
            Console.WriteLine("Программа завершена");
        }
        else
            Console.WriteLine("У вас введено неправильное число");

    }
    static void Угадайчисло()
    {
        Random game = new Random();
        int Number = game.Next(0, 101);
        while (true)
        {
            Console.WriteLine("Угадай загаданное число");
            int reply = Convert.ToInt32(Console.ReadLine());
            if (reply == Number)
            {
                Console.WriteLine("Ты угадал!!!");
                break;

            }
            else
            {
                Console.WriteLine("Неправильно, попробуй ещё раз");
                if (Number > reply)
                {
                    Console.WriteLine("Число должно быть больше");

                }
                else
                {
                    Console.WriteLine("Число должно быть меньше");
                }
            }
        }
        Main();

    }

    static void Таблицаумножения()
    {
        int[,] massiv = new int[10, 10];
        for (int str = 1; str < massiv.GetLength(0); ++str)
        {
            for (int stolb = 1; stolb < massiv.GetLength(1); ++stolb)
            {

                int sum = str * stolb;
                if (str == stolb)
                {
                    massiv[str, stolb] = sum;
                    Console.Write(massiv[str, stolb] + "\t");
                }
                else if (str > stolb)
                {
                    massiv[str, stolb] = sum;
                    Console.Write(massiv[str, stolb] + "\t");
                }
                else if (str < stolb)
                {
                    massiv[str, stolb] = sum;
                    Console.Write(massiv[str, stolb] +"\t");
                }

            }
            Console.WriteLine();

        }
        Main();


    }

    static void Делителичисла()
    {
        Console.WriteLine("Введи число, которое будет делиться");
        int cifra = Convert.ToInt32(Console.ReadLine()); 
        for (int i = 1; i <= cifra; i++)
        {
            if (cifra % i == 0)
            {
                Console.WriteLine(i + "\t");
            }
        }
        Main();

    }

}

































    


 
