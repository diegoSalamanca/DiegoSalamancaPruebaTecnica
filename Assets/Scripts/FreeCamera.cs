/******Código desarrollado por Diego Salamanca*******
***prueba técnica para la empresa Life is the Game***
**********Email> Diegocolmayor@gmail.com*************
******************Tel 3508232690********************/

using UnityEngine;

 public class FreeCamera : MonoBehaviour
 {
     public float sensitivity = 2f;
     void Update ()
     {
         var c = Camera.main.transform;
         c.Rotate(0, Input.GetAxis("Horizontal")* sensitivity, 0);
         
     }
 }
