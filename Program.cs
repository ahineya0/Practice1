using System;
using Practice_1.SampleData;
using Practice_1.UI;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Interface.WindowWidth, Interface.WindowHeight);
            Console.SetBufferSize(Interface.WindowWidth, Interface.WindowHeight);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;

            // Размеры таблиц и столбцов
            int tableWidth = Interface.WindowWidth / 2;
            int tableHeight = Interface.WindowHeight - 3; // отняли строку меню сверху и низ

            // Начинаем с верхней части
            Interface.DrawHead();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;

            // Левая таблица
            Interface.RenderFileList(Data.LeftData, 0, 1, tableWidth, tableHeight, 3, "C:\\NC",
                Interface.FitString("C:| Имя", 17) + Interface.FitString("Имя", 13) + "Имя", false);

            // Правая таблица
            Interface.RenderFileList(Data.RightData, tableWidth, 1, Interface.WindowWidth - tableWidth, tableHeight, 4, "C:\\NC",
                Interface.FitString("C:| Имя", 11) + Interface.FitString("Размер", 11) + Interface.FitString("Дата", 9) + "Время", true);

            // Нижняя строка
            Interface.DrawBottomBar();

            Console.SetCursorPosition(6, Interface.WindowHeight - 2); // Курсор у "ввода"
            Console.ReadKey(true); // Чтобы не завершилось
        }
    }
}
