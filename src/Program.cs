using System;
using System.Drawing;

namespace calculate_yiq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getContrastYIQ("#212121"));
        }

        static string getContrastYIQ(string hexColor)
        {
            var color = ColorTranslator.FromHtml(hexColor);
            var yiq = ((color.R * 299) + (color.G * 587) + (color.B * 114)) / 1000;

            return yiq >= 128 ? "#000000" : "#FFFFFF";
        }
    }
}
