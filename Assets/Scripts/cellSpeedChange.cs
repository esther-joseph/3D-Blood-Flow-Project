using UnityEngine;
 using System.Collections.Generic;

 /*
	Creates list of blood cells to change their velocity using changeSpeed's changeCellSpeed function.
 */

 public class cellSpeedChange : MonoBehaviour {

     public static List<GameObject> list = new List<GameObject>();

     void Start () 
     {
         list.Add(gameObject);
     }

     void OnDestroy() 
     {
         list.Remove(gameObject);
     }
 }