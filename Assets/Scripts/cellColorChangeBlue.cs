using UnityEngine;
 using System.Collections.Generic;

 /*
	Creates list of blood cells to be colored as blue using cellColorChangeBlue's colorBlue function.
 */

 public class cellColorChangeBlue : MonoBehaviour {

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