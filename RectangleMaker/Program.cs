// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;

Console.ForegroundColor = ConsoleColor.DarkRed;


string height;
int intHeight;
string width;
int intWidth;

string repeat = "Y";

do
{

    Console.Write("Enter in the height: ");

    height = Console.ReadLine();

    intHeight = (int)Convert.ToInt64(height);

    Console.Write("Enter in the width: ");

    width = Console.ReadLine();

    intWidth = (int)Convert.ToInt64(width);

    void drawWidth(int width)
    {
        for (int i = 0; i < width; i++)
        {
            Console.Write("-");
        }
    }

    void drawHeight(int height)
    {
        for (int i = 0; i < height; i++)
        {
            Console.Write("|");

            for (int j = 0; j < intWidth - 2; j++)
            {
                Console.Write(" ");
            }

            Console.Write("|");

            Console.WriteLine();
        }
    }


    drawWidth(intWidth);
    Console.WriteLine();
    drawHeight(intHeight);
    drawWidth(intWidth);

    Console.WriteLine();

    Console.Write("Do you want to make another rectangle (y/n)?: ");

    repeat = Console.ReadLine();

} while (repeat == "Y" || repeat == "y");
