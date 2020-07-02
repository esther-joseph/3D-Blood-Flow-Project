using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
	Allows the rotation of the route with collection of oxygenated blood cells to be adjusted in Unity Inspector
	in its own TurnNode component using its slider.
*/

public class TurnNodeRed : MonoBehaviour
{

	//Slider for selected small range for proper cell flow direction 
	[Range(0.0f, 25.0f)]
	public float angleOfPath;

	void Update()
	{
		transform.rotation = Quaternion.Euler(0,0,angleOfPath);
	}

}
