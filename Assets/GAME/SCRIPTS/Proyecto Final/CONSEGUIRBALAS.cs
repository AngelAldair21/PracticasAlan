using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONSEGUIRBALAS : MonoBehaviour
{
    public bool dect;
    public float radio;
    public LayerMask layerMaskPlayer;

    public bool check;

    [SerializeField] private ContadorBalas balas;
    [SerializeField] private int cantidadBalas;

 

    private void OnMouseOver()
    {
        check = true;
    }



    private void Update()
    {
        dect = Physics.CheckSphere(transform.position, radio, layerMaskPlayer);
        if (check && Input.GetKeyDown(KeyCode.E) && dect)
        {
           
            balas.SumarBalas(cantidadBalas);
            Destroy(this.gameObject);


        }
    }



    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radio);
    }
}
