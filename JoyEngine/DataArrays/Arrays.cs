using System.Collections;
using System.Collections.Generic;
using System;
namespace JoyEngine
{
    public class Arrays
    {
        public static float GetArrayValue(float[,] source)
        {
            float result = 0;
            foreach (float f in source)
            {
                result += f;
            }
            return result;
        }

        public static float[,] GetArrayRect(float[,] source, int tx, int ty, int bx, int by)
        {
            int xmax = Math.Abs(tx - bx) + 1;
            int ymax = Math.Abs(ty - by) + 1;
            float[,] result = new float[xmax, ymax];
            for (int i = 0; i < xmax; i++)
            {
                for (int j = 0; j < ymax; j++)
                {
                    result[i, j] = source[tx + i, ty + j];
                }
            }
            return result;
        }
        public static float[,] ResizeArray(float[,] source, int sizex, int sizey)
        {
            int xaspect = 0, xmax = 0, yaspect = 0, ymax = 0;
            bool isSourceGreaterX = false, isSourceGreaterY = false;
            float[,] target;
            if (source.GetLength(0) == sizex && source.GetLength(1) == sizey)
            {
                return source;
            }
            if ((source.GetLength(0) / sizex) == 0)
            {
                xaspect = sizex / source.GetLength(0);
                xmax = sizex;
            }
            else
            {
                xaspect = source.GetLength(0) / sizex;
                isSourceGreaterX = true;
                xmax = sizex;
            }
            if ((source.GetLength(1) / sizey) == 0)
            {
                yaspect = sizey / source.GetLength(1);
                ymax = sizey;
            }
            else
            {
                yaspect = source.GetLength(1) / sizey;
                isSourceGreaterY = true;
                ymax = sizey;
            }
            target = new float[xmax, ymax];
            int basex = 0, basey = 0;
            int basex1 = xaspect - 1, basey1 = yaspect - 1;
            float res = 0;
            if (isSourceGreaterX || isSourceGreaterY)
            {
                for (int i = 0; i < xmax; i++)
                {
                    for (int j = 0; j < ymax; j++)
                    {
                        if (xaspect > 1)
                        {
                            res = (GetArrayValue(GetArrayRect(source, basex, basey, basex1, basey1)));///xaspect));
                            res =(float)Math.Floor(res / xaspect);
                            target[i, j] = res;
                            if (basey1 > ymax)
                            {
                                basex += xaspect;
                                basey = 0;
                                basex1 += xaspect;
                                basey1 -= yaspect;
                            }
                            else
                            {
                                basey1 += yaspect;
                                basey += yaspect;
                            }
                        }
                        else
                        {
                            target[i, j] = source[i, j];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < sizex; i++)
                {
                    for (int j = 0; j < sizey; j++)
                    {
                        if (i < source.GetLength(0) && j < source.GetLength(1))
                            target[i, j] = source[i, j];
                        else
                            target[i, j] = 0;
                    }
                }
            }
            return target;
        }
    }
}