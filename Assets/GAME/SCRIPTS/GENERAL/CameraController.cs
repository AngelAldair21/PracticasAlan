using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <INSTRUCCIONES>
/// Este script debe permitir rotar la cámara usando el mouse.
/// Cuando se rota la cámara, también debe de rotar al objeto que contenga el script o 
/// al que la cámara esté emparentado.
/// 
/// Debe de poder moverse la sensibilidad por una variable.
/// </INSTRUCCIONES>
public class CameraController : MonoBehaviour
{
    [SerializeField] private float sensibilidad = 100f;
    private float rotacionX = 0f;
    public Transform jugador;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }
    void Update()
    {
        
        float ratonX = Input.GetAxis("Mouse X") * sensibilidad * Time.deltaTime;
        float ratonY = Input.GetAxis("Mouse Y") * sensibilidad * Time.deltaTime;

        rotacionX -= ratonY;
        rotacionX = Mathf.Clamp(rotacionX, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotacionX, 0f, 0f);
        jugador.Rotate(Vector3.up * ratonX);
    }


}
