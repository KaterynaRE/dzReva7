using clArray;
using inCalc;
using cISort;
using cIoutpu2;
using InterfaceP;
using cICalc2;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dzReva7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Завдання 1
			//Створіть інтерфейс ICalc.У ньому мають бути два методи:
			//■ int Less(int valueToCompare) — повертає кількість менших значень, ніж valueToCompare;
			//■ int Greater(int valueToCompare) — повертає кількість більших значень, ніж valueToCompare.
			//Клас, створений раніше у практичному завданні Array,має імплементувати інтерфейс ICalc.
			//Метод Less — повертає кількість елементів масиву менших, ніж valueToCompare.
			//Метод Greater — повертає кількість елементів масиву більших, ніж valueToCompare.
			//Напишіть код для тестування отриманої функціональності.

			
			ICalc newArr = new ClassArray(5, 9, 3, 3, 1, 8, 10, 2, 11, 33, 10);
			((IOutput)newArr).Show();
			Console.WriteLine();
			((ISort)newArr).SortAsc();

			int valueToCompare = 10;
			int countMenwe = newArr.Less(valueToCompare);
			Console.WriteLine($"\nNumber of values smaller than {valueToCompare} = {countMenwe}");

			int countBilwe = newArr.Greater(valueToCompare);
			Console.WriteLine($"\nNumber of values smaller than {valueToCompare} = {countBilwe}");

			//Завдання 2
			//Створіть інтерфейс IOutput2.У ньому мають бути
			//два методи:
			//■ void ShowEven() — відображає парні значення контейнера з даними;
			//■ void ShowOdd() — відображає непарні значення контейнера з даними.
			//Клас, створений раніше у практичному завданні Array,має імплементувати інтерфейс IOutput2.
			//Метод ShowEven — відображає парні значення з масиву.
			//Метод ShowOdd — відображає непарні значення масиву.
			//Напишіть код для тестування отриманої функціональності.

			((IOutput2)newArr).ShowEven();
			((IOutput2)newArr).ShowOdd();

			//Завдання 3
			//Створіть інтерфейс ICalc2.У ньому мають бути два методи:
			//■ int CountDistinct() — повертає кількість унікальних значень у контейнері даних;
			//■ int EqualToValue(int valueToCompare) — повертає кількість значень, рівних valueToCompare.
			//Клас, створений раніше у практичному завданні Array, має імплементувати інтерфейс ICalc2.
			//Метод CountDistinct — повертає кількість унікальних значень в масив.
			//Метод EqualToValue — повертає кількість елементів масиву, рівних valueToCompare.
			//Напишіть код для тестування отриманої функціональності.

			Console.WriteLine();
			int countDist = ((ICalc2)newArr).CountDistinct();
			Console.WriteLine($"is unique values, count = {countDist}");
			int countValNum = ((ICalc2)newArr).EqualToValue(valueToCompare);
			Console.WriteLine();
			((IOutput)newArr).Show();
			Console.WriteLine($"\nThe number of array elements of  equal to {valueToCompare} = {countValNum}");
		}
	}
}
