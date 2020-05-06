using System;
using System.Collections;
using System.Collections.Generic;

namespace JamesStuartMediaLimited
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");


			DictionaryGenerics PromEmployee = new DictionaryGenerics ();
			PromEmployee.Add ("Tom Lee", "Training");
			PromEmployee.Add ("James Anderson", "HR");
			PromEmployee.Add ("Michael Chan", "Content Development");
			PromEmployee.Add ("Jackie Jackson", "Training");
			PromEmployee.Add ("Bruce Douglas ", "Graphics");
			PromEmployee.Add ("Kim Dale", "HR");
			PromEmployee.Add ("Joseph Mathews ", "Content Development");
			PromEmployee.Add ("Rose Dorson", "Marketing");
			PromEmployee.Add ("Andrews Stephen", "Graphics");

			PromEmployee.getDetails ();

			SortedList proEmployee = new SortedList ();
			proEmployee.Add ("Tom Lee", "Training");
			proEmployee.Add ("James Anderson", "HR");
			proEmployee.Add ("Michael Chan", "Content Development");
			proEmployee.Add ("Jackie Jackson", "Training");
			proEmployee.Add ("Bruce Douglas ", "Graphics");
			proEmployee.Add ("Kim Dale", "HR");
			proEmployee.Add ("Joseph Mathews ", "Content Development");
			proEmployee.Add ("Rose Dorson", "Marketing");
			proEmployee.Add ("Andrews Stephen", "Graphics");



			bool myBool = proEmployee.Contains ("Andrews Stephen");

			Console.WriteLine (myBool);

			foreach (var  employee  in proEmployee) {
				var temp = proEmployee.ContainsValue ("Andrews Stephen");
				if (temp) {
					foreach (var item in proEmployee) {
						proEmployee.Remove (temp);
					}
					
					Console.WriteLine (proEmployee);

				}
			}


		









		}
	}
}
