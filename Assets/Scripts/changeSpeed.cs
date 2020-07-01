 using UnityEngine;

 //Changes speed of each blood cell by adjusting its speedModifier value.

 public class changeSpeed : MonoBehaviour {

     public void changeCellSpeed(float newSpeedValue)
     {
         foreach (GameObject changeSpeedObject in cellSpeedChange.list)
			changeSpeedObject.GetComponent<follow>().speedModifier = newSpeedValue;
     }
 }