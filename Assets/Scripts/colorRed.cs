 using UnityEngine;

//Colors each cell in cellColorChangeRed's list to color red.

 public class colorRed : MonoBehaviour {
 	
     public void changeToRed()
     {
         foreach (GameObject changeColorObject in cellColorChangeRed.list)
             changeColorObject.GetComponent<Renderer>().material.color = Color.red;
     }
 }