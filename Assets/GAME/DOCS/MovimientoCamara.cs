using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
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
