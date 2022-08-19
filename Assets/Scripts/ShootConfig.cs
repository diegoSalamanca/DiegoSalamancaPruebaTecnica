/******Código desarrollado por Diego Salamanca*******
***prueba técnica para la empresa Life is the Game***
**********Email> Diegocolmayor@gmail.com*************
******************Tel 3508232690********************/

using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ShootConfig", order = 1)]
public class ShootConfig : ScriptableObject
{
     [Range(2f, 12f)]
    public float ShootPower;
    [Range(15f, 60f)]
    public float ParabolicAngle;
    [Range(0.1f, 1f)]
    public float BouncingFactor;
     [Range(1, 10f)]
    public float MagneticPower;    
    
}