/******Código desarrollado por Diego Salamanca*******
***prueba técnica para la empresa Life is the Game***
**********Email> Diegocolmayor@gmail.com*************
******************Tel 3508232690********************/

using UnityEngine;

public class PjController : MonoBehaviour
{

    Animator animator;

    public DanceScriptable danceScriptable;
    
    public  Avatar[] avatars;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StateMachine(int state)
    {

        print(state);
        switch (state)
        {   
            case 0:                 
                 animator.avatar = avatars[0];
                 animator.SetTrigger("house");
                 danceScriptable.selectedAnimation = 0;
            break;

            case 1:                 
                 animator.avatar = avatars[1];
                 animator.SetTrigger("macarena");
                 danceScriptable.selectedAnimation = 1;
            break;

            case 2:                 
                 animator.avatar = avatars[2];
                 animator.SetTrigger("hiphop");
                 danceScriptable.selectedAnimation = 2;
            break;
        }        

    }
}
