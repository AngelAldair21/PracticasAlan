using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemigoVida : MonoBehaviour
{
    [SerializeField] public int vida;

   



    public void DañoEnemigo(int daño)
    {
        vida -= daño;
        if(vida <= 0)
        {
           
            Destroy(this.gameObject);
         
            
        }
        
    }
}
