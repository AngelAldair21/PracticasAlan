using UnityEditor;
using UnityEngine;

/// <summary>
/// Una clase abstracta no tiene definici�n, es decir, no contiene
/// pasos l�gicos, ya que no se sabe a que se refiere.
/// 
/// Entonces la definicion de la clase abstracta, se da en la herencia
/// 
/// Los metodos abstractos, no tienen definicion ni contienen l�gica,
/// por que funcionan diferente seg�n la herencia
/// </summary>
public abstract class Weapon : MonoBehaviour
{

    public int damage;
    public int ammo;
    public int maxAmmo;
    public int magazineSize;
    public float range;
    public float fireRate;

    public abstract void Fire();
    public abstract void Aim();
    public abstract void Reload();


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.rotation * transform.forward *  range);
    }


}
