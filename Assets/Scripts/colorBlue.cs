 using UnityEngine;

 //Changes color of each cell in cellColorChangeBlue's list to color blue.

 public class colorBlue : MonoBehaviour {
 	
     public void changeToBlue()
     {
         foreach (GameObject changeColorObject in cellColorChangeBlue.list)
             changeColorObject.GetComponent<Renderer>().material.color = Color.blue;
     }
 }