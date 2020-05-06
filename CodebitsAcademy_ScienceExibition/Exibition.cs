using System;
using System.Collections;
using System.Collections.Generic;

namespace CodebitsAcademy_ScienceExibition
{
	
	public class Exibition
	{
		public string  ExbName{ get; set; }

		public string ExbCreator{ get; set; }

		public string Subject{ get; set; }

		public string Floor{ get; set; }

		public string Bulding { get; set; }



		public Exibition (string name, string creator, string subject, string floor, string building)
		{
			ExbName = name;
			ExbCreator = creator;
			Subject = subject;
			Floor = floor;
			Bulding = building;


		}

		public override string ToString ()
		{
			return  $"========  CodeBit Academy Exibition: {ExbName} =========\t \nExibit Creator" ;
		}
	}
}


