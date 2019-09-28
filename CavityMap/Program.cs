using System;
using System.Diagnostics;
using System.Linq;

namespace CavityMap
{
    class Program
    {
        static string[] cavityMap(string[] grid)
        {
            string[] newGrid = RecreateStrArr(grid);
            for (int i = 1; i < grid.Length - 1; i++)
            {
                string leftNumberChosen;
                string topNumberChosen;
                string numberChosen;
                string bottomNumberChosen;
                string rightNumberChosen;
                for (int j = 1; j < grid.Length - 1; j++)
                {
                    leftNumberChosen = grid[i].Substring(j - 1, 1);
                    topNumberChosen = grid[i - 1].Substring(j, 1);
                    numberChosen = grid[i].Substring(j, 1);
                    bottomNumberChosen = grid[i + 1].Substring(j, 1);
                    rightNumberChosen = grid[i].Substring(j + 1, 1);

                    if (Convert.ToInt32(numberChosen) > Convert.ToInt32(leftNumberChosen) &&
                        Convert.ToInt32(numberChosen) > Convert.ToInt32(topNumberChosen) &&
                        Convert.ToInt32(numberChosen) > Convert.ToInt32(bottomNumberChosen) &&
                        Convert.ToInt32(numberChosen) > Convert.ToInt32(rightNumberChosen))
                    {
                        string before = grid[i].Substring(0, j);
                        string after = grid[i].Substring(j + 1, grid[i].Length - (j + 1));
                        string done = before + "x" + after;
                        //newGrid[i] = done;
                        //Debug.Print(done + " " + i + Environment.NewLine);
                        newGrid[i] = done;
                    }
                }
            }

            return newGrid;
        }

        public static string[] RecreateStrArr(string[] arr)
        {
            string[] newArr = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                string tempStr = arr[i];
                newArr[i] = tempStr;
            }

            return newArr;
        }
        static void Main(string[] args)
        {
            string[] grid = {"1112", "1912", "1892", "1234"};
            string[] newGrid = cavityMap(grid);
            Console.WriteLine();
        }
    }
}
