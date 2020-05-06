using System;
using System.Collections;
using System.Collections.Generic;

namespace CodebitsAcademy_ScienceExibition
{
	class MainClass
	{       
		public static void Main (string[] args)
		{        
			string[,] ExibtionA = new string[1, 5] { {
					"Wonders Of Excell",
					" Akintola Olusegun",
					"Excell sheet",
					"First Floor",
					"Primary"
				}
			};
			string[,] ExibtionB = new string[1, 5] { {
					" Coderful",
					" Ozougwu Ifeanyi",
					" HTML",
					"Second Floor",
					"Higher"
				}
			};
			string[,] ExibtionC = new string[1, 5] { {
					" Mobile Internet",
					" Bisi Olayinka",
					" Data Base Design",
					"Third",
					"Lab"
				}
			};
			string[,] ExibtionD = new string[1, 5] { {
					" Key To Software testing",
					" Bukola Adebayo",
					" Data Base Design",
					"Second Floor",
					"Higher"
				}
			};
			string[,] ExibtionE = new string[1, 5] { {
					" Edge Computing",
					" Saraki Abu",
					" C#",
					"Second Floor",
					" lab"
				}
			};
			string[,] ExibtionF = new string[1, 5] { {
					" Future Technologies",
					" Eze Ifeanyi",
					" My SQL",
					"First Floor",
					"Higher"
				}
			};
			string[,] ExibtionG = new string[1, 5] { {
					" Women in Tech",
					" Judith Adebanjo",
					" Data Base design",
					"Third Floor",
					"Lab"
				}
			};
			string[,] ExibtionH = new string[1, 5] { {
					" Digital Transformation",
					" Kelvin Eze",
					"Php",
					"First Floor",
					"Higher"
				}
			};
			string[,] ExibtionI = new string[1, 5] { {
					" IT Infrastructure",
					" James Ali",
					" Data Base Design",
					"Second Floor",
					"Higher"
				}
			};
			string[,] ExibtionJ = new string[1, 5] { {
					" App Development",
					" Olusegun Abiola",
					" Xamarin",
					"First Floor",
					"primary"
				}
			};
			string[,] ExibtionK = new string[1, 5] { {
					" Information Security",
					" Emmanuel ayiam",
					" Pythom",
					"First Floor",
					"Primary"
				}
			};
			string[,] ExibtionL = new string[1, 5] { {
					"Power Of Artifucial intelligent",
					" Ogbuka Ifeanyi",
					" Autonomous System",
					"Second Floor",
					"Higher"
				}
			};
			string[,] ExibtionM = new string[1, 5] { {
					" FinTech",
					" Chelozonal Nnamni",
					" Web Deelopment",
					"Third Floor",
					"lab"
				}
			};
			string[,] ExibtionN = new string[1, 5] { {
					" Managed Services",
					" Adejo Baba",
					" Data Base Management",
					"Second Floor",
					"Higher"
				}
			};
			string[,] ExibtionO = new string[1, 5] { {
					" IT Strategy",
					" Ozougwu Ifeanyi",
					" Data Base Design",
					"Third  Floor",
					"Primary"
				}
			};

				
			//......................................Creation of ArrayList Starts here.............................!

			ArrayList ExbList = new ArrayList ();
			ExbList.Add (ExibtionA);
			ExbList.Add (ExibtionB);
			ExbList.Add (ExibtionC);
			ExbList.Add (ExibtionD);
			ExbList.Add (ExibtionE);
			ExbList.Add (ExibtionF);
			ExbList.Add (ExibtionG);
			ExbList.Add (ExibtionH);
			ExbList.Add (ExibtionI);
			ExbList.Add (ExibtionJ);
			ExbList.Add (ExibtionK);
			ExbList.Add (ExibtionL);
			ExbList.Add (ExibtionM);
			ExbList.Add (ExibtionN);
			ExbList.Add (ExibtionO);


			//........................................Generating Top Rankers.................................!



             
            Hashtable hashtable = new Hashtable();
            Result result1 = new Result(2018,89,"HTML");
            Result result2 = new Result(2018, 99, "CSS");
            Result result3 = new Result(2019, 69, "Data Base");
            Result result4 = new Result(2018, 69, "C#");
            Result result5 = new Result(2019, 29, "PHP");
            Rankers rankers1 = new Rankers("Ifeanyi",result1);
            Rankers rankers2 = new Rankers("Bisi", result2);
            Rankers rankers3 = new Rankers("Kenechi", result3);
            Rankers rankers4 = new Rankers("IKKENNA", result4);
            Rankers rankers5 = new Rankers("Kunle", result5);
            rankers1.GetTopRanked();
            rankers2.GetTopRanked();
            rankers3.GetTopRanked();
            rankers4.GetTopRanked();
            rankers5.GetTopRanked();

           

            hashtable.Add(rankers1.Name, rankers1.GetResults());
            hashtable.Add(rankers2.Name, rankers2.GetResults());
            hashtable.Add(rankers3.Name, rankers3.GetResults());
            hashtable.Add(rankers4.Name, rankers4.GetResults());
            hashtable.Add(rankers5.Name, rankers5.GetResults());

           
            foreach (Object key in hashtable.Keys)
            {
                Console.WriteLine($"{value}");
            }


			

	}     }
}
