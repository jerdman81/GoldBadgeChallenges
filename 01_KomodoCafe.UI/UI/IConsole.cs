using System;

namespace _01_KomodoCafe.UI.UI
{
    internal interface IConsole
    {
        string ReadLine();
        ConsoleKeyInfo ReadKey();
        void Clear();
        void Write(string s);
        void WriteLine(string s);
        void ChangeColor(ConsoleColor color);
        void ResetConsoleColor();
    }
}
