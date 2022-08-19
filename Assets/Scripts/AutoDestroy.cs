/******Código desarrollado por Diego Salamanca*******
***prueba técnica para la empresa Life is the Game***
**********Email> Diegocolmayor@gmail.com*************
******************Tel 3508232690********************/

using UnityEngine;

public class AutoDestroy : MonoBehaviour
{    
    void Start()
    {
        Invoke("DestroyAfter",5f);
        
    }

    void DestroyAfter()
    {
        Destroy(gameObject);
    }
    
}
