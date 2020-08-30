using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MathLab2 : MonoBehaviour
{
	// Which shape to draw
	public enum DrawShape
	{
		Points,
		Triangle,
		Parallelogram,
		Triforce,
		Face,
		Hexagon,
		DiamondCut
	};
	public DrawShape shape = DrawShape.Points;

	// Array of shape functions
	public delegate void VoidFunction();
	VoidFunction[] functions = 
	{
		DrawPoints,
		DrawTriangle,
		DrawParallelogram,
		DrawTriforce,
		DrawFace,
		DrawHexagon,
		DrawDiamondCut
	};

	// Update is called once per frame
	void Update()
   {
		if (Input.GetKeyUp(KeyCode.RightArrow))
		{
			++shape;
			if (shape > DrawShape.DiamondCut)
			{
				shape = DrawShape.Points;
			}
		}

		if (Input.GetKeyUp(KeyCode.LeftArrow))
		{
			--shape;
			if (shape < DrawShape.Points)
			{
				shape = DrawShape.DiamondCut;
			}
		}
	}

	// Called when gizmos are drawn
	void OnDrawGizmos()
	{
		// Call the function corresponding the shape we want to draw
		functions[(int)shape]();
	}

	static void DrawPoints()
	{
		DrawPoint(PointAnimator.P);
		Vector3 pPlusU = PointAnimator.P + PointAnimator.U;
		Vector3 pPlusV = PointAnimator.P + PointAnimator.V;
		DrawPoint(pPlusU);
		DrawPoint(pPlusV);
	}

	static void DrawTriangle()
	{
		///////////////////////
		// Student Code Here //
		///////////////////////

		// completion worth 40%
		Vector3 pPlusU = PointAnimator.P + PointAnimator.U;
		Vector3 pPlusV = pPlusU + PointAnimator.V;
		DrawLine(PointAnimator.P, pPlusU);
		DrawLine(pPlusU, pPlusV);
		DrawLine(pPlusV, PointAnimator.P);

		// TO DO: Draw other sides of triangle
	}

	static void DrawParallelogram()
	{
		///////////////////////
		// Student Code Here //
		///////////////////////

		// completion worth 70%
		Vector3 pPlusU = PointAnimator.P + PointAnimator.U;
		Vector3 pPlusV = pPlusU + PointAnimator.V;
		Vector3 pPlusVPlusNegativeU = pPlusV - PointAnimator.U;
		DrawLine(PointAnimator.P, pPlusU);
		DrawLine(pPlusU, pPlusV);
		DrawLine(pPlusV, pPlusVPlusNegativeU);
		DrawLine(pPlusVPlusNegativeU, PointAnimator.P);


	}

	static void DrawTriforce()
	{
		///////////////////////
		// Student Code Here //
		///////////////////////

		// completion worth 80%
		Vector3 pPlusU = PointAnimator.P + PointAnimator.U;
		Vector3 pPlusUPlusV = pPlusU + PointAnimator.V;
		Vector3 halfpPlusU = PointAnimator.P + (PointAnimator.U / 2);
		Vector3 halfpPlusV = pPlusU + (PointAnimator.V/2);
		Vector3 halfpPlusUPlusV = halfpPlusU + (PointAnimator.V/2);
		DrawTriangle();
		DrawLine(halfpPlusU, halfpPlusV);
		DrawLine(halfpPlusV, halfpPlusUPlusV);
		DrawLine(halfpPlusUPlusV, halfpPlusU);
	}

	static void DrawFace()
	{
		///////////////////////
		// Student Code Here //
		///////////////////////

		// completion worth 90%
		/**
		DrawParallelogram();
		Vector3 pPlusU = PointAnimator.P - PointAnimator.U;
		Vector3 pPlusV = pPlusU - PointAnimator.V;
		Vector3 pPlusVPlusNegativeU = pPlusV + PointAnimator.U;
		DrawLine(PointAnimator.P, pPlusU);
		DrawLine(pPlusU, pPlusV);
		DrawLine(pPlusV, pPlusVPlusNegativeU);
		DrawLine(pPlusVPlusNegativeU, PointAnimator.P);
		**/
	}

	static void DrawHexagon()
	{
		///////////////////////
		// Student Code Here //
		///////////////////////

		// completion worth 90%
		Vector3 Start = PointAnimator.P + (PointAnimator.U/3);
		Vector3 Side1 = Start + (PointAnimator.U / 3);
		Vector3 Side2 = Side1 + (PointAnimator.V / 3);
		Vector3 Side3 = Side2 +((PointAnimator.V / 3)- (PointAnimator.U / 3));
		Vector3 Side4 = Side3 - (PointAnimator.U / 3);
		Vector3 Side5 = Side4 - (PointAnimator.V / 3);
		DrawLine(Start, Side1);
		DrawLine(Side1, Side2);
		DrawLine(Side2, Side3);
		DrawLine(Side3, Side4);
		DrawLine(Side4, Side5);
		DrawLine(Side5, Start);
	}

	static void DrawDiamondCut()
	{
		///////////////////////
		// Student Code Here //
		///////////////////////

		// Completion worth 100%
		DrawHexagon();
		Vector3 Start = PointAnimator.P + (PointAnimator.U / 3);
		Vector3 Side1 = Start + (PointAnimator.U / 3);
		Vector3 Side2 = Side1 + (PointAnimator.V / 3);
		Vector3 Side3 = Side2 + ((PointAnimator.V / 3) - (PointAnimator.U / 3));
		Vector3 Side4 = Side3 - (PointAnimator.U / 3);
		Vector3 Side5 = Side4 - (PointAnimator.V / 3);
		Vector3 BigStart = Start - (PointAnimator.V/3);
		Vector3 BigSide1 = Side1 - (PointAnimator.V / 3)+(PointAnimator.U/3);
		Vector3 BigSide2 = Side2 + (PointAnimator.U/3);
		Vector3 BigSide3 = Side3 + (PointAnimator.V/3);
		Vector3 BigSide4 = Side4 + ((PointAnimator.V / 3) - (PointAnimator.U / 3));
		Vector3 BigSide5 = Side5 - (PointAnimator.U / 3);
		DrawLine(BigStart, BigSide1);
		DrawLine(BigSide1, BigSide2);
		DrawLine(BigSide2, BigSide3);
		DrawLine(BigSide3, BigSide4);
		DrawLine(BigSide4, BigSide5);
		DrawLine(BigSide5, BigStart);
		DrawLine(BigStart, Start);
		DrawLine(BigSide1, Side1);
		DrawLine(BigSide2, Side2);
		DrawLine(BigSide3, Side3);
		DrawLine(BigSide4, Side4);
		DrawLine(BigSide5, Side5);




	}

	// Helper functions for drawing
	static void DrawPoint(Vector3 point)
	{
		DrawCircle(point, 1.0f);
	}

	static void DrawCircle(Vector3 center, float radius)
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(center, radius);
	}

	static void DrawLine(Vector3 start, Vector3 end)
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine(start, end);
	}
}
