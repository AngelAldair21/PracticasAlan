using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///     int vidaMaxima; // Nomenclatura de camello
///     int vidamaxima; // Nomenclatura de serpiente o snake
///     int VidaMaxima; // Nomenclatura de Pascal
/// 
/// NOMBRES DE SCRIPTS
/// El nombre de el script lleva el nombre de lo que hace, no el objeto donde va
/// Por ejemplo si voy a programar un control de movimiento
/// el script se debe de llamar MovementController
/// 
/// Nomenclatura: Lleva la nomenclatura Pascal
/// 
/// 
/// NOMBRES DE VARIABLES
/// El nombre de la variable, lleva el nombre de el parametro exacto que se desea modificar
/// no el nombre de lo que se busca hacer
/// 
///     float intensity;
///     float fogIntensity;
///     float bloomIntensity;
///     
/// PRIVACIDAD DE VARIABLES
/// Independientemente de la variable, si esta es privada, se debe de escribir la palabra private antes 
/// de declararla
/// 
///     private int stamina;
/// </summary>
public class CleanCodeRules : MonoBehaviour
{
    /// <summary>
    /// SHORTCURS
    /// 
    /// Ctrl + D: Duplica la o las lineas seleccionadas
    /// 
    /// Ctrl + R,R: Renombra la variable, clase, metodo, funcion o lo que sea, en todas las
    /// instancias donde se esta usando
    /// 
    /// Ctrl + R,M: Todas las lineas seleccionadas crean un metodo, y este se manda a llamar en
    /// el lugar exacto de donde se extrajo el código
    /// 
    /// COMENTARIOS:
    /// Solamente se comenta lo que no se da a entender por su nombre
    /// 
    /// </summary>

    public float stamina;

    private void Start()
    {
        stamina = 0;
    }

    private void Update()
    {
        Run();
    }

    /// <summary>
    /// Este metodo controla los cambios de velocidad en el movimiento de el
    /// objeto
    /// </summary>
    private void Movement()
    {

    }

    /// <summary>
    /// Este metodo aplica los inputs del usuario
    /// a el movimiento para saber en que direccion debe de ir
    /// </summary>
    private void MovementHandler()
    {

    }

    /// <summary>
    /// Se manejan los inputs del usuario
    /// </summary>
    private void Controller()
    {
        
    }

    private void Talk()
    {

    }

    private void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            stamina -= Time.deltaTime;
            // corres
        }
    }
}
