/******Código desarrollado por Diego Salamanca*******
***prueba técnica para la empresa Life is the Game***
**********Email> Diegocolmayor@gmail.com*************
******************Tel 3508232690********************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{

    List<Rigidbody> rigidbodies;

    Coroutine rutine;

   public ShootConfig shootConfig;
   

  private void OnEnable() {
    rigidbodies = new List<Rigidbody>();
     var hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity);
     foreach (var item in hitColliders)
     {
        if(item.GetComponent<Rigidbody>())
        {
            rigidbodies.Add(item.GetComponent<Rigidbody>());
        }
        
     }  

     rutine = StartCoroutine(MagnetCorutine());
  }

  IEnumerator MagnetCorutine()
  {
    while(rigidbodies.Count>0)
    {
        foreach (var item in rigidbodies)
        {            
            
            item.useGravity = false;            
            item.transform.LookAt(transform);           
            item.AddRelativeForce(Vector3.forward * shootConfig.MagneticPower, ForceMode.Acceleration);
            if(item.velocity.x >1 || item.velocity.y >1 || item.velocity.z >1 )
            {
                item.velocity = Vector3.one;
            }    
            yield return new WaitForFixedUpdate();
        }
    } 
    yield return null;
  }



  private void OnDisable() {

    StopCoroutine(rutine);

    foreach (var item in rigidbodies)
    {
        
        item.velocity = Vector3.zero;
        item.useGravity = true;
    }

    rigidbodies.Clear();
    
  }
 
}
