﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" .--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--. \r\n/ .. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\\r\n\\ \\/\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ \\/ /\r\n \\/ /`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'\\/ / \r\n / /\\                                                                                                        / /\\ \r\n/ /\\ \\                                                                                                      / /\\ \\\r\n\\ \\/ /   /$$$$$$$   /$$$$$$  /$$$$$$$$ /$$$$$$$$ /$$       /$$$$$$$$  /$$$$$$  /$$   /$$ /$$$$$$ /$$$$$$$   \\ \\/ /\r\n \\/ /   | $$__  $$ /$$__  $$|__  $$__/|__  $$__/| $$      | $$_____/ /$$__  $$| $$  | $$|_  $$_/| $$__  $$   \\/ / \r\n / /\\   | $$  \\ $$| $$  \\ $$   | $$      | $$   | $$      | $$      | $$  \\__/| $$  | $$  | $$  | $$  \\ $$   / /\\ \r\n/ /\\ \\  | $$$$$$$ | $$$$$$$$   | $$      | $$   | $$      | $$$$$   |  $$$$$$ | $$$$$$$$  | $$  | $$$$$$$/  / /\\ \\\r\n\\ \\/ /  | $$__  $$| $$__  $$   | $$      | $$   | $$      | $$__/    \\____  $$| $$__  $$  | $$  | $$____/   \\ \\/ /\r\n \\/ /   | $$  \\ $$| $$  | $$   | $$      | $$   | $$      | $$       /$$  \\ $$| $$  | $$  | $$  | $$         \\/ / \r\n / /\\   | $$$$$$$/| $$  | $$   | $$      | $$   | $$$$$$$$| $$$$$$$$|  $$$$$$/| $$  | $$ /$$$$$$| $$         / /\\ \r\n/ /\\ \\  |_______/ |__/  |__/   |__/      |__/   |________/|________/ \\______/ |__/  |__/|______/|__/        / /\\ \\\r\n\\ \\/ /                                                                                                      \\ \\/ /\r\n \\/ /                                                                                                        \\/ / \r\n / /\\.--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--./ /\\ \r\n/ /\\ \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\.. \\/\\ \\\r\n\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `'\\ `' /\r\n `--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--' ");
            Game game = new Game();
            game.Start();
        }
    }

}
