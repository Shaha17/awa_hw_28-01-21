using System;

namespace DZ_28_01_21
{
	static class ArrayHelper<T>
	{
		public static T Pop(ref T[] arr)
		{
			T[] newArr = new T[arr.Length - 1];
			for (int i = 0; i < arr.Length - 1; i++)
			{
				newArr[i] = arr[i];
			}
			T returnVal = arr[arr.Length - 1];
			arr = newArr;
			return returnVal;
		}
		public static int Push(ref T[] arr, T itemToPush)
		{
			T[] newArr = new T[arr.Length + 1];
			for (int i = 0; i < arr.Length; i++)
			{
				newArr[i] = arr[i];
			}
			newArr[arr.Length] = itemToPush;
			arr = newArr;
			return arr.Length;
		}
		public static T Shift(ref T[] arr)
		{
			T[] newArr = new T[arr.Length - 1];
			for (int i = 0; i < arr.Length; i++)
			{
				newArr[i] = arr[i + 1];
			}
			T returnVal = arr[0];
			arr = newArr;
			return returnVal;
		}
		public static int Unshift(ref T[] arr, T itemToUnshift)
		{
			T[] newArr = new T[arr.Length + 1];
			for (int i = 0; i < arr.Length; i++)
			{
				newArr[i + 1] = arr[i];
			}
			newArr[0] = itemToUnshift;
			arr = newArr;
			return arr.Length;
		}
		public static void Show(T[] arr)
		{
			foreach (var item in arr)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();
		}
	}
}
