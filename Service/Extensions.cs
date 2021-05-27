using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
	static class  Extensions
    {
		public static bool IsLower(this string value)
		{
			for (int i = 0; i < value.Length; i++)
			{
				if (char.IsUpper(value[i]))
				{
					return false;
				}
			}
			return true;
		}
	}
}
