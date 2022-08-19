/******Código desarrollado por Diego Salamanca*******
***prueba técnica para la empresa Life is the Game***
**********Email> Diegocolmayor@gmail.com*************
******************Tel 3508232690********************/

using UnityEngine;
public class RenderPlayer : MonoBehaviour
{
    Animator animator;

    public DanceScriptable  danceScriptable;

    public  Avatar[] avatars;
    
    void Start()
    {
        animator = GetComponent<Animator>();

        switch (danceScriptable.selectedAnimation)
        {
            case 0:
                animator.avatar = avatars[0];
                 animator.SetTrigger("house");
            break;

            case 1:
                animator.avatar = avatars[1];
                animator.SetTrigger("macarena");
            break;

            case 2:
                animator.avatar = avatars[2];
                animator.SetTrigger("hiphop");
            break;
        }  
    }

    
}
