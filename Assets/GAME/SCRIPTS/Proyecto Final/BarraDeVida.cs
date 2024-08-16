using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{

    public Image barraDeVida;
    public float vidaActual;
    public float vidaMaxima;
    public TextMeshProUGUI vidaText;
    void Update()
    {
        ActualizarSalud();
    }

    public void ActualizarSalud()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
        vidaText.text = vidaActual.ToString("f0");
    }

    public void RecibirDaño(float daño)
    {
        vidaActual -= daño;
        if(vidaActual == 0) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void Curacion(float cura)
    {
        vidaActual += cura;
        if(vidaActual > vidaMaxima)
        {
            vidaActual = vidaMaxima;
        }

    }
}
