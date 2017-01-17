using System;

namespace Explorer
{
	public class Map
	{
		char[,] map;
		int width;
		int height;
		Character hero;

		public Map (int width_, int height_)
		{
			width = width_;
			height = height_;
			map = new char[height, width];
		}
		public void display ()
		{
			Console.Clear ();
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++) 
				{
					Console.Write (map [i, j] + " ");
				}
				Console.WriteLine();
			} 
		}
	}

}

