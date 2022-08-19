/******Código desarrollado por Diego Salamanca*******
***prueba técnica para la empresa Life is the Game***
**********Email> Diegocolmayor@gmail.com*************
******************Tel 3508232690********************/

using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void GoTolevel(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
   
