using System;
using System.Collections.Generic;
public class Triangle
{
	public int SideA;
  public int SideB;
	public int SideC;



	public Triangle(int sideA, int sideB, int sideC )
	{
		SideA = sideA;
		SideB = sideB;
		SideC = sideC;
	}

	public string TriangleType()
	{
		if ((SideA + SideB) < (SideC) || (SideA + SideC) < (SideB) || (SideB + SideC) < (SideA))
		{
			return "This is not a triangle!";
		}
		else if ((SideA == SideB) && (SideB == SideC))
		{
			return "Equilateral";
		}
		else if ((SideA == SideB) || (SideB == SideC) || (SideC == SideA))
		{
			return "Isosceles";
		}
		else if ((SideA != SideB) && (SideB != SideC) && (SideC != SideA))
		{
			return "Scalene";
		}
		else {
			return "test";
		}
	}
}

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter Side One of Triangle");
		string stringSideA = Console.ReadLine();
		int sideA = int.Parse(stringSideA);
		
		Console.WriteLine("Enter Side Two of Triangle");
		string stringSideB = Console.ReadLine();
		int sideB = int.Parse(stringSideB);
		
		Console.WriteLine("Enter Side Three of Triangle");
		string stringSideC = Console.ReadLine();
		int sideC = int.Parse(stringSideC);
		
		Triangle userTriangle = new Triangle(sideA, sideB, sideC);

		string typeOfTriangle = userTriangle.TriangleType();
		Console.WriteLine(typeOfTriangle);


	}
}


