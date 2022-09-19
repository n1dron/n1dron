class Programcs
{
     static void Main(string[] args)
    {

        Console.WriteLine("Выберите операцию, введя число от 1 до 9: ");
        Console.WriteLine("1.Сложить 2 числа");
        Console.WriteLine("2.Вычесть первое из второго");
        Console.WriteLine("3.Перемножить два числа");
        Console.WriteLine("4.Разделить первое на второе");
        Console.WriteLine("5.Возвести в степень N первое число");
        Console.WriteLine("6.Найти квадратный корень из числа");
        Console.WriteLine("7.Найти 1 процент от числа");
        Console.WriteLine("8.Найти факториал из числа");
        Console.WriteLine("9.Выйти из программы");
        Console.WriteLine(" ");
        string a = "yes";

        do
        {
            int Amount = Convert.ToInt32(Console.ReadLine());

            if (Amount == 1)
            {

                Console.WriteLine("Введите первое число: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ответ: ");
                Console.WriteLine(x + y);

            }

            else if (Amount == 2)
            {
                Console.WriteLine("Введите первое число: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число: ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ответ: ");
                Console.WriteLine(x - y);

            }
            else if (Amount == 3)
            {
                Console.WriteLine("Введите первое число: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число: ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ответ: " + x * y);

            }
            else if (Amount == 4)
            {
                Console.WriteLine("Введите первое число: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число: ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ответ: " + x / y);

            }
            else if (Amount == 5)
            {
                Console.WriteLine("Введите первое число: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите степень, в которую хотите возвести число: ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ответ: " + Math.Pow(x, y));

            }
            else if (Amount == 6)
            {
                Console.WriteLine("Введите первое число: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Корень из данного числа равняется: " + Math.Sqrt(x));

            }
            else if (Amount == 7)
            {
                Console.WriteLine("Введите первое число: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("1% из данного числа равняется: " + x / 100);

            }
            else if (Amount == 8)
            {
                Console.WriteLine("Введите число, которое хотите возвести в факториал: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int n = 1;
                for (int i = 1; x >= i; ++i)
                {
                    n = n * i;
                }
                Console.WriteLine(n);
            }
            else if (Amount == 9)
            {
                Console.WriteLine("Выход из программы");
                break;
            }
            Console.WriteLine("Продолжить? (yes/no)");
            a = Convert.ToString(Console.ReadLine());

        } while (a == "yes");
    }
}