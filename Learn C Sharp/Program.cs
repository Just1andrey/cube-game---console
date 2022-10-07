Random random = new Random();
void resrart()
{
    int result = 0;
    int chances = 3;
    int change;
    Console.WriteLine("Задача: набрать 10 очков за 3 броска");

    while (result < 10 && chances != 0)
    {
        while (chances > 0)
        {
            chances--;
            Console.WriteLine("Вы кидаете кубик");
            int numbers = random.Next(1, 6);

            Console.WriteLine($"На кубике выпало: {numbers}");
            result += numbers; 
        }
    }

    if (result >= 10)
    {
        Console.WriteLine("Вы выиграли ! \nХотите попробовать снова ? нажми 1");
        change = Convert.ToInt32(Console.ReadLine());

        if (change == 1)
        {
            resrart();
        }
    }
    else
    {
        Console.WriteLine("Вы проиграли \nХотите попробовать снова ? нажми 1");
        change = Convert.ToInt32(Console.ReadLine());
        
        if (change == 1)
        {
            resrart();
        }
    }
}

resrart();