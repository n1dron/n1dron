using System.Data;

class Program
{
        static void Main(string[] args)
        {
            pianino();
        }
        static void pianino()
        {
            Console.WriteLine("Пианино c двумя октавами");
            Console.WriteLine("Выберите октаву нажав 'F1' или 'F2':");
            ConsoleKeyInfo Clavisha = Console.ReadKey();
            List<int[]> tablica = new List<int[]>
            {
            new int[] {523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987},
            new int[] {1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976}
            };
            if (Clavisha.Key == ConsoleKey.F1)
            {
                Octava1(tablica[0]);
            }
            if (Clavisha.Key == ConsoleKey.F2)
            {
                Octava2(tablica[1]);
            }
        }
        static void Octava1(int[] note)
        {
            Console.WriteLine("5 Октава");
            Console.WriteLine("Для переключения октав нажмите 'F5'");
            for (ConsoleKeyInfo octava = Console.ReadKey(); octava.Key != ConsoleKey.F5;)
            {
                if (octava.Key == ConsoleKey.A) 
                {
                    Console.Beep(note[0], 400);
                    Console.Clear();
                }
                if (octava.Key == ConsoleKey.W)
                {
                    Console.Beep(note[1], 400);
                    Console.Clear();
                }
                if (octava.Key == ConsoleKey.S)
                {
                    Console.Beep(note[2], 400);
                    Console.Clear();
                }
                if (octava.Key == ConsoleKey.D)
                {
                    Console.Beep(note[3], 400);
                    Console.Clear();
                }
                if (octava.Key == ConsoleKey.R)
                {
                    Console.Beep(note[4], 400);
                    Console.Clear();
                }
                if (octava.Key == ConsoleKey.F)
                {
                    Console.Beep(note[5], 400);
                    Console.Clear();
                }
                if (octava.Key == ConsoleKey.T)
                {
                    Console.Beep(note[6], 400);
                    Console.Clear();
                }
                if (octava.Key == ConsoleKey.G)
                {
                    Console.Beep(note[7], 400);
                    Console.Clear();
                }
                if (octava.Key == ConsoleKey.Y)
                {
                    Console.Beep(note[8], 400);
                    Console.Clear();
                }
                if (octava.Key == ConsoleKey.H)
                {
                    Console.Beep(note[9], 400);
                    Console.Clear();
                }
                if (octava.Key == ConsoleKey.J)
                {
                    Console.Beep(note[10], 400);
                    Console.Clear();
                }
                if (octava.Key == ConsoleKey.I)
                {
                    Console.Beep(note[11], 400);
                    Console.Clear();
                }
                octava = Console.ReadKey();
            }
            pianino();
        }
        static void Octava2(int[] note)
        {
            Console.WriteLine("6 Октава");
            Console.WriteLine("Для переключения октав нажмите 'F5'");
            for (ConsoleKeyInfo octava = Console.ReadKey(); octava.Key != ConsoleKey.F5;)
            {
            if (octava.Key == ConsoleKey.A)
            {
                Console.Beep(note[0], 400);
                Console.Clear();
            }
            if (octava.Key == ConsoleKey.W)
            {
                Console.Beep(note[1], 400);
                Console.Clear();
            }
            if (octava.Key == ConsoleKey.S)
            {
                Console.Beep(note[2], 400);
                Console.Clear();
            }
            if (octava.Key == ConsoleKey.D)
            {
                Console.Beep(note[3], 400);
                Console.Clear();
            }
            if (octava.Key == ConsoleKey.R)
            {
                Console.Beep(note[4], 400);
                Console.Clear();
            }
            if (octava.Key == ConsoleKey.F)
            {
                Console.Beep(note[5], 400);
                Console.Clear();
            }
            if (octava.Key == ConsoleKey.T)
            {
                Console.Beep(note[6], 400);
                Console.Clear();
            }
            if (octava.Key == ConsoleKey.G)
            {
                Console.Beep(note[7], 400);
                Console.Clear();
            }
            if (octava.Key == ConsoleKey.Y)
            {
                Console.Beep(note[8], 400);
                Console.Clear();
            }
            if (octava.Key == ConsoleKey.H)
            {
                Console.Beep(note[9], 400);
                Console.Clear();
            }
            if (octava.Key == ConsoleKey.J)
            {
                Console.Beep(note[10], 400);
                Console.Clear();
            }
            if (octava.Key == ConsoleKey.I)
            {
                Console.Beep(note[11], 400);
                Console.Clear();
            }
                octava = Console.ReadKey();
            }
            pianino();
        }
    
}