using System.Collections;
using UnityEngine;

//Allows blood cell to follow a path created in bezier.cs component. 

public class follow : MonoBehaviour
{
	public float speedModifier;

	[SerializeField]
	private Transform[] routes;

	private int routeToGo;

	private float tParam;

	private Vector2 cellPosition;

	private bool coroutineAllowed;

	changeSpeed cs = new changeSpeed();

	void Start()
	{
		routeToGo = 0;
		tParam = 0f;
		speedModifier = 0.5f;
		coroutineAllowed = true;
	}

	void Update () 
	{
		if(coroutineAllowed)
			StartCoroutine(GoByTheRoute(routeToGo));
	}
	
	//Selects the four gameObjects for bezier path and enables animation for cell to travel path
	private IEnumerator GoByTheRoute(int routeNumber)
	{
		coroutineAllowed = false;

		Vector2 p0 = routes[routeNumber].GetChild(0).position;
		Vector2 p1 = routes[routeNumber].GetChild(1).position;
		Vector2 p2 = routes[routeNumber].GetChild(2).position;
		Vector2 p3 = routes[routeNumber].GetChild(3).position;

		while(tParam < 1)
		{
			//Animates cell object along path
			tParam += Time.deltaTime * speedModifier;

			//Cell follows the Bezier formula for path 
			cellPosition = Mathf.Pow(1 - tParam, 3) * p0 +
				 3 * Mathf.Pow(1 - tParam, 2) * tParam * p1 +
				 3 * (1 - tParam)* Mathf.Pow(tParam, 2) * p2 +
				 Mathf.Pow(tParam, 3) * p3;

			 transform.position = cellPosition;
			 yield return new WaitForEndOfFrame();
		}

		tParam = 0f;

		//If more than one route is present, allow cell object to pass from one path to another
		routeToGo += 1;

		if (routeToGo > routes.Length - 1)
			routeToGo = 0;

		coroutineAllowed = true;

	}
	
	
}