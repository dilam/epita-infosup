﻿namespace Debugger
{
	public class Ex2
	{
		public static int ex2() //FIXME
		{
			int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
			int res = 0;
			for (uint i = Misc.getLength(array) -1; i > 0; i--)
				res += array [i];
			return res + array [0];
		}
	}
}

