using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DMineSweeper
{

    public class INITIALIZE_GAME
    {
        private Random r = new Random();
        private int X = 0, Y = 0;
        private int[,] table = new int[8, 8];
        private int[,] tmpTable = new int[8, 8];
        private int x_ = 0, y_ = 0;
        private int score = 0;
        private int life = 3;
        public void Game_Table()
        {
            Console.WindowHeight = 28;
            Console.WindowWidth = 79;
            Console.BufferHeight = 28;
            Console.BufferWidth = 79;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██ ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌");
            Console.WriteLine("██   ██   ██   ██   ██   ██   ██   ██   ██ ▐                                 ▌");
            Console.WriteLine("██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██ ▐                                 ▌");
            Console.WriteLine("██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██ ▐                                 ▌");
            Console.WriteLine("██   ██   ██   ██   ██   ██   ██   ██   ██ ▐                                 ▌");
            Console.WriteLine("██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██ ▐                                 ▌");
            Console.WriteLine("██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██ ▐                                 ▌");
            Console.WriteLine("██   ██   ██   ██   ██   ██   ██   ██   ██ ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌");
            Console.WriteLine("██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██ ▐               █                 ▌");
            Console.WriteLine("██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██ ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌");
            Console.WriteLine("██   ██   ██   ██   ██   ██   ██   ██   ██ ▐                                 ▌");
            Console.WriteLine("██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██ ▐                                 ▌");
            Console.WriteLine("██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██ ▐                                 ▌");
            Console.WriteLine("██   ██   ██   ██   ██   ██   ██   ██   ██ ▐                                 ▌");
            Console.WriteLine("██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██ ▐                                 ▌");
            Console.WriteLine("██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██ ▐                                 ▌");
            Console.WriteLine("██   ██   ██   ██   ██   ██   ██   ██   ██ ▐                                 ▌");
            Console.WriteLine("██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██ ▐                                 ▌");
            Console.WriteLine("██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██ ▐                                 ▌");
            Console.WriteLine("██   ██   ██   ██   ██   ██   ██   ██   ██ ▐                                 ▌");
            Console.WriteLine("██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██ ▐                                 ▌");
            Console.WriteLine("██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██▀▀▀██ ▐                                 ▌");
            Console.WriteLine("██   ██   ██   ██   ██   ██   ██   ██   ██ ▐                                 ▌");
            Console.WriteLine("██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██▄▄▄██ ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌");
            Console.WriteLine("██▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██");
            Console.WriteLine("██                                      ██");
            Console.WriteLine("██▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(8, 25); Console.Write("By: John Patrick S.Papares");
            Console.ResetColor();

            Console.SetCursorPosition(55, 1); Console.ResetColor(); Console.Write("INSTRUCTIONS");
            Console.SetCursorPosition(45, 2); Console.ResetColor(); Console.Write("Controls: Up, Down, Left, Right");
            Console.SetCursorPosition(45, 3); Console.ResetColor(); Console.Write("Legends:   = HP = 5 points");
            Console.SetCursorPosition(45, 4); Console.ResetColor(); Console.Write("           = BOMB = 0 point");
            Console.SetCursorPosition(45, 5); Console.ResetColor(); Console.Write("           = BOSS = 10 points");
            Console.SetCursorPosition(45, 6); Console.ResetColor(); Console.Write("           = BLANK = 1 point");
            Console.SetCursorPosition(54, 3); Console.ForegroundColor = ConsoleColor.Green; Console.Write("♥");
            Console.SetCursorPosition(54, 4); Console.ForegroundColor = ConsoleColor.Red; Console.Write("Q");
            Console.SetCursorPosition(54, 5); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("☻");
            Console.SetCursorPosition(54, 6); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("O");
            Console.SetCursorPosition(46, 8); Console.Write("HP:         ");
            Console.SetCursorPosition(61, 8); Console.Write("Score: 0");

            this.lifePoints(life);
            Console.ResetColor();
        }

        private void lifePoints(int HP)
        {
            Console.SetCursorPosition(46, 8); Console.Write("HP:         ");
            if (HP >= 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (HP == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else if (HP == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            for (int i = 0; i < HP; i++)
            {
                Console.SetCursorPosition(49 + i, 8); Console.Write("♥");
            }
        }

        private void replaceZero(int entity, int limit)
        {
            for (int i = 0; i < limit; i++)
            {
            a:
                X = r.Next(0, 8); Y = r.Next(0, 8);
                if (table[X, Y] == 0)
                {
                    table[X, Y] = entity;
                }
                else
                {
                    goto a;
                }
            }
        }

        public void Initialize()
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    table[x, y] = 0;
                }
            }
            this.replaceZero(1, 3);     //bosses
            this.replaceZero(2, 5);     //bonus life
            this.replaceZero(3, 40);    //bombs
        }

        private void printTableContent()
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Console.Write("{0} ", table[x, y]);
                }
                Console.Write("\n");
                Console.Write("\n");
            }
        }

        public void controller()
        {
            string validInput = Console.ReadKey(true).Key.ToString();
            switch (validInput)
            {
                case "RightArrow":
                    {
                        if (Console.CursorLeft < 38)
                        {
                            Console.SetCursorPosition(Console.CursorLeft + 5, Console.CursorTop);
                            x_++;
                        }
                        break;
                    }
                case "LeftArrow":
                    {
                        if (Console.CursorLeft > 3)
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop);
                            x_--;
                        }
                        break;
                    }
                case "DownArrow":
                    {
                        if (Console.CursorTop < 21)
                        {
                            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 3);
                            y_++;
                        }
                        break;
                    }
                case "UpArrow":
                    {
                        if (Console.CursorTop > 1)
                        {
                            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 3);
                            y_--;
                        }
                        break;
                    }
                case "Spacebar":
                    {
                        if (tmpTable[x_, y_] != 9)
                        {
                            X = Console.CursorLeft; Y = Console.CursorTop;
                            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                            Console.Write(this.output_(table[x_, y_]));
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            tmpTable[x_, y_] = 9;
                            Console.ResetColor();

                            Console.SetCursorPosition(68, 8); Console.Write(score);
                            this.lifePoints(life);
                            Console.SetCursorPosition(X, Y);
                        }

                        break;
                    }
            }
        }

        private string output_(int entity)
        {
            string str = "";
            switch (entity)
            {
                case 0:
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        score += 1;
                        str = "O";
                        Console.SetCursorPosition(45, 12); Console.Write("NICE ONE! You hit a SAFE PLACE!");
                        break;
                    }
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        score += 10;
                        str = "☻";
                        Console.SetCursorPosition(45, 12); Console.Write("EXCELLENT! You hit a BOSS!!     ");
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        score += 5;
                        life++;
                        str = "♥";
                        Console.SetCursorPosition(45, 12); Console.Write("GOOD JOB! You hit a BONUS LIFE!");
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        life--;
                        str = "Q";
                        Console.SetCursorPosition(45, 12); Console.Write("BOOM! You hit a BOMB!          ");
                        break;
                    }
            }
            Console.SetCursorPosition(X, Y);
            return str;
        }


        public void startGame()
        {
        start:
            INITIALIZE_GAME IG = new INITIALIZE_GAME();
            Console.Clear();
            IG.Initialize();
            IG.Game_Table();
            Console.CursorVisible = true;
            tmpTable = table;
            Console.SetCursorPosition(3, 1);//game console starting position
            while (IG.life != 0)
            {
                IG.controller();
            }
            Console.SetCursorPosition(45, 17); Console.ForegroundColor = ConsoleColor.Red; Console.Write("GAME OVER!"); Console.ResetColor();
            Console.SetCursorPosition(45, 12); Console.Write("                               ");
            Console.CursorVisible = false;
            Console.SetCursorPosition(45, 19); Console.ForegroundColor = ConsoleColor.White; Console.Write("Play again?"); Console.ResetColor();
            Console.SetCursorPosition(46, 21); Console.ForegroundColor = ConsoleColor.Green; Console.BackgroundColor = ConsoleColor.White; Console.Write("YES"); Console.ResetColor();
            Console.SetCursorPosition(52, 21); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("NO"); Console.ResetColor();
            Console.SetCursorPosition(46, 21);
            for (; ; )
            {
                string validInput = Console.ReadKey(true).Key.ToString();
                switch (validInput)
                {
                    case "RightArrow":
                        {
                            if (Console.CursorLeft == 46)
                            {
                                Console.SetCursorPosition(46, 21); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("YES"); Console.ResetColor();
                                Console.SetCursorPosition(52, 21); Console.ForegroundColor = ConsoleColor.Green; Console.BackgroundColor = ConsoleColor.White; Console.Write("NO"); Console.ResetColor();
                                Console.SetCursorPosition(52, 21);
                            }
                            break;
                        }
                    case "LeftArrow":
                        {
                            if (Console.CursorLeft == 52)
                            {
                                Console.SetCursorPosition(52, 21); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("NO"); Console.ResetColor();
                                Console.SetCursorPosition(46, 21); Console.ForegroundColor = ConsoleColor.Green; Console.BackgroundColor = ConsoleColor.White; Console.Write("YES"); Console.ResetColor();
                                Console.SetCursorPosition(46, 21);
                            }
                            break;
                        }
                    case "Enter":
                        {
                            if (Console.CursorLeft == 52)
                            {
                                return;
                            }
                            else if (Console.CursorLeft == 46)
                            {
                                goto start;
                            }
                            break;
                        }
                    case "Spacebar":
                        {
                            if (Console.CursorLeft == 52)
                            {
                                return;
                            }
                            else if (Console.CursorLeft == 46)
                            {
                                goto start;
                            }
                            break;
                        }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            INITIALIZE_GAME IG = new INITIALIZE_GAME();
            IG.startGame();
        }
    }
}
