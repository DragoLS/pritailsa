

using Pritaivsheysa_zmey;
using static System.Net.Mime.MediaTypeNames;

namespace zmey
{
    class Program
    {
        static void Main()
        {

            for (int i = 0; i < (int)border.hght; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("|");
                Console.SetCursorPosition((int)border.wdth, i);
                Console.WriteLine("|");
            }
            for (int i = 1; i < (int)border.wdth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("-");
                Console.SetCursorPosition(i, (int)border.hght);
                Console.WriteLine("-");
            }
            zmeya anakonda = new zmeya();
            anakonda.zmey();
            Console.WriteLine("Game over");
        }
    }
}
