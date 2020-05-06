using System;
using System.Collections;
using System.Collections.Generic;

namespace JamesStuartMediaLimited
{
	public class DictionaryGenerics :  DictionaryBase //abstract class
	{
		
		public  void Add (string name, string dept)
		{
			Dictionary.Add (name, dept);	
		}

		public void getDetails ()
		{
			IDictionaryEnumerator objEnumerate = Dictionary.GetEnumerator ();
			while (objEnumerate.MoveNext ()) {
				Console.WriteLine ("Name: " + objEnumerate.Key.ToString () + "\t" + "Department: " + objEnumerate.Value);

			}
		}
	}
}

