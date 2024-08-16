using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaEnemigos : MonoBehaviour
{
    [SerializeField] private Transform[] puntoDeInstancia;
 

    [SerializeField] private GameObject instanciaEnemigo;

    private int numeroRandom;

    [SerializeField] private float tiempo;



    private void Start()
    {
        StartCoroutine(TiempoEnemigos());

    }

    IEnumerator TiempoEnemigos()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempo);
            Instantiate(instanciaEnemigo, puntoDeInstancia[numeroRandom]);
            numeroRandom = Random.Range(0, puntoDeInstancia.Length);

        }
    }

   


  
}
