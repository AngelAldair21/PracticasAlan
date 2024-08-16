using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cura : MonoBehaviour
{
    public float curacion;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetComponent<BarraDeVida>())
        {
            other.GetComponent<BarraDeVida>().Curacion(curacion);
            Destroy(this.gameObject);
        }
    }
}
