using System;

namespace DZ_28_01_21
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Задание 2");
			// Задание 2
			// Cоздать статический класс ArrayHelper.
			// 1. Добавить 4 статичных методов перегрузкой основных типов
			// string[], int[], double[], decimal[], float[]:
			// • Pop(ref тип[]) – Удаляет последний элемент массива и возвращает этот
			// удалённый элемент используя return.
			// • Push(ref тип[], элемент) – Добавляет элемент с конца массива и
			// возвращает обновленную длину массива
			// • Shift(ref тип[]) – Удаляет первый элемент и возвращает этот удалённый
			// элемент используя return.
			// • UnShift(ref тип[], элемент) – Добавляет элемент в начало массива и
			// возвращает обновленную длину массива
			string[] strs = new string[] { "1", "2", "3", "4", "5" };
			Console.WriteLine("Начальное состояние массива");
			ArrayHelper<string>.Show(strs);
			string tempString = ArrayHelper<string>.Pop(ref strs);
			Console.WriteLine("Массив после операции Pop");
			ArrayHelper<string>.Show(strs);
			ArrayHelper<string>.Push(ref strs, tempString);
			Console.WriteLine("Массив после операции Push");
			ArrayHelper<string>.Show(strs);
			Console.WriteLine();


			int[] ints = new int[] { 1, 2, 3, 4, 5 };
			Console.WriteLine("Начальное состояние массива");
			ArrayHelper<int>.Show(ints);
			int tempInt = ArrayHelper<int>.Pop(ref ints);
			Console.WriteLine("Массив после операции Pop");
			ArrayHelper<int>.Show(ints);
			ArrayHelper<int>.Push(ref ints, tempInt);
			Console.WriteLine("Массив после операции Push");
			ArrayHelper<int>.Show(ints);
			Console.WriteLine();
		}
	}
}
