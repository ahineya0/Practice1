using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = Practice_1.Form.File;

namespace Practice_1.UI
{
    public class Interface
    {
        // Размер окна фиксированный
        public const int WindowWidth = 80;
        public const int WindowHeight = 20;
        
        // Коды символов
        const char H = '\u2550'; // прямая горизонтально
        const char V = '\u2551'; // прямая вертикально
        const char CLT = '\u2554'; // угол левый верх
        const char CRT = '\u2557'; // угол правый верх
        const char CLB = '\u255A'; // угол левый низ
        const char CRB = '\u255D'; // угол правый низ
        const char SH = '\u2500'; // разделитель горизонтальный
        const char SV = '\u2502'; // разделитель вертикальный
        const char SU = '\u2564'; // разделитель верх
        const char SD = '\u2534'; // разделитель низ
        const char SL = '\u255F'; // разделитель лево
        const char SR = '\u2562'; // разделитель право

        // Метод внесения строк по "координатам" консоли
        public static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        // Подгон строки под ширину (слева направо)
        public static string FitString(string s, int width)
        {
            if (s.Length > width) return s.Substring(0, width);
            if (s.Length < width) return s + new string(' ', width - s.Length);
            return s;
        }

        // Подгон строки под ширину (справа налево)
        public static string FitStringOp(string s, int width)
        {
            if (s.Length > width) return s.Substring(0, width);
            if (s.Length < width) return new string(' ', width - s.Length) + s;
            return s;
        }

        public static void DrawHLine(int x, int y, int w)
        {
            WriteAt(new string(H, w), x, y);
        }

        public static void DrawSepHLine(int x, int y, int w)
        {
            WriteAt(new string(SH, w), x, y);
        }

        public static void DrawFrame(int x, int y, int width, int height, int numOfCol)
        {
            // верх
            WriteAt(CLT.ToString(), x, y);
            DrawHLine(x + 1, y, width - 2);
            WriteAt(CRT.ToString(), x + width - 1, y);

            // бока
            for (int i = 1; i < height - 1; i++)
            {
                WriteAt(V.ToString(), x, y + i);
                WriteAt(V.ToString(), x + width - 1, y + i);
            }

            // обозначим внутреннюю область
            int innerW = width - 2;
            int sepRow = y + height - 3;

            // нижний горизонтальный разделитель
            WriteAt(SL.ToString(), x, sepRow);
            DrawSepHLine(x + 1, sepRow, width - 2);
            WriteAt(SR.ToString(), x + width - 1, sepRow);

            int gap = 1;
            int colW;
            if ((innerW - (numOfCol - 1) * gap) % numOfCol == 0) colW = (innerW - (numOfCol - 1) * gap) / numOfCol;
            else colW = ((innerW - (numOfCol - 1) * gap) / numOfCol) + 1;

            // вертикальные разделители
            for (int k = 1; k <= numOfCol - 1; k++)
            {
                int xSep = x + k * (colW + 1); // координата разделителя
                WriteAt(SU.ToString(), xSep, y);
                for (int j = y + 1; j <= sepRow - 1; j++)
                    WriteAt(SV.ToString(), xSep, j);
                WriteAt(SD.ToString(), xSep, sepRow);
            }

            // низ
            WriteAt(CLB.ToString(), x, y + height - 1);
            DrawHLine(x + 1, y + height - 1, width - 2);
            WriteAt(CRB.ToString(), x + width - 1, y + height - 1);
        }

        public static void DrawHead()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            WriteAt(FitString("    Левая     Файл     Диск    Команды    Правая", WindowWidth), 0, 0);
            WriteAt(DateTime.Now.ToString("HH:mm"), WindowWidth - 5, 0);
        }

        public static void DrawBottomBar()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            WriteAt(FitString("..", 19), 1, WindowHeight - 4);
            WriteAt("КАТАЛОГ " + DateTime.Now.ToString("dd.MM HH:mm"), 20, WindowHeight - 4);

            WriteAt(FitString("..", 19), 41, WindowHeight - 4);
            WriteAt("КАТАЛОГ " + DateTime.Now.ToString("dd.MM HH:mm"), 60, WindowHeight - 4);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            WriteAt("С:\\NC", 0, WindowHeight - 2);
            WriteAt("1Помощь 2Вызов 3Чтение 4Правка 5Копия 6НовИмя 7НовКат 8Удал-е 9Меню 10Выход", 0, WindowHeight - 1);
        }

        public static void RenderFileList(List<File> files, int x, int y, int w, int h, int noc, string panelTitle, string columnNames, bool detailed)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteAt(FitString(columnNames, w - 2), x + 1, y + 1);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;

            int listTop = y + 2; // Верх списка
            int rows = h - 5;    // Количество строк

            if (detailed) // для правой таблицы (детальнее тип)
            {
                int wName = 9, wSize = 9, wDate = 9, wTime = 8;

                for (int i = 0; i < rows; i++)
                {
                    int yy = listTop + i;
                    string line;

                    if (i < files.Count)
                    {
                        var f = files[i];
                        var date = f.Dt.ToString("dd.MM.yy");
                        var time = f.Dt.ToString("HH:mm");
                        var name = f.GetName(wName - 4);
                        var type = f.Typ.ToString();
                        var size = f.Size.ToString();
                        line = FitString(name, wName - 4) + FitStringOp(type, 4) + ' ' + FitStringOp(size, wSize) + ' ' + FitString(date, wDate + 1) + ' ' + FitString(time, wTime);
                    }
                    else line = new string(' ', w - 2);

                    WriteAt(FitString(line, w - 2), x + 1, yy);
                }
            }
            else // для левой таблицы
            {
                int innerW = w - 2;
                int gap = 1;
                int colW = (innerW - (noc - 1) * gap) / noc;

                int maxItems = rows * noc;
                int count = Math.Min(files.Count, maxItems);

                for (int i = 0; i < count; i++)
                {
                    int r = i % rows;
                    int c = i / rows;
                    int cellX = x + 1 + c * (colW + gap);
                    int cellY = listTop + r;

                    var f = files[i];
                    var name = f.GetName(colW - 4);
                    var type = f.Typ.ToString();

                    WriteAt(FitString(name, colW - 4) + FitStringOp(type, 4), cellX, cellY);
                }
            }

            // Рисуем рамку поверх всего этого дела
            DrawFrame(x, y, w, h, noc);
        }
    }
}
