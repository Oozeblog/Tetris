void Figure(int x, int y, char sim)

{

    Console.Clear();

    for (int i = x - 1; i <= x + 1; i++)

    {

        for (int j = y - 1; j <= y + 1; j++)

        {

            Console.SetCursorPosition(i, j);

            Console.Write(sim);

        }

    }

}

int x = 10;

int y = 2;

char sim = '*';


// Логика отрисовки всего

new Thread(() =>

{

    while (true)

    {

        Figure(x, y, sim);

        Thread.Sleep(500);

        y++;

        if (y > 15) y = 1;

    }

}).Start();

// Логика проверки нажатия кнопок

while (true)

{

    var key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.LeftArrow)

    {

        x--;

        Figure(x, y, sim);

    }

    if (key == ConsoleKey.RightArrow)

    {

        x++;

        Figure(x, y, sim);

    }

}
