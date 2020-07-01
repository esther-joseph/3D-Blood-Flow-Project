 using UnityEngine;

 //Changes cell's color in cellColorChangeDefault's list to default material color in order to reset cell's color.

 public class colorDefault : MonoBehaviour {

     public void changeToDefault()
     {
         foreach (GameObject changeColorObject in cellColorChangeDefault.list)
         	 
             changeColorObject.GetComponent<Renderer>().material = Resources.Load("defaultMaterial", typeof(Material)) as Material;
     }
 }