using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
	Enables non-linear paths for each blood cell moving through blood vessel, where follow.cs allows the animation of the cell following 
	a created bezier path. 
*/
public class bezier : MonoBehaviour
{
	
	[SerializeField]
	private Transform[] controlPoints;

	private Vector2 gizmosPosition;

	private void OnDrawGizmos()
	{
		for (float t = 0; t <= 1; t += 0.05f)
		{
			//Equation based off the Bezier formula
			gizmosPosition = Mathf.Pow(1 - t, 3) * controlPoints[0].position +
			 3 * Mathf.Pow(1 - t, 2) * t * controlPoints[1].position +
			 3 * (1 - t)* Mathf.Pow(t, 2) * controlPoints[2].position +
			 Mathf.Pow(t, 3) * controlPoints[3].position;

			//Creates path of spheres for bezier path
			Gizmos.DrawSphere(gizmosPosition,0.25f);
		}

	//Draws the line using the four points's positions to adjust the curve of the path

	Gizmos.DrawLine(new Vector2(controlPoints[0].position.x, controlPoints[0].position.y), new Vector2(controlPoints[1].position.x, controlPoints[1].position.y));

	Gizmos.DrawLine(new Vector2(controlPoints[2].position.x, controlPoints[2].position.y), new Vector2(controlPoints[3].position.x, controlPoints[3].position.y));

	}
}
