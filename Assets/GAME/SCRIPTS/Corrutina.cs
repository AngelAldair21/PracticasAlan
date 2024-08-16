using System;
using System.Collections;
using UnityEngine;

public class Corrutina : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private float speed;
    [SerializeField] private bool usingScaledTime;

    private void Start()
    {
        StartCoroutine(PruebaDeTiempo());
        StartCoroutine(PruebaDeTiempoReal());
        StartCoroutine(PruebaDeUntil());
        StartCoroutine(PruebaWhile());
    }

    private void Update()
    {
        if (!usingScaledTime)
        {
            transform.position += new Vector3(0, 0, 1 * speed * Time.unscaledDeltaTime);
        }
        else
        {
            transform.position += new Vector3(0, 0, 1 * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Time.timeScale = 0.0f;
            Debug.Log("Tiempo en: " + Time.timeScale);
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            Time.timeScale = 3.0f;
            Debug.Log("Tiempo en: " + Time.timeScale);
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            Time.timeScale = 1.0f;
            Debug.Log("Tiempo en: " + Time.timeScale);
        }
    }


    int random;
    private void RandomNumber() => random = UnityEngine.Random.Range(0, 8);

    /// <summary>
    /// WAIT UNTIL
    /// Se espera hasta que una condicion se deje de cumplir para avanzar
    /// 
    /// Se suele usar para todo tipo de mecanicas
    /// </summary>
    private IEnumerator PruebaWhile()
    {
        yield return new WaitWhile(() => speed == 3);
        Debug.Log("Tiempo no escalado activado WHILE");
    }


    /// <summary>
    /// WAIT UNTIL
    /// Se espera hasta que una condicion se cumpla para avanzar
    /// 
    /// Se suele usar para todo tipo de mecanicas
    /// </summary>
    private IEnumerator PruebaDeUntil()
    {
        yield return new WaitUntil(() => usingScaledTime == true);
        Debug.Log("Tiempo no escalado activado UNTIL");
    }

    /// <summary>
    /// WAIT FOR SECONDS 
    /// Se espera X cantidad de segundos en tiempo escalado
    /// 
    /// Se suele usar para todo tipo de mecanicas
    /// </summary>
    private IEnumerator PruebaDeTiempo()
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Tiempo escalado");
    }

    /// <summary>
    /// WAIT FOR SECONDSREALTIME 
    /// Se espera X cantidad de segundos en tiempo NO escalado, es decir, tiempo real
    /// 
    /// Se suele usar para pausar o renaudar procesos durante la pausa o cualquier otra escala de tiempo que no sea 1
    /// También para animaciones o activar cosas en el UI durante la pausa
    /// </summary>
    private IEnumerator PruebaDeTiempoReal()
    {
        yield return new WaitForSecondsRealtime(time);
        Debug.Log("Tiempo no escalado");
    }

}
