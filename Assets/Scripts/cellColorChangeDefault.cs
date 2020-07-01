using UnityEngine;
using System.Collections.Generic;

 /*
	Creates list of blood cells to be colored as default material color using cellColorChangeDefault's colorDefault function.
 */

 public class cellColorChangeDefault : MonoBehaviour {

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