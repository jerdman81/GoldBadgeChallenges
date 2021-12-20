using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
