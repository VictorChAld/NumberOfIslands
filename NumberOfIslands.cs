using System;
using System.Collections.Generic;
using System.Text;

public class NOI
{
	public static int NumberOfIslands(char[][] chart)
	{
		int islands = 0;
		for (int r = 0; r < chart.Length; r++)
		{
			for (int c = 0; c < chart[r].Length; c++)
			{
				if (chart[r][c].ToString() == "1")
				{
					islands++;
				}
				Explore_Chart(r, c, ref chart);
			}
		}
		return islands;
	}
	private static void Explore_Chart(int row, int col, ref char[][] chart)
	{
		if (row < 0 || col < 0 || row >= chart.Length || col >= chart[row].Length || chart[row][col].ToString() != "1")
		{
			return;
		}
		if (chart[row][col].ToString() == "1")
		{
			chart[row][col] = char.Parse("0");
		}
		Explore_Chart(row - 1, col, ref chart);
		Explore_Chart(row + 1, col, ref chart);
		Explore_Chart(row, col - 1, ref chart);
		Explore_Chart(row, col + 1, ref chart);
	}
}
