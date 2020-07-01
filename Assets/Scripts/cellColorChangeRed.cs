using UnityEngine;
 using System.Collections.Generic;

 /*
	Creates list of blood cells to be colored as red using cellColorChangeRed's colorRed function.
 */

 public class cellColorChangeRed : MonoBehaviour {

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