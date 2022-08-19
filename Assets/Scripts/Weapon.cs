/******Código desarrollado por Diego Salamanca*******
***prueba técnica para la empresa Life is the Game***
**********Email> Diegocolmayor@gmail.com*************
******************Tel 3508232690********************/

using UnityEngine;

public class Weapon : MonoBehaviour
{

    Shooter shooter;
    Rigidbody  rigidbody;

    Collider collider;    

    public GameObject GunTypes;

    public int GunType;

    public bool Handled;

    public Transform ShootPoint;

    public ShootConfig shootConfig;
    
    void Start()
    {
        shooter = FindObjectOfType<Shooter>();
        rigidbody = GetComponent<Rigidbody>();
        Handled = false;
        collider = GetComponent<BoxCollider>();
    }

    private void Update() 
    {    

        switch (GunType)
        {
            case 0:  
                    if(Handled)
                    {
                        transform.localRotation = Quaternion.Euler(90-shootConfig.ParabolicAngle,0,0); 
                    }
                    
                    if(Input.GetKeyDown(KeyCode.Space) && Handled)   
                    {
                    var shoot = Instantiate(GunTypes, null);
                    shoot.GetComponent<Rigidbody>().AddRelativeForce(ShootPoint.up * shootConfig.ShootPower, ForceMode.Impulse);
                    shoot.transform.position = ShootPoint.position; 
                }                                
                
            break;

            case 1:
                    if(Input.GetKeyDown(KeyCode.Space) && Handled)   
                    {
                        ShootPoint.gameObject.SetActive(true);
                    } 
                    if(Input.GetKeyUp(KeyCode.Space))  
                    {
                         ShootPoint.gameObject.SetActive(false);
                    }
                    
            break;

            case 2:
            if(Input.GetKeyDown(KeyCode.Space) && Handled)   
                    {
                    var shoot = Instantiate(GunTypes, null);
                    shoot.GetComponent<SphereCollider>().material.bounciness = shootConfig.BouncingFactor;
                    shoot.GetComponent<Rigidbody>().AddRelativeForce(ShootPoint.up * shootConfig.ShootPower, ForceMode.Impulse);
                    shoot.transform.position = ShootPoint.position; 
                    } 
                
            break;
        
        } 
           
        
    }
    

    private void OnMouseDown() 
    {
        var weapons = FindObjectsOfType<Weapon>();
        foreach (var item in weapons)
        {
            item.WeaponOff();
        }
        Handled = true;
        rigidbody.isKinematic = true;
        var shooterTrannsform = shooter.GetComponent<Transform>();        
        transform.SetParent(shooterTrannsform);
        transform.position = shooterTrannsform.position;
        transform.localRotation = Quaternion.Euler(90,0,0);  
        collider.enabled = false;
        
    }

    public void WeaponOff()
    {
        if(Handled)
        {
            rigidbody.isKinematic = false;
            transform.SetParent(null);
            rigidbody.AddForce(new Vector3(Random.Range(-1f,1f),-1,Random.Range(2f,4f))*110);
            Handled = false;
            collider.enabled = true;
        }
    }

    
}
