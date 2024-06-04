using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// EJERCICIO 2 >:)
/// 
/// Deben de realizar codigo para que el objeto que tenga este script, sea capaz
/// de detectar si se encuentra o no tocando el suelo.
/// 
/// En caso de tocar el suelo, debe de regresar por medio de un metodo booleano, un valor verdadero
/// caso contrario debe regresar un valor falso
/// 
/// 
/// PD: En caso de agregar un script de gravedad, se les dar� +4 puntos sobre la tarea
/// </summary>
public class GroundCheck : MonoBehaviour
{
    public float radio;
    public LayerMask layerMask;

    private void Update()
    {
        estaenelsuelo();
    }
    public bool estaenelsuelo()
    {
        return Physics.CheckSphere(transform.position, radio, layerMask);
 
    }
}
