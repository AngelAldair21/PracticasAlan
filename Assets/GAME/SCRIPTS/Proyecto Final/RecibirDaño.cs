using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecibirDaño : MonoBehaviour
{
    public float cantidadDaño;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&& other.GetComponent<BarraDeVida>())
        {
            other.GetComponent<BarraDeVida>().RecibirDaño(cantidadDaño);
        }
    }
}
