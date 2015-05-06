//Problem 12.** Falling Rocks

//Implement the "Falling Rocks" game in the text console.
//    A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
//    A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
//    Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
//Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class RocksAreFallingGame
{
    struct user
    {
        public int xCoordinate;
        public int yCoordinate;
        public string symbol;
        public ConsoleColor dwarfColor;
    }
    struct rock
    {
        public int xCoordinate;
        public int yCoordinate;
        public string symbol;
        public ConsoleColor rockColor;
    }
    static void printAtPosition(int xCoordinate, int yCoordinate, string symbol, ConsoleColor color)
    {
        Console.SetCursorPosition(xCoordinate, yCoordinate);
        Console.ForegroundColor = color;
        Console.Write(symbol);
    }
    static void printInfo(int xCoordinate, int yCoordinate, string text, ConsoleColor color)
    {
        Console.SetCursorPosition(xCoordinate, yCoordinate);
        Console.ForegroundColor = color;
        Console.Write(text);
    }


    static void Main()
    {
        Console.OutputEncoding = Encoding.GetEncoding(1252);
        Console.CursorVisible = false;
        Console.Title = "Falling Rocks";

        Task.Run(() =>
        {
            while (true)
            {
                PlaySound();
            }
        });

        
        int field = 50;
        Console.WindowWidth = 52;
        Console.BufferHeight = Console.WindowHeight = 40;
        Console.BufferWidth = Console.WindowWidth = 51;
        user dwarf = new user();
        dwarf.xCoordinate = field / 2;
        dwarf.yCoordinate = Console.WindowHeight - 1;
        dwarf.symbol = "0";
        dwarf.dwarfColor = ConsoleColor.White;
        Random randomGenerator = new Random();
        int points = 10;
             
        
        List<rock> rocks = new List<rock>();
        while (true)
        {
            bool impact = false;
            {
                Random colorRandom = new Random();
                ConsoleColor[] color = new ConsoleColor[8] { ConsoleColor.Cyan, ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.DarkCyan };
                Random symbolRandom = new Random();
                string[] symbol = new string[11] { "^", "@", "**", "&", "++", "%", "$", "#", "!", ".", ";" };
                string newSymbol = symbol[symbolRandom.Next(0, 10)];
                rock newRock = new rock();
                newRock.xCoordinate = randomGenerator.Next(0, field);
                newRock.yCoordinate = 8;
                newRock.symbol = newSymbol;
                newRock.rockColor = color[colorRandom.Next(0, 8)];
                rocks.Add(newRock);
            }



            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.xCoordinate - 1 >= 0)
                    {
                        dwarf.xCoordinate--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.xCoordinate + 1 < field)
                    {
                        dwarf.xCoordinate++;
                    }
                }
            }

            List<rock> newList = new List<rock>();
            for (int i = 0; i < rocks.Count; i++)
            {
                rock oldRock = rocks[i];
                rock newRock = new rock();
                newRock.xCoordinate = oldRock.xCoordinate;
                newRock.yCoordinate = oldRock.yCoordinate + 1;
                newRock.symbol = oldRock.symbol;
                newRock.rockColor = oldRock.rockColor;

                if (newRock.yCoordinate == dwarf.yCoordinate && newRock.xCoordinate == dwarf.xCoordinate)
                {
                    points--;
                    
                    impact = true;
                    if (points <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        printInfo(11, 13, "Whoopsie, you died...", ConsoleColor.Black);
                        Console.ReadLine();
                        return;
                    }
                }
                if (newRock.yCoordinate < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
            }
            rocks = newList;
            Console.Clear();

            if (impact)
            {
                rocks.Clear();
                printAtPosition(dwarf.xCoordinate, dwarf.yCoordinate, "ouch!", ConsoleColor.Red);
            }
            else
            {
                printAtPosition(dwarf.xCoordinate, dwarf.yCoordinate, dwarf.symbol, dwarf.dwarfColor);
            }
            foreach (rock rock in rocks)
            {
                printAtPosition(rock.xCoordinate, rock.yCoordinate, rock.symbol, rock.rockColor);
            }

            printInfo(0, 1, "   Move with the left & right arrows \n   and avoid the falling rocks!\n   The scoring:\n   You lose points when you get hit by a rock :)", ConsoleColor.Gray);
            printInfo(10, 6, "Points:" + points, ConsoleColor.Green);
            //printInfo(30, 6, "Score:" + score, ConsoleColor.Green);

            Thread.Sleep(150);
        }
    }


    static void PlaySound()
    {
        Console.Beep(247, 400);
        Console.Beep(417, 800);
        Console.Beep(417, 300);
        Console.Beep(370, 700);
        Console.Beep(417, 200);
        Console.Beep(329, 200);
        Console.Beep(247, 300);
        Console.Beep(247, 500);
        Console.Beep(247, 500);
        Console.Beep(417, 500);
        Console.Beep(417, 500);
        Console.Beep(370, 500);
        Console.Beep(417, 500);
        Console.Beep(497, 800);
        Thread.Sleep(300);
        Console.Beep(497, 500);
        Console.Beep(277, 500);
        Console.Beep(277, 500);
        Console.Beep(440, 500);
        Console.Beep(440, 500);
        Console.Beep(417, 500);
        Console.Beep(370, 500);
        Console.Beep(329, 500);
        Console.Beep(247, 500);
        Console.Beep(417, 500);
        Console.Beep(417, 500);
        Console.Beep(370, 500);
        Console.Beep(417, 500);
        Console.Beep(329, 500);

    }
}




//Note to self: check: 
//static void Printline()
//{
//    const char BorderChar = (char)176;
//    for (int col = 0; col < 51; col++)
//    {
//        Console.SetCursorPosition(col, 5);
//        Console.Write(BorderChar);
//    }

//}