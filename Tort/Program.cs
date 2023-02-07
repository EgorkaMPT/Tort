namespace Tort
{
    internal class Program
    {
        public static string[] names;
        public static int[] symma;
        static void Main(string[] args)
        {
            while (true)
            {
                names = new string[7];
                symma = new int[7];
                Console.WriteLine("Если вы хотите закать тортик, нажмите ENTER");
                Console.WriteLine("Если вы ошиблись, нажмите ESC");
                ConsoleKey Key = Console.ReadKey().Key;
                switch (Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Menu();
                        int cena = 0;
                        for (int i = 0; i < symma.Length; i++)
                        {
                            cena += symma[i];
                        }
                        string zakaz = "";
                        for (int i = 0; i < names.Length; i++)
                        {
                            if (names[i] != null)
                            {
                                zakaz += "\n    " + names[i] + " - " + symma[i];
                            }
                        }
                    DateTime date = DateTime.Now;
                    string text = "Заказ от " + date + ":\n  Заказ: " + zakaz + "\n  Цена: " + cena + "\n";
                    File.AppendAllText("S:\\История заказов.txt", text);
                        break;
                    case ConsoleKey.Escape:
                    Console.Clear();
                    Console.SetCursorPosition(1, 0);
                    Console.WriteLine("До скорых встреч");
                        return;
                }
            }
        }
        static void Menu()
        {
            Dop.pos = 0;
            while (true)
            {
                Console.WriteLine("  1. Форма тортика \n  2. Размер тортика \n  3. Количество коржиков \n  4. Вид коржиков \n  5. Начиночка \n  6. Глазурь \n  7. Декор тортика \n  8. Сделать заказ \n");
                int cena = 0;
                for (int i = 0; i < symma.Length; i++)
                {
                    cena += symma[i];
                }
                Console.WriteLine("Итоговая цена: " + cena);
                Console.WriteLine("Ваш торт:");
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] != null)
                    {
                    Console.WriteLine("  " + names[i] + " - " + symma[i]);
                }
            }
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 0, 8);
                if (Dop.pos == 0 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    MenuForma();
                    Dop.pos = 0;
                }
                else if (Dop.pos == 1 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    MenuRazmer();
                    Dop.pos = 1;
                }
                else if (Dop.pos == 2 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    MenuVkys();
                    Dop.pos = 2;
                }
                else if (Dop.pos == 3 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    MenuColvo();
                    Dop.pos = 3;
                }
                else if (Dop.pos == 4 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    MenuNachunka();
                    Dop.pos = 4;
                }
                else if (Dop.pos == 5 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    MenuGlazyr();
                    Dop.pos = 5;
                }
                else if (Dop.pos == 6 && Key == ConsoleKey.Enter)
                {
                     Console.Clear();
                     MenuDekor();
                     Dop.pos = 6;
                }
                else if (Dop.pos == 7 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    return;
                }
                Console.Clear();
            }
        }
        static void MenuForma()
        {
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите форму тортика: ");
                int cena = 99;
                int cena1 = 149;
                int cena2 = 199;
                string forma = "Паралепипед";
                string forma1 = "Звезда";
                string forma2 = "Сердечко";
                Console.WriteLine("     " + forma + " - " + cena);
                Console.WriteLine("     " + forma1 + " - " + cena1);
                Console.WriteLine("     " + forma2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);
                if (Key == ConsoleKey.Enter)
                {
                    if (Dop.pos == 1)
                    {
                        names[0] = forma;
                        symma[0] = cena;
                    }
                    else if (Dop.pos == 2)
                    {
                        names[0] = forma1;
                        symma[0] = cena1;
                    }
                    else if (Dop.pos == 3)
                    {
                        names[0] = forma2;
                        symma[0] = cena2;
                    }
                }
                Console.Clear();
            }
        }
        static void MenuRazmer()
        { 
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите размер тортика: ");
                int cena = 199;
                int cena1 = 249;
                int cena2 = 299;
                string razmer = "Маленький";
                string razmer1 = "Средний";
                string razmer2 = "Большой";
                Console.WriteLine("     " + razmer + " - " + cena);
                Console.WriteLine("     " + razmer1 + " - " + cena1);
                Console.WriteLine("     " + razmer2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);
                if (Key == ConsoleKey.Enter)
                {
                    if (Dop.pos == 1)
                    {
                        names[1] = razmer;
                        symma[1] = cena;
                    }
                    else if (Dop.pos == 2)
                    {
                        names[1] = razmer1;
                        symma[1] = cena1;
                    }
                    else if (Dop.pos == 3)
                    {
                        names[1] = razmer2;
                        symma[1] = cena2;
                    }
                }
                Console.Clear();
            }
        }
        static void MenuVkys()
        {
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите вкус коржиков: ");
                int cena = 99;
                int cena1 = 199;
                int cena2 = 299;
                string vkys = "Шоколадный";
                string vkys1 = "Классический";
                string vkys2 = "Клубника + шоколад";
                Console.WriteLine("     " + vkys + " - " + cena);
                Console.WriteLine("     " + vkys1 + " - " + cena1);
                Console.WriteLine("     " + vkys2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);
                if (Key == ConsoleKey.Enter)
                {
                    if (Dop.pos == 1)
                    {
                        names[2] = vkys;
                        symma[2] = cena;
                    }
                    else if (Dop.pos == 2)
                    {
                        names[2] = vkys1;
                        symma[2] = cena1;
                    }
                    else if (Dop.pos == 3)
                    {
                        names[2] = vkys2;
                        symma[2] = cena2;
                    }
                }
                Console.Clear();
            }
        }
        static void MenuColvo()
        {
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите количество коржиков: ");
                int cena = 49;
                int cena1 = 79;
                int cena2 = 99;
                string colvo = "Один коржик";
                string colvo1 = "Два коржика";
                string colvo2 = "Три коржика";
                Console.WriteLine("     " + colvo + " - " + cena);
                Console.WriteLine("     " + colvo1 + " - " + cena1);
                Console.WriteLine("     " + colvo2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);
                if (Key == ConsoleKey.Enter)
                {
                    if (Dop.pos == 1)
                    {
                        names[3] = colvo;
                        symma[3] = cena;
                    }
                    else if (Dop.pos == 2)
                    {
                        names[3] = colvo1;
                        symma[3] = cena1;
                    }
                    else if (Dop.pos == 3)
                    {
                        names[3] = colvo2;
                        symma[3] = cena2;
                    }
                }
                Console.Clear();
            }
        }
        static void MenuNachunka()
        {
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите начинку тортика: ");
                int cena = 149;
                int cena1 = 199;
                int cena2 = 249;
                string nachunka = "Ваниль";
                string nachunka1 = "Шоколад";
                string nachunka2 = "Шоколад + ягоды";
                Console.WriteLine("     " + nachunka + " - " + cena);
                Console.WriteLine("     " + nachunka1 + " - " + cena1);
                Console.WriteLine("     " + nachunka2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);
                if (Key == ConsoleKey.Enter)
                {
                    if (Dop.pos == 1)
                    {
                        names[4] = nachunka;
                        symma[4] = cena;
                    }
                    else if (Dop.pos == 2)
                    {
                        names[4] = nachunka1;
                        symma[4] = cena1;
                    }
                    else if (Dop.pos == 3)
                    {
                        names[4] = nachunka2;
                        symma[4] = cena2;
                    }
                }
                Console.Clear();
            }
        }
        static void MenuGlazyr()
        {
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите глазурь для тортика: ");
                int cena = 99;
                int cena1 = 99;
                int cena2 = 99;
                string glazyr = "Молочный шоколад";
                string glazyr1 = "Тёмный шоколад";
                string glazyr2 = "Белый шоколад";
                Console.WriteLine("     " + glazyr + " - " + cena);
                Console.WriteLine("     " + glazyr1 + " - " + cena1);
                Console.WriteLine("     " + glazyr2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);
                if (Key == ConsoleKey.Enter)
                {
                    if (Dop.pos == 1)
                    {
                        names[5] = glazyr;
                        symma[5] = cena;
                    }
                    else if (Dop.pos == 2)
                    {
                        names[5] = glazyr1;
                        symma[5] = cena1;
                    }
                    else if (Dop.pos == 3)
                    {
                        names[5] = glazyr2;
                        symma[5] = cena2;
                    }
                }
                Console.Clear();
            }
        }
        static void MenuDekor()
        {
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите декор: ");
                int cena = 149;
                int cena1 = 199;
                int cena2 = 319;
                string dekor = "Ягоды";
                string dekor1 = "Шоколадная присыпка";
                string dekor2 = "Рожок + радужная присыпка";
                Console.WriteLine("     " + dekor + " - " + cena);
                Console.WriteLine("     " + dekor1 + " - " + cena1);
                Console.WriteLine("     " + dekor2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);
                if (Key == ConsoleKey.Enter)
                {
                    if (Dop.pos == 1)
                    {
                        names[6] = dekor;
                        symma[6] = cena;
                    }
                    else if (Dop.pos == 2)
                    {
                        names[6] = dekor1;
                        symma[6] = cena1;
                    }
                    else if (Dop.pos == 3)
                    {
                        names[6] = dekor2;
                        symma[6] = cena2;
                    }
                }
            }
                Console.Clear();
        }
    }
}