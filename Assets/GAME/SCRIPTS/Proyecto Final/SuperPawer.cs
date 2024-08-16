using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPawer : MonoBehaviour
{
 
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Colisionaste");

           
            GameObject[] enemigos = GameObject.FindGameObjectsWithTag("enemigo");

          
            foreach (GameObject enemigo in enemigos)
            {
                Destroy(enemigo);
            }

            
            Destroy(this.gameObject);

        }
    }
}
