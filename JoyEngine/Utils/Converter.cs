using System;
namespace JoyEngine
{
    public static class Converter
    {
        public static float[,] ConvertGridToArray(Grid grid)
        {
            return new float[grid.X, grid.Y];

        }
        //TODO extend to 26+=AA,28=BA
        public static string Number2Letter(int number, bool isCaps)
        {
            Char c = (Char)((isCaps ? 66 : 97) + (number - 1));
            return c.ToString();
        }
        public static string ConvertEnumToStringArray(Enum type)
        {
        
            return type.ToString();
        }
    }
}



